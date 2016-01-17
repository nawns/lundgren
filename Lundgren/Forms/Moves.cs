using System.Diagnostics;
using System.Threading;
using Lundgren.Controller;
using Lundgren.Game;
using Lundgren.Game.Helpers;
using Lundgren.Logs;

namespace Lundgren.Forms
{
    public class Moves
    {
        private LundgrenForm _lundgrenForm;

        public Moves(LundgrenForm lundgrenForm)
        {
            _lundgrenForm = lundgrenForm;
        }

        private void AttemptToPickFox()
        {
            var currentFrame = GameState.LastFrame + 5;
            for (var i = 0; i < 8; i++)
            {
                currentFrame++;
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame, new StickPress(Direction.NE));
                currentFrame++;
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame, new StickPress(Direction.N));
            }
            _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 1, new DigitalPress(DigitalButton.A));
            for (var i = 0; i < 8; i++)
            {
                currentFrame++;
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame, new StickPress(Direction.SE));
                currentFrame++;
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame, new StickPress(Direction.S));
            }
            _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 1, new DigitalPress(DigitalButton.A));
            _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 15, new DigitalPress(DigitalButton.A));
            _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 30, new DigitalPress(DigitalButton.Start));
        }

        private void AttemptToPickAndName20XX()
        {
            AttemptToPickFox20XX();
            AttemptToName20XX();
        }

        private void AttemptToName20XX()
        {
            var currentFrame = GameState.LastFrame + 1;
            for (var i = 0; i < 20; i++)
            {
                currentFrame++;
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame, new StickPress(Direction.S));
            }
            Thread.Sleep(100);
            _lundgrenForm.CurrentAI.Queue.Clear();
            _lundgrenForm.CurrentAI.Queue.AddToFrame(GameState.LastFrame + 5, new DigitalPress(DigitalButton.A));

        }

        public void AttemptToPickFox20XX()
        {
            var currentFrame = GameState.LastFrame + 5;
            for (var i = 0; i < 6; i++)
            {
                currentFrame++;
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + i, new StickPress(Direction.N));
            }
            Thread.Sleep(100);

            var prev = 0;
            var p1 = Memory.ReadByte(0x8042208F);
            while (p1 != 2)
            {
                prev = p1;
                _lundgrenForm.CurrentAI.Queue.AddToFrame(GameState.LastFrame + 1, new DigitalPress(DigitalButton.B));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(GameState.LastFrame + 2, new DigitalPress(DigitalButton.A));
                Thread.Sleep(75);
                p1 = Memory.ReadByte(0x8042208F);
                if (p1 != 2) continue;
                _lundgrenForm.Log(null, new Logging.LogEventArgs("Fox selected!"));
                _lundgrenForm.CurrentAI.Queue.Clear();
                return;
            }
        }

        public void MoveWaveshine()
        {
            int currentFrame = GameState.LastFrame + 15;

            for (int i = 0; i < 10; i++) {
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 0, new StickPress(Direction.S));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 0, new DigitalPress(DigitalButton.B));

                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 6, new DigitalPress(DigitalButton.Y));

                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 10, new StickPress(Direction.SE));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 10, new ShoulderPress(150));
                currentFrame += 55;

                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 0, new StickPress(Direction.S));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 0, new DigitalPress(DigitalButton.B));

                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 6, new DigitalPress(DigitalButton.Y));

                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 10, new StickPress(Direction.SW));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 10, new ShoulderPress(150));
                currentFrame += 55;
            }
        }

        public void MoveMultiShine()
        {
            var currentFrame = GameState.LastFrame + 10;

            for (var i = 0; i < 30; i++)
            {
                var aix = GameState.p1.x;
                var playerx = GameState.p2.x;
                var dir = playerx > aix ? Direction.E : Direction.W;
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 0, new StickPress(dir));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 1, new StickPress(Direction.S));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 1, new DigitalPress(DigitalButton.B));

                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 5, new DigitalPress(DigitalButton.Y));

                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 8, new StickPress(Direction.S));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 8, new DigitalPress(DigitalButton.B));

                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 14, new StickPress(Direction.N));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 15, new StickPress(dir));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 16, new StickPress(dir));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 17, new StickPress(dir));

                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 18, new DigitalPress(DigitalButton.A));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 19, new StickPress(dir));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 20, new StickPress(dir));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 21, new StickPress(dir));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 22, new StickPress(dir));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 23, new StickPress(dir));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 24, new StickPress(dir));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 25, new DigitalPress(DigitalButton.R));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 26, new DigitalPress(DigitalButton.R));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 27, new DigitalPress(DigitalButton.R));



                currentFrame += 60;
            }

            //Debug.WriteLine(_lundgrenForm.CurrentAI.Queue.ToString());
            /*
            queue.AddToFrame(((currentFrame + 39) % 60), new StickPress(Direction.S));
            queue.AddToFrame(((currentFrame + 39) % 60), new DigitalPress(DigitalButton.B));

            queue.AddToFrame(((currentFrame + 44) % 60), new DigitalPress(DigitalButton.Y));

            queue.AddToFrame(((currentFrame + 47) % 60), new StickPress(Direction.S));
            queue.AddToFrame(((currentFrame + 47) % 60), new DigitalPress(DigitalButton.B));

            queue.AddToFrame(((currentFrame + 52) % 60), new DigitalPress(DigitalButton.Y));

            queue.AddToFrame(((currentFrame + 55) % 60), new StickPress(Direction.S));
            queue.AddToFrame(((currentFrame + 55) % 60), new DigitalPress(DigitalButton.B));
            */


        }

        public void MoveLol()
        {
            var currentFrame = GameState.LastFrame + 15;

            var dir1 = Direction.E;
            var dir2 = Direction.W;
            

            for (var i = 0; i < 20; i++)
            {
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 1, new StickPress(dir1));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 0, new StickPress(Direction.S));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 0, new DigitalPress(DigitalButton.B));

                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 4, new DigitalPress(DigitalButton.Y));

                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 7, new DigitalPress(DigitalButton.B));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 13, new DigitalPress(DigitalButton.B));
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 14, new DigitalPress(DigitalButton.B));
                currentFrame += 35;
                var temp = dir1;
                dir1 = dir2;
                dir2 = temp;
            }


        }

        public void MoveTowards()
        {
            var currentFrame = GameState.LastFrame + 15;

            double aix = GameState.p1.x;
            double playerx = GameState.p2.x;

            if (playerx > aix)
            {
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 1, new StickPress(Direction.E));
            }
            else
            {
                _lundgrenForm.CurrentAI.Queue.AddToFrame(currentFrame + 1, new StickPress(Direction.W));
            }

        }
    }
}
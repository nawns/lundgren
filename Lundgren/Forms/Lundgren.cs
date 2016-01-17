﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Lundgren.Controller;
using Lundgren.Game;
using Lundgren.Game.Helpers;
using Lundgren.Logs;
using Timer = System.Timers.Timer;

namespace Lundgren
{
    public partial class Lundgren : Form
    {
        private System.Reflection.Assembly assembly
            = System.Reflection.Assembly.GetExecutingAssembly();

        private System.Timers.Timer        _gameTimer = new System.Timers.Timer();
        private System.Windows.Forms.Timer _formTimer = new System.Windows.Forms.Timer();

        public static int LastFrameNum = 0;

        private MoveQueue queue = new MoveQueue();
        public ControllerState State, Prev;

        public Lundgren()
        {
            // Refactor this later
            queue = new MoveQueue();
            Prev = new ControllerState(-1);

            InitializeComponent();

            _gameTimer.Elapsed += new ElapsedEventHandler(MoveTimer);
            _gameTimer.Interval = 1;
            _gameTimer.Enabled = true;

            _formTimer.Tick += new EventHandler(FormTimer);
            _formTimer.Interval = 1;
            _formTimer.Enabled = true;

            Driver = new Driver(this);

            Driver.DriverLog += Log;
            Driver.InputLog += Log;
            JoystickHelper.JoystickLog += Log;
        }
        
        public Driver Driver { get; }

        private void LogFrameState(int frameNum, ControllerState controllerState, bool rem)
        {
            Log(null,
                !rem
                    ? new Logging.LogEventArgs($"Something went wrong on frame {frameNum}")
                    : new Logging.LogEventArgs($"F: {frameNum} - {controllerState}"));
        }

        void MoveTimer(Object sender, EventArgs e)
        {
            if (ProcessMoves() == false)
                return;
        }

        private bool ProcessMoves()
        {
            var thisFrameNum = GameState.GetFrame();
            if (thisFrameNum == LastFrameNum)
                return false;
            if (GameState.p1 != null && GameState.Stage != null)
            {
                if (GameState.p1.OnLeftLedge(GameState.Stage))
                    Debug.WriteLine("on left edge");
                if (GameState.p1.OnRightLedge(GameState.Stage))
                    Debug.WriteLine("on right edge");
            }

            //Debug.WriteLine("On frame " + thisFrameNum);
            if (thisFrameNum != LastFrameNum + 1 && thisFrameNum > LastFrameNum)
                Debug.WriteLine($"Lost frames between { LastFrameNum } and { thisFrameNum }");

            LastFrameNum = thisFrameNum;
            Prev = State;
            if (queue.HasFrame(thisFrameNum))
            {
                Debug.WriteLine($"Performing move on frame { thisFrameNum }");
                State = queue.Get(thisFrameNum);
                var rem = queue.Remove(thisFrameNum);
                LogFrameState(thisFrameNum, State, rem);
            }
            else
            {
                State = new ControllerState(LastFrameNum);
            }
            return true;
        }


        private void FormTimer(Object sender, EventArgs e)
        {
            GameState.GetState();
            UpdateTextboxes();
        }

        private void UpdateTextboxes()
        {
            frame.Text = LastFrameNum.ToString();
            stage.Text = GameState.StageString;

            if (GameState.p1 != null)
            {
                p1percent.Text = GameState.P1Percent;
                p1Animation.Text = GameState.P1Animation;
                p1char.Text = GameState.P1Char;
                p1stocks.Text = GameState.P1Stocks;
                p1X.Text = GameState.P1X;
                p1Y.Text = GameState.P1Y;
                if (GameState.p1.HasCharacterSelected)
                {
                    Stream myStream = assembly.GetManifestResourceStream(GameState.p1.CharacterImage);
                    if (myStream != null) p1PictureBox.Image = new Bitmap(myStream);
                }
            }
            if (GameState.p2 != null)
            {
                p2percent.Text = GameState.P2Percent;
                p2Animation.Text = GameState.P2Animation;
                p2char.Text = GameState.P2Char;
                p2stocks.Text = GameState.P2Stocks;
                p2X.Text = GameState.P2X;
                p2Y.Text = GameState.P2Y;
                if (GameState.p2.HasCharacterSelected)
                {
                    Stream myStream = assembly.GetManifestResourceStream(GameState.p2.CharacterImage);
                    if (myStream != null) p2PictureBox.Image = new Bitmap(myStream);
                }
            }

            timer.Text = GameState.TimerString;
        }


        private void Log(object sender, Logging.LogEventArgs e)
        {
            if (InvokeRequired)
            {
                var hnd = new EventHandler<Logging.LogEventArgs>(Log);
                Invoke(hnd, new object[] { sender, e });
                return;
            }
            logText.AppendText(e.Text + Environment.NewLine);
            logText.SelectionStart = logText.TextLength;
            logText.ScrollToCaret();
        }


        private void beginButton_Click(object sender, EventArgs e)
        {
            var threadDelegate = new ThreadStart(AttemptToPickFox20XX);
            var t = new Thread(threadDelegate);
            Log(null, new Logging.LogEventArgs("Attempting to pick fox."));
            t.Start();
        }

        private void AttemptToPickFox()
        {
            var currentFrame = LastFrameNum + 5;
            for (var i = 0; i < 8; i++)
            {
                currentFrame++;
                queue.AddToFrame(currentFrame, new StickPress(Direction.NE));
                currentFrame++;
                queue.AddToFrame(currentFrame, new StickPress(Direction.N));
            }
            queue.AddToFrame(currentFrame + 1, new DigitalPress(DigitalButton.A));
            for (var i = 0; i < 8; i++)
            {
                currentFrame++;
                queue.AddToFrame(currentFrame, new StickPress(Direction.SE));
                currentFrame++;
                queue.AddToFrame(currentFrame, new StickPress(Direction.S));
            }
            queue.AddToFrame(currentFrame + 1, new DigitalPress(DigitalButton.A));
            queue.AddToFrame(currentFrame + 15, new DigitalPress(DigitalButton.A));
            queue.AddToFrame(currentFrame + 30, new DigitalPress(DigitalButton.Start));
        }

        private void AttemptToPickAndName20XX()
        {
            AttemptToPickFox20XX();
            AttemptToName20XX();
        }

        private void AttemptToName20XX()
        {
            var currentFrame = LastFrameNum + 1;
            for (var i = 0; i < 20; i++)
            {
                currentFrame++;
                queue.AddToFrame(currentFrame, new StickPress(Direction.S));
            }
            Thread.Sleep(100);
            queue.Clear();
            queue.AddToFrame(LastFrameNum + 5, new DigitalPress(DigitalButton.A));

        }

        private void AttemptToPickFox20XX()
        {
            var currentFrame = LastFrameNum + 5;
            for (var i = 0; i < 6; i++)
            {
                currentFrame++;
                queue.AddToFrame(currentFrame + i, new StickPress(Direction.N));
            }
            Thread.Sleep(100);

            var prev = 0;
            var p1 = Memory.ReadByte(0x8042208F);
            while (p1 != 2)
            {
                prev = p1;
                queue.AddToFrame(LastFrameNum + 1, new DigitalPress(DigitalButton.B));
                queue.AddToFrame(LastFrameNum + 2, new DigitalPress(DigitalButton.A));
                Thread.Sleep(75);
                p1 = Memory.ReadByte(0x8042208F);
                if (p1 != 2) continue;
                Log(null, new Logging.LogEventArgs("Fox selected!"));
                queue.Clear();
                return;
            }
        }


        private void SleepUntilFrame(int frame)
        {
            // This doesn't work at all
            int count = 0;
            Debug.WriteLine("Beginning to wait...");
            while (LastFrameNum != frame)
            {
                Debug.WriteLine("wait..." + LastFrameNum + " " + frame);
                count++;
            }
            Debug.WriteLine("Done waiting... waited " + count);
        }

        private void waveshineBtn_Click(object sender, EventArgs e)
        {
            var threadDelegate = new ThreadStart(MoveWaveshine);
            var t = new Thread(threadDelegate);
            Log(null, new Logging.LogEventArgs("Attempting to waveshine."));
            t.Start();
        }

        private void MoveWaveshine()
        {
            int currentFrame = LastFrameNum + 15;

            for (int i = 0; i < 10; i++) {
                queue.AddToFrame(currentFrame + 0, new StickPress(Direction.S));
                queue.AddToFrame(currentFrame + 0, new DigitalPress(DigitalButton.B));

                queue.AddToFrame(currentFrame + 6, new DigitalPress(DigitalButton.Y));

                queue.AddToFrame(currentFrame + 10, new StickPress(Direction.SE));
                queue.AddToFrame(currentFrame + 10, new ShoulderPress(150));
                currentFrame += 15;

                queue.AddToFrame(currentFrame + 0, new StickPress(Direction.S));
                queue.AddToFrame(currentFrame + 0, new DigitalPress(DigitalButton.B));

                queue.AddToFrame(currentFrame + 6, new DigitalPress(DigitalButton.Y));

                queue.AddToFrame(currentFrame + 10, new StickPress(Direction.SW));
                queue.AddToFrame(currentFrame + 10, new ShoulderPress(150));
                currentFrame += 15;
            }
        }


        private void multishineBtn_Click(object sender, EventArgs e)
        {
            var threadDelegate = new ThreadStart(MoveMultiShine);
            var t = new Thread(threadDelegate);
            Log(null, new Logging.LogEventArgs("Attempting to multishine."));
            t.Start();
        }


        private void MoveMultiShine()
        {
            var currentFrame = LastFrameNum + 10;

            for (var i = 0; i < 10; i++)
            {
                 
                queue.AddToFrame(currentFrame + 1, new StickPress(Direction.S));
                queue.AddToFrame(currentFrame + 1, new DigitalPress(DigitalButton.B));

                queue.AddToFrame(currentFrame + 4, new DigitalPress(DigitalButton.Y));

                queue.AddToFrame(currentFrame + 7, new StickPress(Direction.S));
                queue.AddToFrame(currentFrame + 7, new DigitalPress(DigitalButton.B));

                queue.AddToFrame(currentFrame + 12, new DigitalPress(DigitalButton.Y));

                queue.AddToFrame(currentFrame + 15, new StickPress(Direction.S));
                queue.AddToFrame(currentFrame + 15, new DigitalPress(DigitalButton.B));
                queue.AddToFrame(currentFrame + 20, new DigitalPress(DigitalButton.Y));
            
                queue.AddToFrame(currentFrame + 23, new DigitalPress(DigitalButton.B));

                queue.AddToFrame(currentFrame + 28, new DigitalPress(DigitalButton.Y));
            
                queue.AddToFrame(currentFrame + 31, new DigitalPress(DigitalButton.B));

                queue.AddToFrame(currentFrame + 36, new DigitalPress(DigitalButton.Y));

                currentFrame += 40;
            }

            Debug.WriteLine(queue.ToString());
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

        private void lolBtn_Click(object sender, EventArgs e)
        {
            var threadDelegate = new ThreadStart(MoveLol);
            var t = new Thread(threadDelegate);
            Log(null, new Logging.LogEventArgs("Attempting to multishine."));
            t.Start();
        }


        private void MoveLol()
        {
            var currentFrame = LastFrameNum + 15;

            var dir1 = Direction.E;
            var dir2 = Direction.W;
            

            for (var i = 0; i < 20; i++)
            {
                queue.AddToFrame(currentFrame + 1, new StickPress(dir1));
                queue.AddToFrame(currentFrame + 0, new StickPress(Direction.S));
                queue.AddToFrame(currentFrame + 0, new DigitalPress(DigitalButton.B));

                queue.AddToFrame(currentFrame + 4, new DigitalPress(DigitalButton.Y));

                queue.AddToFrame(currentFrame + 7, new DigitalPress(DigitalButton.B));
                queue.AddToFrame(currentFrame + 13, new DigitalPress(DigitalButton.B));
                queue.AddToFrame(currentFrame + 14, new DigitalPress(DigitalButton.B));
                currentFrame += 35;
                var temp = dir1;
                dir1 = dir2;
                dir2 = temp;
            }


        }


        /* Side buttons */

        private void btnA_Click(object sender, EventArgs e)
        {
            queue.AddToFrame(LastFrameNum + 15, new DigitalPress(DigitalButton.A));
            Log(null, new Logging.LogEventArgs("Adding A to frame " + (LastFrameNum + 15)));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            queue.AddToFrame(LastFrameNum + 15, new DigitalPress(DigitalButton.Start));
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            queue.AddToFrame(LastFrameNum + 15, new DigitalPress(DigitalButton.B));
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            queue.AddToFrame(LastFrameNum + 150, new DigitalPress(DigitalButton.Y));
            Log(null, new Logging.LogEventArgs("Adding A to frame " + (LastFrameNum + 150)));
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            queue.AddToFrame(LastFrameNum + 15, new DigitalPress(DigitalButton.X));
        }

        private void btnSRight_Click(object sender, EventArgs e)
        {
            queue.AddToFrame(LastFrameNum + 15, new StickPress(Direction.E));
        }

        private void btnSUp_Click(object sender, EventArgs e)
        {
            queue.AddToFrame(LastFrameNum + 15, new StickPress(Direction.N));
        }

        private void btnSDown_Click(object sender, EventArgs e)
        {
            queue.AddToFrame(LastFrameNum + 15, new StickPress(Direction.S));
        }

        private void btnSLeft_Click(object sender, EventArgs e)
        {
            queue.AddToFrame(LastFrameNum + 15, new StickPress(Direction.W));
        }

        private void btnThing_Click(object sender, EventArgs e)
        {
            GameState.P1Data();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!Driver.run)
            {
                Driver.run = true;
                var threadDelegate = new ThreadStart(Driver.Start);
                var t = new Thread(threadDelegate);
                Log(null, new Logging.LogEventArgs("Starting driver."));
                t.Start();
            }
            else
            {
                Log(null, new Logging.LogEventArgs("Driver is already started."));
            }
        }

    }
}

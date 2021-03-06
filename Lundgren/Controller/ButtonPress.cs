﻿using System.Text;

namespace Lundgren.Controller
{
    public enum DigitalButton { A, B, X, Y, L, R, Z, Start, DUp, DRight, DDown, DLeft };

    public class ButtonPress { }

    class ShoulderPress : ButtonPress
    {
        public byte L, R;
        public ShoulderPress(byte l = 0, byte r = 0)
        {
            L = l;
            R = r;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            if (L != 0) sb.Append($"L:{L} ");
            if (R != 0) sb.Append($"R:{R} ");
            return sb.ToString();
        }
    }


    class DigitalPress : ButtonPress
    {
        public DigitalButton db;
        public DigitalPress(DigitalButton _db)
        {
            db = _db;
        }

        public override string ToString()
        {
            return db.ToString() + " ";
        }
    }
}

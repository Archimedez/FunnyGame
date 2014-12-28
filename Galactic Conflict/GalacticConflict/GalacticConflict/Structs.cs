using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace GalacticConflict {
    [StructLayout(LayoutKind.Sequential)]
    public struct Point {
        public float X { get; set; }
        public float Y { get; set; }

        public Point(float x, float y)
            : this() {
            X = x;
            Y = y;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Color {
        public float Red { get; set; }
        public float Green { get; set; }
        public float Blue { get; set; }
        public float Alpha { get; set; }

        public Color(float r, float g, float b, float a)
            : this() {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = a;
        }
    }
}

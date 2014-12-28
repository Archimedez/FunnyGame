using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace GalacticConflict {
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double x, double y, double z)
            : this() {
            X = x;
            Y = y;
            Z = z;
        }

        public double Lenght() {
            return Math.Sqrt(LenghtSquared());
        }

        public double LenghtSquared() {
            return (X * X + Y * Y + Z * Z);
        }

        public bool Equals(Vector v) {
            return (X == v.X) && (Y == v.Y) && (Z == v.Z);
        }

        public override int GetHashCode() {
            return (int)X ^ (int)Y ^ (int)Z;
        }

        public static bool operator ==(Vector v1, Vector v2) {
            if (System.Object.ReferenceEquals(v1, v2)) {
                return true;
            }

            if (v1 == null || v2 == null) {
                return false;
            }

            return v1.Equals(v2);
        }

        public override bool Equals(object obj) {
            if (obj is Vector) {
                return Equals((Vector)obj);
            }
            return base.Equals(obj);
        }

        public static bool operator !=(Vector v1, Vector v2) {
            return (!v1.Equals(v2));
        }

        public Vector Add(Vector r) {
            return new Vector(X + r.X, Y + r.Y, Z + r.Z);
        }

        public static Vector operator +(Vector v1, Vector v2) {
            return v1.Add(v2);
        }

        public Vector Substract(Vector r) {
            return new Vector(X - r.X, Y - r.Y, Z - r.Z);
        }

        public static Vector operator -(Vector v1, Vector v2) {
            return v1.Substract(v2);
        }

        public Vector Multiply(double v) {
            return new Vector(X * v, Y * v, Z * v);
        }

        public static Vector operator *(Vector v, double s) {
            return v.Multiply(s);
        }

        public Vector Normalize(Vector v) {
            double r = v.Lenght();
            if (r != 0.0) {
                return new Vector(v.X / r, v.Y / r, v.Z / r);
            } else {
                return new Vector(0, 0, 0);
            }
        }
    }
}

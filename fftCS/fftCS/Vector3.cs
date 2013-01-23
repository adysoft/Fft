using System;

namespace fftCS
{
    public class Vector3
    {
        public Vector3(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static float operator *(Vector3 v1, Vector3 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        public static Vector3 operator *(Vector3 v1, float scale)
        {
            return new Vector3(v1.X * scale, + v1.Y * scale, v1.Z * scale);
        }

        public Vector3 Cross(Vector3 v1)
        {
            return new Vector3(this.Y*v1.Z - this.Z*v1.Y, this.Z*v1.X - this.X*v1.Z, this.X*v1.Y - this.Y*v1.Z);
        }

        public float Length
        {
            get
            {
                return (float)Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2) + Math.Pow(this.Z, 2));
            }
        }

        public Vector3 Normalized
        {
            get
            {
                return new Vector3(this.X / Length, this.Y / Length, this.Z / Length);
            }
        }
    }
}

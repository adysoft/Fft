using System;

namespace fftCS
{
    public class Vector2
    {
        public Vector2(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public float X { get; set; }
        public float Y { get; set; }

        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static float operator *(Vector2 v1, Vector2 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        public float Length
        {
            get
            {
                return (float)Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            }
        }

        public Vector2 Normalized
        {
            get
            {
                return new Vector2(this.X / Length, this.Y / Length);
            }
        }
    }
}

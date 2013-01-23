namespace fftCS
{
    public class Complex
    {
        public Complex(float real, float imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        public float Real { get; set; }
        public float Imaginary { get; set; }

        public Complex Conjugate
        {
            get
            {
                return new Complex(Real, -Imaginary);
            }
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.Real * c2.Real - c1.Imaginary * c2.Imaginary, c1.Real * c2.Imaginary + c1.Imaginary * c2.Real);
        }

        public static Complex operator *(Complex c1, float factor)
        {
            return new Complex(c1.Real * factor, c1.Imaginary * factor);
        }
    }
}

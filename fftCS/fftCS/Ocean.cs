using System.Collections.Generic;

namespace fftCS
{
    public class Ocean
    {
        private List<Complex> hTilde;
        private List<VertexOcean> vertices;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="N">Grid width & height</param>
        public Ocean(int N)
        {
            // Why + 1 ?? Is it because of tilling ?
            int Nplus1 = N + 1;

            int index;

            hTilde = new List<Complex>(N * N);
            vertices = new List<VertexOcean>(Nplus1 * Nplus1);
            for(int m = 0 ; m < Nplus1 ; m++)
            {
                for(int n = 0 ; n < Nplus1 ; n++)
                {
                    index = m * Nplus1 + n;
                }
            }
        }

        /// <summary>
        /// ~h0(n, m) = 1/sqrt(2) * (gauss_1 + i * gauss2) * sqrt(Phillips(n,m))
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        Complex GetHTilde0(int n, int m)
        {
            return null;
        }
    }
}

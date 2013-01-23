using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fftCS
{
    public struct VertexOcean
    {
        float x, y, z; // vertex
        float nx, ny, nz; // normal
        float a, b, c; // htilde0
        float _a, _b, _c; // htilde0mk conjugate
        float ox, oy, oz; // original position
    }
}

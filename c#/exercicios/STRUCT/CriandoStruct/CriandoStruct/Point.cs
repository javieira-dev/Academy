using System;
using System.Collections.Generic;
using System.Text;

namespace CriandoStruct
{
    struct Point
        //trocar o class por struct 
    {
        public double x;
        public double y;

        public override string ToString()
        {
            return "(" + x + " , " + y + ")";
        }
    }
}

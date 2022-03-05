﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercAluno
{
    class Aluno
    {
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if(NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }

        public override string ToString()
        {
            return NotaFinal().ToString("F2", CultureInfo.InvariantCulture)

            ;
        }




    }
}
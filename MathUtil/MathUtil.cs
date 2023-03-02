using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaLibrairieForme;

namespace MathUtil
{
    public static class MathUtil
    {
        public static double CalculerSurface(Forme f)
        {
            if (f is Carre carre)
            {
                return carre.L * carre.L;
            }
            else if (f is Cercle cercle)
            {
                return Math.PI * Math.Pow(cercle.R, 2);
            }
            else if (f is Rectangle rectangle)
            {
                return rectangle.L * rectangle.l;
            }
            else
            {
                return 0;
            }
        }

        public static bool VerifierValeur(int nb, int min, int max)
        {
            return min < nb && nb < max;
        }
    }
}
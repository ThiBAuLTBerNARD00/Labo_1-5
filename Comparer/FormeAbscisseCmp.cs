using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaLibrairieForme;

namespace Comparer
{
    public class FormeAbscisseComparer : IComparer<Forme>
    {
        public int Compare(Forme _x, Forme _y)
        {
            return _x.cor.x.CompareTo(_y.cor.x);
        }
    }
}

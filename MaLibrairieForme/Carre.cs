
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public class Carre : Forme, IEstDans, ISommets, IComparable<Carre>
    {
        #region VARIABLES MEMBRES
        public int L;

        #endregion

        #region PROPRIETIES
        public int _L
        {
            get { return L; }
            set
            {
                if (value > 0)
                {
                    L = value;
                }
                //pe faire un throw
            }
        }

        #endregion
        #region CONSTRUCTEURS
        public Carre(int _L=0,int x=0, int y=0)
        {
            L = _L;
            cor.x = x;
            cor.y = y;

        }
        public Carre(Coordonnees c,int _L=0)
        {
            cor.x = c.x;
            cor.y = c.y;
            L=_L;
        }
        public Carre(Carre c)
        {
            cor.y=c.cor.y;
            cor.x = c.cor.x;
            L=c.L;
        }
        #endregion

        #region METHODE
        public override string ToString()
        {
            return "coordonne " + cor.ToString() + "cote = " + L;
        }
        public override void Affiche()
        {
            Console.WriteLine(ToString());
        }
        public override bool CoordonneeEstDans(Coordonnees p)
        {
            if (p.x > cor.x && p.x < cor.x + L && p.y > cor.y && p.y < cor.y + L)
                return true;
            else
                return false;
        }

        

        public byte NbSommets
        { get { return 4; } }

        public byte NbSommmet => throw new NotImplementedException();
        public int CompareTo(Carre other)
        {
            return L.CompareTo(other.L);
        }
        #endregion
    }
}

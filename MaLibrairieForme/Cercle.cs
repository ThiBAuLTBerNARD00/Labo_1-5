using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public class Cercle : Forme, IEstDans
    {
        #region VARIABLES MEMBRES
        public int R;

        #endregion

        #region PROPRIETIES
        public int _R
        {
            get { return R; }
            set { R = value; }
        }

        #endregion
        #region CONSTRUCTEURS
        public Cercle(int x=0,int y=0,int _R=0)
        {
            R = _R;
            cor.y = y;
            cor.x = x;

        }
        public Cercle(Coordonnees c,int r=0)
        {
            cor.x=c.x;
            cor.y=c.y;
            R = r;

        }
        public Cercle(Cercle c)
        {
            cor.x=c.cor.x;
            cor.y=c.cor.y;
            R = c.R;
        }
        #endregion

        #region METHODE
        public override string ToString()
        {
            return "rayon " + R + "Coord" + cor.ToString();
        }
        public override void Affiche()
        {
            Console.WriteLine("Cercle :\t" +ToString());
        }
        public override bool  CoordonneeEstDans(Coordonnees p)
        {
            return Math.Pow(p.x - cor.x, 2) + Math.Pow(p.y - cor.y, 2) <= Math.Pow(R, 2);

        }

        bool IEstDans.CoordonneeEstDans(Coordonnees p)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}


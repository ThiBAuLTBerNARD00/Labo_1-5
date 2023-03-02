using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public class Rectangle : Forme, ISommets
    {
        #region VARIABLES MEMBRES
        public int L;
        public int l;

        #endregion

        #region PROPRIETIES
        public int _L
        {
            get { return L; }
            set { L = value; }
        }
        public int _l
        {
            get { return l; }
            set { l = value; }
        }

        #endregion
        #region CONSTRUCTEURS
        public Rectangle(int _L=0, int _l = 0,int x=0,int y=0)
        {
            L = _L;
            l = _l;
            cor.x = x; 
            cor.y = y;

        }
        public Rectangle(Coordonnees c,int _l=0, int _L=0)
        {
            L = _L;
            l = _l;
            cor.x = c.x;
            cor.y = c.y;
            
        }
        public Rectangle(Rectangle r)
        {
            cor.x=r.cor.x;
            cor.y=r.cor.y;
            l = r.l;
            L = r.l;
        }
        
        #endregion

        #region METHODE
        public override string ToString()
        {
            return "Largeur " + L +" "+ "longeur " + l+ " Coordonnée : "+ cor.ToString();
        }
        public override void Affiche()
        {
            Console.WriteLine("Rectangle : \t"+ToString());
        }
        public override bool CoordonneeEstDans(Coordonnees p)
        {
            return cor.x <= p.x && p.x <= cor.x + l && cor.y <= p.y && p.y <= cor.y + L;

        }

        
        public byte NbSommets
        {
            get { return 4; } 
        }

        public byte NbSommmet => throw new NotImplementedException();

        #endregion
    }
}

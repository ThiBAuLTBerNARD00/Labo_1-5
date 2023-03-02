using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MaLibrairieForme
{
    public class Coordonnees
    {
        #region VARIABLES MEMBRES
        private int _x;
        private int _y;
        #endregion
        #region PROPRIETES

        public int x
        {
            get { return _x; }
            set { _x = value; }
        }
        public int y
        {
            get { return _y; }
            set { _y = value; }
        }
        #endregion

        #region CONSTRUCTEURS
        public Coordonnees(int x=0, int y=0)
        {
            _x = x;
            _y = y;
        }
        public Coordonnees(Coordonnees c)
        {
            
            _x = c.x;
            _y = c.y;
            
        }
        public override string ToString()
        {
            return "(" + x + "," + y + ")";
        }

        #endregion
    }
}

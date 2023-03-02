using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public abstract class Forme : IEstDans
    {
        #region VARIABLES MEMBRES
        public Coordonnees cor;
        #endregion


        #region CONSTRUCTEURS
        public Forme()
        {
            cor = new Coordonnees();
        }
        #endregion
        #region GETTERS/SETTERS
        public Coordonnees _cor
        {
            get { return cor; }
            set { cor = value; }
        }
        #endregion
        #region METHODE
        public abstract void Affiche();
        public abstract bool CoordonneeEstDans(Coordonnees p);
        #endregion
    }
}

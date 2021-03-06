
using Barricade.Logic.Exceptions;

namespace Barricade.Logic.Velden
{
    public class Finishveld : VeldBase
    {
        #region properties
        public override bool MagBarricade { get { return false; } }
        public override bool MagPionErlangs { get { return true; } }
        #endregion

        #region logica methodes
        /// <summary>
        /// Plaats een pion op dit veld
        /// </summary>
        /// <param name="pion">de pion</param>
        /// <returns>een gewonnenexception</returns>
        public override bool Plaats(Pion pion)
        {
            Pionnen.Add(pion);
            throw new GewonnenException(pion.Speler);
        }
        #endregion
    }
}


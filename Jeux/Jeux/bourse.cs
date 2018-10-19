using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeux
{
    class bourse
    {
        private int pieceOr;
        public bourse(int pieceOr)
        {
            this.pieceOr = pieceOr;
        }
        public void PlacerOr(int pieceOr)
        {
            this.pieceOr = this.pieceOr + pieceOr;
        }
        public void PrendreOr(int pieceOr)
        {
            if (pieceOr > this.pieceOr)
                Console.WriteLine("impossible de retirer autant de piece d'or , vous n'avez que {0}",this.pieceOr);
            else
                this.pieceOr = this.pieceOr - pieceOr;
        }
        public int GetPieceOr()
        {
            return this.pieceOr;
        }
        public string ToString()
        {
            return string.Format("vous avez {0}",this.pieceOr);
        }

    }
}

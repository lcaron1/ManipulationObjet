using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeux
{
    class casque
    {
        private string nom;
        private int valeur;
        private int ac;


    
        public casque (string nom,int valeur , int ac)
        {
        this.nom = nom;
        this.valeur = valeur;
        this.ac = ac;
        }
        public string Nom
        {
            get
            {
                return this.nom;
            }
        }
        public int Valeur
        {
            get
            {
                return this.valeur;
            }
        }
        public int Ac
        {
            get
            {
                return this.ac;
            }
        }
        public string ToString()
        {
            return string.Format("vous avez un {0} de valeur {1} et de protection {2}", this.nom , this.valeur , this.ac);
        }
    }
}

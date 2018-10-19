using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeux
{
    class armes
    {
        private string nom;
        private int valeur;
        private int dommage;


    
        public armes (string nom,int valeur , int dommageArme1 , int dommageArme2)
        {
        Random rnd = new Random();
        this.nom = nom;
        this.valeur = valeur;
        this.dommage = rnd.Next(dommageArme1, dommageArme2);
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
        public int Dommage
        {
            get
            {
                return this.dommage;
            }
        }
        public string ToString()
        {
            return string.Format("vous avez une {0} de valeur {1} et de dommage {2}", this.nom , this.valeur , this.dommage);
        }
        
    } 

}

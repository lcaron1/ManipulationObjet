using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeux
{
    class potion
    {
        private Effet effet;
        private string couleur;
        private int nombrePointVie;

        public potion(Effet effet ,int nombrePointVie)
        {
            Random rnd = new Random();
            double tirage;
            this.effet = effet;
            this.nombrePointVie = nombrePointVie;
            if (this.effet == Effet.antipoison)
            {
                tirage = rnd.NextDouble();
                if (tirage <= 0.8)
                {
                    couleur = "verte";
                }
                else
                
                    if(tirage <= 0.9)
                {
                    couleur = "rouge";
                }
                    else
                        if (tirage <= 0.1)
                        {
                            couleur = "bleu";
                        }

            }
            if (this.effet == Effet.poison)
            {
                tirage = rnd.NextDouble();
                if (tirage <= 0.8)
                {
                    couleur = "rouge";
                }
                else

                    if (tirage <= 0.9)
                    {
                        couleur = "vert";
                    }
                    else
                        if (tirage <= 0.1)
                        {
                            couleur = "bleu";
                        }

            }
            if (this.effet == Effet.neutre)
            {
                tirage = rnd.NextDouble();
                if (tirage <= 0.8)
                {
                    couleur = "bleu";
                }
                else

                    if (tirage <= 0.9)
                    {
                        couleur = "rouge";
                    }
                    else
                        if (tirage <= 0.1)
                        {
                            couleur = "vert";
                        }

            }
        }


        public int NombrePointVie
        {
            get
            {
                return this.nombrePointVie;
            }
        }
        public Effet Effet
        {
            get
            {
                return this.effet;
            }
        }
    }
}

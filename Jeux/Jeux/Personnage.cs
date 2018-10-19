using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeux
{
    class Personnage
    {
        Caractère caractère;
        classe classe;
        int force;
        Peuple peuple;
        int agilité;
        int chance;
        int pointsDeVie;
        int pointsDeVieMaximum;
        string nom;
        Etat etat;

        public Personnage(int pointsDeVieMaximum, Caractère caractère,classe classe, int force, int agilité, string nom, Peuple peuple, int chance)
        {
            this.pointsDeVie = pointsDeVieMaximum;
            this.pointsDeVieMaximum = pointsDeVieMaximum;
            this.force = force;
            this.agilité = agilité;
            this.nom = nom;
            this.peuple = peuple;
            this.chance = chance;
            this.classe = classe;
            this.caractère = caractère;
            this.etat = Etat.ok;
        }
        public void SetNom(string nouveauNom)
        {
            if (nouveauNom != "ROBERT")
            {
                this.nom = nouveauNom;
            }
        }
        public string Nom
        {
            get
            {
                return this.nom;
            }
        }
        public int Force
        {
            get
            {
                return this.force;
            }
        }
        public int Chance
        {
            get
            {
                return this.chance;
            }
        }
        public int PointDeVie
        {
            get
            {
                return this.pointsDeVie;
            }
        }
        public int Agilité
        {
            get
            {
                return this.agilité;
            }
        }
        public Peuple Peuple
        {
            get
            {
                return this.peuple;
            }
        }
        public classe Classe
        {
            get
            {
                return this.classe;
            }
        }
        public Caractère Caractère
        {
            get
            {
                return this.caractère;
            }
        }
        public Etat Etat
        {
            get
            {
                return this.etat;
            }
        }
        public void boire(potion potion)
        {
            if (potion.Effet == Effet.poison)
            {
                this.pointsDeVie = this.pointsDeVie - potion.NombrePointVie;
                this.etat = Etat.empoisonné;
                if (this.pointsDeVie < 0)
                {
                    this.pointsDeVie = 0;
                }
                Console.WriteLine("{0} boit une potion {1}", this.nom, potion.Effet);
            }

            if (potion.Effet == Effet.neutre)
            {
                this.pointsDeVie = this.pointsDeVie + potion.NombrePointVie;
                if (this.pointsDeVie > this.pointsDeVieMaximum)
                {
                    this.pointsDeVie = this.pointsDeVieMaximum;
                }
                Console.WriteLine("{0} boit une potion {1}", this.nom, potion.Effet);
            }
            if (potion.Effet == Effet.antipoison)
            {
                this.pointsDeVie = this.pointsDeVie + potion.NombrePointVie;
                this.etat = Etat.ok;
                if (this.pointsDeVie > this.pointsDeVieMaximum)
                {
                    this.pointsDeVie = this.pointsDeVieMaximum;
                }
                Console.WriteLine("{0} boit une potion {1}", this.nom, potion.Effet);
            }
        }
        public string ToString(){
            return string.Format("Personnage: {0} , Peuple: {1} , Classe: {2} , Caractère: {3} , PV: {4} , PVMAX: {5} , Agilite: {6} , Force: {7} , Chance: {8},Etat {9} ", nom, peuple, classe, caractère , pointsDeVie ,pointsDeVieMaximum ,agilité , force ,chance,etat);
        }
        public Personnage(string nom)
        {
            Random rnd = new Random();
            this.nom = nom;
            this.peuple = (Peuple)rnd.Next(0, 8);
            this.classe = (classe)rnd.Next(0, 3);
            this.caractère = (Caractère)rnd.Next(0, 2);
            this.force = rnd.Next(6, 15);
            this.agilité = rnd.Next(6, 15);
            this.chance = rnd.Next(6, 15);
            this.pointsDeVieMaximum = rnd.Next(6, 15);
            this.pointsDeVie = pointsDeVieMaximum;
        }
        public bool EstVivant()
        {
            bool vivant = false;
            if (this.pointsDeVie < 0)
            {
                vivant = true;
            }
            return vivant;
        }
        private void mourir()
        {
            Console.WriteLine("argh c'est la fin pour moi...");
        }
    }
}
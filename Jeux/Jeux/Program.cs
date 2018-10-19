using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeux
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnage kyo = new Personnage(1000, Caractère.Evil, classe.combattant, 50,30, "kyo", Peuple.elfe, 100);
            potion petitePotion = new potion(Effet.antipoison ,50);
            kyo.boire(petitePotion);
            Console.WriteLine(kyo.ToString());
            potion grandePotion = new potion(Effet.poison, 50);
            kyo.boire(grandePotion);
            Console.WriteLine(kyo.ToString());
            Personnage Azog = new Personnage(120, Caractère.Evil, classe.combattant, 40, 15, "Azog", Peuple.orc, 100);
            Console.WriteLine(Azog.ToString());
            Personnage bilbo = new Personnage(80, Caractère.neutral, classe.voleur, 20, 50, "bilbo", Peuple.hobbit, 100);
            Console.WriteLine(bilbo.ToString());
            Personnage Gauvin = new Personnage("Gauvin");
            Console.WriteLine(Gauvin.ToString());

            bourse bourse = new bourse(150);
            bourse.PlacerOr(100);
            bourse.PrendreOr(350);
            Console.WriteLine(bourse.GetPieceOr());
            Console.WriteLine(bourse.ToString());

            armes arme1 = new armes("Dague",5,1,4);
            Console.WriteLine(arme1.ToString());
            armes arme2 = new armes("Longue Epée", 4000, 3, 12);
            Console.WriteLine(arme2.ToString());

            armure armure1 = new armure("Robe", 15, 1);
            Console.WriteLine(armure1.ToString());
            armure armure2 = new armure("demon plaque", 150000, 9);
            Console.WriteLine(armure2.ToString());

            casque casque1 = new casque("petit casque", 100, 1);
            Console.WriteLine(casque1.ToString());
            casque casque2 = new casque("grand casque", 7000, 5);
            Console.WriteLine(casque2.ToString());

            bouclier bouclier1 = new bouclier("petit bouclier", 20, 2);
            Console.WriteLine(bouclier1.ToString());
            bouclier bouclier2 = new bouclier("grand bouclier", 40, 3);
            Console.WriteLine(bouclier2.ToString());

            gant gant1 = new gant("petit gant", 6000, 1);
            Console.WriteLine(gant1.ToString());
            gant gant2 = new gant("grand gant", 60000, 3);
            Console.WriteLine(gant2.ToString());

            armes[] tabArmes = new armes[2];
            tabArmes[0] = arme1;
            tabArmes[1] = arme2;

            armure[] tabArmure = new armure[2];
            tabArmure[0] = armure1;
            tabArmure[1] = armure2;

            casque[] tabCasque = new casque[2];
            tabCasque[0] = casque1;
            tabCasque[1] = casque2;

            gant[] tabGant = new gant[2];
            tabGant[0] = gant1;
            tabGant[1] = gant2;

            bouclier[] tabBouclier = new bouclier[2];
            tabBouclier[0] = bouclier1;
            tabBouclier[1] = bouclier2;

            for(int i = 0; i < tabArmes.Length; i++)
            {
                Console.WriteLine(tabArmes[i].ToString());
            }
            for (int i = 0; i < tabArmure.Length; i++)
            {
                Console.WriteLine(tabArmure[i].ToString());
            }
            for (int i = 0; i < tabCasque.Length; i++)
            {
                Console.WriteLine(tabCasque[i].ToString());
            }
            for (int i = 0; i < tabGant.Length; i++)
            {
                Console.WriteLine(tabGant[i].ToString());
            }
            for (int i = 0; i < tabBouclier.Length; i++)
            {
                Console.WriteLine(tabBouclier[i].ToString());
            }

            Console.ReadLine();

        }
    }
}

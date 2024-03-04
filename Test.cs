namespace Gestion_Enseignant
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestion d'enseignant au college la cité!");


            //Creation de deux professeurchargepartielle et deux professeurpermenent
            ProfesseurPermenent prof1 = new ProfesseurPermenent("Joel","Muteba","4382281211","Programmation orienté objet",5);
            ProfesseurPermenent prof2 = new ProfesseurPermenent("Mounir", "Katet", "5142581242", "Base de données", 7);
            ProfesseurChargePartielle prof3 = new ProfesseurChargePartielle("Mouhamed", "bouhlel", "4356678909", 3, 45);
            ProfesseurChargePartielle prof4 = new ProfesseurChargePartielle("Fallou", "Fall", "4356576423", 6, 48);
            //Creation du tableau des professeur et ajout des quatre objets precedents dans le tableau
            Professeur[] professeurs = new Professeur[] { prof1, prof2, prof3, prof4 };
            //Affichage des professeurs qui ont une Assurance
            foreach (var prof in professeurs)
            {
               if (prof is IAssurance)
               {
                    Console.WriteLine( prof.ToString() );
               }
            }
        }
    }
}
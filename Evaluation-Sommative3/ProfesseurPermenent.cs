using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Enseignant
{
    public sealed class ProfesseurPermenent: Professeur ,IAssurance
    {
      
            //Attributs
           private string diplome;
            private int anneeExperience;
            //Propriétés
            public string Diplome
            {
                get { return diplome; }
                set { diplome = value; }
            }
            public int AnneeExperience
            {
                get { return anneeExperience; }
                set {anneeExperience = value; }
            }
            //Constructeur
            public  ProfesseurPermenent(string nom,string prenom,string telephone,string diplome,int anneeExperience):base(nom,prenom,telephone)
            {
           this.diplome = diplome;
            this.anneeExperience = anneeExperience;
            
            }
        //Redefinition de la methode CalculerSAlaire
        public override double CalculerSalaire()
        {
            double SalaireAnnuel = 0;
            if(anneeExperience <= 2) { SalaireAnnuel = 60000; }
            else if(anneeExperience  <= 5) { SalaireAnnuel = 80000; }
            else if (anneeExperience <= 10) { SalaireAnnuel = 100000; }
            else { SalaireAnnuel = 120000; }

            return SalaireAnnuel / 12 ;


        }
        //Redefinition de la methode Equals
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            ProfesseurPermenent other = (ProfesseurPermenent)obj;
            return diplome == other.diplome &&
                   anneeExperience == other.anneeExperience;
                
        }
        //Redefinition de la methode ToString
        public override string ToString()
        {
            return base.ToString()+$" ProfesseurPermenent: \n Diplome: {Diplome} \n  AnneeExperience: {AnneeExperience}";
        }

        public double CalculerPrimeAssurance()
        {
            return CalculerSalaire() * 0.25;


        }
    }
}


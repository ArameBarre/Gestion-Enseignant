using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Enseignant
{
    public sealed class ProfesseurChargePartielle : Professeur  
    {
        //Attributs
        public int nombreHeuresSemaine;
        public double prixHeure;
        //Propriétés
        public  int NombreHeureSemaine
        {
            get{return nombreHeuresSemaine;}
            set 
            {
                if (value == 3 || value == 6)
                {
                    nombreHeuresSemaine = value;
                }
                else
                    throw new Exception("Le nombre d'heures par semaine doit être 3 ou 6.");
            }
        }
        public double PrixHeure
        {
            get { return prixHeure; }
            set { prixHeure = value; }
        }
        //Constructeur
        public ProfesseurChargePartielle(string nom,string prenom,long telephone,int nombreHeuresSemaine,double prixHeure):base(nom,prenom,telephone)
        {
           
            this.nombreHeuresSemaine=nombreHeuresSemaine;
            this.prixHeure=prixHeure;
        }
        //Redefinition de la methode calculer salaire
        public double CalculerSalaire()
        {
            double salaire = nombreHeuresSemaine * 4 * prixHeure;
            return salaire;
        }
        //Redefinition de la methode Equals
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            ProfesseurChargePartielle other = (ProfesseurChargePartielle)obj;
            return nombreHeuresSemaine == other.nombreHeuresSemaine &&
                  prixHeure == other.prixHeure;

        }
        //Redefinition de la methode ToString
        public override string ToString()
        {
            return base.ToString()+ $" ProfesseurChargePartielle:\n NombreHeuresSemaine :{NombreHeureSemaine} \n PrixHeure: {PrixHeure}";
        }
       

    }
}

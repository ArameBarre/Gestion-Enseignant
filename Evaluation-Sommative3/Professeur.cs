using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Enseignant
{
    public abstract class Professeur
    {
        //Attributs
        public static int compteur = 0;
        private int  code;
        private string nom;
        private string prenom;
        private string telephone;
        //Propriétés
        public int Code 
        {
            get { return code; } 
        }
        public string Nom 
        {
            get { return nom; }
             set { nom = value; } 
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Telephone
        {
            get { return telephone; }
            set 
            {
                
                    if (value.Length == 10)
                        telephone = value;
                    else
                        throw new Exception("Le numéro de téléphone ne doit pas dépasser 10 chiffres.");
                
              }
        }
        //Constructeur
        public Professeur(string nom,string prenom,string telephone)
        {
            compteur++;
            this.code = compteur;
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
        }
        //Méthode abstraite pour calculer le salaire
        //la méthode CalculerSalaire est abstraite car elle doit 
        //etre implémenter differement  pour les professeurs permanent et les
        //professeue à charge partielle.
        public abstract double CalculerSalaire();
        //Redefinition de la methode Equals
        public override bool Equals(object obj)
        {
           if(obj == null) return false; 
           Professeur other = (Professeur)obj;
            return code==other.code &&
                   nom==other.nom &&
                   prenom==other.prenom &&
                  telephone==other.telephone;
        }
        //Redefinition de la methode ToString
        public virtual string ToString()
        {
            return  $"Professeur : \n Nom: {Nom}  \n (Code {Code}) \n Tel: {Telephone}";
        }


    }
}

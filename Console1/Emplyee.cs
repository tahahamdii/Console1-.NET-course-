using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    public abstract class Emplyee

    {
        public string Matricule { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }


        public DateTime dateNaissance { get; set; }

        
        public Emplyee(string matricule, string nom, string prenom, DateTime dateNaissance)
        {
            this.Matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
        }


        public override string ToString()
        {
            return "Matricule: " + Matricule + "\nNom: " + nom + "\nPrenom: " + prenom + "\nDate de naissance: " + dateNaissance;
        }
        public double GetSalaire()
        {
            return 0;
        }
    }
}

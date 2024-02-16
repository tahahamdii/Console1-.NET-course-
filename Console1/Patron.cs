using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    internal class Patron : Emplyee
    {
        private static double chiffreAffaire {  get; set; }
        private double pourcentage { get; set; }
        public Patron(string matricule, string nom, string prenom, DateTime dateNaissance, double pourcentage) : base(matricule, nom, prenom, dateNaissance)
        {
            this.pourcentage = pourcentage;
        }
       
        public override string ToString()
        {
            return base.ToString() + "\nChiffre d'affaire: " + chiffreAffaire + "\nPourcentage: " + pourcentage;
        }
        public double GetSalaire()
        {
            return chiffreAffaire * pourcentage / 100;
        }
    }
}

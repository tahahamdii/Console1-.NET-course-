using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    internal class Cadre : Emplyee
    {
        private int indice { get; set; }
        public Cadre(string matricule, string nom, string prenom, DateTime dateNaissance, int indice) : base(matricule, nom, prenom, dateNaissance)
        {
            this.indice = indice;
        }
        
        public override string ToString()
        {
            return base.ToString() + "\nIndice: " + indice;
        }
        public double GetSalaire()
        {
            switch (indice)
            {
                case 1: return 1300;
                case 2: return 1500;
                case 3: return 1700;
                case 4: return 2000;
                default: return 0;
            }
        }
    }
}

using Console1;
using System;

class Program
{
    static void Main()
    {

        DateTime dateTime = new DateTime(1999, 12, 12);

        Console.ReadLine("donner le matricule: ");
        string matricule = string.Parse(Console.ReadLine());
        Console.ReadLine("donner le nom: ");
        string nom = Console.ReadLine();
        Console.ReadLine("donner le prenom: ");
        string prenom = Console.ReadLine();
        
        Console.ReadLine("donner l'indice: ");
        int indice = int.Parse(Console.ReadLine());
        Cadre c = new Cadre(matricule, nom, prenom, dateTime, indice);
        Console.WriteLine(c.ToString());
        Console.WriteLine("Salaire: " + c.GetSalaire());

    }
}
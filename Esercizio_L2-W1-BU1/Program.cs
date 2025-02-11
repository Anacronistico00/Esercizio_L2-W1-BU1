using Esercizio_L2_W1_BU1.Models;

Persona persona1 = new Persona("Vittorio", "Turiaci", 24);
Console.WriteLine("Dettagli Singoli persona1:");
Console.WriteLine("Nome: " + persona1.GetNome());
Console.WriteLine("Cognome: " + persona1.GetCognome());
Console.WriteLine("Età: " + persona1.GetEta());
Console.WriteLine("-----------------");
Console.WriteLine("Dettagli Completi: ");
Console.WriteLine(persona1.GetDettagli());

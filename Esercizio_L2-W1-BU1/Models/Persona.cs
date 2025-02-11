
namespace Esercizio_L2_W1_BU1.Models
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }
        public Persona(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }

        public string GetNome()
        {
            return Nome;
        }
        public string GetCognome()
        {
            return Cognome;

        }

        public int GetEta()
        {
            return Eta;
        }

        public string GetDettagli()
        {
            return $"Nome: {Nome}, Cognome: {Cognome}, Età: {Eta} anni";
        }

    }
}

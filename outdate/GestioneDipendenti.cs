using System;

namespace RisorseUmane
{
    public class GestioneDipendenti
    {
        public Dipendente CreaDipendente()
        {
            Console.WriteLine("Inserisci i dettagli del dipendente:");
            Console.Write("ID Dipendente: ");
            int idDipendente = int.Parse(Console.ReadLine());

            Console.Write("Nome Dipendente: ");
            string nomeDipendente = Console.ReadLine();

            Console.Write("Posizione: ");
            string posizione = Console.ReadLine();

            Console.Write("Stipendio: ");
            decimal stipendio = decimal.Parse(Console.ReadLine());

            Console.Write("Data di Assunzione (gg/mm/aaaa): ");
            DateTime dataAssunzione = DateTime.Parse(Console.ReadLine());

            return new Dipendente(idDipendente, nomeDipendente, posizione, stipendio, dataAssunzione);
        }
    }
}

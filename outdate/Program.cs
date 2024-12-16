using System;
using System.Collections.Generic;

namespace RisorseUmane
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Dipartimento> dipartimenti = new List<Dipartimento>();

            
            GestioneDipartimenti gestioneDipartimenti = new GestioneDipartimenti();
            GestioneDipendenti gestioneDipendenti = new GestioneDipendenti();

            
            var nuovoDipartimento = gestioneDipartimenti.CreaDipartimento();
            dipartimenti.Add(nuovoDipartimento);
            Console.WriteLine("Il dipartimento è stato creato con successo.\n");

            
            var nuovoDipendente = gestioneDipendenti.CreaDipendente();
            nuovoDipartimento.AggiungiDipendente(nuovoDipendente);
            Console.WriteLine("Il dipendente è stato creato con successo.\n");

            
            Console.WriteLine("Dettagli del Dipartimento:");
            nuovoDipartimento.MostraDettagliDipartimento();

            Console.WriteLine("\nDettagli del Dipendente:");
            nuovoDipendente.MostraDettagliDipendente();

            
            Azienda azienda = new Azienda("ExtraNet", "Informatica");
            azienda.AggiungiDipartimento(nuovoDipartimento);
            Console.WriteLine("\nDettagli dell'Azienda:");


            azienda.MostraDettagliAzienda();
        }
    }
}

using System;
using System.Collections.Generic;

namespace RisorseUmane
{
    public class Dipartimento
    {

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Sede { get; private set; }


        private string numeroTelefono;
        private List<Dipendente> dipendenti;

        public Dipartimento(int id, string nome, string sede, string numeroTelefono)
        {
            Id = id;
            Nome = nome;
            Sede = sede;
            this.numeroTelefono = numeroTelefono;
            dipendenti = new List<Dipendente>(); 
        }

        public void AggiungiDipendente(Dipendente dipendente)
        {
            dipendenti.Add(dipendente);
        }

        public void MostraDettagliDipartimento()
        {
            Console.WriteLine($"Dipartimento: {Nome}, Sede: {Sede}, Telefono: {numeroTelefono}");
            Console.WriteLine("Dipendenti:");
            foreach (var dip in dipendenti)
            {
                dip.MostraDettagliDipendente();
            }
        }

        private void CalcolaNumeroDipendenti()
        {
            Console.WriteLine($"Numero di dipendenti nel dipartimento {Nome}: {dipendenti.Count}");
        }
    }
}

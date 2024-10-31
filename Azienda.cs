using System;
using System.Collections.Generic;

namespace RisorseUmane
{
    public class Azienda
    {
        public string Nome { get; private set; }
        public string Settore { get; private set; }
        public List<Dipartimento> Dipartimenti { get; private set; }

        private int numeroDipartimenti;


        public Azienda(string nome, string settore)
        {
            Nome = nome;
            Settore = settore;
            Dipartimenti = new List<Dipartimento>();
        }

        public void AggiungiDipartimento(Dipartimento dipartimento)
        {
            Dipartimenti.Add(dipartimento);
        }

        public void MostraDettagliAzienda()
        {
            Console.WriteLine($"Azienda: {Nome}, Settore: {Settore}");
            foreach (var dip in Dipartimenti)
            {
                dip.MostraDettagliDipartimento();
            }
        }

        private void CalcolaNumeroDipartimenti()
        {
            numeroDipartimenti = Dipartimenti.Count;
            Console.WriteLine($"Numero di dipartimenti: {numeroDipartimenti}");
        }
    }
}

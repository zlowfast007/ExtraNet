using System;

namespace RisorseUmane
{
    public class Dipendente
    {

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Posizione { get; private set; }


        private decimal stipendio;
        private DateTime dataAssunzione;


        public Dipendente(int id, string nome, string posizione, decimal stipendio, DateTime dataAssunzione)
        {
            Id = id;
            Nome = nome;
            Posizione = posizione;
            this.stipendio = stipendio;
            this.dataAssunzione = dataAssunzione;
        }


        public void MostraDettagliDipendente()
        {
            Console.WriteLine($"ID: {Id}, Nome: {Nome}, Posizione: {Posizione}, Stipendio: {stipendio}, Data di Assunzione: {dataAssunzione.ToShortDateString()}");
        }

        public void AumentaStipendio(decimal incremento)
        {
            stipendio += incremento;
            Console.WriteLine($"Nuovo stipendio per {Nome}: {stipendio}");
        }
    }
}

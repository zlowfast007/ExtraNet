using System;

namespace RisorseUmane
{
    public class GestioneDipartimenti
    {
        public Dipartimento CreaDipartimento()
        {
            Console.WriteLine("Inserisci i dettagli del dipartimento:");
            Console.Write("ID Dipartimento: ");
            int idDipartimento = int.Parse(Console.ReadLine());

            Console.Write("Nome Dipartimento: ");
            string nomeDipartimento = Console.ReadLine();

            Console.Write("Sede Dipartimento: ");
            string sedeDipartimento = Console.ReadLine();

            Console.Write("Numero di Telefono: ");
            string numeroTelefono = Console.ReadLine();

            return new Dipartimento(idDipartimento, nomeDipartimento, sedeDipartimento, numeroTelefono);
        }
    }
}

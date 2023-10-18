using ConsoleAppEFwoensdag.Model;

namespace ConsoleAppEFwoensdag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Uitgeverij u = new Uitgeverij("Lannoo", "Kasteelstraat Tielt", "info@lannoo.gmail");
            Auteur a = new Auteur("Fieke Van der Gucht", "fieke@gmail");
            Boek b = new Boek("Het grote vloekboek", "veel gevloek");
            b.Auteurs.Add(a);
            b.Uitgeverij = u;

            BoekManager BM = new BoekManager();
            BM.VoegBoekToe(b);
            var x = BM.GeefBoek(1);
        }
    }
}
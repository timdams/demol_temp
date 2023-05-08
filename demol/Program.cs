namespace demol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Deelnemer> deelnemers = new List<Deelnemer>();

            deelnemers.Add(new Deelnemer());
            deelnemers.Add(new Deelnemer());
            deelnemers.Add(new Deelnemer());
            deelnemers.Add(new Deelnemer());
            deelnemers.Add(new Deelnemer());
            deelnemers.Add(new Mol());
            int pot = 0;

            do
            {
                Console.WriteLine("***\nvolgende proef");
                double som = 0;
                foreach (var deelnemer in deelnemers)
                {
                    double percent = deelnemer.NeemDeelAanProef();
                    Console.WriteLine(percent);
                    som += percent;
                }

                
                double gemiddelde = som / deelnemers.Count;
                Console.WriteLine($"Gemiddelde is {gemiddelde}");
                if (gemiddelde >= 50)
                {
                    Console.WriteLine("geslaagd");
                    pot += 1000;
                }
                else Console.WriteLine("mislukt");

                deelnemers.RemoveAt(0);

                foreach (var deelnemer in deelnemers)
                {

                    (deelnemer as Mol).MolStem();


                }

            } while (deelnemers.Count >= 3);

            Console.WriteLine($"Finale pot bedraagt {pot}");


        }
    }
}
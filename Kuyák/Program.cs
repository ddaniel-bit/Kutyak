using Kuyák;

internal class Program
{
    private static void Main(string[] args)
    {

        List<Kutyak> kutyak = new List<Kutyak>();

        StreamReader sr = new StreamReader("Kutyak.csv");
        sr.ReadLine();
        while (!sr.EndOfStream)
        {
            string[] adatok = sr.ReadLine().Split(";");
            StreamReader sr2 = new StreamReader("Kutyafajtak.csv");
            //kutyak.Add(new Kutyak(int.Parse(adatok[0]));
        }
        sr.Close();
    }
}
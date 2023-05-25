using Kuyák;

internal class Program
{
    private static void Main(string[] args)
    {

        List<Kutyak> kutyak = new List<Kutyak>();
        List<string> kutyafajtak = new List<string>();
        List<string> kutyanevek = new List<string>();

        StreamReader sr2 = new StreamReader("KutyaFajtak.csv");
        sr2.ReadLine();
        while (!sr2.EndOfStream)
        {
            kutyafajtak.Add(sr2.ReadLine());
        }
        sr2.Close();

        StreamReader sr3 = new StreamReader("KutyaNevek.csv");
        sr3.ReadLine();
        
        while (!sr3.EndOfStream)
        {
            kutyanevek.Add(sr3.ReadLine());
        }
        sr3.Close();


        StreamReader sr = new StreamReader("Kutyak.csv");
        sr.ReadLine();
        while (!sr.EndOfStream)
        {
            string[] adatok = sr.ReadLine().Split(";");
            string fajta = "";
            string fajta_eredeti = "";
            foreach (var kutyafaj in kutyafajtak)
            {
                string[] adatok2 = kutyafaj.Split(";");
                if (adatok2[0] == adatok[1])
                {
                    fajta = adatok2[1];
                    fajta_eredeti = adatok2[2];
                }
            }
            string nev = "";
            foreach (var kutyanev in kutyanevek)
            {
                string[] adatok2 = kutyanev.Split(";");
                if (adatok2[0] == adatok[2])
                {
                    nev = adatok2[1];
                }
            }

            kutyak.Add(new Kutyak(int.Parse(adatok[0]), fajta, fajta_eredeti, nev, int.Parse(adatok[3]), adatok[4]));
        }
        sr.Close();

        Console.WriteLine($"3. feladat: Kutyanevek száma: {kutyanevek.Count()}");
        double atlag = 0;
        foreach (var kutya in kutyak)
        {
            atlag += kutya.Eletkor;
        }
        atlag /= kutyak.Count();
        Console.WriteLine($"6. feladat: Kutyák átlag életkora: {Math.Round(atlag, 2)}");

        Kutyak legidosebb = kutyak[0];
        foreach (var kutya in kutyak)
        {
            if (legidosebb.Eletkor < kutya.Eletkor)
            {
                legidosebb = kutya;
            }
        }
        Console.WriteLine($"7. feladat: A legidősebb kutya neve és fajtája: {legidosebb.Nev}, {legidosebb.Fajta}");
    }
}
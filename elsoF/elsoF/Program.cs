using System.Diagnostics.Tracing;

class Szemely
{
    public string nev;
    public int eletkor;
    public string nem;
    public string lakhely;


    static void Main(string[] args)
    {
        Szemely e = new Szemely();

        e.nev = "Tomi";
        e.eletkor = 22;
        e.nem = "ferfi";
        e.lakhely = "Viador utca 11, 1035";

        Console.WriteLine(e.nev);
        Console.WriteLine(e.eletkor);
        Console.WriteLine(e.nem);
        Console.WriteLine(e.lakhely);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        // V = 1/3 pi *(r*r)v
        double radius;
        double vyska;
        double objem;
        Console.WriteLine("Zadaj polomer korena stromu:");
        double.TryParse(Console.ReadLine(),out radius);
        Console.WriteLine("Zadaj vysku stromu:");
        double.TryParse(Console.ReadLine(),out vyska);
        objem = Math.PI *Math.Pow(radius,2)*vyska * (1.0/3.0) ;
        Console.WriteLine(objem);
    } 
}
public class Strom
{
    static double year = 365;
    static double width = 0.01;
    static double prirastok = 2.0;
    public double age; //roky
    public double radius; //metre
    public double height; //metre
    public void Rastie()
    {
        age+=1/year;
        radius += width/year;
        height += prirastok/year;
    }
    public Strom()
    {
        age = 0.0;
        radius = 0.0;
        height = 0.0;
    }
}
public class Les
{
    Strom[] stromy;
    public Les(int pocet)
    {
        stromy = new Strom[pocet];
        for (int i = 0; i < pocet; i++)
        {
            stromy[i] = new Strom();
        }
    }
    public void Info()
    {   
        double s_age = stromy[0].age;
        double s_width = 0;
        double s_height = 0;
        foreach (var strom in stromy)
        {
            s_width += strom.radius;
            s_height += strom.height;        
        }
        Console.WriteLine("Vek lesa: {0} rokov",s_age);
        Console.WriteLine("Sirka lesa: {0} metrov",s_width);
        Console.WriteLine("Pocet metrov dreva: {0} metrov",s_height);
    }
    public void Rast(int pocet)
    {
        for (int i=0; i< pocet;i++)
        {
            foreach (var strom in stromy)
            {
                strom.Rastie();
            }
        }
    }
}

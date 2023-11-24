class Program
{
    public static void Main()
    {
        int pocet_stromov;
        int pocet_dni;
        Console.Write("Zadajte pocet stromov: ");
        int.TryParse(Console.ReadLine(),out pocet_stromov);
        Les les = new Les(pocet_stromov);
        Console.Write("Zadajte pocet dni: ");
        int.TryParse(Console.ReadLine(), out pocet_dni);
        les.Rast(pocet_dni);
        les.Info();
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

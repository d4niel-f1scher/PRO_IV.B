using System;

namespace Forest_PRO
{
    class Program
    {
        public static void Main(string[] args)
        {
            Oak oak = new Oak();
            oak.isDry = true;
            try
            {
                oak.Grow();
            }
            catch (DryException e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

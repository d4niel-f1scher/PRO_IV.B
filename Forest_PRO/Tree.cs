using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest_PRO
{
    class Tree : IOrganism
    {
       public bool isDry;
        static 
            double height_increment = 0.02/365.0;
            double radius_increment = 0.01/365.0;
        ~Tree() { }
        public
            double radius, height;
        public int pocet_konarov;
        public virtual
            double Volume
            { get { return Math.PI * Math.Pow(radius, 2) * height * 1.0 / 3.0; } }
        List<Branch> branches;
        Dictionary<Branch, BranchPosition> dictBranches;
        public Tree()
        {
            radius = 0.0;
            height = 0.0;
            pocet_konarov = 0;
            branches = new List<Branch>();
            Branch branch1 = new Branch();
            branches.Add(branch1);
            dictBranches = new Dictionary<Branch, BranchPosition>();
            dictBranches.Add(branch1,  new BranchPosition(1, 1, 1));
        }
        public Tree(double radius, double height, int pocet_konarov)
        {
            this.height = height;
            this.radius = radius;
            this.pocet_konarov = pocet_konarov;
        }
        public void Grow() 
        {
            radius = radius + radius_increment;
            height = height + height_increment;
        }
        public double vypocitajObjem()
        {
                List<double> volumeBranch = new List<double>();
                double averageVolume = 0.0;
                for(int i = 0; i< volumeBranch.Count();i++)
                    averageVolume += volumeBranch[i];
                try
                {
                    averageVolume /= volumeBranch.Count();
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
            return averageVolume;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest_PRO
{
    class Tree : IOrganism
    {
        static 
            double height_increment = 0.02/365.0,
            double radius_increment = 0.01/365.0;
        ~Tree() { }
        public
            double radius, height;
        public virtual
            double Volume
            { get { return Math.PI * Math.Pow(radius, 2) * height * 1.0 / 3.0; } }
        public Tree()
        {
            radius = 0.0;
            height = 0.0;
            pocet_konarov = 0;
        }
        public Tree(double radius, double height, double pocet_konarov)
        {
            this.height = height;
            this.radius = radius;
            this.pocet_konarov = pocet_konarov;
        }
        public void Growing() 
        {
            radius = radius + radius_increment;
            height = height + height_increment;
        }
    }
}

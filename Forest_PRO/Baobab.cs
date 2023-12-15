using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest_PRO
{
    class Baobab:Leaf_Tree
    {
        public override double Volume { get { return Math.PI * Math.Pow(radius, 2) * height;}}
        public Baobab() 
        { 
            
        }
        ~Baobab() 
        { 
        
        }
    }
}

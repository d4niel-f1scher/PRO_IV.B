using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest_PRO
{
	class Branch
	{
		public
            double radius, height;
        public virtual
            double Volume
			{ get { return Math.PI * Math.Pow(radius, 2) * height * 1.0 / 3.0; } }
		public Branch()
		{
			radius = 0.0;
            height = 0.0;
		}
		public Branch(double radius, double height)
		{
			this.height = height;
            this.radius = radius;
		}
		~Branch()
		{

		}
	}
}


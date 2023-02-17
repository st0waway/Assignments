using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
	internal class Two
	{
		public static int find_it(int[] seq)
		{
			return seq.Where(e => e % 2 != 0).Count();
		}


	}
}
}

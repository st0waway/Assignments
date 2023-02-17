using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OverloadingAndInterfaces.ComparableCar
{
	class SpeedComparerHighToLow : IComparer
	{
		int IComparer.Compare(object x, object y)
		{
			Car c1 = (Car)x;
			Car c2 = (Car)y;

			if (c1.Speed < c2.Speed)
				return 1;

			if (c1.Speed > c2.Speed)
				return -1;

			else
				return 0;
		}
	}
}

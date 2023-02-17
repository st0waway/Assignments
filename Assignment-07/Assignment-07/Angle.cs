namespace Assignment_07
{
	public class Angle
	{
		public int Seconds;
		public int Minutes;
		public int Degree;

		public static Angle operator +(Angle angle1, Angle angle2)
		{
			var seconds = 0;
			var minutes = 0;
			var degrees = 0;

			if (angle1.Seconds + angle2.Seconds < 60)
			{
				seconds  = angle1.Seconds + angle2.Seconds;
			}

			else
			{
				seconds += angle1.Seconds + angle2.Seconds - 60;
				minutes++;
			}

			if (minutes + angle1.Minutes + angle2.Minutes < 60)
			{
				minutes += angle1.Minutes + angle2.Minutes;
			}

			else
			{
				minutes += angle1.Minutes + angle2.Minutes - 60;
				degrees++;
			}

			degrees += angle1.Degree + angle2.Degree;

			return new Angle(degrees, minutes, seconds);
		}

		public static Angle operator -(Angle angle1, Angle angle2)
		{
			var seconds = 0;
			var minutes = 0;
			var degrees = 0;

			if (angle1.Seconds >= angle2.Seconds)
			{
				seconds = angle1.Seconds - angle2.Seconds;
			}

			else
			{
				seconds = angle1.Seconds + 60 - angle2.Seconds;
				angle1.Minutes--;
			}

			if (angle1.Minutes >= angle2.Minutes)
			{
				minutes = angle1.Minutes - angle2.Minutes;
			}

			else
			{
				minutes = angle1.Minutes + 60  - angle2.Minutes;
				angle1.Degree--;
			}

			degrees = angle1.Degree - angle2.Degree;

			return new Angle(degrees, minutes, seconds);
		}

		public Angle(int degree, int minutes, int seconds)
		{
			this.Degree = degree;
			this.Minutes = minutes;
			this.Seconds = seconds;
		}
	}
}

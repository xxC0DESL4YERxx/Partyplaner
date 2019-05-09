using System.Collections.Generic;
using System.Drawing;

namespace Partyplaner
{
	public class Gast
	{
		public string name { get; set; }
		public string beruf { get; set; }
		public Point position { get; set; }
		public Dictionary<string, int> wunschabstaende { get; private set; }

		public Gast(string aName, string aBeruf, Point aPosition, Dictionary<string, int> someWunschabstaende)
		{
			name = aName;
			beruf = aBeruf;
			position = aPosition;
			wunschabstaende = someWunschabstaende;
		}

		public override string ToString()
		{
			return name;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partyplaner
{
	class Gast
	{
		public string name { get; private set; }
		public string beruf { get; private set; }
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

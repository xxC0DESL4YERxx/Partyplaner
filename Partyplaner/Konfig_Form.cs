using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Partyplaner
{
    public partial class Konfig_Form : Form
    {
        public Konfig_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var configRoot = XElement.Load("D:\\Workspaces\\Visual Studio 2019\\C#\\Partyplaner\\Partyplaner\\Partyplaner\\config.xml");
            var gaestelisteNode = configRoot.Element("gaesteliste");

			var raumNode = configRoot.Element("raum");
			var raumGroesseNode = raumNode.Element("groesse");

			var raumTischNode = raumNode.Element("tisch");
			var raumTischGroesseNode = raumTischNode.Element("groesse");
			var raumTischPositionNode = raumTischNode.Element("position");

			foreach (var gastNode in gaestelisteNode.Elements())
			{
				// TODO Gäste parsen

			}
			var raumGroesse = ExtractXYDataFromNode(raumGroesseNode);
			var tischGroesse = ExtractXYDataFromNode(raumTischGroesseNode);
			var tischPosition = ExtractXYDataFromNode(raumTischPositionNode);
			// TODO Daten in Oberfläche laden

        }

		private Tuple<int, int> ExtractXYDataFromNode(XElement node)
		{
			var x = Convert.ToInt32(node.Attribute("x").Value);
			var y = Convert.ToInt32(node.Attribute("y").Value);
			return new Tuple<int, int>(x, y);

		}
    }
}

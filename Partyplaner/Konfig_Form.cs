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
			// TODO Pfad dynamisch machen
            var configRoot = XElement.Load("D:\\Workspaces\\Visual Studio 2019\\C#\\Partyplaner\\Partyplaner\\Partyplaner\\config.xml");
            var gaestelisteNode = configRoot.Element("gaesteliste");

			var raumNode = configRoot.Element("raum");
			var raumGroesseNode = raumNode.Element("groesse");

			var raumTischNode = raumNode.Element("tisch");
			var raumTischGroesseNode = raumTischNode.Element("groesse");
			var raumTischPositionNode = raumTischNode.Element("position");

			var gaesteliste = new List<Gast>();
			foreach (var gastNode in gaestelisteNode.Elements("gast"))
			{
				var name = gastNode.Attribute("name").Value;
				var beruf = gastNode.Attribute("beruf").Value;
				var position = ExtractXYDataFromNode(gastNode.Element("startposition"));
				var wunschabstaende = new Dictionary<string, int>();
				var wunschabstaendeNodes = gastNode.Element("wunschabstaende").Elements("wunschabstand");
				foreach (var eachWunschabstandNode in wunschabstaendeNodes)
				{
					var abstandName = eachWunschabstandNode.Attribute("gast").Value;
					var abstandDistanz = Convert.ToInt32(eachWunschabstandNode.Attribute("distanz").Value);
					wunschabstaende.Add(abstandName, abstandDistanz);
				}
				gaesteliste.Add(new Gast(name, beruf, new Point(position.Item1, position.Item2), wunschabstaende));
			}
			Console.WriteLine(gaesteliste);
			var raumGroesse = ExtractXYDataFromNode(raumGroesseNode);
			var tischGroesse = ExtractXYDataFromNode(raumTischGroesseNode);
			var tischPosition = ExtractXYDataFromNode(raumTischPositionNode);
			// TODO Daten in Oberfläche laden
			num_raum_groesse_x.Value = raumGroesse.Item1;
			num_raum_groesse_y.Value = raumGroesse.Item2;
			num_tisch_groesse_x.Value = tischGroesse.Item1;
			num_tisch_groesse_y.Value = tischGroesse.Item2;
			num_tisch_pos_x.Value = tischPosition.Item1;
			num_tisch_pos_y.Value = tischPosition.Item2;

			list_gaesteliste.BeginUpdate();
			foreach (var gast in gaesteliste)
			{
				list_gaesteliste.Items.Add(gast);
			}
			list_gaesteliste.SelectedValueChanged += OnGastSelectionChanged;
			list_gaesteliste.EndUpdate();
		}

		private void OnGastSelectionChanged(object sender, EventArgs ev)
		{
			var gast = (Gast)list_gaesteliste.SelectedItem;
			txt_name.Text = gast.name;
			txt_beruf.Text = gast.beruf;
			num_startpos_x.Value = gast.position.X;
			num_startpos_y.Value = gast.position.Y;
			// TODO Wunschabstände
		}

		private Tuple<int, int> ExtractXYDataFromNode(XElement node)
		{
			var x = Convert.ToInt32(node.Attribute("x").Value);
			var y = Convert.ToInt32(node.Attribute("y").Value);
			return new Tuple<int, int>(x, y);

		}
    }
}

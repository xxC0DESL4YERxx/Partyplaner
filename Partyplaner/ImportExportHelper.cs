using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace Partyplaner
{
    public class ImportExportHelper
    {
        private const string XML_PATH = "config.xml";
        public Dictionary<string, Gast> gaesteliste = new Dictionary<string, Gast>();
        private static ImportExportHelper importExportHelper;
        private Tuple<int,int> tischGroesse { get; set; }
        private Tuple<int,int> tischPosition { get; set; }
        private Tuple<int, int> raumGroesse { get; set; }

		/// <summary>
		/// Der Konstruktor der Klasse.
		/// </summary>
		private ImportExportHelper() { }

        /// <summary>
        /// Liefert die Instanz der Klasse.
        /// </summary>
        /// <returns>Die Instanz der Klasse.</returns>
        public static ImportExportHelper getImportExportHelper()
        {
            if (importExportHelper == null)
            {
                importExportHelper = new ImportExportHelper();
            }
            return importExportHelper;
        }

        /// <summary>
        /// Liest die relevanten Daten aus der XML Datei.
        /// </summary>
        private void loadXMLValues()
        {
            // Extrahieren der Daten
            XElement configRoot = null;
            try
            {
                configRoot = XElement.Load(XML_PATH);
            }
            catch (FileNotFoundException ex)
            {
                // Noch keine Konfiguration vorhanden
                return;
            }
            var gaestelisteNode = configRoot.Element("gaesteliste");
            var raumNode = configRoot.Element("raum");
            var raumGroesseNode = raumNode.Element("groesse");
            var raumTischNode = raumNode.Element("tisch");
            var raumTischGroesseNode = raumTischNode.Element("groesse");
            var raumTischPositionNode = raumTischNode.Element("position");

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
                // Hier könnte man noch eine If-Prüfung einbauen ob der Gast schon existiert.
                gaesteliste.Add(name, new Gast(name, beruf, new Point(position.Item1, position.Item2), wunschabstaende));
            }

            raumGroesse = ExtractXYDataFromNode(raumGroesseNode);
            tischGroesse = ExtractXYDataFromNode(raumTischGroesseNode);
            tischPosition = ExtractXYDataFromNode(raumTischPositionNode);
        }

        /// <summary>
        /// Liefert für einen Gastnamen den dazugehörigen Gast aus der Gaesteliste.
        /// </summary>
        /// <param name="guestName"> Der Name des zu suchenden Gast.</param>
        /// <returns>Den gesuchten Gast.</returns>
        public Gast GetGast(string guestName)
        {
            foreach (Gast eachGast in gaesteliste.Values)
            {
                if(eachGast.name == guestName)
                {
                    return eachGast;
                }
            }
			return null;
        }

        /// <summary>
        /// Liefert die XY-Attribute einer XY-Node als Tupel zurück.
        /// </summary>
        /// <param name="node">Die Node, deren XY-Attribute extrahiert werden sollen.</param>
        /// <returns>Die XY-Attribute.</returns>
        private Tuple<int, int> ExtractXYDataFromNode(XElement node)
        {
            var x = Convert.ToInt32(node.Attribute("x").Value);
            var y = Convert.ToInt32(node.Attribute("y").Value);
            return new Tuple<int, int>(x, y);
        }
    }
}
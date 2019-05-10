using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace Partyplaner
{
    public class Statistik
    {
        ImportExportHelper DatenManager;
        public Statistik()
        {
            DatenManager = ImportExportHelper.getImportExportHelper();
        }

        public float GetPartyindex()
        {
            List<int> befindlichkeiten = DatenManager.GetBefindlichkeiten();
            int anzahl = DatenManager.GetAnzahlGaeste();
            float sum = 0;
            float partyindex = 0;
            
            foreach(int befindlichkeit in befindlichkeiten)
            {
                sum = sum + befindlichkeit;
            }

            partyindex = sum / anzahl;

            return partyindex;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Partyplaner
{
    public static class Befindlichkeit
    {
        /// <summary>
        /// Berechnet die Befindlichkeit einer Person 
        /// </summary>
        /// <param name="person"></param>
        /// <param name="gaesteliste"></param>
        /// <returns></returns>
        public static Dictionary<Point, double> GetBefindlichkeit(Gast person, List<Gast> gaesteliste, List<Point> tisch)
        {
            Dictionary<Point, double> befindlichkeiten = new Dictionary<Point, double>();
            double sum = 0;
            double befind = 0;
            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    //Für jede andere Person in Gästeliste 
                    foreach (Gast otherpers in gaesteliste)
                    {
                        if (otherpers != person)
                        {
                            //Berechne Abstand zur aktuell anderen Person 
                            double abstand = GetAbstand(person.position.X + x, person.position.Y + y, otherpers.position);
                            double sumTisch = 0;
                            foreach (Point p in tisch)
                            {
                                double abstandTisch = GetAbstand(person.position.X, person.position.Y, p);
                                sumTisch += abstandTisch;
                            }
                            sumTisch = sumTisch / tisch.Count;
                            int wabs = 0;
                            //Hole den W-Abstand und subtrahiere diesen von tatsächlichen Abstand
                            person.wunschabstaende.TryGetValue(otherpers.name, out wabs);
                           
                            if (abstand - wabs <= 0)
                                befind = 0;
                            else
                                befind += (abstand - wabs);
                            if (befind > 0)
                            {
                                if (befind - sumTisch <= 0)
                                    befind = 0;
                                else
                                    befind += sumTisch;
                            }
                            sum += abstand - wabs;
                        }
                    }
                    Point akt = new Point(person.position.X + x, person.position.Y + y);
                    befindlichkeiten.Add(akt, sum);
                    sum = 0;
                }
            }
            return befindlichkeiten;
        }
        /// <summary>
        /// Berechnet den Abstand zwischen zwei Personen
        /// </summary>
        /// <param name="xa"></param>
        /// <param name="ya"></param>
        /// <param name="pb"></param>
        /// <returns></returns>
        private static double GetAbstand(double xa, double ya, Point pb)
        {
            double x = Math.Pow((xa - pb.X), 2);
            double y = Math.Pow((ya - pb.Y), 2);
            return Math.Round(Math.Sqrt(x + y), 1);
        }
    }
}

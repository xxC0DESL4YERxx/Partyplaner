using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partyplaner
{
    class Darstellung
    {
        Graphics g;
        int gameWidth;
        int gameHeight;
        int tileWidth;
        int tileHeight;
        public Darstellung(Graphics g)
        {
            this.g = g;

        }
        /*
        public void ZeichneSpielfeld()
        {
            List<Point> tisch = DatenManager.GetTisch();
            SpielFeld spielFeld = DatenManager.GetSpielfeld();
            List<Point> personen = DatenManager.GetPersonen();
            gameWidth = spielFeld.GameSize.X;
            gameHeight = spielFeld.GameSize.Y;
            tileHeight = spielFeld.TileSize.Y;
            tileWidth = spielFeld.TileSize.X;
            Pen p = new Pen(Color.Black, 1);
            g.Clear(Color.FromKnownColor(KnownColor.Control));
            g.FillRectangle(new Pen(Color.White, 1).Brush, new Rectangle(0, 0, gameWidth, gameHeight));
            Point startPoint = new Point(0, 0);
            Point endPoint = new Point(0, 0);
            for (int x = 0; x <= gameWidth; x += tileWidth)
            {
                startPoint = new Point(x, 0);
                endPoint = new Point(startPoint.X, startPoint.Y + gameHeight);
                g.DrawLine(p, startPoint, endPoint);
            }
            for (int y = 0; y <= gameHeight; y += tileHeight)
            {
                startPoint = new Point(0, y);
                endPoint = new Point(startPoint.X + gameWidth, startPoint.Y);
                g.DrawLine(p, startPoint, endPoint);
            }
            foreach (Point point in tisch)
            {
                g.FillRectangle(new Pen(Color.Brown, 1).Brush, new Rectangle(point.X * tileWidth, point.Y * tileHeight, tileWidth, tileHeight));
            }

            foreach (Point point in personen)
            {
                g.FillRectangle(new Pen(Color.Orange, 1).Brush, new Rectangle(point.X * tileWidth, point.Y * tileHeight, tileWidth, tileHeight));
            }
        }
        */
        public void DrawPartyIndex(Graphics g, List<Point> points)
        {
            Point grosse = new Point(200, 100);
            Pen pGraph = new Pen(Color.Black, 1);

            g.DrawLine(pGraph, new Point(5, 5), new Point(5, 95));
            g.DrawLine(pGraph, new Point(5, 95), new Point(195, 95));

            for (int i = 0; i < points.Count; i++)
            {
                Point p = points[i];
                points[i] = new Point((p.X + 1) * 5, p.Y);
            }
            if (points.Count > 0)
                g.DrawLines(pGraph, points.ToArray());
        }
    }
}

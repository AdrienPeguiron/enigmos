using System.Drawing;
using System.Windows.Forms;
using System;

namespace Cpln.Enigmos.Enigmas
{
    /// <summary>
    /// Un casse brique classique
    /// </summary>
    class CasseBriqueEnigmaPanel : EnigmaPanel
    {
        /// <summary>
        /// constructeur de base sans paramètres
        /// </summary>
        public CasseBriqueEnigmaPanel()
        {
            //largeur de la fenêtre
            int iLargeur = 800;
            //hauteur de la fenêtre
            int iHauteur = 600;
            //largeur des rectangles à casser
            int iLargeurBrique = 100;
            //hauteur des rectangles à casser
            int iHauteurBrique = 30;
            int iLargeurPlateforme = 50;
            int X = 0;
            int Y = 0;
            Random rndRGB = new Random();
            for (int i = 0; i < 24; i++)
            {
                Color rndColor = Color.FromArgb(rndRGB.Next(240), rndRGB.Next(240), rndRGB.Next(255));
                Label dynamicLabel = new Label();
                dynamicLabel.Name = "Label" + (i + 1);
                dynamicLabel.Width = iLargeurBrique;
                dynamicLabel.Height = iHauteurBrique;
                dynamicLabel.BackColor = rndColor;
                dynamicLabel.BorderStyle = BorderStyle.FixedSingle;
                dynamicLabel.Left = X;
                dynamicLabel.Top = Y;
                Controls.Add(dynamicLabel);
                if (X < 700)
                {
                    X += 100;
                }
                else
                {
                    X = 0;
                    Y += 30;
                }
            }

        }
    }
}

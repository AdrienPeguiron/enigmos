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
            //hauteur des rectangles 
            int iHauteurBrique = 30;
            //largeur de la plateforme de réception
            int iLargeurPlateforme = 50;
            //position sur l'axe des X utilisé pour la création des briques
            int X = 0;
            //position sur l'axe des Y utilisé pour la création des briques
            int Y = 0;
            //variable aléatoire pour assigner des couleurs aux hasard aux briques
            Random rndRGB = new Random();
            //permet de créer toutes les briques
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

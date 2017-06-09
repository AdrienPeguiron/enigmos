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
        //création d'un timer gérant les déplacements de la plateforme et de la balle
        Timer timer = new Timer();
        /// <summary>
        /// constructeur de base sans paramètres
        /// </summary>
        public CasseBriqueEnigmaPanel()
        {
            //le temps entre chaque tic sera de une milliseconde
            Timer.Interval = 1;
            //ajout d'un événement pour chaque tic
            Timer.Tick += new EventHandler(Timer_Tick);
            //largeur de la fenêtre
            int iLargeur = 800;

            //hauteur de la fenêtre
            int iHauteur = 600;

            //largeur des rectangles à casser
            int iLargeurBrique = 100;

            //hauteur des rectangles 
            int iHauteurBrique = 30;

            //largeur de la plateforme de réception
            int iLargeurPlateforme = 75;

            //position sur l'axe des X utilisé pour la création des briques
            int X = 0;

            //position sur l'axe des Y utilisé pour la création des briques
            int Y = 0;

            //variable aléatoire pour assigner des couleurs aux hasard aux briques
            Random rndRGB = new Random();

            //permet de créer toutes les briques
            for (int i = 0; i < 25; i++)
            {
                //créé une couleur aléatoire
                Color rndColor = Color.FromArgb(rndRGB.Next(240), rndRGB.Next(240), rndRGB.Next(255));

                //crée un label
                Label dynamicLabel = new Label();

                //différencie les briques à casser de la brique contrôlable
                if (i == 24)
                {
                    //donne le nom de la brique contrôlable
                    dynamicLabel.Name = "lblRecepteur";

                    //donne la largeur de la brique contrôlable
                    dynamicLabel.Width = iLargeurPlateforme;

                    //positionne la brique contrôlable au milieu de l'axe des X
                    X = iLargeur / 2 - iLargeurPlateforme / 2;

                    //positionne la brique contrôlable au trois quarts de l'axe des Y
                    Y = (iHauteur / 4) * 3;
                }
                else
                {
                    //donne les nom des briques à casser
                    dynamicLabel.Name = "LblBrique" + (i + 1);

                    //définit la longueur des briques à casser
                    dynamicLabel.Width = iLargeurBrique;

                }
                //définit la hauteur des briques
                dynamicLabel.Height = iHauteurBrique;

                //attribue une couleur aléatoire à une brique
                dynamicLabel.BackColor = rndColor;

                //donne une bordure aux briques
                dynamicLabel.BorderStyle = BorderStyle.FixedSingle;

                //la position des briques sur l'axe des X
                dynamicLabel.Left = X;

                //la position des briques sur l'axe des Y
                dynamicLabel.Top = Y;

                //ajoute le label à l'écran 
                Controls.Add(dynamicLabel);

                //tant qu'une ligne de briques n'atteint pas le bout de l'écran, elle continue
                if (X < 700)
                {
                    X += 100;
                }
                //une fois que les briques atteignent le bord de l'écran, elles descendent d'une ligne
                else
                {
                    X = 0;
                    Y += 30;
                }

            }
            //PictureBx contenant la balle
            PictureBox pbxBalle = new PictureBox();
            //définission de la taille de la balle
            pbxBalle.Size = new Size(30, 30);
            //on séléctionne l'image voulue
            pbxBalle.Image = Properties.Resources.balletennispovray___Copie;
            //on pose la balle au milieu sur l'axe horizontal
            pbxBalle.Left = iLargeur / 2 - pbxBalle.Width / 2;
            //on pose la balle au dessus de la plateforme sur l'axe vertical
            pbxBalle.Top = (iHauteur / 4) * 3 - iHauteurBrique;
            //fait en sorte que la balle soit à la taille de la PictureBox
            pbxBalle.SizeMode = PictureBoxSizeMode.StretchImage;
            //on ajoute la balle
            Controls.Add(pbxBalle);
        }
        /// <summary>
        /// déplace la plateforme en fonction des touches pressées
        /// </summary>
        public override void PressKey(object sender, KeyEventArgs e)
        {

        }
        /// <summary>
        /// gère le déplacement de la balle
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {

        }
    }
}

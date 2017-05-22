using System.Drawing;
using System.Windows.Forms;

namespace Cpln.Enigmos.Enigmas
{
    class CasseBriqueEnigmaPanel : EnigmaPanel
    {
        public CasseBriqueEnigmaPanel()
        {
            int iLargeur = 800;
            int iHauteur = 600;
            int iLargeurBrique = 100;
            int iHauteurBrique = 30;
            int iLargeurPlateforme = 50;
            int X = 0;
            int Y = 0;
            for (int i = 0; i < 8; i++)
            {
                Label dynamicLabel = new Label();
                dynamicLabel.Name = "Label" + (i + 1);
                dynamicLabel.Width = 100;
                dynamicLabel.Height = 100;
                dynamicLabel.BackColor = Color.;
                dynamicLabel.Left = X;
                dynamicLabel.Top = Y;
                if (X != 800)
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

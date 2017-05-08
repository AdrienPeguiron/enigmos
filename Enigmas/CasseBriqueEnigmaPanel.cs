using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
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
            for (int i = 0; i < 8; i++)
            {
                Label dynamicLabel = new Label();
                dynamicLabel.Name = "Label" + (i + 1);
                dynamicLabel.Width = 100;
                dynamicLabel.Height = 100;
                dynamicLabel.BackColor = Color.Yellow;
            }
        }
    }
}

using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		/* Függvények */
		void bfraktal(double meret, int év)
        {
            if (év==1)
            {
				Előre(meret);
            }
            else if (év>1)
            {
                bfraktal(meret / 3, év - 1);
                Balra(90);
                bfraktal(meret / 3, év - 1);
                Jobbra(90);
                bfraktal(meret / 3, év - 1);
                Jobbra(90);
                bfraktal(meret / 3, év - 1);
                Balra(90);
                bfraktal(meret / 3, év - 1);
            }
        }
		void jfraktal(double meret, int év)
        {
            if (év == 1)
            {
                Előre(meret);
            }
            else if (év > 1)
            {
                jfraktal(meret / 3, év - 1);
                Jobbra(90);
                jfraktal(meret / 3, év - 1);
                Balra(90);
                jfraktal(meret / 3, év - 1);
                Balra(90);
                jfraktal(meret / 3, év - 1);
                Jobbra(90);
                jfraktal(meret / 3, év - 1);
            }
        }

        void fraktal(double meret, int év)
        {
            if (év==1)
            {
                Előre(meret);
            }
            else if (év>1)
            {
                bfraktal(meret / 3, év - 1);
                Balra(90);
                jfraktal(meret / 3, év - 1);
                Jobbra(90);
                bfraktal(meret / 3, év - 1);
                Jobbra(90);
                jfraktal(meret / 3, év - 1);
                Balra(90);
                bfraktal(meret / 3, év - 1);
            }
        }

		/* Függvények vége */
		void FELADAT()
		{
            /* Ezt indítja a START gomb! */
            Jobbra(90);
            fraktal(100, 3);
			// Teleport(közép.X, közép.Y+150, észak);
		}
	}
}

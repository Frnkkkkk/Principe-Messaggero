using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlPrincipeEIlMessaggero
{
    public partial class Form1 : Form
    {
        bool andata = true,first=true;
        int YMess=381, XMess=12;
        int XPrinc=12,YPrinc= 316;
        int Giorni=1,Distanza=50;

        private void TimerSecond_Tick(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tiger.Start();
        }

        private void Tiger_Tick(object sender, EventArgs e)
        {
            if (first)
            {
                pictureBox2.Location = new Point(XPrinc + 5, YPrinc);
                pictureBox1.Location = new Point(XMess + 5, YMess);
                XPrinc += 5;
                XMess += 5;
                first = false;
                Giorni++;
                andata = false;
                label1.Text = "Giorno: " + Convert.ToString(Giorni);
                pictureBox1.Load("../../../ezgif.com-rotate.gif");
            }
            else
            {

                if (andata)
                {
                    if (XPrinc != XMess)
                    {
                        pictureBox1.Location = new Point(XMess + 10, YMess);
                        XMess += 10;
                    }
                    else
                    {
                        andata = false;
                        pictureBox1.Load("../../../ezgif.com-rotate.gif");
                    }
                }
                if(!andata)
                {
                    pictureBox1.Location = new Point(XMess - 5, YMess);
                    XMess -= 5;
                    if (XMess-5 > 12)
                    {
                        pictureBox1.Location = new Point(XMess - 5, YMess);
                        XMess -= 5;
                    }
                    else
                    {
                        pictureBox1.Location = new Point(17, YMess);
                        XMess = 17;
                        pictureBox1.Load("../../../QGo5isT.gif");
                        andata = true;
                    }

                }
                pictureBox2.Location = new Point(XPrinc + 5, YPrinc);
                XPrinc += 5;
                Distanza += 50;
                // MessageBox.Show(Convert.ToString(XPrinc) + "    " + Convert.ToString(XMess));
                if (XPrinc == XMess)
                {
                    lastmeeting.Text = "Ultimo incontro: giorno " + Giorni.ToString() + ", alla distanza di " + Distanza.ToString()+"Km dal castello";
                }
                
                Giorni++;
            }
            label1.Text = "Giorno: " + Convert.ToString(Giorni);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema2
{
    public partial class Form1 : Form
    {
        int cont = 0;

        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
        }

        public void CambiarAmbar(PictureBox p1)
        {
            p1.Image = Problema2.Properties.Resources.Ambar;
        }
        public void CambiarAmbars(PictureBox p1, PictureBox p2)
        {
            p1.Image = Problema2.Properties.Resources.Ambar;
            p2.Image = Problema2.Properties.Resources.Ambar;
        }

        public void CambiarApagado(PictureBox p1)
        {
            p1.Image = Problema2.Properties.Resources.Apagados;
        }
        public void CambiarApagados(PictureBox p1, PictureBox p2)
        {
            p1.Image = Problema2.Properties.Resources.Apagados;
            p2.Image = Problema2.Properties.Resources.Apagados;
        }

        public void CambiarVerde(PictureBox p1)
        {
            p1.Image = Problema2.Properties.Resources.Verde;
        }
        public void CambiarVerdes(PictureBox p1, PictureBox p2)
        {
            p1.Image = Problema2.Properties.Resources.Verde;
            p2.Image = Problema2.Properties.Resources.Verde;
        }

        public void CambiarRojo(PictureBox p1)
        {
            p1.Image = Problema2.Properties.Resources.Rojo;
        }
        public void CambiarRojos(PictureBox p1, PictureBox p2)
        {
            p1.Image = Problema2.Properties.Resources.Rojo;
            p2.Image = Problema2.Properties.Resources.Rojo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cont == 1)
            {
                CambiarAmbar(pictureBox1);
                CambiarAmbar(pictureBox2);
                CambiarAmbar(pictureBox3);
                CambiarAmbar(pictureBox4);
            }

            else if (cont == 2)
            {
                CambiarApagado(pictureBox1);
                CambiarApagado(pictureBox2);
                CambiarApagado(pictureBox3);
                CambiarApagado(pictureBox4);
                cont = 0;
            }
            cont++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          
                if (cont > 0 && cont < 21)
                {
                    CambiarVerdes(pictureBox1, pictureBox4);
                    CambiarRojos(pictureBox2, pictureBox3);
                }
                else if (cont > 20 && cont < 26)
                {
                    CambiarAmbars(pictureBox1, pictureBox4);
                }
                else if (cont > 25 && cont < 31)
                {
                    CambiarRojos(pictureBox1, pictureBox4);
                }

                else if (cont > 30 && cont < 51)
                {
                    CambiarVerdes(pictureBox2, pictureBox3);
                    CambiarRojos(pictureBox1, pictureBox4);
                }
                else if (cont > 50 && cont < 56)
                {
                    CambiarAmbars(pictureBox2, pictureBox3);
                }
                else if (cont > 55  && cont < 61)
                {
                    CambiarRojos(pictureBox2, pictureBox3);
                }
                else if (cont == 65)
                {
                    cont = 0;
                }

            cont++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Stop();
                CambiarApagado(pictureBox1);
                CambiarApagado(pictureBox2);
                CambiarApagado(pictureBox3);
                CambiarApagado(pictureBox4);
            }
            timer2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled == true)
            {
                timer2.Stop();
                CambiarApagado(pictureBox1);
                CambiarApagado(pictureBox2);
                CambiarApagado(pictureBox3);
                CambiarApagado(pictureBox4);
            }
            if (timer1.Enabled == true)
            {
                timer1.Stop();
                CambiarApagado(pictureBox1);
                CambiarApagado(pictureBox2);
                CambiarApagado(pictureBox3);
                CambiarApagado(pictureBox4);
            }
            else
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                label1.Text = "*Selecciona la vía que quiere\n transformar a ´vías preferentes`\n con el RadioButton.";
                label1.Visible = true;
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true)
            {
                if (cont > 0 && cont < 41)
                {
                    CambiarVerdes(pictureBox1, pictureBox4);
                    CambiarRojos(pictureBox2, pictureBox3);
                }
                else if (cont > 40 && cont < 46)
                {
                    CambiarAmbars(pictureBox1, pictureBox4);
                }
                else if (cont > 45 && cont < 51)
                {
                    CambiarRojos(pictureBox1, pictureBox4);
                }

                else if (cont > 50 && cont < 71)
                {
                    CambiarVerdes(pictureBox2, pictureBox3);
                    CambiarRojos(pictureBox1, pictureBox4);
                }
                else if (cont > 70 && cont < 76)
                {
                    CambiarAmbars(pictureBox2, pictureBox3);
                }
                else if (cont > 75 && cont < 81)
                {
                    CambiarRojos(pictureBox2, pictureBox3);
                }
                else if (cont == 85)
                {
                    cont = 0;
                }
            }

            else if (radioButton3.Checked == true || radioButton4.Checked == true)
            {
                if (cont > 0 && cont < 41)
                {
                    CambiarVerdes(pictureBox2, pictureBox3);
                    CambiarRojos(pictureBox1, pictureBox4);
                }
                else if (cont > 40 && cont < 46)
                {
                    CambiarAmbars(pictureBox2, pictureBox3);
                }
                else if (cont > 45 && cont < 51)
                {
                    CambiarRojos(pictureBox2, pictureBox3);
                }

                else if (cont > 50 && cont < 71)
                {
                    CambiarVerdes(pictureBox1, pictureBox4);
                    CambiarRojos(pictureBox2, pictureBox3);
                }
                else if (cont > 70 && cont < 76)
                {
                    CambiarAmbars(pictureBox1, pictureBox4);
                }
                else if (cont > 75 && cont < 81)
                {
                    CambiarRojos(pictureBox1, pictureBox4);
                }
                else if (cont == 85)
                {
                    cont = 0;
                }
            }
        }
    }
}

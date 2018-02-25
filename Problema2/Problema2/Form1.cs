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
        Random r = new Random();
        int cont = 0;
        int cuentan1 = 0;
        int cuentan2 = 0;
        int x = 0, y = 0;
        int x2 = 0, y2 = 0;
        int x3 = 0, y3 = 0;
        int x4 = 0, y4 = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            x = pictureBox5.Location.X;
            y = pictureBox5.Location.Y;
            x2 = pictureBox6.Location.X;
            y2 = pictureBox6.Location.Y;
            x3 = pictureBox7.Location.X;
            y3 = pictureBox7.Location.Y;
            x4 = pictureBox8.Location.X;
            y4 = pictureBox8.Location.Y;
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
            if (timer2.Enabled == true)
            {
                timer2.Enabled = false;
                CambiarApagado(pictureBox1);
                CambiarApagado(pictureBox2);
                CambiarApagado(pictureBox3);
                CambiarApagado(pictureBox4);
                timer1.Start();
            }
            else
            {
                timer1.Start();
            }

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
                pictureBox7.Location = new Point(x3, y3 -= 14);
                pictureBox8.Location = new Point(x4, y4 += 14);
                CambiarRojos(pictureBox2, pictureBox3);
            }
            else if (cont > 20 && cont < 26)
            {
                CambiarAmbars(pictureBox1, pictureBox4);
                pictureBox7.Location = new Point(x3, y3 -= 30);
                pictureBox8.Location = new Point(x4, y4 += 30);

            }
            else if (cont > 25 && cont < 31)
            {
                CambiarRojos(pictureBox1, pictureBox4);
                pictureBox7.Location = new Point(x3, y3 -= 20);
                pictureBox8.Location = new Point(x4, y4 += 20);
            }

            else if (cont > 30 && cont < 51)
            {
                CambiarVerdes(pictureBox2, pictureBox3);
                    pictureBox5.Visible = true;
                    pictureBox5.Location = new Point(x += 14, y);
                    pictureBox6.Location = new Point(x2 -= 14, y2);
                CambiarRojos(pictureBox1, pictureBox4);
            }
            else if (cont > 50 && cont < 56)
            {
                CambiarAmbars(pictureBox2, pictureBox3);
                 pictureBox5.Location = new Point(x += 30, y);
                 pictureBox6.Location = new Point(x2 -= 30, y2);

            }
            else if (cont > 55 && cont < 61)
            {
                CambiarRojos(pictureBox2, pictureBox3);
                pictureBox5.Location = new Point(x += 20, y);
                pictureBox6.Location = new Point(x2 -= 20, y2);
            }
            else if (cont == 65)
            {
                cont = 0;
                pictureBox5.Update();
                pictureBox6.Update();
                pictureBox7.Update();
                pictureBox8.Update();
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
                timer3.Start();
            }
            else if (timer1.Enabled == true)
            {
                timer1.Stop();
                CambiarApagado(pictureBox1);
                CambiarApagado(pictureBox2);
                CambiarApagado(pictureBox3);
                CambiarApagado(pictureBox4);
                timer3.Start();
            }
            else
            {
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (cont > 0 && cont < 41)
                {
                    CambiarVerdes(pictureBox1, pictureBox4);
                    CambiarRojos(pictureBox2, pictureBox3);
                    pictureBox7.Location = new Point(x3, y3 -= 8);
                    pictureBox8.Location = new Point(x4, y4 += 8);
                }
                else if (cont > 40 && cont < 46)
                {
                    CambiarAmbars(pictureBox1, pictureBox4);
                    pictureBox7.Location = new Point(x3, y3 -= 15);
                    pictureBox8.Location = new Point(x4, y4 += 15);
                }
                else if (cont > 45 && cont < 51)
                {
                    CambiarRojos(pictureBox1, pictureBox4);
                    pictureBox7.Location = new Point(x3, y3 -= 20);
                    pictureBox8.Location = new Point(x4, y4 += 20);
                }

                else if (cont > 50 && cont < 71)
                {
                    CambiarVerdes(pictureBox2, pictureBox3);
                    pictureBox5.Visible = true;
                    pictureBox5.Location = new Point(x += 14, y);
                    pictureBox6.Location = new Point(x2 -= 14, y2);
                    CambiarRojos(pictureBox1, pictureBox4);
                    
                }
                else if (cont > 70 && cont < 76)
                {
                    CambiarAmbars(pictureBox2, pictureBox3);
                    pictureBox5.Location = new Point(x += 30, y);
                    pictureBox6.Location = new Point(x2 -= 30, y2);
                }
                else if (cont > 75 && cont < 81)
                {
                    CambiarRojos(pictureBox2, pictureBox3);
                    pictureBox5.Location = new Point(x += 20, y);
                    pictureBox6.Location = new Point(x2 -= 20, y2);
                }
                else if (cont == 85)
                {
                    cont = 0;
                }
            }

            else if (radioButton2.Checked)
            {
                if (cont > 0 && cont < 41)
                {
                    pictureBox5.Visible = true;
                    CambiarVerdes(pictureBox2, pictureBox3);
                    CambiarRojos(pictureBox1, pictureBox4);
                    pictureBox6.Location = new Point(x2 -= 8, y2);
                    pictureBox5.Location = new Point(x += 8, y);
                }
                else if (cont > 40 && cont < 46)
                {
                    CambiarAmbars(pictureBox2, pictureBox3);
                    pictureBox6.Location = new Point(x2 -= 15, y2);
                    pictureBox5.Location = new Point(x += 15, y );
                }
                else if (cont > 45 && cont < 51)
                {
                    CambiarRojos(pictureBox2, pictureBox3);
                    pictureBox6.Location = new Point(x2 -= 30, y2);
                    pictureBox5.Location = new Point(x += 30, y);
                }

                else if (cont > 50 && cont < 71)
                {
                    CambiarVerdes(pictureBox1, pictureBox4);
                    CambiarRojos(pictureBox2, pictureBox3);
                    pictureBox7.Location = new Point(x3, y3 -= 14);
                    pictureBox8.Location = new Point(x4, y4 += 14);
                }
                else if (cont > 70 && cont < 76)
                {
                    CambiarAmbars(pictureBox1, pictureBox4);
                    pictureBox7.Location = new Point(x3, y3 -= 30);
                    pictureBox8.Location = new Point(x4, y4 += 30);
                }
                else if (cont > 75 && cont < 81)
                {
                    CambiarRojos(pictureBox1, pictureBox4);
                    pictureBox7.Location = new Point(x3, y3 -= 20);
                    pictureBox8.Location = new Point(x4, y4 += 20);
                }
                else if (cont == 85)
                {
                    cont = 0;
                }
            }
            cont++;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Stop();
            }
            else if (timer2.Enabled == true)
            {
                timer2.Stop();
            }
            else if (timer3.Enabled == true)
            {
                timer2.Stop();
            }
            else
            {
                timer4.Start();
            cuentan1 = r.Next(0, 20);
            cuentan2 = r.Next(0, 20);
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            numericUpDown1.Value = cuentan1;
            numericUpDown2.Value = cuentan2;

            if (numericUpDown1.Value > numericUpDown2.Value)
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
                    cuentan1 = r.Next(0, 20);
                    cuentan2 = r.Next(0, 20);
                    cont = 0;
                }
            }

            else if (numericUpDown2.Value > numericUpDown1.Value)
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
                    cuentan1 = r.Next(0, 20);
                    cuentan2 = r.Next(0, 20);
                    cont = 0;
                }
            }

            else if (numericUpDown1.Value == numericUpDown2.Value)
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
                    cuentan1 = r.Next(0, 20);
                    cuentan2 = r.Next(0, 20);
                    cont = 0;
                }
            }
            cont++;
        }
    }
}

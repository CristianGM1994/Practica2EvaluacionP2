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
        bool modoaveria;
        bool modonormal;
        bool modopreferente;
        bool modointeligente;

       
        int x = -112, y = 223;
        int x2 = 418, y2 = 155;
        int x3 = 210, y3 = 351;
        int x4 = 152, y4 = -33;

        public Form1()
        {

            InitializeComponent();
            DoubleBuffered = true;
            timer1.Stop();
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
            modonormal = false;
            modointeligente = false;
            modopreferente = false;
            CambiarApagado(pictureBox1);
            CambiarApagado(pictureBox2);
            CambiarApagado(pictureBox3);
            CambiarApagado(pictureBox4);
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            modoaveria = true;
            timer1.Start();
            cont = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (modoaveria == true)
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

            else if (modonormal == true)
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
                    pictureBox5.Location = new Point(x += 25, y);
                    pictureBox6.Location = new Point(x2 -= 20, y2);
                }
                else if (cont == 65)
                {
                    EmpezarDeNuevo();
                }

                cont++;
            }

            else if (modopreferente == true)
            {
                if (radioButton1.Checked)
                {
                    if (cont > 0 && cont < 41)
                    {
                        radioButton1.Enabled = false;
                        radioButton2.Enabled = false;
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
                        radioButton1.Enabled = true;
                        radioButton2.Enabled = true;
                    }
                    else if (cont == 85)
                    {
                        EmpezarDeNuevo();
                    }
                }

                else if (radioButton2.Checked)
                {
                    if (cont > 0 && cont < 41)
                    {
                        radioButton1.Enabled = false;
                        radioButton2.Enabled = false;
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
                        pictureBox5.Location = new Point(x += 15, y);
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
                        radioButton1.Enabled = true;
                        radioButton2.Enabled = true;
                        pictureBox7.Location = new Point(x3, y3 -= 20);
                        pictureBox8.Location = new Point(x4, y4 += 20);
                    }
                    else if (cont == 85)
                    {
                        EmpezarDeNuevo();
                    }
                }
                cont++;
            }

            else if (modointeligente == true)
            {
                numericUpDown1.Value = numericUpDown3.Value + numericUpDown6.Value;
                numericUpDown2.Value = numericUpDown4.Value + numericUpDown5.Value;

                if (numericUpDown1.Value > numericUpDown2.Value)
                {
                    if (cont > 0 && cont < 41)
                    {
                        CambiarVerdes(pictureBox1, pictureBox4);
                        pictureBox7.Location = new Point(x3, y3 -= 8);
                        pictureBox8.Location = new Point(x4, y4 += 8);
                        CambiarRojos(pictureBox2, pictureBox3);
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
                        numericUpDown3.Value = r.Next(0, 20);
                        numericUpDown4.Value = r.Next(0, 20);
                        numericUpDown5.Value = r.Next(0, 20);
                        numericUpDown6.Value = r.Next(0, 20);
                        EmpezarDeNuevo();
                    }
                }

                else if (numericUpDown2.Value > numericUpDown1.Value)
                {
                    if (cont > 0 && cont < 41)
                    {
                        CambiarVerdes(pictureBox2, pictureBox3);
                        pictureBox6.Location = new Point(x2 -= 8, y2);
                        pictureBox5.Location = new Point(x += 8, y);
                        CambiarRojos(pictureBox1, pictureBox4);
                    }
                    else if (cont > 40 && cont < 46)
                    {
                        CambiarAmbars(pictureBox2, pictureBox3);
                        pictureBox6.Location = new Point(x2 -= 15, y2);
                        pictureBox5.Location = new Point(x += 15, y);
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
                        pictureBox7.Location = new Point(x3, y3 -= 14);
                        pictureBox8.Location = new Point(x4, y4 += 14);
                        CambiarRojos(pictureBox2, pictureBox3);
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
                        numericUpDown3.Value = r.Next(0, 20);
                        numericUpDown4.Value = r.Next(0, 20);
                        numericUpDown5.Value = r.Next(0, 20);
                        numericUpDown6.Value = r.Next(0, 20);
                        EmpezarDeNuevo();
                    }
                }

                else if (numericUpDown1.Value == numericUpDown2.Value)
                {
                    if (cont > 0 && cont < 41)
                    {
                        CambiarVerdes(pictureBox1, pictureBox4);
                        pictureBox7.Location = new Point(x3, y3 -= 8);
                        pictureBox8.Location = new Point(x4, y4 += 8);
                        CambiarRojos(pictureBox2, pictureBox3);
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
                        numericUpDown3.Value = r.Next(0, 20);
                        numericUpDown4.Value = r.Next(0, 20);
                        numericUpDown5.Value = r.Next(0, 20);
                        numericUpDown6.Value = r.Next(0, 20);
                        EmpezarDeNuevo();
                    }
                }

                else if (numericUpDown1.Value == 0 && numericUpDown2.Value > 0)
                {
                    if (cont > 0 && cont < 41)
                    {
                        CambiarVerdes(pictureBox2, pictureBox3);
                        pictureBox5.Visible = true;
                        pictureBox6.Location = new Point(x2 -= 8, y2);
                        pictureBox5.Location = new Point(x += 8, y);
                        CambiarRojos(pictureBox1, pictureBox4);
                    }
                    else if (cont > 40 && cont < 46)
                    {
                        CambiarAmbars(pictureBox2, pictureBox3);
                        pictureBox6.Location = new Point(x2 -= 15, y2);
                        pictureBox5.Location = new Point(x += 15, y);
                    }
                    else if (cont > 45 && cont < 51)
                    {
                        CambiarRojos(pictureBox2, pictureBox3);
                        pictureBox6.Location = new Point(x2 -= 30, y2);
                        pictureBox5.Location = new Point(x += 30, y);
                    }
                    else if (cont > 49 && cont < 91)
                    {
                        CambiarVerdes(pictureBox2, pictureBox3);
                        pictureBox5.Location = new Point(-112, 223);
                        pictureBox6.Location = new Point(418, 155);
                        x = pictureBox5.Location.X;
                        y = pictureBox5.Location.Y;
                        x2 = pictureBox6.Location.X;
                        y2 = pictureBox6.Location.Y;
                        pictureBox5.Visible = true;
                        pictureBox6.Location = new Point(x2 -= 8, y2);
                        pictureBox5.Location = new Point(x += 8, y);
                        CambiarRojos(pictureBox1, pictureBox4);
                    }
                    else if (cont > 90 && cont < 96)
                    {
                        CambiarAmbars(pictureBox2, pictureBox3);
                        pictureBox6.Location = new Point(x2 -= 15, y2);
                        pictureBox5.Location = new Point(x += 15, y);
                    }
                    else if (cont > 95 && cont < 100)
                    {
                        CambiarRojos(pictureBox2, pictureBox3);
                        pictureBox6.Location = new Point(x2 -= 30, y2);
                        pictureBox5.Location = new Point(x += 30, y);
                    }
                    else if (cont == 100)
                    {
                        numericUpDown3.Value = r.Next(0, 20);
                        numericUpDown4.Value = r.Next(0, 20);
                        numericUpDown5.Value = r.Next(0, 20);
                        numericUpDown6.Value = r.Next(0, 20);
                        EmpezarDeNuevo();
                    }
                }

                else if (numericUpDown2.Value == 0 && numericUpDown1.Value > 0)
                {
                    if (cont > 0 && cont < 41)
                    {
                        CambiarVerdes(pictureBox1, pictureBox4);
                        pictureBox7.Location = new Point(x3, y3 -= 8);
                        pictureBox8.Location = new Point(x4, y4 += 8);
                        CambiarRojos(pictureBox2, pictureBox3);
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
                    else if (cont > 49 && cont < 91)
                    {
                        CambiarVerdes(pictureBox1, pictureBox4);
                        pictureBox7.Location = new Point(210, 351);
                        pictureBox8.Location = new Point(152, -33);
                        pictureBox7.Location = new Point(x3, y3 -= 8);
                        pictureBox8.Location = new Point(x4, y4 += 8);
                        CambiarRojos(pictureBox1, pictureBox4);
                    }
                    else if (cont > 90 && cont < 96)
                    {
                        CambiarAmbars(pictureBox1, pictureBox4);
                        pictureBox7.Location = new Point(x3, y3 -= 15);
                        pictureBox8.Location = new Point(x4, y4 += 15);
                    }
                    else if (cont > 95 && cont < 100)
                    {
                        CambiarRojos(pictureBox1, pictureBox4);
                        pictureBox7.Location = new Point(x3, y3 -= 20);
                        pictureBox8.Location = new Point(x4, y4 += 20);
                    }
                    else if (cont == 100)
                    {
                        numericUpDown3.Value = r.Next(0, 20);
                        numericUpDown4.Value = r.Next(0, 20);
                        numericUpDown5.Value = r.Next(0, 20);
                        numericUpDown6.Value = r.Next(0, 20);
                        EmpezarDeNuevo();
                    }

                }
                cont++;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            modoaveria = false;
            modointeligente = false;
            modopreferente = false;
            CambiarApagado(pictureBox1);
            CambiarApagado(pictureBox2);
            CambiarApagado(pictureBox3);
            CambiarApagado(pictureBox4);
            modonormal = true;
            timer1.Start();
            EmpezarDeNuevo();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            modoaveria = false;
            modointeligente = false;
            modonormal = false;
            CambiarApagado(pictureBox1);
            CambiarApagado(pictureBox2);
            CambiarApagado(pictureBox3);
            CambiarApagado(pictureBox4);
            modopreferente = true;
            timer1.Start();
            EmpezarDeNuevo();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            modoaveria = false;
            modonormal = false;
            modopreferente = false;
            CambiarApagado(pictureBox1);
            CambiarApagado(pictureBox2);
            CambiarApagado(pictureBox3);
            CambiarApagado(pictureBox4);
            modointeligente = true;
            numericUpDown3.Value = r.Next(0, 20);
            numericUpDown4.Value = r.Next(0, 20);
            numericUpDown5.Value = r.Next(0, 20);
            numericUpDown6.Value = r.Next(0, 20);
            timer1.Start();
            EmpezarDeNuevo();
        }

        private void EmpezarDeNuevo()
        {
            cont = 0;

            pictureBox5.Location = new Point(-112, 223);
            pictureBox6.Location = new Point(418, 155);
            pictureBox7.Location = new Point(210, 351);
            pictureBox8.Location = new Point(152, -33);

            x = pictureBox5.Location.X;
            y = pictureBox5.Location.Y;
            x2 = pictureBox6.Location.X;
            y2 = pictureBox6.Location.Y;
            x3 = pictureBox7.Location.X;
            y3 = pictureBox7.Location.Y;
            x4 = pictureBox8.Location.X;
            y4 = pictureBox8.Location.Y;

        }

    }
}

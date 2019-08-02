using Final_Seismic.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Seismic
{
    public partial class rip : Form
    {
        public rip()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double[] given1 = new double[] { 0.25, 0.50, 0.75, 1.00, 1.25 };
        double[] A1 = new double[] { 0.80, 0.80, 0.80, 0.80, 0.80 };
        double[] B1 = new double[] { 1.00, 1.00, 1.00, 1.00, 1.00 };
        double[] C1 = new double[] { 1.20, 1.20, 1.10, 1.00, 1.00 };
        double[] D1 = new double[] { 1.60, 1.40, 1.20, 1.10, 1.00 };
        double[] E1 = new double[] { 2.50, 1.70, 1.20, 0.90, 0.90 };

        double[] given2 = new double[] { 0.10, 0.20, 0.30, 0.40, 0.50 };
        double[] A2 = new double[] { 0.80, 0.80, 0.80, 0.80, 0.80 };
        double[] B2 = new double[] { 1.00, 1.00, 1.00, 1.00, 1.00 };
        double[] C2 = new double[] { 1.70, 1.60, 1.50, 1.40, 1.30 };
        double[] D2 = new double[] { 2.40, 2.00, 1.80, 1.60, 1.50 };
        double[] E2 = new double[] { 3.50, 3.20, 2.80, 2.40, 2.40 };

        private void Button1_Click_1(object sender, EventArgs e)
        {
            double Ss1 = (Convert.ToDouble(spectralResponse1.Text)) / 100;
            double Ss2 = (Convert.ToDouble(spectralResponse2.Text)) / 100;
            double Fa1 = 0.0;
            double Fa2 = 0.0;
            double Sms1 = 0.0;
            double Sds1 = 0.0;
            double Sm11 = 0.0;
            double Sd11 = 0.0;
            double PGA1 = 0.0;

            if (siteClass1.Text == "A Hard Rock")
            {
                Fa1 = ((Ss1 - given1[0]) / (given1[1] - given1[0])) * (A1[1] - A1[0]) + A1[0];
                Fa2 = ((Ss2 - given2[0]) / (given2[1] - given2[0])) * (A2[1] - A2[0]) + A2[0];
                Sms1 = Fa1 * Ss1;
                Sds1 = 0.67 * Sms1;
                Sm11 = Fa2 * Ss2;
                Sd11 = 0.67 * Sm11;
                PGA1 = Sms1 * 0.4;

            }
            else if (siteClass1.Text == "B Rock")
            {
                Fa1 = ((Ss1 - given1[0]) / (given1[1] - given1[0])) * (B1[1] - B1[0]) + B1[0];
                Fa2 = ((Ss2 - given2[0]) / (given2[1] - given2[0])) * (B2[1] - B2[0]) + B2[0];
                Sms1 = Fa1 * Ss1;
                Sds1 = 0.67 * Sms1;
                Sm11 = Fa2 * Ss2;
                Sd11 = 0.67 * Sm11;
                PGA1 = Sms1 * 0.4;

            }
            else if (siteClass1.Text == "C Very Desnse Soil and Soft Rock")
            {
                Fa1 = ((Ss1 - given1[0]) / (given1[1] - given1[0])) * (C1[1] - C1[0]) + C1[0];
                Fa2 = ((Ss2 - given2[0]) / (given2[1] - given2[0])) * (C2[1] - C2[0]) + C2[0];
                Sms1 = Fa1 * Ss1;
                Sds1 = 0.67 * Sms1;
                Sm11 = Fa2 * Ss2;
                Sd11 = 0.67 * Sm11;
                PGA1 = Sms1 * 0.4;

            }
            else if (siteClass1.Text == "D Stiff Soil")
            {
                Fa1 = ((Ss1 - given1[0]) / (given1[1] - given1[0])) * (D1[1] - D1[0]) + D1[0];
                Fa2 = ((Ss2 - given2[0]) / (given2[1] - given2[0])) * (D2[1] - D2[0]) + D2[0];
                Sms1 = Fa1 * Ss1;
                Sds1 = 0.67 * Sms1;
                Sm11 = Fa2 * Ss2;
                Sd11 = 0.67 * Sm11;
                PGA1 = Sms1 * 0.4;

            }
            else
            {
                Fa1 = ((Ss1 - given1[0]) / (given1[1] - given1[0])) * (E1[1] - E1[0]) + E1[0];
                Fa2 = ((Ss2 - given2[0]) / (given2[1] - given2[0])) * (E2[1] - E2[0]) + E2[0];
                Sms1 = Fa1 * Ss1;
                Sds1 = 0.67 * Sms1;
                Sm11 = Fa2 * Ss2;
                Sd11 = 0.67 * Sm11;
                PGA1 = Sms1 * 0.4;

            }


            Fa1 = Math.Round(Fa1, 2);
            Fa2 = Math.Round(Fa2, 2);
            Sms1 = Math.Round(Sms1, 2);
            Sds1 = Math.Round(Sds1, 2);
            Sm11 = Math.Round(Sm11, 2);
            Sd11 = Math.Round(Sd11, 2);
            PGA1 = Math.Round(PGA1, 2);

            SC1.Text = Fa1.ToString();
            SC2.Text = Fa2.ToString();
            Sms.Text = Sms1.ToString();
            Sds.Text = Sds1.ToString();
            Sm1.Text = Sm11.ToString();
            Sd1.Text = Sd11.ToString();
            PGA.Text = PGA1.ToString();

            if (PGA1 <= 0.1)
            {
                SQL.Text = "Low";
            }
            else if (PGA1 > 0.5)
            {
                SQL.Text = "High";
            }
            else
            {
                SQL.Text = "Moderate";
            }
        }

        List<Point> MyCircles = new List<Point>();
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            string x = coordinates.X.ToString();
            string y = coordinates.Y.ToString();
            var assembly = Assembly.GetExecutingAssembly();
            var txtPath = Resources.LeftImage;
            String[] line = txtPath.Split('\n');
            char[] TrimChar = { '(', ')' };
            for (int i = 0; i < txtPath.Length; i++)
            {
                string split_line = line[i].Trim(TrimChar);
                string[] split_lines = split_line.Split(',');
                if ((y == split_lines[0]) && (x == split_lines[1]))
                {
                    string z = split_lines[2].TrimEnd('\r');
                    z = z.TrimEnd(')');
                    z = Math.Round(Convert.ToDouble(z), 2).ToString();
                    spectralResponse1.Text = z;
                    break;
                }
            }
            var txtPath2 = Resources.RightImage;
            String[] line2 = txtPath2.Split('\n');
            char[] TrimChar2 = { '(', ')' };
            for (int i = 0; i < txtPath2.Length; i++)
            {
                string split_line = line2[i].Trim(TrimChar2);
                string[] split_lines = split_line.Split(',');
                if ((y == split_lines[0]) && (x == split_lines[1]))
                {
                    string z = split_lines[2].TrimEnd('\r');
                    z = z.TrimEnd(')');
                    z = Math.Round(Convert.ToDouble(z), 2).ToString();
                    spectralResponse2.Text = z;
                    break;
                }
            }
            Graphics g = Graphics.FromImage(pictureBox3.Image);
            Graphics d = Graphics.FromImage(pictureBox4.Image);
            d.Clear(Color.Transparent);
            this.pictureBox4.Image = Resources.SeismicImage1;
            g.Clear(Color.Transparent);
            this.pictureBox3.Image = Resources.SeismicImage2;
            Graphics a = Graphics.FromImage(pictureBox3.Image);
            Graphics b = Graphics.FromImage(pictureBox4.Image);
            Pen p = new Pen(Color.Green, 3);

            var cursorPosition = pictureBox3.PointToClient(Cursor.Position);
            a.DrawEllipse(p, (int)(cursorPosition.X - 7), (int)(cursorPosition.Y - 7), 15, 15);
            b.DrawEllipse(p, (int)(cursorPosition.X - 7), (int)(cursorPosition.Y - 7), 15, 15);

            MyCircles.Add(cursorPosition);
            pictureBox3.Refresh();
            pictureBox4.Refresh();
        }


        private void PictureBox4_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            string x = coordinates.X.ToString();
            string y = coordinates.Y.ToString();
            var assembly = Assembly.GetExecutingAssembly();
            var txtPath = Resources.RightImage;
            String[] line = txtPath.Split('\n');
            char[] TrimChar = { '(', ')' };
            for (int i = 0; i < txtPath.Length; i++)
            {
                string split_line = line[i].Trim(TrimChar);
                string[] split_lines = split_line.Split(',');
                if ((y == split_lines[0]) && (x == split_lines[1]))
                {
                    string z = split_lines[2].TrimEnd('\r');
                    z = z.TrimEnd(')');
                    z = Math.Round(Convert.ToDouble(z), 2).ToString();
                    spectralResponse2.Text = z;
                    break;
                }
            }
            var txtPath2 = Resources.LeftImage;
            String[] line2 = txtPath2.Split('\n');
            char[] TrimChar2 = { '(', ')' };
            for (int i = 0; i < txtPath2.Length; i++)
            {
                string split_line = line2[i].Trim(TrimChar2);
                string[] split_lines = split_line.Split(',');
                if ((y == split_lines[0]) && (x == split_lines[1]))
                {
                    string z = split_lines[2].TrimEnd('\r');
                    z = z.TrimEnd(')');
                    z = Math.Round(Convert.ToDouble(z), 2).ToString();
                    spectralResponse1.Text = z;
                    break;
                }
            }
            Graphics g = Graphics.FromImage(pictureBox4.Image);
            Graphics d = Graphics.FromImage(pictureBox3.Image);
            g.Clear(Color.Transparent);
            this.pictureBox4.Image = Resources.SeismicImage1;
            d.Clear(Color.Transparent);
            this.pictureBox3.Image = Resources.SeismicImage2;
            Graphics a = Graphics.FromImage(pictureBox4.Image);
            Graphics b = Graphics.FromImage(pictureBox3.Image);
            Pen p = new Pen(Color.Green, 3);

            var cursorPosition = pictureBox4.PointToClient(Cursor.Position);
            a.DrawEllipse(p, (int)(cursorPosition.X - 7), (int)(cursorPosition.Y - 7), 15, 15);
            b.DrawEllipse(p, (int)(cursorPosition.X - 7), (int)(cursorPosition.Y - 7), 15, 15);

            MyCircles.Add(cursorPosition);
            pictureBox4.Refresh();
            pictureBox3.Refresh();
        }
    }
}

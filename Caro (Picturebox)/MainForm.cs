using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

 

namespace Caro__Picturebox_
{
    public partial class MainForm : Form
    {
        TableLayoutPanel table = new TableLayoutPanel();
        int so = 6;
        int turn = 0;
        int ID1 = -1;
        int ID2 = -1;
        int[] id;
        int cellsize = 100;
        int time = 0;
        int minute = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        void ganidvaohinh()
        {
            id = new int[so * so];
            for (int i = 0; i < so * so; i++)
            {
                id[i] = 0;
            }
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            table.ColumnCount = so;
            table.RowCount = so;
            if (so == 12)
            {
                cellsize = 49;
            }
            if (so == 6)
            {
                cellsize = 100;
            }
            table.Dock = DockStyle.Fill;
            for (int i = 0; i < so*so; i++)
            {
                PictureBox pict = new PictureBox();
                pict.Name = i.ToString();
                if (so == 24)
                {
                    pict.Image = Image.FromFile("HTH12.jpg");
                    pict.Margin = new Padding(1, 1, 1, 1);
                    pict.Width = cellsize;
                    pict.Height = cellsize;
                    pict.Click += PictureBox_Click;
                    table.Controls.Add(pict);
                }
                if (so == 12)
                {
                    pict.Image = Image.FromFile("HTH12.jpg");
                    pict.Margin = new Padding(1, 1, 1, 1);
                    pict.Width = cellsize;
                    pict.Height = cellsize;
                    pict.Click += PictureBox_Click;
                    table.Controls.Add(pict);
                }
                if (so == 6)
                {
                    pict.Image = Image.FromFile("HTH.jpg");
                    pict.Margin = new Padding(1, 1, 1, 1);
                    pict.Width = cellsize;
                    pict.Height = cellsize;
                    pict.Click += PictureBox_Click;
                    table.Controls.Add(pict);
                }
            }
                this.Controls.Add(table);
                ganidvaohinh();
        }
        private void reDraw()
        {
            if (so == 12)
            {
                cellsize = 49;
            }
            if (so == 6)
            {
                cellsize = 100;
            }
            turn = 0;
            time = 0;
            minute = 0;
            label5.Text = time.ToString();
            label6.Text = minute.ToString();
            DoubleBuffered = true;
            table.Controls.Clear();
            table.ColumnCount = so;
            table.RowCount = so;
            table.Dock = DockStyle.Fill;
            for (int i = 0; i < so * so; i++)
            {
                PictureBox pict = new PictureBox();
                pict.Name = i.ToString();
                if (so == 12)
                {
                    pict.Image = Image.FromFile("HTH12.jpg");
                    pict.Margin = new Padding(1, 1, 1, 1);
                    pict.Width = cellsize;
                    pict.Height = cellsize;
                    pict.Click += PictureBox_Click;
                    table.Controls.Add(pict);
                }
                if (so == 6)
                {
                    pict.Image = Image.FromFile("HTH.jpg");
                    pict.Margin = new Padding(1, 1, 1, 1);
                    pict.Width = cellsize;
                    pict.Height = cellsize;
                    pict.Click += PictureBox_Click;
                    table.Controls.Add(pict);
                }
            }
            this.Controls.Add(table);
            ganidvaohinh();
        }
        private void reDraw2()
        {
            time = 0;
            minute = 0;
            if (so == 12)
            {
                cellsize = 49;
            }
            if (so == 6)
            {
                cellsize = 100;
            }
            turn = 0;
            DoubleBuffered = true;
            table.Controls.Clear();
            table.ColumnCount = so;
            table.RowCount = so;
            table.Dock = DockStyle.Fill;
            for (int i = 0; i < so * so; i++)
            {
                PictureBox pict = new PictureBox();
                pict.Name = i.ToString();
                if (so == 12)
                {
                    if (id[i] == 3)
                    {
                        pict.Image = Image.FromFile("redwin12.jpg");
                    }
                   /* if (id[i] == 1)
                    {
                        pict.Image = Image.FromFile("red12.jpg");
                    }
                    if (id[i] == 2)
                    {
                        pict.Image = Image.FromFile("blue12.jpg");
                    }*/
                    //if (id[i] == 0) 
                    else
                    {
                       pict.Image = Image.FromFile("HTH12.jpg");
                    }
                    pict.Margin = new Padding(1, 1, 1, 1);
                    pict.Width = cellsize;
                    pict.Height = cellsize;
                    pict.Click += PictureBox_Click;
                    table.Controls.Add(pict);
                }
                if (so == 6)
                {
                    if (id[i] == 3)
                    {
                        pict.Image = Image.FromFile("redwin.jpg");
                    }
                   /* if (id[i] == 1)
                    {
                        pict.Image = Image.FromFile("red.jpg");
                    }
                    if (id[i] == 2)
                    {
                        pict.Image = Image.FromFile("blue.jpg");
                    }*/
                    //if (id[i] == 0)
                    else
                    {
                        pict.Image = Image.FromFile("HTH.jpg");
                    }
                    pict.Margin = new Padding(1, 1, 1, 1);
                    pict.Width = cellsize;
                    pict.Height = cellsize;
                    pict.Click += PictureBox_Click;
                    table.Controls.Add(pict);
                }
            }
            this.Controls.Add(table);
        }
        private void reDraw3()
        {
            time = 0;
            minute = 0;
            if (so == 24)
            {
                cellsize = 29;
            }
            if (so == 12)
            {
                cellsize = 49;
            }
            if (so == 6)
            {
                cellsize = 100;
            }
            turn = 0;
            DoubleBuffered = true;
            table.Controls.Clear();
            table.ColumnCount = so;
            table.RowCount = so;
            table.Dock = DockStyle.Fill;
            for (int i = 0; i < so * so; i++)
            {
                PictureBox pict = new PictureBox();
                pict.Name = i.ToString();
                if (so == 12)
                {
                    if (id[i] == 4)
                    {
                        pict.Image = Image.FromFile("bluewin12.jpg");
                    }
                    /*if (id[i] == 1)
                    {
                        pict.Image = Image.FromFile("red12.jpg");
                    }
                    if (id[i] == 2)
                    {
                        pict.Image = Image.FromFile("blue12.jpg");
                    }*/
                    //if (id[i] == 0)
                    else
                    {
                        pict.Image = Image.FromFile("HTH12.jpg");
                    }
                    pict.Margin = new Padding(1, 1, 1, 1);
                    pict.Width = cellsize;
                    pict.Height = cellsize;
                    pict.Click += PictureBox_Click; //Do may' sin. thui :)) check cai gi ?? :-?
                    table.Controls.Add(pict);
                }
                if (so == 6)
                {
                    if (id[i] == 4)
                    {
                        pict.Image = Image.FromFile("bluewin.jpg");
                    }
                    /*if (id[i] == 1)
                    {
                        pict.Image = Image.FromFile("red.jpg");
                    }
                    if (id[i] == 2)
                    {
                        pict.Image = Image.FromFile("blue.jpg");
                    }*/
                    //if (id[i] == 0)
                    else
                    {
                        pict.Image = Image.FromFile("HTH.jpg");
                    }
                    pict.Margin = new Padding(1, 1, 1, 1);
                    pict.Width = cellsize;
                    pict.Height = cellsize;
                    pict.Click += PictureBox_Click;
                    table.Controls.Add(pict);
                }
            }
            this.Controls.Add(table);
        }
        public void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox photo = (PictureBox)sender;
                if (turn % 2 == 0)
                {
                    ID1 = Int32.Parse(photo.Name);
                    if (so == 12)
                    {
                        photo.Image = Image.FromFile("red12.jpg");
                    }
                    if (so == 6)
                    {
                        photo.Image = Image.FromFile("red.jpg");
                    }
                    for (int i = 0; i < so * so; i++)
                    {
                        if (Convert.ToInt32(photo.Name) == i)
                        {
                            id[i] = 1;
                        }
                    }
                    photo.Click -= PictureBox_Click;
                }
                else 
                {
                    ID2 = Int32.Parse(photo.Name);
                    if (so == 12)
                    {
                        photo.Image = Image.FromFile("blue12.jpg");
                    }
                    if (so == 6)
                    {
                        photo.Image = Image.FromFile("blue.jpg");
                    }
                    for (int i = 0; i < so * so; i++)
                    {
                        if (Convert.ToInt32(photo.Name) == i)
                        {
                            id[i] = 2;
                        }
                    }
                    photo.Click -= PictureBox_Click;
                }
                turn++;
                if (turn == so * so)
                {
                    MessageBox.Show("Draw =_=", "HTH");
                    reDraw();
                }
                Delay.Enabled = true;
                Delay.Start();
                timeplay.Enabled = true;
                Delay.Start();
        }

        private void Delay_Tick(object sender, EventArgs e)
        {
            Delay.Stop();
            if (so == 12)
            {
                for (int i = 0; i < so * so; i++)
                {
                    try
                    {
                        int ix = i % so;
                        if ((ix + 1) >= 0 && (ix + 1) < so && (ix + 2) >= 0 && (ix + 2) < so && (ix + 3) >= 0 && (ix + 3) < so && (ix + 4) >= 0 && (ix + 4) < so)
                        {
                            if (id[i] == id[i + 1] && id[i + 1] == id[i + 2] && id[i + 2] == id[i + 3] && id[i + 3] == id[i + 4] && id[i] != 0)
                            {
                                if (id[i] == 1)
                                {
                                    timeplay.Stop();
                                    id[i] = 3;
                                    id[i + 1] = 3;
                                    id[i + 2] = 3;
                                    id[i + 3] = 3;
                                    id[i + 4] = 3;
                                    reDraw2();
                                    MessageBox.Show("RED Win ^^!" + "\n" + "In just " + label6.Text + " : " + label5.Text + " s", "HTH");
                                    reDraw();
                                }
                                else
                                {
                                    timeplay.Stop();
                                    id[i] = 4;
                                    id[i + 1] = 4;
                                    id[i + 2] = 4;
                                    id[i + 3] = 4;
                                    id[i + 4] = 4;
                                    reDraw3();
                                    MessageBox.Show("BLUE Win ^^!" + "\n" + "In just " + label6.Text + " : " + label5.Text + " s", "HTH");
                                    reDraw();
                                }
                            }
                        }
                        if (id[i] == id[i + so] && id[i + so] == id[i + 2 * so] && id[i + 2 * so] == id[i + 3 * so] && id[i + 3 * so] == id[i + 4 * so] && id[i] != 0)
                        {
                            if (id[i] == 1)
                            {
                                timeplay.Stop();
                                id[i] = 3;
                                id[i + so] = 3;
                                id[i + 2*so] = 3;
                                id[i + 3*so] = 3;
                                id[i + 4*so] = 3;
                                reDraw2();
                                MessageBox.Show("RED Win ^^!" + "\n" + "In just " + label6.Text + " : " + label5.Text + " s", "HTH");
                                reDraw();
                            }
                            else
                            {
                                timeplay.Stop();
                                id[i] = 4;
                                id[i + so] = 4;
                                id[i + 2 * so] = 4;
                                id[i + 3 * so] = 4;
                                id[i + 4 * so] = 4;
                                reDraw3();
                                MessageBox.Show("BLUE Win ^^!" + "\n" + "In just " + label6.Text + " : " + label5.Text + " s", "HTH");
                                reDraw();
                            }
                        }
                        if ((ix + 1) >= 0 && (ix + 1) < so && (ix + 2) >= 0 && (ix + 2) < so && (ix + 3) >= 0 && (ix + 3) < so && (ix + 4) >= 0 && (ix + 4) < so)
                        {

                            if (id[i] == id[i + so + 1] && id[i + so + 1] == id[i + 2 * so + 2] && id[i + 2 * so + 2] == id[i + 3 * so + 3] && id[i + 3 * so + 3] == id[i + 4 * so + 4] && id[i] != 0)
                            {
                                if (id[i] == 1)
                                {
                                    timeplay.Stop();
                                    id[i] = 3;
                                    id[i + so + 1] = 3;
                                    id[i + 2 * so + 2] = 3;
                                    id[i + 3 * so + 3] = 3;
                                    id[i + 4 * so + 4] = 3;
                                    reDraw2();
                                    MessageBox.Show("RED Win ^^!" + "\n" + "In just " + label6.Text + " : " + label5.Text + " s", "HTH");
                                    reDraw();
                                }
                                else
                                {
                                    timeplay.Stop();
                                    id[i] = 4;
                                    id[i + so + 1] = 4;
                                    id[i + 2 * so + 2] = 4;
                                    id[i + 3 * so + 3] = 4;
                                    id[i + 4 * so + 4] = 4;
                                    reDraw3();
                                    MessageBox.Show("BLUE Win ^^!" + "\n" + "In just " + label6.Text + " : " + label5.Text + " s", "HTH");
                                    reDraw();
                                }
                            }
                        }
                        if (id[i] == id[i + so - 1] && id[i + so - 1] == id[i + 2 * so - 2] && id[i + 2 * so - 2] == id[i + 3 * so - 3] && id[i + 3 * so - 3] == id[i + 4 * so - 4] && id[i] != 0)
                        {
                            if (id[i] == 1)
                            {
                                timeplay.Stop();
                                id[i] = 3;
                                id[i + so - 1] = 3;
                                id[i + 2 * so - 2] = 3;
                                id[i + 3 * so - 3] = 3;
                                id[i + 4 * so - 4] = 3;
                                reDraw2();
                                MessageBox.Show("RED Win ^^!" + "\n" + "In just " + label6.Text + " : " + label5.Text + " s", "HTH");
                                reDraw();
                            }
                            else
                            {
                                timeplay.Stop();
                                id[i] = 4;
                                id[i + so - 1] = 4;
                                id[i + 2 * so - 2] = 4;
                                id[i + 3 * so - 3] = 4;
                                id[i + 4 * so - 4] = 4;
                                reDraw3();
                                MessageBox.Show("BLUE Win ^^!" + "\n" + "In just " + label6.Text + " : " + label5.Text + " s", "HTH");
                                reDraw();
                            }
                        }
                    }
                    //}
                    catch { };
                }
            }
            if (so == 6)
            {
                for (int i = 0; i < so * so; i++)
                {
                    try
                    {
                        int ix = i % so;
                        if ((ix + 1) >= 0 && (ix + 1) < so && (ix + 2) >= 0 && (ix + 2) < so)
                        {
                            if (id[i] == id[i + 1] && id[i + 1] == id[i + 2] && id[i] != 0)
                            {
                                if (id[i] == 1)
                                {
                                    timeplay.Stop();
                                    id[i] = 3;
                                    id[i + 1] = 3;
                                    id[i + 2] = 3;
                                    reDraw2();
                                    MessageBox.Show("RED Win ^^!" + "\n" + "In just " + label6.Text + " : " + label5.Text + " s", "HTH");
                                    reDraw();
                                }
                                else
                                {
                                    timeplay.Stop();
                                    id[i] = 4;
                                    id[i + 1] = 4;
                                    id[i + 2] = 4;
                                    reDraw3();
                                    MessageBox.Show("BLUE Win ^^!" + "\n" + "In just " + label6.Text + " : " + label5.Text + " s", "HTH");
                                    reDraw();
                                }
                            }
                        }
                        if (id[i] == id[i + so] && id[i + so] == id[i + 2 * so] && id[i] != 0)
                        {
                            if (id[i] == 1)
                            {
                                timeplay.Stop();
                                id[i] = 3;
                                id[i + so] = 3;
                                id[i + 2 * so] = 3;
                                reDraw2();
                                MessageBox.Show("RED Win ^^!" + "\n" + "In just " + label6.Text + " : " + label5.Text + " s", "HTH");
                                reDraw();
                            }
                            else
                            {
                                timeplay.Stop();
                                id[i] = 4;
                                id[i + so] = 4;
                                id[i + 2 * so] = 4;
                                reDraw3();
                                MessageBox.Show("BLUE Win ^^!" + "\n" + "In just " + label6.Text + " : " + label5.Text + " s", "HTH");
                                reDraw();
                            }
                        }
                        if ((ix + 1) >= 0 && (ix + 1) < so && (ix + 2) >= 0 && (ix + 2) < so)
                        {
                            if (id[i] == id[i + so + 1] && id[i + so + 1] == id[i + 2 * so + 2] && id[i] != 0)
                            {
                                if (id[i] == 1)
                                {
                                    timeplay.Stop();
                                    id[i] = 3;
                                    id[i + so + 1] = 3;
                                    id[i + 2 * so + 2] = 3;
                                    reDraw2();
                                    MessageBox.Show("RED Win ^^!" + "\n" + "In just " + label6.Text + " : " + label5.Text + " s", "HTH");
                                    reDraw();
                                }
                                else
                                {
                                    timeplay.Stop();
                                    id[i] = 4;
                                    id[i + so + 1] = 4;
                                    id[i + 2 * so + 2] = 4;
                                    reDraw3();
                                    MessageBox.Show("BLUE Win ^^!" + "\n" + "In just " + label6.Text + " : " + label5.Text + " s", "HTH");
                                    reDraw();
                                }
                            }
                        }
                        if ((ix + 1) >= 0 && (ix + 1) < so && (ix + 2) >= 0 && (ix + 2) < so)
                        {
                            if (id[i] == id[i + so - 1] && id[i + so - 1] == id[i + 2 * so - 2] && id[i] != 0)
                            {
                                if (id[i] == 1)
                                {
                                    timeplay.Stop();
                                    id[i] = 3;
                                    id[i + so - 1] = 3;
                                    id[i + 2 * so - 2] = 3;
                                    reDraw2();
                                    MessageBox.Show("RED Win ^^!" + "\n" + "In just " + label6.Text + " : " + label5.Text + " s", "HTH");
                                    reDraw();
                                }
                                else
                                {
                                    timeplay.Stop();
                                    id[i] = 4;
                                    id[i + so - 1] = 4;
                                    id[i + 2 * so - 2] = 4;
                                    reDraw3();
                                    MessageBox.Show("BLUE Win ^^!" + "\n" + "In just " + label6.Text + " : " + label5.Text + " s", "HTH");
                                    reDraw();
                                }
                            }
                        }
                    }
                    // }
                    catch { };
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            reDraw();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            so = 6;
            reDraw();
            MessageBox.Show("3 cell to WIN ^^!", "HTH");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            so = 12;
            reDraw();
            MessageBox.Show("5 cell to WIN ^^!", "HTH");
        }

        private void timeplay_Tick(object sender, EventArgs e)
        {
            time++;
            if (time == 60)
            {
                time = 0;
                minute++;
            }
            label5.Text = time.ToString();
            label6.Text = minute.ToString();
        }
    }
}

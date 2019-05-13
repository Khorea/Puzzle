using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace Puzzle_Frinco_Horea
{
    public partial class puzzleForm : Form
    {
        public puzzleForm()
        {
            InitializeComponent();
        }

        string path = "";
        int nr = 0;

        int x = 0, y = 0;

        bool click = false;
        bool win = false;

        int k = 0, p = 0;
        int t = 0;

        PictureBox[,] pb = new PictureBox[2, 2];
        Image img;
        Image[,] images;

        SqlConnection con;
        SqlCommand cmd;

        string nume = "";

        public void GetName(string nm)
        {
            nume = nm;
        }

        public void GetPath(string str)
        {
            path = str;
        }

        public void GetPatrate(int patrate)
        {
            nr = patrate;
        }

        private void CutImage(string path, int nr)
        {
            img = Image.FromFile(path);

            int startX = 0, startY = 0;
            int width = 0, height = 0;
            width = img.Size.Width;
            height = img.Size.Height;

            if (nr == 4)
            {                           
                images = new Image[2,2];

                for (int i = 0; i < 2; i++)
                {                                 
                    for (int j = 0; j < 2; j++)
                    {
                        images[i, j] = new Bitmap(200, 200);
                        Graphics g = Graphics.FromImage(images[i, j]);

                        g.DrawImage(img, new Rectangle(0, 0, 200, 200), new Rectangle(startX, startY, width / 2, height / 2), GraphicsUnit.Pixel);
                        startX += width / 2;

                        g.Dispose();              
                    }
                    startX = 0;
                    startY += height / 2;
                }
            }
            else
            {
                images = new Image[3, 3];

                for (int i = 0; i < 3; i++)
                {                  
                    for (int j = 0; j < 3; j++)
                    {
                        images[i, j] = new Bitmap(200, 200);
                        Graphics g = Graphics.FromImage(images[i, j]);

                        g.DrawImage(img, new Rectangle(0, 0, 200, 200), new Rectangle(startX, startY, width / 3, height / 3), GraphicsUnit.Pixel);
                        startX += width / 3;

                        g.Dispose();
                    }
                    startX = 0;
                    startY += height / 3;
                }
            }           
        }


        private void puzzleForm_Load(object sender, EventArgs e)
        {
            CutImage(path, nr);

            if(nr == 4)
            {
                this.ClientSize = new Size(400, 400);

                pb = new PictureBox[2, 2];

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        pb[i, j] = new PictureBox();
                        pb[i, j].Size = new Size(200, 200);
                        pb[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                        pb[i, j].Name = i.ToString() + j.ToString() + "PictureBox";
                        pb[i, j].Image = images[i, j];
                        pb[i, j].Location = new Point(x, y);                    
                        pb[i, j].Click += new EventHandler(Button_Click);

                        x = x + 200;

                        panel1.Controls.Add(pb[i, j]);
                    }

                    x = 0;
                    y += 200;
                }
            }
            else
            {
                this.ClientSize = new Size(600, 600);

                pb = new PictureBox[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        pb[i, j] = new PictureBox();
                        pb[i, j].Size = new Size(200, 200);
                        pb[i, j].SizeMode = PictureBoxSizeMode.StretchImage;;
                        pb[i, j].Name = i.ToString() + j.ToString() + "PictureBox";
                        pb[i, j].Image = images[i, j];
                        pb[i, j].Location = new Point(x, y);
                        pb[i, j].Size = new Size(200, 200);
                        pb[i, j].Click += new EventHandler(Button_Click);

                        x = x + 200;

                        panel1.Controls.Add(pb[i, j]);
                    }

                    x = 0;
                    y += 200;
                }
            }

            Randomize();
        }

        private void Randomize()
        {
            Random r = new Random();

            if(nr==4)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        int w = r.Next(0, 2);
                        int q = r.Next(0, 2);

                        Image aux = pb[w, q].Image;
                        pb[w, q].Image = pb[i, j].Image;
                        pb[i, j].Image = aux;

                    }                 
                }

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (images[i, j] != pb[i, j].Image)
                        {
                            win = false;
                        }
                    }
                }

                if (win) Randomize();
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int w = r.Next(0, 3);
                        int q = r.Next(0, 3);

                        Image aux = pb[w, q].Image;
                        pb[w, q].Image = pb[i, j].Image;
                        pb[i, j].Image = aux;
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (images[i, j] != pb[i, j].Image)
                        {
                            win = false;
                        }
                    }
                }

                if (win) Randomize();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;
        }

        private void Verify()
        {
            win = true;

            if(nr==4)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if(images[i,j] != pb[i,j].Image)
                        {
                            win = false;
                        }
                    }
                }

                if(win)
                {
                    timer1.Stop();

                    TimeSpan time = TimeSpan.FromSeconds(t);

                    MessageBox.Show("Felicitari, ai castigat", "Victorie!");

                    using (con = new SqlConnection(Services.connectionString))
                    {
                        con.Open();

                        string sqlInsert = "INSERT INTO Clasament VALUES (@nume, @timp, @nr)";

                        cmd = new SqlCommand(sqlInsert, con);
                        cmd.Parameters.AddWithValue("@nume", nume);
                        cmd.Parameters.AddWithValue("@timp", time);
                        cmd.Parameters.AddWithValue("@nr", nr);

                        cmd.ExecuteNonQuery();
                    }

                    if (MessageBox.Show("Mai joci?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Application.OpenForms["inputForm"].Show();
                        this.Close();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (images[i, j] != pb[i, j].Image)
                        {
                            win = false;
                        }
                    }
                }

                if (win)
                {
                    timer1.Stop();

                    TimeSpan time = TimeSpan.FromSeconds(t);

                    MessageBox.Show("Felicitari, ai castigat", "Victorie!");

                    using (con = new SqlConnection(Services.connectionString))
                    {
                        con.Open();

                        string sqlInsert = @"INSERT INTO Clasament VALUES (@nume, @timp, @nr)";

                        cmd = new SqlCommand(sqlInsert, con);
                        cmd.Parameters.AddWithValue("@nume", nume);
                        cmd.Parameters.AddWithValue("@timp", time);
                        cmd.Parameters.AddWithValue("@nr", nr);
                        
                        cmd.ExecuteNonQuery();
                    }

                    if (MessageBox.Show("Mai joci?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Application.OpenForms["inputForm"].Show();
                        this.Close();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }                                     
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled) timer1.Start();

            PictureBox pb1 = (PictureBox)sender;

            int i = Convert.ToInt32(pb1.Name.Remove(1));
            int j = Convert.ToInt32(pb1.Name.Remove(2)) % 10;

            if(click)
            {
                click = false;
                Image aux = pb[i, j].Image;
                pb[i, j].Image = pb[p, k].Image;
                pb[p, k].Image = aux;
                Verify();
            }
            else
            {
                click = true;
                p = i;
                k = j;
            }
        }
    }
}

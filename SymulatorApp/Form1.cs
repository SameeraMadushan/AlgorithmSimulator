using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SymulatorApp
{
    public partial class Symulator : Form
    {
        Button[] toggleButton = new Button[10];         //create button array for animate sorting process
        TextBox[] inputNumber = new TextBox[10];        //create textbox array for input 10 numbers 


        int xCordinatesTxt, yCordinatesTxt;                     //x and y cordinates for first textbox
        int xCordinatesBtn = 20, yCordinatesBtn = 108;        //x and y cordinates for first toggle button

        int k = 0;
        int n = 0;
        int p = 0;
        int j = 1;
        int d = 0;
        int length;
 
        public Symulator()
        {
            InitializeComponent();
            insertionPanel.Visible = false;
            quicksortPanel.Visible = false;
        }
               
//---------------------------------------------------------------------initialy load form with input text boxes--------------
        private void Symulator_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 9; i++)
            {
                inputNumber[i] = new TextBox();                                         //create textbox object
                inputNumber[i].Location = new Point(xCordinatesTxt, yCordinatesTxt);    //initialize position of textbox
                inputNumber[i].Width = 50;                                              //initialize width of the textbox
                xCordinatesTxt = xCordinatesTxt + 60;                                   //initialize gap between next textbox    
                textboxPanel.Controls.Add(inputNumber[i]);                              //add text box to the panel 
                inputNumber[i].Visible = true;                                          //set visibility true in the panel
            }
        }
        //-------------------------------------------------------insertion sort-------------------------------------
        private void insertion_Click(object sender, EventArgs e)
        {

            mainPanel.Refresh();

            k = 1;
            n = 1;
            j = 0;

            try
            {
                for (int i = 1; i < 10; i++)
                {
                    int chk = Convert.ToInt32(inputNumber[i].Text);
                }
            }
            catch
            {
                MessageBox.Show("Please Fill All the Fields!!","Input Error!");
            }

            for (int i = 0; i <= 9; i++)
            {
                toggleButton[i] = new Button();
                toggleButton[i].Text = inputNumber[i].Text;
                toggleButton[i].Location = new Point(xCordinatesBtn, yCordinatesBtn);
                toggleButton[i].Width = 50;
                toggleButton[i].Height = 60;
                toggleButton[i].BackColor = Color.White;
                xCordinatesBtn = xCordinatesBtn + 60;
                toggleButton[i].Visible = true;

            }
            xCordinatesBtn = 20;
            //timer3.Start();
        }
        //------------------------------------------------------------selection sort-----------------------------------
        private void selection_Click(object sender, EventArgs e)
        {
            mainPanel.Refresh();

            k = 0;
            n = 0;
            p = 0;

            try
            {
                for (int i = 1; i < 10; i++)
                {
                    int chk = Convert.ToInt32(inputNumber[i].Text);
                }
            }
            catch
            {
                MessageBox.Show("Please Fill All the Fields!!","Input Error!");
            }

            for (int i = 0; i <= 9; i++)
            {
                toggleButton[i] = new Button();
                toggleButton[i].Text = inputNumber[i].Text;
                toggleButton[i].Location = new Point(xCordinatesBtn, yCordinatesBtn);
                toggleButton[i].Width = 50;
                toggleButton[i].Height = 60;
                toggleButton[i].BackColor = Color.Violet;
                xCordinatesBtn = xCordinatesBtn + 60;
                toggleButton[i].Visible = true;

            }
            xCordinatesBtn = 20;
            timer1.Start();
        }
        //----------------------------------------------------------timer 01--------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (k == n)
            {
                toggleButton[k].BackColor = Color.Yellow;
                k++;
            }
            else if (k <= 4)
            {
                toggleButton[k - 1].BackColor = Color.White;
                toggleButton[k].BackColor = Color.Yellow;
                k++;
            }
            else if (k == 5)
            {
                toggleButton[k - 1].BackColor = Color.White;
                toggleButton[minIndex()].BackColor = Color.Red;
                k++;
            }
            else if (n == 6)
            {
                timer1.Stop();
            }
            else
            {
                k = 0;
                timer1.Stop();
                timer2.Start();

            } 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            int aa, bb, cc, dd;
            if (d == 0)
            {
                length = toggleButton[minIndex()].Location.X - toggleButton[p].Location.X;
            }
            if (d < 100)
            {
                aa = toggleButton[minIndex()].Location.X;
                bb = toggleButton[minIndex()].Location.Y;
                cc = toggleButton[p].Location.X;
                dd = toggleButton[p].Location.Y;

                if (length == 0)
                {
                    Point qqq = new Point(cc, dd - 1);
                    toggleButton[p].Location = qqq;
                }
                else
                {
                    Point pp = new Point(aa, bb - 1);
                    toggleButton[minIndex()].Location = pp;

                    Point qq = new Point(cc, dd + 1);
                    toggleButton[p].Location = qq;
                }

                d++;
            }
            else if (d < length + 100)
            {
                aa = toggleButton[minIndex()].Location.X;
                bb = toggleButton[minIndex()].Location.Y;
                cc = toggleButton[p].Location.X;
                dd = toggleButton[p].Location.Y;

                if (length == 0)
                {

                }
                else
                {
                    Point pp = new Point(aa - 1, bb);
                    toggleButton[minIndex()].Location = pp;

                    Point qq = new Point(cc + 1, dd);
                    toggleButton[p].Location = qq;
                }


                d++;
            }
            else if (d < length + 200)
            {
                aa = toggleButton[minIndex()].Location.X;
                bb = toggleButton[minIndex()].Location.Y;



                cc = toggleButton[p].Location.X;
                dd = toggleButton[p].Location.Y;

                if (length == 0)
                {
                    Point qqq = new Point(cc, dd + 1);
                    toggleButton[p].Location = qqq;
                }
                else
                {
                    Point pp = new Point(aa, bb + 1);
                    toggleButton[minIndex()].Location = pp;

                    Point qq = new Point(cc, dd - 1);
                    toggleButton[p].Location = qq;
                }


                d++;
            }
            else
            {
                d = 0;
                Button temp = toggleButton[minIndex()];
                toggleButton[minIndex()] = toggleButton[p];
                toggleButton[p] = temp;
                n++;
                k = n;
                p++;
                timer2.Stop();
                toggleButton[p - 1].BackColor = Color.CornflowerBlue;

                if (k == 5)
                {
                    button1.Enabled = true;
                    MessageBox.Show("Sorting is Completed !!","Successfull");
                }
                else
                {
                    timer1.Start();
                }
            }
        }

         public int minIndex()
        {
            int min = n;

            for (int j = n; j < 10; j++)
            {
                for (int i = j + 1; i < 10; i++)
                {
                    if (Convert.ToInt32(toggleButton[i].Text) < Convert.ToInt32(toggleButton[min].Text))
                        min = i;
                }
            }
            return min;
         }
        

    }

}

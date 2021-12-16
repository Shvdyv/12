using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace _12kontrolek_Agnieszka_Filinska
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 8)
            {
                label2.Text = "Dana jest definicja metody: static double f(int b, int a) " +
Environment.NewLine + "{ return a + a * b; } " +
Environment.NewLine + "Co zostanie wypisane na ekranie po wykonaniu instrukcji Console.WriteLine(f(1,3)); ";
                label3.Text = " ";
                progressBar1.Value = 33;
            }

            if (numericUpDown1.Value == 6)
            {
                label2.Text = "static int Rek(int a) { if (a > 0) return 2 * a + Rek(a - 1); else return a; }" +
                Environment.NewLine + "Dana jest powyższa metoda o nazwie Rek.Jaka będzie wartość wyrażenia Rek(5) - 1 ?";
                label3.Text = " ";
                progressBar1.Value = 66;
            }
            if (numericUpDown1.Value == 29)
            {
                label2.Text = "Test zakończony";
                label3.Text = " ";
                progressBar1.Value = 100;
            }


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Convert.ToInt32(numericUpDown1.Value);
            if (numericUpDown1.Value == 8)
            {
                label3.Text = "Dobra odpowiedź. Przejdź dalej.";
            }

            else label3.Text = "Zła odpowiedź. Spróbuj jeszcze raz.";
            if (progressBar1.Value == 33)
            {
                if (numericUpDown1.Value == 6)
                {
                    label3.Text = "Dobra odpowiedź. Przejdź dalej.";
                }

                else label3.Text = "Zła odpowiedź. Spróbuj jeszcze raz.";
            }
            if (progressBar1.Value == 66)
            {
                if (numericUpDown1.Value == 29)
                {
                    label3.Text = "Dobra odpowiedź. Przejdź dalej.";
                }

                else label3.Text = "Zła odpowiedź. Spróbuj jeszcze raz.";
            }
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

       private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.BackColor = colorDialog1.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string odpowiedzi = "Pytanie 1: 8, Pytanie 2: 6, Pytanie 3: 29";
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

             saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
             saveFileDialog1.FilterIndex = 2;
             saveFileDialog1.RestoreDirectory = true;

             if (saveFileDialog1.ShowDialog() == DialogResult.OK)
             {
                 
                 File.WriteAllText(saveFileDialog1.FileName, odpowiedzi);

             }
               

        }


    }   
    
}

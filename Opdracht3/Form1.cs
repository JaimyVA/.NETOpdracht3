using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht3
{
    public partial class Form1 : Form
    {
        Stapel<String> stringList = new Stapel<String>();
        Stapel<int> intList = new Stapel<int>();
        public Form1()
        {
            InitializeComponent();
        }

        //String
        private void btnStringToevoegen_Click(object sender, EventArgs e)
        {
                string inputString = tbString.Text;
                stringList.Toevoegen(inputString);
                listBoxString.Items.Add(inputString);
        }

        private void btnStringVerwijderen_Click(object sender, EventArgs e)
        {
            try
            {
                stringList.Verwijderen();
                listBoxString.Items.RemoveAt(listBoxString.Items.Count - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Er is niets om te verwijderen!", "Error");
            }
        }

        private void btnStringAanwezig_Click(object sender, EventArgs e)
        {
            String inputString = tbString.Text;
            if (stringList.isAanwezig(inputString) == true)
            {
                MessageBox.Show("String " + inputString + " werd gevonden");
            }
            else MessageBox.Show("String " + inputString + " werd niet gevonden");
        }

        private void btnStringLeegmaken_Click(object sender, EventArgs e)
        {
            stringList.Leegmaken();
            listBoxString.DataSource = null;
            listBoxString.Items.Clear();
        }

        private void btnStringCopy_Click(object sender, EventArgs e)
        {
            listBoxCopy.DataSource = null;
            foreach (var item in stringList.myStapel)
            {
                listBoxCopy.Items.Add(item);
            }
        }
        //int
        private void btnIntToevoegen_Click(object sender, EventArgs e)
        {
            try
            {
                int inputInt = Convert.ToInt32(tbInt.Text);
                intList.Toevoegen(inputInt);
                listBoxInt.Items.Add(inputInt);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Dit veld moet een cijfer bevatten", "Error");
            }
        }

        private void btnIntVerwijderen_Click(object sender, EventArgs e)
        {
            intList.Verwijderen();
            if (listBoxInt.Items.Count > 0)
            {
                listBoxInt.Items.RemoveAt(listBoxInt.Items.Count - 1);
            }
        }

        private void btnIntAanwezig_Click(object sender, EventArgs e)
        {
            try
            {
                int inputInt = Convert.ToInt32(tbInt.Text);
                if (intList.isAanwezig(inputInt))
                {
                    MessageBox.Show("Nummer " + inputInt + " is gevonden");
                }
                else
                {
                    MessageBox.Show("Nummer " + inputInt + " is niet gevonden");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Veld mag niet leeg zijn", "Error");
            }
        }

        private void btnIntLeegmaken_Click(object sender, EventArgs e)
        {
            intList.Leegmaken();
            listBoxInt.Items.Clear();
        }

        private void btnIntCopy_Click(object sender, EventArgs e)
        {
            listBoxCopy.DataSource = null;
            foreach (var item in intList.myStapel)
            {
                listBoxCopy.Items.Add(item);
            }
        }

        private void btnToString_Click(object sender, EventArgs e)
        {
            listBoxToString.Items.Add(intList.ToString() + stringList.ToString());
        }
    }
}

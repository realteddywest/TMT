using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMT1.Controllers;

namespace TMT1.Forms
{
    public partial class FormReadTownInfo : Form
    {
        private TMTContext context;
        private ReadController read;
        private List<Town> towns;
        private int i = 0;

        public FormReadTownInfo(TMTContext context, ReadController read)
        {
            InitializeComponent();
            this.context = context;
            this.read = read;
            towns = read.TownsList();
            EnableOrDisable(false);
        }

        private void FormReadTownInfo_Load(object sender, EventArgs e)
        {
            labelCountryName.Text = towns.First().Country.Name;
            labelTownName.Text = towns.First().Name;
        }
        

        //--------------------------BUTTONS------------------------------------


        private void button1_Click(object sender, EventArgs e)
        {
            i--;

            if (i < 0)
            {
                i = towns.Count - 1;
                labelCountryName.Text = towns[i].Country.Name;
                labelTownName.Text = towns[i].Name;
            }

            else
            {
                labelCountryName.Text = towns[i].Country.Name;
                labelTownName.Text = towns[i].Name;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;

            if (i >= towns.Count - 1)
            {
                i = 0;
                labelCountryName.Text = towns[i].Country.Name;
                labelTownName.Text = towns[i].Name;
            }

            else
            {
                labelCountryName.Text = towns[i].Country.Name;
                labelTownName.Text = towns[i].Name;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var find = towns.FirstOrDefault(t => t.Name == textBox1.Text);

            if (find != null)
            {
                labelCountryName.Text = find.Country.Name;
                labelTownName.Text = find.Name;
            }

            else
            {
                labelCountryName.Text = "Not found!";
                labelTownName.Text = "Not found!";
            }
        }


        //----------------------------------------------------------------------


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                EnableOrDisable(true);
            }

            else
            {
                EnableOrDisable(false);
            }
        }

        private void EnableOrDisable(bool trueOrFalse)
        {
            button1.Enabled = !trueOrFalse;
            button2.Enabled = !trueOrFalse;
            button3.Enabled = trueOrFalse;
            textBox1.Enabled = trueOrFalse;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

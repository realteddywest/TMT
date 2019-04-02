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
        private static TMTContext context = new TMTContext();
        private static ReadController read = new ReadController(context);
        private List<Town> towns = read.TownsList();
        int i = 0;

        public FormReadTownInfo()
        {
            InitializeComponent();
            EnableOrDesable(false);
        }

        private void FormReadTownInfo_Load(object sender, EventArgs e)
        {
            labelCountryName.Text = towns.First().Country.Name;
            labelTownName.Text = towns.First().Name;
        }

        //------------------------------Button1 & Button2 & Button3------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            if (i <= 0)
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
            if (i >= towns.Count-1)
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
            if (find!=null)
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


        //------------------------------Checkbox------------------------------

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                EnableOrDesable(true);
            }
            else
            {
                EnableOrDesable(false);
            }
        }


        private void EnableOrDesable(bool trueOrFalse)
        {
            button1.Enabled = !trueOrFalse;
            button2.Enabled = !trueOrFalse;
            button3.Enabled = trueOrFalse;
            textBox1.Enabled = trueOrFalse;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

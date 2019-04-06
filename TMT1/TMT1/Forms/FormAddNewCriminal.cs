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
    public partial class FormAddNewCriminal : Form
    {
        private TMTContext context;
        private InsertController insert;
        private ReadController read;
        private List<Country> countries ;
        private List<Town> towns;

        public FormAddNewCriminal(TMTContext context,InsertController insert,ReadController read)
        {
            InitializeComponent();
            this.context = context;
            this.insert = insert;
            this.read = read;
        }

        private void FormAddNewCriminal_Load(object sender, EventArgs e)
        {
            countries = read.CountriesList();
            towns = read.TownsList();

            foreach (var t in towns)
            {
                comboBox1.Items.Add(t.Name);
            }
            foreach (var c in countries)
            {
                comboBox2.Items.Add(c.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isAdd = insert.InsertIntoCriminals(textBox1.Text, textBox2.Text, comboBox1.Text, comboBox2.Text, labelCrime.Text, labelSentence.Text, labelStatus.Text, labelEvilnessFactor.Text);

            if (isAdd)
            {
                MessageBox.Show("Criminal is added successfully!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = towns.FirstOrDefault(c => c.Name == comboBox1.Text).Country.Name;
            comboBox2.Enabled = false;
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

    }
}

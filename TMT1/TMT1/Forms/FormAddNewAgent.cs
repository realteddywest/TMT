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
    public partial class FormAddNewAgent : Form
    {
        private TMTContext context;
        private InsertController insert;
        private ReadController read;
        private List<Country> countries;
        private List<Town> towns;
        public FormAddNewAgent(TMTContext context, InsertController insert, ReadController read)
        {
            InitializeComponent();
            this.context = context;
            this.insert = insert;
            this.read = read;
        }

        private void FormAddNewAgent_Load(object sender, EventArgs e)
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
            bool isAdd = insert.InsertIntoAgents(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), comboBox1.Text, comboBox2.Text);
            if (isAdd)
            {
                MessageBox.Show("Agent is added!");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = towns.FirstOrDefault(c => c.Name == comboBox1.Text).Country.Name;
            comboBox2.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

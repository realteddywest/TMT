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
    public partial class FormMain : Form
    {
        private TMTContext context;
        private InsertController insert;
        private ReadController read;
        private UpdateController update;
        private DeleteController delete;
        public FormMain(TMTContext context, InsertController insert, ReadController read, UpdateController update, DeleteController delete)
        {
            InitializeComponent();
            this.context = context;
            this.insert = insert;
            this.read = read;
            this.update = update;
            this.delete = delete;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new FormAddNewAgent(context, insert, read);
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new FormReadAgentInfo();
            form.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new FormAddNewCriminal(context, insert, read);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new FormReadTownInfo();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new FormReadCriminalInfo();
            form.Show();
        }
    }
}

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
    public partial class FormReadCriminalInfo : Form
    {
        private  TMTContext context ;
        private  ReadController read ;
        private List<Criminal> criminals;
        private int i = 0;

        public FormReadCriminalInfo(TMTContext context, ReadController read)
        {
            InitializeComponent();
            this.context = context;
            this.read = read;
            criminals = read.CriminalsList();
            EnableOrDesable(false);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void FormReadCriminalInfo_Load(object sender, EventArgs e)
        {
            labelCriminalID.Text = criminals[i].Id.ToString();
            labelCriminalName.Text = criminals[i].Name;
            labelCriminalNickName.Text = criminals[i].Nickname;
            labelCriminalTownId.Text = criminals[i].TownId.ToString();
            labelCriminalCrime.Text = criminals[i].Crime.ToString();
            labelCriminalSentence.Text = criminals[i].Sentence.ToString();
            labelCriminalStatus.Text = criminals[i].Status.ToString();
            labelCriminalEvilnessFactor.Text = criminals[i].EvilnessFactor.ToString();
        }

        private void CriminalID_Click(object sender, EventArgs e)
        {

        }

        //------------------------------Button1 & Button2------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            if (i <= 0)
            {
                i = criminals.Count - 1;
                labelCriminalID.Text = criminals[i].Id.ToString();
                labelCriminalName.Text = criminals[i].Name;
                labelCriminalNickName.Text = criminals[i].Nickname;
                labelCriminalTownId.Text = criminals[i].TownId.ToString();
                labelCriminalCrime.Text = criminals[i].Crime.ToString();
                labelCriminalSentence.Text = criminals[i].Sentence.ToString();
                labelCriminalStatus.Text = criminals[i].Status.ToString();
                labelCriminalEvilnessFactor.Text = criminals[i].EvilnessFactor.Name;

            }
            else
            {
                labelCriminalID.Text = criminals[i].Id.ToString();
                labelCriminalName.Text = criminals[i].Name;
                labelCriminalNickName.Text = criminals[i].Nickname;
               labelCriminalTownId.Text = criminals[i].TownId.ToString();
                labelCriminalCrime.Text = criminals[i].Crime.ToString();
                labelCriminalSentence.Text = criminals[i].Sentence.ToString();
                labelCriminalStatus.Text = criminals[i].Status.ToString();
                labelCriminalEvilnessFactor.Text = criminals[i].EvilnessFactor.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            i++;
            if (i >= criminals.Count - 1)
            {
                i = 0;
                labelCriminalID.Text = criminals[i].Id.ToString();
                labelCriminalName.Text = criminals[i].Name;
                labelCriminalNickName.Text = criminals[i].Nickname;
                labelCriminalTownId.Text = criminals[i].TownId.ToString();
                labelCriminalCrime.Text = criminals[i].Crime.ToString();
                labelCriminalSentence.Text = criminals[i].Sentence.ToString();
                labelCriminalStatus.Text = criminals[i].Status.ToString();
                labelCriminalEvilnessFactor.Text = criminals[i].EvilnessFactor.Name;
            }
            else
            {
                labelCriminalID.Text = criminals[i].Id.ToString();
                labelCriminalName.Text = criminals[i].Name;
                labelCriminalNickName.Text = criminals[i].Nickname;
                labelCriminalTownId.Text = criminals[i].TownId.ToString();
                labelCriminalCrime.Text = criminals[i].Crime.ToString();
                labelCriminalSentence.Text = criminals[i].Sentence.ToString();
                labelCriminalStatus.Text = criminals[i].Status.ToString();
                labelCriminalEvilnessFactor.Text = criminals[i].EvilnessFactor.Name;
            }
        }


        private void FormReadCriminalInfo_Load_1(object sender, EventArgs e)
        {

        }

        private void EnableOrDesable(bool trueOrFalse)
        {
            button1.Enabled = !trueOrFalse;
            button2.Enabled = !trueOrFalse;
            button3.Enabled = trueOrFalse;
            textBox1.Enabled = trueOrFalse;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            EnableOrDesable(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var c = criminals.FirstOrDefault(x=>x.Name==textBox1.Text);
            labelCriminalID.Text = c.Id.ToString();
            labelCriminalName.Text = c.Name;
            labelCriminalNickName.Text = c.Nickname;
            labelCriminalTownId.Text = c.TownId.ToString();
            labelCriminalCrime.Text = c.Crime.ToString();
            labelCriminalSentence.Text = c.Sentence.ToString();
            labelCriminalStatus.Text = c.Status.ToString();
            labelCriminalEvilnessFactor.Text = c.EvilnessFactor.Name;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

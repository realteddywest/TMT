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
        private static TMTContext context = new TMTContext();
        private static ReadController read = new ReadController(context);
        private List<Criminal> criminals= read.CriminalsList();
        int i = 0;

        public FormReadCriminalInfo()
        {
            InitializeComponent();
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
                labelCriminalEvilnessFactor.Text = criminals[i].EvilnessFactor.ToString();

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
                labelCriminalEvilnessFactor.Text = criminals[i].EvilnessFactor.ToString();
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
    }
}

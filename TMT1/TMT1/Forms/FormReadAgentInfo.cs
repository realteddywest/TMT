﻿using System;
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
    public partial class FormReadAgentInfo : Form
    {
        private static TMTContext context = new TMTContext();
        private static ReadController read = new ReadController(context);
        private List<Agent> agents = read.AgentsList();
        int i = 0;

        public FormReadAgentInfo()
        {
            InitializeComponent();
            EnableOrDesable(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            if (i <= 0)
            {
                i = agents.Count - 1;
                labelAgentID.Text = agents[i].Id.ToString();
                labelAgentName.Text = agents[i].Name;
                labelAgentNickname.Text = agents[i].Nickname;
                labelAgentAge.Text = agents[i].Age.ToString();
                labelAgentTownId.Text = agents[i].TownId.ToString();
            }
            else
            {
                labelAgentID.Text = agents[i].Id.ToString();
                labelAgentName.Text = agents[i].Name;
                labelAgentNickname.Text = agents[i].Nickname;
                labelAgentAge.Text = agents[i].Age.ToString();
                labelAgentTownId.Text = agents[i].TownId.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            if (i >= agents.Count - 1)
            {
                i = 0;
                labelAgentID.Text = agents[i].Id.ToString();
                labelAgentName.Text = agents[i].Name;
                labelAgentNickname.Text = agents[i].Nickname;
                labelAgentAge.Text = agents[i].Age.ToString();
                labelAgentTownId.Text = agents[i].TownId.ToString();
            }
            else
            {
                labelAgentID.Text = agents[i].Id.ToString();
                labelAgentName.Text = agents[i].Name;
                labelAgentNickname.Text = agents[i].Nickname;
                labelAgentAge.Text = agents[i].Age.ToString();
                labelAgentTownId.Text = agents[i].TownId.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var find = agents.FirstOrDefault(t => t.Name == textBox1.Text);
            if (find != null)
            {
                labelAgentID.Text = find.Id.ToString();
                labelAgentName.Text = find.Name;
                labelAgentNickname.Text = find.Nickname;
                labelAgentAge.Text = find.Age.ToString();
                labelAgentTownId.Text = find.TownId.ToString();
            }
            else
            {
                labelAgentID.Text = "Not found!";
                labelAgentName.Text = "Not found!";
                labelAgentNickname.Text = "Not found!";
                labelAgentAge.Text = "Not found!";
                labelAgentTownId.Text = "Not found!";
                
            }
        }

        private void LabelAgentID_Click(object sender, EventArgs e)
        {

        }

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

        private void FormReadAgentInfo_Load(object sender, EventArgs e)
        {

            labelAgentID.Text = agents[i].Id.ToString();
            labelAgentName.Text = agents[i].Name;
            labelAgentNickname.Text = agents[i].Nickname;
            labelAgentAge.Text = agents[i].Age.ToString();
            labelAgentTownId.Text = agents[i].TownId.ToString();

        }
    }
}
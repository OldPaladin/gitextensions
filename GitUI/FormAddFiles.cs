﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GitCommands;

namespace GitUI
{
    public partial class FormAddFiles : Form
    {
        public FormAddFiles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Output.Text = "";

            AddFilesDto dto = new AddFilesDto(Filter.Text);
            GitCommands.AddFiles cmd = new GitCommands.AddFiles(dto);
            cmd.Execute();

            Output.Text = "Command executed \n" + dto.Result;
        }
    }
}

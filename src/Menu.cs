﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_solitaire.src
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog(this);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoculCuCulori
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Map.rows = (int)numUD_Rows.Value;
            Map.columns = (int)numUD_Cols.Value;
            form1.ShowDialog();
            this.Close();
        }
    }
}

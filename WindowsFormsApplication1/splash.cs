﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class splash : Form
    {       
        public splash()
        {
         
            InitializeComponent();
        }
        
        private void SPL_Load(object sender, EventArgs e)
        {
            Form mainme = new Form1();
            this.AddOwnedForm(mainme);
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs   e)
        {
            Form mainme = new Form1();
            this.AddOwnedForm(mainme);
            mainme.Show();
            this.Hide();
            timer1.Enabled = false;
                      
        }
        
    }
}

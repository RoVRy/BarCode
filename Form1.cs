using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
            CRC.Text = Convert.ToString(GenerateCRC());
        }

        private void GetCRC(object sender, EventArgs e)
        {
            CRC.Text = Convert.ToString(GenerateCRC());
        }

        private int GenerateCRC()
        {
            int i, j, ctrlcode = 0;
            string bc = BarCodeField.Text;
            for (i = 0; i < 12; i++)
            {
                j = 9 - (i % 2) * 2;
                ctrlcode += ((int)bc[i]-48) * j;
            }
            ctrlcode %= 10;
            return ctrlcode;
        }
    }
}
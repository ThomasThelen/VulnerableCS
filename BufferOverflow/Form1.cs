using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BufferOverflow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        unsafe private void button1_Click(object sender, EventArgs e)
        {

            float* number = stackalloc float[2];
           for(int i=0; i<5; i++)
            {
                *number++=1;
            }
        }
    }    
    }


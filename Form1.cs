using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_10_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            picComponent.Image = Properties.Resources.CPUImage;
            lblDescription.Text = "The CPU is the brain of the computer. It processes instructions and helps the computer run programs.";
        }

        private void btnRAM_Click(object sender, EventArgs e)
        {
            picComponent.Image = Properties.Resources.RAMImage;
            lblDescription.Text = "RAM is short-term memory that stores information the computer is currently using. It loses its data when the computer is off.";
        }

        private void btnSSD_Click(object sender, EventArgs e)
        {
            picComponent.Image = Properties.Resources.SSDImage;
            lblDescription.Text = "An SSD is a storage device that saves files , programs , and the operating system. It keeps information even when the computer is off.";
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            picComponent.Image = Properties.Resources.PowerImage;
            lblDescription.Text = "The power supply provides electricity to the different parts of the computer so they can work.";
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            picComponent.Image = Properties.Resources.InputImage;
            lblDescription.Text = "An input peripheral is a device used to enter information into a computer. Examples include a keyboard and mouse.";
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            picComponent.Image = Properties.Resources.OutputImage;
            lblDescription.Text = "An Output peripheral is a device that shows or plays information from a computer. Examples include a monitor and speakers.";
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }
    }
}

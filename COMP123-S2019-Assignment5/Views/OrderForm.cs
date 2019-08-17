using COMP123_S2019_Assignment5.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Authors Name: Tanvi
 * StudentID: 301044096
 * App Creation Date: 16/8/2019
 * 
 * **/
namespace COMP123_S2019_Assignment5.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This event displays the Productinfo Form and hides the Order form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }


        /// <summary>
        /// This event terminates the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This event shows a message dialog box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Thank you for choosing dollar computers...\n Your order will be processed in 7-10 bussiness days");
            Application.Exit();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selected to print the selected page.......");
            OrderPrintForm.PrintAction = PrintAction.PrintToPreview;
            OrderPrintForm.Print();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.Show();
            this.Hide();
        }

        

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            PlatformTextBox.Text = Program.hardware.platform;
            ConditionTextBox.Text = Program.hardware.condition;
            ManufacturerTextBox.Text = Program.hardware.manufacturer;
            ModelTextBox.Text = Program.hardware.model;
            LCDSizeTextBox.Text = Program.hardware.screenSize;
            MemoryTextBox.Text = Program.hardware.RAM_Size;
            CPUBrandTextBox.Text = Program.hardware.CPU_Brand;
            CPUSpeedTextBox.Text = Program.hardware.CPU_Speed;
            HDDTextBox.Text = Program.hardware.HDD_Size;
            WebCamTextBox.Text = Program.hardware.webcam;
            OSTextBox.Text = Program.hardware.OS;
            PriceTextBox.Text = Convert.ToString(Program.hardware.cost);
            double cost = Program.hardware.cost;
            double tax = (Program.hardware.cost * 13) / 100;
            SalesTaxTextBox.Text = Convert.ToString(tax);
            TotalTextBox.Text = Convert.ToString(cost+tax);

        }
    }
}

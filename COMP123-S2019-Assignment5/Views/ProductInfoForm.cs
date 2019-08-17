using COMP123_S2019_Assignment5.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This event terminates the application when the Cancel button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This event displays the OrderForm and hides the ProductInfoForm
        /// when Next Button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Next_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIDTextBox.Text = Convert.ToString(Program.hardware.productID);
            ConditionTextBox.Text = Program.hardware.condition;
            CostTextBox.Text = Convert.ToString(Program.hardware.cost);
            PlatformTextBox.Text = Program.hardware.platform;
            ManufacturerTextBox.Text = Program.hardware.manufacturer;
            OSTextBox.Text = Program.hardware.OS;
            ModelTextBox.Text = Program.hardware.model;
            MemoryTextBox.Text = Program.hardware.RAM_Size;
            CPUBrandTextBox.Text = Program.hardware.CPU_Brand;
            CPUTypeTextBox.Text = Program.hardware.CPU_Type;
            LCDSizeTextBox.Text = Program.hardware.screenSize;
            CPUNumberTextBox.Text = Program.hardware.CPU_Number;
            CPUSpeedTextBox.Text = Program.hardware.CPU_Speed;
            HDDTextBox.Text = Program.hardware.HDD_Size;
            GPUTypeTextBox.Text = Program.hardware.GPU_Type;
            WebCamTextBox.Text = Program.hardware.webcam;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamReader inputStream = new StreamReader(
                File.Open("Product.txt", FileMode.Open)))
            {

                Program.hardware.productID = Convert.ToInt32(inputStream.ReadLine());
                Program.hardware.cost = Convert.ToDouble(inputStream.ReadLine());
                Program.hardware.manufacturer = inputStream.ReadLine();
                Program.hardware.model = inputStream.ReadLine();
                Program.hardware.RAM_Type = inputStream.ReadLine();
                Program.hardware.RAM_Size = inputStream.ReadLine();
                Program.hardware.displayType = inputStream.ReadLine();
                Program.hardware.screenSize = inputStream.ReadLine();
                Program.hardware.resolution = inputStream.ReadLine();
                Program.hardware.CPU_Class =  inputStream.ReadLine();
                Program.hardware.CPU_Brand = inputStream.ReadLine();
                Program.hardware.CPU_Type = inputStream.ReadLine();
                Program.hardware.CPU_Speed = inputStream.ReadLine();
                Program.hardware.CPU_Number = inputStream.ReadLine();
                Program.hardware.condition = inputStream.ReadLine();
                Program.hardware.OS = inputStream.ReadLine();
                Program.hardware.platform = inputStream.ReadLine();
                Program.hardware.HDD_Size = inputStream.ReadLine();
                Program.hardware.HDD_Speed = inputStream.ReadLine();
                Program.hardware.GPU_Type = inputStream.ReadLine();
                Program.hardware.optical_Drive = inputStream.ReadLine();
                Program.hardware.audio_Type = inputStream.ReadLine();
                Program.hardware.LAN = inputStream.ReadLine();
                Program.hardware.WIFI = inputStream.ReadLine();
                Program.hardware.width = inputStream.ReadLine();
                Program.hardware.height = inputStream.ReadLine();
                Program.hardware.depth = inputStream.ReadLine();
                Program.hardware.weigth = inputStream.ReadLine();
                Program.hardware.mouse_Type = inputStream.ReadLine();
                Program.hardware.power = inputStream.ReadLine();
                Program.hardware.webcam = inputStream.ReadLine();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //open a stream to write
            using (StreamWriter outputString = new StreamWriter(
                File.Open("Product.txt",FileMode.Create)))
            {
                //write the data into the file
                outputString.WriteLine(Program.hardware.productID);
                outputString.WriteLine(Program.hardware.cost);
                outputString.WriteLine(Program.hardware.manufacturer);
                outputString.WriteLine(Program.hardware.model);
                outputString.WriteLine(Program.hardware.RAM_Type);
                outputString.WriteLine(Program.hardware.RAM_Size);
                outputString.WriteLine(Program.hardware.displayType);
                outputString.WriteLine(Program.hardware.screenSize);
                outputString.WriteLine(Program.hardware.resolution);
                outputString.WriteLine(Program.hardware.CPU_Class);
                outputString.WriteLine(Program.hardware.CPU_Brand);
                outputString.WriteLine(Program.hardware.CPU_Type);
                outputString.WriteLine(Program.hardware.CPU_Speed);
                outputString.WriteLine(Program.hardware.CPU_Number);
                outputString.WriteLine(Program.hardware.condition);
                outputString.WriteLine(Program.hardware.OS);
                outputString.WriteLine(Program.hardware.platform);
                outputString.WriteLine(Program.hardware.HDD_Size);
                outputString.WriteLine(Program.hardware.HDD_Speed);
                outputString.WriteLine(Program.hardware.GPU_Type);
                outputString.WriteLine(Program.hardware.optical_Drive);
                outputString.WriteLine(Program.hardware.audio_Type);
                outputString.WriteLine(Program.hardware.LAN);
                outputString.WriteLine(Program.hardware.WIFI);
                outputString.WriteLine(Program.hardware.width);
                outputString.WriteLine(Program.hardware.height);
                outputString.WriteLine(Program.hardware.depth);
                outputString.WriteLine(Program.hardware.weigth);
                outputString.WriteLine(Program.hardware.mouse_Type);
                outputString.WriteLine(Program.hardware.power);
                outputString.WriteLine(Program.hardware.webcam);

                //cleanup
                outputString.Close();
                outputString.Dispose();

            }
        }

        private void AnotherProductButton_Click(object sender, EventArgs e) 
        {
            Program.selectForm.Show();
            this.Hide();
        }

       

        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }
    }
}

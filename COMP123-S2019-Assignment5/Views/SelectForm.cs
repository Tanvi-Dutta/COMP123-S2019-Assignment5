using COMP123_S2019_Assignment5.Models;
using COMP123_S2019_Assignment5.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This event terminates the application when the cancel button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This event displays the ProductInfo Form and hides the Select Form 
        /// when the NextButton is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        /// <summary>
        /// This is the select form load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }

        }


        /// <summary>
        /// /// This is the event handler that highlights the entire row when any of the 
        /// single row's cell is clicked and displays the data of the selected row in
        /// the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HardwareDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //the next button gets enabled when a cell is clicked.
            NextButton.Enabled = true;
            //local scope alias
            var rowIndex = HardwareDataGridView.CurrentCell.RowIndex;
            var rows = HardwareDataGridView.Rows;
            var columnCount = HardwareDataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;

            rows[rowIndex].Selected = true;

            string outputString = string.Empty;

            //storing the informatio to be displayed in a string
            outputString = cells[2].Value.ToString() + " "+ cells[3].Value.ToString() + "  $" + cells[1].Value.ToString();
            //displaying the string in the textbox.
            SelectionTextBox.Text = outputString;

            //storing the data in data containers
            Program.hardware.productID = int.Parse(cells[0].Value.ToString());
            Program.hardware.cost = double.Parse(cells[1].Value.ToString());
            Program.hardware.manufacturer = cells[2].Value.ToString();
            Program.hardware.model = cells[3].Value.ToString();
            Program.hardware.RAM_Type = cells[4].Value.ToString();
            Program.hardware.RAM_Size = cells[5].Value.ToString();
            Program.hardware.displayType = cells[6].Value.ToString();
            Program.hardware.screenSize = cells[7].Value.ToString();
            Program.hardware.resolution = cells[8].Value.ToString();
            Program.hardware.CPU_Class = cells[9].Value.ToString();
            Program.hardware.CPU_Brand = cells[10].Value.ToString();
            Program.hardware.CPU_Type = cells[11].Value.ToString();
            Program.hardware.CPU_Speed = cells[12].Value.ToString();
            Program.hardware.CPU_Number = cells[13].Value.ToString();
            Program.hardware.condition = cells[14].Value.ToString();
            Program.hardware.OS = cells[15].Value.ToString();
            Program.hardware.platform = cells[16].Value.ToString();
            Program.hardware.HDD_Size = cells[17].Value.ToString();
            Program.hardware.HDD_Speed = cells[18].Value.ToString();
            Program.hardware.GPU_Type = cells[19].Value.ToString();
            Program.hardware.optical_Drive = cells[20].Value.ToString();
            Program.hardware.audio_Type = cells[21].Value.ToString();
            Program.hardware.LAN = cells[22].Value.ToString();
            Program.hardware.WIFI = cells[23].Value.ToString();
            Program.hardware.width = cells[24].Value.ToString();
            Program.hardware.height = cells[25].Value.ToString();
            Program.hardware.depth = cells[26].Value.ToString();
            Program.hardware.weigth = cells[27].Value.ToString();
            Program.hardware.mouse_Type = cells[28].Value.ToString();
            Program.hardware.power = cells[29].Value.ToString();
            Program.hardware.webcam = cells[30].Value.ToString();

           


        }
    }
}

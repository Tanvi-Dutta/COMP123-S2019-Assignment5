using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This event shows the selectForm and hides the StartForm 
        /// when NewOrder Button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewOrder_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.SELECT_FORM].Show();
            this.Hide();
        }

        /// <summary>
        /// This event displays the productInfo form and hides the 
        /// statrtForm when the SavedOrder Button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavedOrder_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.PRODUCTINFO_FORM].Show();
            this.Hide();
        }


        /// <summary>
        /// This event will terminate the application when the
        /// ExitButton is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

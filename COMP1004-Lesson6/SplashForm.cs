using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Lesson6
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            //1. instantiate the next form
            AbilityForm abilityForm = new AbilityForm();
            abilityForm.PreviousForm = this;
            //2. pass a referance to the current form to the next form
            this.SplashFormTimer.Enabled = false;
            abilityForm.Show();
            this.Hide();



        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagPrinter.Properties;
using System.Configuration;

namespace Zebra_Tag_Printer
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            labelSetting.Hide();
            textTagX.Text = Properties.Settings.Default.TagX.ToString();
            textTagY.Text = Properties.Settings.Default.TagY.ToString();

            textPermitNoX.Text = Properties.Settings.Default.PermitNoX.ToString();
            textPermitNoY.Text = Properties.Settings.Default.PermitNoY.ToString();

            textPermitBoxX.Text = Properties.Settings.Default.PermitBoxX.ToString();
            textPermitBoxY.Text = Properties.Settings.Default.PermitBoxY.ToString();
            
            textIsoPointX.Text = Properties.Settings.Default.IsoPointX.ToString();
            textIsoPointY.Text = Properties.Settings.Default.IsoPointY.ToString();

            textOfficerX.Text = Properties.Settings.Default.OfficerX.ToString();
            textOfficerY.Text = Properties.Settings.Default.OfficerY.ToString();

            textIsoOfficerX.Text = Properties.Settings.Default.IsoOfficerX.ToString();
            textIsoOfficerY.Text = Properties.Settings.Default.IsoOfficerY.ToString();

            textDateX.Text = Properties.Settings.Default.DateX.ToString();
            textDateY.Text = Properties.Settings.Default.DateY.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDefaults_Click(object sender, EventArgs e)
        {
            textTagX.Text = 80.ToString();
            textTagY.Text = 50.ToString();
            textPermitNoX.Text = 160.ToString();
            textPermitNoY.Text = 380.ToString();
            textPermitBoxX.Text = 240.ToString();
            textPermitBoxY.Text = 405.ToString();
            textIsoPointX.Text = 50.ToString();
            textIsoPointY.Text = 480.ToString();
            textOfficerX.Text = 190.ToString();
            textOfficerY.Text = 535.ToString();
            textIsoOfficerX.Text = 90.ToString();
            textIsoOfficerY.Text = 580.ToString();
            textDateX.Text = 90.ToString();
            textDateY.Text = 610.ToString();

        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.TagX = Convert.ToInt32(textTagX.Text);
                Properties.Settings.Default.TagY = Convert.ToInt32(textTagY.Text);

                Properties.Settings.Default.PermitNoX = Convert.ToInt32(textPermitNoX.Text);
                Properties.Settings.Default.PermitNoY = Convert.ToInt32(textPermitNoY.Text);

                Properties.Settings.Default.PermitBoxX = Convert.ToInt32(textPermitBoxX.Text);
                Properties.Settings.Default.PermitBoxY = Convert.ToInt32(textPermitBoxY.Text);

                Properties.Settings.Default.IsoPointX = Convert.ToInt32(textIsoPointX.Text);
                Properties.Settings.Default.IsoPointY = Convert.ToInt32(textIsoPointY.Text);

                Properties.Settings.Default.IsoOfficerX = Convert.ToInt32(textIsoOfficerX.Text);
                Properties.Settings.Default.IsoOfficerY = Convert.ToInt32(textIsoOfficerY.Text);

                Properties.Settings.Default.DateX = Convert.ToInt32(textDateX.Text);
                Properties.Settings.Default.DateY = Convert.ToInt32(textDateY.Text);

                Properties.Settings.Default.OfficerX = Convert.ToInt32(textOfficerX.Text);
                Properties.Settings.Default.OfficerY = Convert.ToInt32(textOfficerY.Text);

                Properties.Settings.Default.Save();

                labelSetting.Show();
            }
            catch (FormatException)

            {
                MessageBox.Show("Only integers allowed, settings not saved.",
                         "Important Note",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Exclamation);
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

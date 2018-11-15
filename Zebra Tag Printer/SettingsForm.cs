using System;
using System.Windows.Forms;

namespace Zebra_Tag_Printer
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {   // Hide label on load
            labelSetting.Hide();

            // Assign X and y settings variables to text boxes. 
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


        private void buttonDefaults_Click(object sender, EventArgs e)
        {
            // On load defaults set all x and y text boxed to the default values
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
                // Try block to endure all values are integers, If not show warning dialog box.
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
       
    }
}

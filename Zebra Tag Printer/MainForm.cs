using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using TagPrinter.Properties;
using Zebra_Tag_Printer.Properties;

namespace TagPrinter
{

    public partial class MainWindow : Form

    {
        // Public number for counting up the tags
        int totalnumber = 0;
        List<object[]> Result;
        object item = 0;
        string newstring = "";
     


        public MainWindow()
        {
            InitializeComponent();
        }

        //Print button checks
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            totalnumber = 0;
            // Get list from grid list[0][0]
            var Result = myDataGridView.Rows.OfType<DataGridViewRow>().Select(
            r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList();

            // Set variable for the first item in the list
            var firstitem = Result[0][0];

            //If the first item is null throw message and return
            if (firstitem == null)
            {
                MessageBox.Show("No data entered into table to print.", "Important Message");
                return;
            }

            // Set the print options
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                // Set the print document soze for the print function, this may be different for the print preview for viewing reasons.
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 1000, 6000);
                printDocument1.Print();
            }
        }

        // Paste the clipboard into the DataGridView *** Look into not pasting columns
        private void PasteClipboard()
        {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.Text))
            {
                string s = Clipboard.GetText();

                string[] lines = s.Replace("\n", "").Split('\r');

                try
                {
                    myDataGridView.Rows.Add(lines.Length - 1);
                    string[] fields;
                    int row = 0;
                    int col = 0;

                    foreach (string item in lines)
                    {
                        fields = item.Split('\t');
                        myDataGridView[col, row].Value = fields.First();
                        row++;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred: '{0}'", e);
                }
            }
        }

        // Reset the counter, clear the grid and paste
        private void buttonPaste_Click(object sender, EventArgs e)
        {

            myDataGridView.Rows.Clear();
            PasteClipboard();
        }

        // Reset the counter and clear the grid
        private void buttonClear_Click(object sender, EventArgs e)
        {

            myDataGridView.Rows.Clear();
        }

        // Print document function will loop for all pages until the 
        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Get table results
            Result = myDataGridView.Rows.OfType<DataGridViewRow>().Select(
            r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList();
            // Set vairable for the isolation item in the list

            item = Result[totalnumber][0];
            // Set variable for the next item this is to check later on if the next page needs to be setup or it is null

            // Print all text to the page ** Look into try block

            // Add one to the counter for tag numbers

            // If the isolation point is long
            if (item.ToString().Length > 32)
            {
                //Find all spaces in string and add to list
                var foundIndexes = new List<int>();
                for (int i = 0; i < item.ToString().Length; i++)

                    if (item.ToString()[i] == ' ') foundIndexes.Add(i);
                
                // Find the closest space to the position 32
                int closest = foundIndexes.Aggregate((x, y) => Math.Abs(x - 32) < Math.Abs(y - 32) ? x : y);
             
               // Get string length
                int z = item.ToString().Length;

                // Create substrings, add newling and join them together again
                string a = item.ToString().Substring(0, closest) + Environment.NewLine;
                string b = item.ToString().Substring(closest, z - closest);
                newstring = a + b;


            }

            totalnumber += 1;
            e.Graphics.DrawString(totalnumber.ToString(), new Font("Areal Black", 22, FontStyle.Bold), Brushes.Black, Settings.Default.TagX, Settings.Default.TagY);
            e.Graphics.DrawString(textPermitNumber.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, Settings.Default.PermitNoX, Settings.Default.PermitNoY);
            e.Graphics.DrawString(textPermitBox.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, Settings.Default.PermitBoxX, Settings.Default.PermitBoxY);
            e.Graphics.DrawString(newstring, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, Settings.Default.IsoPointX, Settings.Default.IsoPointY); //Across,Down
            e.Graphics.DrawString(textPermitOfficer.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, Settings.Default.OfficerX, Settings.Default.OfficerY);
            e.Graphics.DrawString(textPermitIsoOfficer.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, Settings.Default.IsoOfficerX, Settings.Default.IsoOfficerY);
            e.Graphics.DrawString(DateTime.Now.ToString("d/M/yyyy"), new Font("Areal", 16, FontStyle.Bold), Brushes.Black, Settings.Default.DateX, Settings.Default.DateY);

            //e.Graphics.DrawString(totalnumber.ToString(), new Font("Areal Black", 22, FontStyle.Bold), Brushes.Black, 80, 50);
            //e.Graphics.DrawString(textPermitNumber.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, 160, 380);
            //e.Graphics.DrawString(textPermitBox.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, 240, 405);
            //e.Graphics.DrawString(item.ToString(), new Font("Areal", 16, FontStyle.Bold), Brushes.Black, 50, 480); //Across,Down
            //e.Graphics.DrawString(textPermitOfficer.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, 190, 535);
            //e.Graphics.DrawString(textPermitIsoOfficer.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, 90, 580);
            //e.Graphics.DrawString(DateTime.Now.ToString("d/M/yyyy"), new Font("Areal", 16, FontStyle.Bold), Brushes.Black, 90, 610);

            // Check if the next item is an empty string if it is the next tag is not needed.
            if (Result.ElementAtOrDefault(totalnumber + 1) == null)
            {
                e.HasMorePages = false;
                totalnumber = 0;

            }
            else
                if (Result[totalnumber + 1].Equals(""))
            {

                e.HasMorePages = false;
                totalnumber = 0;

            }
            else
                e.HasMorePages = true;



            //Else set up the next page


            // May not need this with the new check

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        // Print Preview
        private void button1_Click(object sender, EventArgs e)
        {

            //Get table data to check if empty
            var Result = myDataGridView.Rows.OfType<DataGridViewRow>().Select(
            r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList();

            var firstitem = Result[0][0];

            if (firstitem == null)
            {
                MessageBox.Show("No data entered into table to preview.", "Important Message");
                return;
            }

            // Setup print preview
            //printPreviewDialog1.Size = new System.Drawing.Size(200, 300);
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 450, 700);
            printPreviewDialog1.WindowState = FormWindowState.Maximized;

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();


        }


        private void buttonSettings_Click(object sender, EventArgs e)
        {
            new Zebra_Tag_Printer.SettingsForm().Show();
        }

  
    }
}



using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
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
        bool pPreview = false;


        public MainWindow()
        {
            InitializeComponent();
            
        }

        //Print button checks
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            pPreview = false;
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

            object item = GetCellData(totalnumber);

            totalnumber += 1;

            if (pPreview.Equals(true))
            {
                Assembly myAssembly = Assembly.GetExecutingAssembly();
                string[] names = myAssembly.GetManifestResourceNames();

                Stream myStream = myAssembly.GetManifestResourceStream("Zebra_Tag_Printer.tag.bmp");
                Bitmap bmp = new Bitmap(myStream);
                e.Graphics.DrawImage(Zebra_Tag_Printer.BitmapTools.ScaleByPercent(bmp, 80), 0, 0);
            }

            e.Graphics.DrawString(totalnumber.ToString(), new Font("Areal Black", 22, FontStyle.Bold), Brushes.Black, Settings.Default.TagX, Settings.Default.TagY);
            e.Graphics.DrawString(textPermitNumber.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, Settings.Default.PermitNoX, Settings.Default.PermitNoY);
            e.Graphics.DrawString(textPermitBox.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, Settings.Default.PermitBoxX, Settings.Default.PermitBoxY);
            e.Graphics.DrawString(item.ToString(), new Font("Areal", 16, FontStyle.Bold), Brushes.Black, Settings.Default.IsoPointX, Settings.Default.IsoPointY); //Across,Down
            e.Graphics.DrawString(textPermitOfficer.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, Settings.Default.OfficerX, Settings.Default.OfficerY);
            e.Graphics.DrawString(textPermitIsoOfficer.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, Settings.Default.IsoOfficerX, Settings.Default.IsoOfficerY);
            e.Graphics.DrawString(DateTime.Now.ToString("d/M/yyyy"), new Font("Areal", 16, FontStyle.Bold), Brushes.Black, Settings.Default.DateX, Settings.Default.DateY);

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
            }

        // Print Preview
        private void button1_Click(object sender, EventArgs e)
        {
            pPreview = true;
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
            // Disable print button on preview
            ((ToolStripButton)((ToolStrip)printPreviewDialog1.Controls[1]).Items[0]).Enabled = false;

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            new Zebra_Tag_Printer.SettingsForm().Show();
        }

        public object GetCellData(int tagnumber)
        {
            //Get table data
            Result = myDataGridView.Rows.OfType<DataGridViewRow>().Select(
           r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList();
            // Check if null
            if (Result[tagnumber][0] == null)
            {
                return "Isolation Point";
            }
            else
            {
                if (Result[tagnumber][0].ToString().Length > 24)
                {
                    item = Result[tagnumber][0];
                    //Find all spaces in string and add to list
                    var foundIndexes = new List<int>();
                    for (int i = 0; i < item.ToString().Length; i++)

                        if (item.ToString()[i] == ' ') foundIndexes.Add(i);

                    // Find the closest space to the position 32
                    int closest = foundIndexes.Aggregate((x_a, y_a) => Math.Abs(x_a - 24) < Math.Abs(y_a - 24) ? x_a : y_a);

                    // Get string length
                    int z = item.ToString().Length;

                    // Create substrings, add newling and join them together again
                    string a = item.ToString().Substring(0, closest) + Environment.NewLine;
                    string b = item.ToString().Substring(closest, z - closest);
                    newstring = a + b;

                    return newstring;
                }
                else
                {
                    newstring = Result[0][0].ToString();

                    return newstring;
                }
            }
        }
  
        public void panel1_Paint()
        {
            double x = 2.3;
            double y = 1.3;
            SolidBrush s = new SolidBrush(Color.Black);
            Graphics e = panelTag.CreateGraphics();
            e.Clear(Color.White);
            e.DrawString(1.ToString(), new Font("Areal Black", 22, FontStyle.Bold), Brushes.Black, Convert.ToInt32(Math.Round(Settings.Default.TagX/x,0)), Convert.ToInt32(Math.Round(Settings.Default.TagY/ y, 0)));
            e.DrawString(textPermitNumber.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, Convert.ToInt32(Math.Round(Settings.Default.PermitNoX / x, 0)), Convert.ToInt32(Math.Round(Settings.Default.PermitNoY / y, 0)));
            e.DrawString(textPermitBox.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, Convert.ToInt32(Math.Round(Settings.Default.PermitBoxX / x, 0)), Convert.ToInt32(Math.Round(Settings.Default.PermitBoxY / y, 0)));
            object item = GetCellData(0);
            e.DrawString(item.ToString(), new Font("Areal", 16, FontStyle.Bold), Brushes.Black, Convert.ToInt32(Math.Round(Settings.Default.IsoPointX / x, 0)), Convert.ToInt32(Math.Round(Settings.Default.IsoPointY / y, 0))); //Across,Down
            e.DrawString(textPermitOfficer.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, Convert.ToInt32(Math.Round(Settings.Default.OfficerX / x, 0)), Convert.ToInt32(Math.Round(Settings.Default.OfficerY / y, 0)));
            e.DrawString(textPermitIsoOfficer.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, Convert.ToInt32(Math.Round(Settings.Default.IsoOfficerX / x, 0)), Convert.ToInt32(Math.Round(Settings.Default.IsoOfficerY / y, 0)));
            e.DrawString(DateTime.Now.ToString("d/M/yyyy"), new Font("Areal", 16, FontStyle.Bold), Brushes.Black, Convert.ToInt32(Math.Round(Settings.Default.DateX / x, 0)), Convert.ToInt32(Math.Round(Settings.Default.DateY / y, 0)));
        }

        private void textPermitNumber_TextChanged(object sender, EventArgs e)
        {
            panel1_Paint();
        }

        private void textPermitBox_TextChanged(object sender, EventArgs e)
        {
            panel1_Paint();
        }

        private void textPermitOfficer_TextChanged(object sender, EventArgs e)
        {
            panel1_Paint();
        }

        private void textPermitIsoOfficer_TextChanged(object sender, EventArgs e)
        {
            panel1_Paint();
        }

        private void myDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            panel1_Paint();
        }
    }
}



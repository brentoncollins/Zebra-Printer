using System;
using System.Drawing.Printing;

namespace TagPrinter
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.labelPermitNumber = new System.Windows.Forms.Label();
            this.labelPermitBox = new System.Windows.Forms.Label();
            this.labelPermitOfficer = new System.Windows.Forms.Label();
            this.labelPermitIsoOfficer = new System.Windows.Forms.Label();
            this.labelPermitTagPrint = new System.Windows.Forms.Label();
            this.textPermitNumber = new System.Windows.Forms.TextBox();
            this.textPermitBox = new System.Windows.Forms.TextBox();
            this.textPermitOfficer = new System.Windows.Forms.TextBox();
            this.textPermitIsoOfficer = new System.Windows.Forms.TextBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.myDataGridView = new System.Windows.Forms.DataGridView();
            this.IsolationPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonClear = new System.Windows.Forms.Button();
            this.PrintPerview = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.buttonSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPermitNumber
            // 
            this.labelPermitNumber.AutoSize = true;
            this.labelPermitNumber.Location = new System.Drawing.Point(954, 41);
            this.labelPermitNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPermitNumber.Name = "labelPermitNumber";
            this.labelPermitNumber.Size = new System.Drawing.Size(233, 37);
            this.labelPermitNumber.TabIndex = 0;
            this.labelPermitNumber.Text = "Permit Number";
            // 
            // labelPermitBox
            // 
            this.labelPermitBox.AutoSize = true;
            this.labelPermitBox.Location = new System.Drawing.Point(954, 91);
            this.labelPermitBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPermitBox.Name = "labelPermitBox";
            this.labelPermitBox.Size = new System.Drawing.Size(172, 37);
            this.labelPermitBox.TabIndex = 1;
            this.labelPermitBox.Text = "Permit Box";
            // 
            // labelPermitOfficer
            // 
            this.labelPermitOfficer.AutoSize = true;
            this.labelPermitOfficer.Location = new System.Drawing.Point(954, 142);
            this.labelPermitOfficer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPermitOfficer.Name = "labelPermitOfficer";
            this.labelPermitOfficer.Size = new System.Drawing.Size(212, 37);
            this.labelPermitOfficer.TabIndex = 2;
            this.labelPermitOfficer.Text = "Permit Officer";
            // 
            // labelPermitIsoOfficer
            // 
            this.labelPermitIsoOfficer.AutoSize = true;
            this.labelPermitIsoOfficer.Location = new System.Drawing.Point(954, 193);
            this.labelPermitIsoOfficer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPermitIsoOfficer.Name = "labelPermitIsoOfficer";
            this.labelPermitIsoOfficer.Size = new System.Drawing.Size(340, 37);
            this.labelPermitIsoOfficer.TabIndex = 3;
            this.labelPermitIsoOfficer.Text = "Permit Isolation Officer";
            // 
            // labelPermitTagPrint
            // 
            this.labelPermitTagPrint.AutoSize = true;
            this.labelPermitTagPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPermitTagPrint.Location = new System.Drawing.Point(177, 5);
            this.labelPermitTagPrint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPermitTagPrint.Name = "labelPermitTagPrint";
            this.labelPermitTagPrint.Size = new System.Drawing.Size(555, 82);
            this.labelPermitTagPrint.TabIndex = 4;
            this.labelPermitTagPrint.Text = "Permit Tag Print";
            // 
            // textPermitNumber
            // 
            this.textPermitNumber.Location = new System.Drawing.Point(1347, 33);
            this.textPermitNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textPermitNumber.Name = "textPermitNumber";
            this.textPermitNumber.Size = new System.Drawing.Size(448, 44);
            this.textPermitNumber.TabIndex = 5;
            this.textPermitNumber.Text = "Permit Number";
            // 
            // textPermitBox
            // 
            this.textPermitBox.Location = new System.Drawing.Point(1347, 84);
            this.textPermitBox.Margin = new System.Windows.Forms.Padding(4);
            this.textPermitBox.Name = "textPermitBox";
            this.textPermitBox.Size = new System.Drawing.Size(448, 44);
            this.textPermitBox.TabIndex = 6;
            this.textPermitBox.Text = "Permit Box";
     
            // 
            // textPermitOfficer
            // 
            this.textPermitOfficer.Location = new System.Drawing.Point(1347, 135);
            this.textPermitOfficer.Margin = new System.Windows.Forms.Padding(4);
            this.textPermitOfficer.Name = "textPermitOfficer";
            this.textPermitOfficer.Size = new System.Drawing.Size(448, 44);
            this.textPermitOfficer.TabIndex = 7;
            this.textPermitOfficer.Text = "Permit Officer";
            // 
            // textPermitIsoOfficer
            // 
            this.textPermitIsoOfficer.Location = new System.Drawing.Point(1347, 186);
            this.textPermitIsoOfficer.Margin = new System.Windows.Forms.Padding(4);
            this.textPermitIsoOfficer.Name = "textPermitIsoOfficer";
            this.textPermitIsoOfficer.Size = new System.Drawing.Size(448, 44);
            this.textPermitIsoOfficer.TabIndex = 8;
            this.textPermitIsoOfficer.Text = "Permit Isolation Officer";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Location = new System.Drawing.Point(1564, 1924);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(267, 86);
            this.buttonPrint.TabIndex = 9;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonPaste
            // 
            this.buttonPaste.Location = new System.Drawing.Point(27, 1924);
            this.buttonPaste.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(255, 91);
            this.buttonPaste.TabIndex = 10;
            this.buttonPaste.Text = "Paste";
            this.buttonPaste.UseVisualStyleBackColor = true;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // myDataGridView
            // 
            this.myDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsolationPoint});
            this.myDataGridView.Location = new System.Drawing.Point(27, 91);
            this.myDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.myDataGridView.MinimumSize = new System.Drawing.Size(475, 0);
            this.myDataGridView.Name = "myDataGridView";
            this.myDataGridView.RowHeadersVisible = false;
            this.myDataGridView.RowTemplate.Height = 15;
            this.myDataGridView.Size = new System.Drawing.Size(898, 1821);
            this.myDataGridView.TabIndex = 11;
            // 
            // IsolationPoint
            // 
            this.IsolationPoint.HeaderText = "Isolation Point";
            this.IsolationPoint.Name = "IsolationPoint";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(290, 1924);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(274, 91);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear Table";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // PrintPerview
            // 
            this.PrintPerview.Location = new System.Drawing.Point(1281, 1922);
            this.PrintPerview.Margin = new System.Windows.Forms.Padding(4);
            this.PrintPerview.Name = "PrintPerview";
            this.PrintPerview.Size = new System.Drawing.Size(276, 88);
            this.PrintPerview.TabIndex = 13;
            this.PrintPerview.Text = "Print Preview";
            this.PrintPerview.UseVisualStyleBackColor = true;
            this.PrintPerview.Click += new System.EventHandler(this.button1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(1005, 1922);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(269, 88);
            this.buttonSettings.TabIndex = 14;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
          
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1861, 2048);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.PrintPerview);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.myDataGridView);
            this.Controls.Add(this.buttonPaste);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.textPermitIsoOfficer);
            this.Controls.Add(this.textPermitOfficer);
            this.Controls.Add(this.textPermitBox);
            this.Controls.Add(this.textPermitNumber);
            this.Controls.Add(this.labelPermitTagPrint);
            this.Controls.Add(this.labelPermitIsoOfficer);
            this.Controls.Add(this.labelPermitOfficer);
            this.Controls.Add(this.labelPermitBox);
            this.Controls.Add(this.labelPermitNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(53, 103);
            this.Name = "MainWindow";
            this.Text = "Permit of Isolation tag printer.";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private PaperSize GetPaperSize(int v)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label labelPermitNumber;
        private System.Windows.Forms.Label labelPermitBox;
        private System.Windows.Forms.Label labelPermitOfficer;
        private System.Windows.Forms.Label labelPermitIsoOfficer;
        private System.Windows.Forms.Label labelPermitTagPrint;
        private System.Windows.Forms.TextBox textPermitNumber;
        private System.Windows.Forms.TextBox textPermitBox;
        private System.Windows.Forms.TextBox textPermitOfficer;
        private System.Windows.Forms.TextBox textPermitIsoOfficer;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonPaste;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView myDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsolationPoint;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button PrintPerview;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button buttonSettings;
    }
}


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
            this.panelTag = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPermitNumber
            // 
            this.labelPermitNumber.AutoSize = true;
            this.labelPermitNumber.Location = new System.Drawing.Point(803, 33);
            this.labelPermitNumber.Name = "labelPermitNumber";
            this.labelPermitNumber.Size = new System.Drawing.Size(204, 32);
            this.labelPermitNumber.TabIndex = 0;
            this.labelPermitNumber.Text = "Permit Number";
            // 
            // labelPermitBox
            // 
            this.labelPermitBox.AutoSize = true;
            this.labelPermitBox.Location = new System.Drawing.Point(803, 76);
            this.labelPermitBox.Name = "labelPermitBox";
            this.labelPermitBox.Size = new System.Drawing.Size(153, 32);
            this.labelPermitBox.TabIndex = 1;
            this.labelPermitBox.Text = "Permit Box";
            // 
            // labelPermitOfficer
            // 
            this.labelPermitOfficer.AutoSize = true;
            this.labelPermitOfficer.Location = new System.Drawing.Point(803, 119);
            this.labelPermitOfficer.Name = "labelPermitOfficer";
            this.labelPermitOfficer.Size = new System.Drawing.Size(188, 32);
            this.labelPermitOfficer.TabIndex = 2;
            this.labelPermitOfficer.Text = "Permit Officer";
            // 
            // labelPermitIsoOfficer
            // 
            this.labelPermitIsoOfficer.AutoSize = true;
            this.labelPermitIsoOfficer.Location = new System.Drawing.Point(803, 162);
            this.labelPermitIsoOfficer.Name = "labelPermitIsoOfficer";
            this.labelPermitIsoOfficer.Size = new System.Drawing.Size(302, 32);
            this.labelPermitIsoOfficer.TabIndex = 3;
            this.labelPermitIsoOfficer.Text = "Permit Isolation Officer";
            // 
            // labelPermitTagPrint
            // 
            this.labelPermitTagPrint.AutoSize = true;
            this.labelPermitTagPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPermitTagPrint.Location = new System.Drawing.Point(149, 5);
            this.labelPermitTagPrint.Name = "labelPermitTagPrint";
            this.labelPermitTagPrint.Size = new System.Drawing.Size(463, 69);
            this.labelPermitTagPrint.TabIndex = 4;
            this.labelPermitTagPrint.Text = "Permit Tag Print";
            // 
            // textPermitNumber
            // 
            this.textPermitNumber.Location = new System.Drawing.Point(1133, 29);
            this.textPermitNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPermitNumber.Name = "textPermitNumber";
            this.textPermitNumber.Size = new System.Drawing.Size(377, 38);
            this.textPermitNumber.TabIndex = 5;
            this.textPermitNumber.Text = "Permit Number";
            this.textPermitNumber.TextChanged += new System.EventHandler(this.textPermitNumber_TextChanged);
            // 
            // textPermitBox
            // 
            this.textPermitBox.Location = new System.Drawing.Point(1133, 69);
            this.textPermitBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPermitBox.Name = "textPermitBox";
            this.textPermitBox.Size = new System.Drawing.Size(377, 38);
            this.textPermitBox.TabIndex = 6;
            this.textPermitBox.Text = "Permit Box";
            this.textPermitBox.TextChanged += new System.EventHandler(this.textPermitBox_TextChanged);
            // 
            // textPermitOfficer
            // 
            this.textPermitOfficer.Location = new System.Drawing.Point(1133, 112);
            this.textPermitOfficer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPermitOfficer.Name = "textPermitOfficer";
            this.textPermitOfficer.Size = new System.Drawing.Size(377, 38);
            this.textPermitOfficer.TabIndex = 7;
            this.textPermitOfficer.Text = "Permit Officer";
            this.textPermitOfficer.TextChanged += new System.EventHandler(this.textPermitOfficer_TextChanged);
            // 
            // textPermitIsoOfficer
            // 
            this.textPermitIsoOfficer.Location = new System.Drawing.Point(1133, 155);
            this.textPermitIsoOfficer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPermitIsoOfficer.Name = "textPermitIsoOfficer";
            this.textPermitIsoOfficer.Size = new System.Drawing.Size(377, 38);
            this.textPermitIsoOfficer.TabIndex = 8;
            this.textPermitIsoOfficer.Text = "Permit Isolation Officer";
            this.textPermitIsoOfficer.TextChanged += new System.EventHandler(this.textPermitIsoOfficer_TextChanged);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Location = new System.Drawing.Point(1400, 1664);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(224, 72);
            this.buttonPrint.TabIndex = 9;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonPaste
            // 
            this.buttonPaste.Location = new System.Drawing.Point(24, 1664);
            this.buttonPaste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(216, 76);
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
            this.myDataGridView.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsolationPoint});
            this.myDataGridView.Location = new System.Drawing.Point(24, 76);
            this.myDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myDataGridView.MinimumSize = new System.Drawing.Size(400, 0);
            this.myDataGridView.Name = "myDataGridView";
            this.myDataGridView.RowHeadersVisible = false;
            this.myDataGridView.RowTemplate.Height = 15;
            this.myDataGridView.Size = new System.Drawing.Size(765, 1579);
            this.myDataGridView.TabIndex = 11;
            this.myDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.myDataGridView_CellValueChanged);
            // 
            // IsolationPoint
            // 
            this.IsolationPoint.HeaderText = "Isolation Point";
            this.IsolationPoint.Name = "IsolationPoint";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(284, 1664);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(232, 76);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear Table";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // PrintPerview
            // 
            this.PrintPerview.Location = new System.Drawing.Point(557, 1664);
            this.PrintPerview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrintPerview.Name = "PrintPerview";
            this.PrintPerview.Size = new System.Drawing.Size(232, 74);
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
            this.buttonSettings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Location = new System.Drawing.Point(1165, 1664);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(227, 72);
            this.buttonSettings.TabIndex = 14;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // panelTag
            // 
            this.panelTag.BackColor = System.Drawing.Color.White;
            this.panelTag.Location = new System.Drawing.Point(811, 343);
            this.panelTag.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelTag.Name = "panelTag";
            this.panelTag.Size = new System.Drawing.Size(813, 1312);
            this.panelTag.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1032, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 87);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tag Preview";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1659, 1738);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTag);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1573, 970);
            this.Name = "MainWindow";
            this.Text = "Permit of Isolation tag printer.";
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
        private System.Windows.Forms.Panel panelTag;
        private System.Windows.Forms.Label label1;
    }
}


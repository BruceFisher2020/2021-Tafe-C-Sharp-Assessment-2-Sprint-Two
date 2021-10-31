
namespace AstronomicalProcessing
{
    partial class AstronomicalProcessingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AstronomicalProcessingForm));
            this.ListBoxMain = new System.Windows.Forms.ListBox();
            this.TextBoxMain = new System.Windows.Forms.TextBox();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonAutoFill = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ButtonSeqSearch = new System.Windows.Forms.Button();
            this.ButtonMidExtreme = new System.Windows.Forms.Button();
            this.TextBoxMidExtreme = new System.Windows.Forms.TextBox();
            this.ButtonMode = new System.Windows.Forms.Button();
            this.TextBoxMode = new System.Windows.Forms.TextBox();
            this.ButtonAverage = new System.Windows.Forms.Button();
            this.TextBoxAverage = new System.Windows.Forms.TextBox();
            this.ButtonRange = new System.Windows.Forms.Button();
            this.TextBoxRange = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxMain
            // 
            this.ListBoxMain.FormattingEnabled = true;
            this.ListBoxMain.Location = new System.Drawing.Point(160, 130);
            this.ListBoxMain.Name = "ListBoxMain";
            this.ListBoxMain.Size = new System.Drawing.Size(130, 316);
            this.ListBoxMain.TabIndex = 0;
            this.ListBoxMain.SelectedIndexChanged += new System.EventHandler(this.ListBoxMain_SelectedIndexChanged);
            // 
            // TextBoxMain
            // 
            this.TextBoxMain.Location = new System.Drawing.Point(160, 92);
            this.TextBoxMain.Name = "TextBoxMain";
            this.TextBoxMain.Size = new System.Drawing.Size(130, 20);
            this.TextBoxMain.TabIndex = 1;
            this.TextBoxMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInput_KeyPress);
            // 
            // ButtonSort
            // 
            this.ButtonSort.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ButtonSort.FlatAppearance.BorderSize = 2;
            this.ButtonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSort.Location = new System.Drawing.Point(29, 279);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(123, 25);
            this.ButtonSort.TabIndex = 2;
            this.ButtonSort.Text = "Sort";
            this.ButtonSort.UseVisualStyleBackColor = false;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ButtonSearch.FlatAppearance.BorderSize = 2;
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.Location = new System.Drawing.Point(29, 316);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(123, 25);
            this.ButtonSearch.TabIndex = 3;
            this.ButtonSearch.Text = "Binary Search";
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonAutoFill
            // 
            this.ButtonAutoFill.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonAutoFill.FlatAppearance.BorderSize = 2;
            this.ButtonAutoFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAutoFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAutoFill.Location = new System.Drawing.Point(29, 421);
            this.ButtonAutoFill.Name = "ButtonAutoFill";
            this.ButtonAutoFill.Size = new System.Drawing.Size(123, 25);
            this.ButtonAutoFill.TabIndex = 4;
            this.ButtonAutoFill.Text = "AutoFill Data";
            this.ButtonAutoFill.UseVisualStyleBackColor = false;
            this.ButtonAutoFill.Click += new System.EventHandler(this.ButtonAutoFill_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ButtonAdd.FlatAppearance.BorderSize = 2;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.Location = new System.Drawing.Point(29, 130);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(123, 25);
            this.ButtonAdd.TabIndex = 5;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ButtonEdit.FlatAppearance.BorderSize = 2;
            this.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEdit.Location = new System.Drawing.Point(29, 167);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(123, 25);
            this.ButtonEdit.TabIndex = 6;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ButtonDelete.FlatAppearance.BorderSize = 2;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Location = new System.Drawing.Point(29, 205);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(123, 25);
            this.ButtonDelete.TabIndex = 7;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.BackColor = System.Drawing.Color.MediumTurquoise;
            this.LabelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(96, 44);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Padding = new System.Windows.Forms.Padding(3);
            this.LabelTitle.Size = new System.Drawing.Size(258, 33);
            this.LabelTitle.TabIndex = 8;
            this.LabelTitle.Text = "Astronomical Processing";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 468);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(450, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(112, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // ButtonSeqSearch
            // 
            this.ButtonSeqSearch.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ButtonSeqSearch.FlatAppearance.BorderSize = 2;
            this.ButtonSeqSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSeqSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSeqSearch.Location = new System.Drawing.Point(29, 354);
            this.ButtonSeqSearch.Name = "ButtonSeqSearch";
            this.ButtonSeqSearch.Size = new System.Drawing.Size(123, 25);
            this.ButtonSeqSearch.TabIndex = 10;
            this.ButtonSeqSearch.Text = "Sequential Search";
            this.ButtonSeqSearch.UseVisualStyleBackColor = false;
            // 
            // ButtonMidExtreme
            // 
            this.ButtonMidExtreme.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ButtonMidExtreme.FlatAppearance.BorderSize = 2;
            this.ButtonMidExtreme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMidExtreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMidExtreme.Location = new System.Drawing.Point(297, 130);
            this.ButtonMidExtreme.Name = "ButtonMidExtreme";
            this.ButtonMidExtreme.Size = new System.Drawing.Size(123, 25);
            this.ButtonMidExtreme.TabIndex = 11;
            this.ButtonMidExtreme.Text = "Mid Extreme";
            this.ButtonMidExtreme.UseVisualStyleBackColor = false;
            // 
            // TextBoxMidExtreme
            // 
            this.TextBoxMidExtreme.Location = new System.Drawing.Point(297, 167);
            this.TextBoxMidExtreme.Name = "TextBoxMidExtreme";
            this.TextBoxMidExtreme.Size = new System.Drawing.Size(123, 20);
            this.TextBoxMidExtreme.TabIndex = 12;
            // 
            // ButtonMode
            // 
            this.ButtonMode.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ButtonMode.FlatAppearance.BorderSize = 2;
            this.ButtonMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMode.Location = new System.Drawing.Point(297, 205);
            this.ButtonMode.Name = "ButtonMode";
            this.ButtonMode.Size = new System.Drawing.Size(123, 25);
            this.ButtonMode.TabIndex = 13;
            this.ButtonMode.Text = "Mode";
            this.ButtonMode.UseVisualStyleBackColor = false;
            // 
            // TextBoxMode
            // 
            this.TextBoxMode.Location = new System.Drawing.Point(297, 242);
            this.TextBoxMode.Name = "TextBoxMode";
            this.TextBoxMode.Size = new System.Drawing.Size(123, 20);
            this.TextBoxMode.TabIndex = 14;
            // 
            // ButtonAverage
            // 
            this.ButtonAverage.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ButtonAverage.FlatAppearance.BorderSize = 2;
            this.ButtonAverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAverage.Location = new System.Drawing.Point(297, 279);
            this.ButtonAverage.Name = "ButtonAverage";
            this.ButtonAverage.Size = new System.Drawing.Size(123, 25);
            this.ButtonAverage.TabIndex = 15;
            this.ButtonAverage.Text = "Average";
            this.ButtonAverage.UseVisualStyleBackColor = false;
            // 
            // TextBoxAverage
            // 
            this.TextBoxAverage.Location = new System.Drawing.Point(296, 316);
            this.TextBoxAverage.Name = "TextBoxAverage";
            this.TextBoxAverage.Size = new System.Drawing.Size(123, 20);
            this.TextBoxAverage.TabIndex = 16;
            // 
            // ButtonRange
            // 
            this.ButtonRange.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ButtonRange.FlatAppearance.BorderSize = 2;
            this.ButtonRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRange.Location = new System.Drawing.Point(296, 354);
            this.ButtonRange.Name = "ButtonRange";
            this.ButtonRange.Size = new System.Drawing.Size(123, 25);
            this.ButtonRange.TabIndex = 17;
            this.ButtonRange.Text = "Range";
            this.ButtonRange.UseVisualStyleBackColor = false;
            // 
            // TextBoxRange
            // 
            this.TextBoxRange.Location = new System.Drawing.Point(297, 391);
            this.TextBoxRange.Name = "TextBoxRange";
            this.TextBoxRange.Size = new System.Drawing.Size(123, 20);
            this.TextBoxRange.TabIndex = 18;
            // 
            // AstronomicalProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 493);
            this.Controls.Add(this.TextBoxRange);
            this.Controls.Add(this.ButtonRange);
            this.Controls.Add(this.TextBoxAverage);
            this.Controls.Add(this.ButtonAverage);
            this.Controls.Add(this.TextBoxMode);
            this.Controls.Add(this.ButtonMode);
            this.Controls.Add(this.TextBoxMidExtreme);
            this.Controls.Add(this.ButtonMidExtreme);
            this.Controls.Add(this.ButtonSeqSearch);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonAutoFill);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.TextBoxMain);
            this.Controls.Add(this.ListBoxMain);
            this.MinimumSize = new System.Drawing.Size(466, 532);
            this.Name = "AstronomicalProcessingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astronomical Processing";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxMain;
        private System.Windows.Forms.TextBox TextBoxMain;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonAutoFill;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button ButtonSeqSearch;
        private System.Windows.Forms.Button ButtonMidExtreme;
        private System.Windows.Forms.TextBox TextBoxMidExtreme;
        private System.Windows.Forms.Button ButtonMode;
        private System.Windows.Forms.TextBox TextBoxMode;
        private System.Windows.Forms.Button ButtonAverage;
        private System.Windows.Forms.TextBox TextBoxAverage;
        private System.Windows.Forms.Button ButtonRange;
        private System.Windows.Forms.TextBox TextBoxRange;
    }
}


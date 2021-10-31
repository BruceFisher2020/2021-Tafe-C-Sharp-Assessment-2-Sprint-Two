
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
            this.ButtonAverage = new System.Windows.Forms.Button();
            this.TextBoxAverage = new System.Windows.Forms.TextBox();
            this.ButtonRange = new System.Windows.Forms.Button();
            this.TextBoxRange = new System.Windows.Forms.TextBox();
            this.DataLabel = new System.Windows.Forms.Label();
            this.ButtonFindNext = new System.Windows.Forms.Button();
            this.ListBoxMode = new System.Windows.Forms.ListBox();
            this.ButtonSystemConfig = new System.Windows.Forms.Button();
            this.SystemConfigPanel = new System.Windows.Forms.Panel();
            this.ButtonSaveDataSize = new System.Windows.Forms.Button();
            this.TextBoxMaxDataSize = new System.Windows.Forms.TextBox();
            this.LabelMaxDataSize = new System.Windows.Forms.Label();
            this.LabelMinDataSize = new System.Windows.Forms.Label();
            this.TextBoxMinDataSize = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SystemConfigPanel.SuspendLayout();
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
            this.TextBoxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextBoxes_MouseMove);
            // 
            // ButtonSort
            // 
            this.ButtonSort.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ButtonSort.FlatAppearance.BorderSize = 2;
            this.ButtonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSort.Location = new System.Drawing.Point(18, 257);
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
            this.ButtonSearch.Location = new System.Drawing.Point(18, 294);
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
            this.ButtonAutoFill.Location = new System.Drawing.Point(18, 423);
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
            this.ButtonAdd.Location = new System.Drawing.Point(18, 130);
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
            this.ButtonEdit.Location = new System.Drawing.Point(18, 167);
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
            this.ButtonDelete.Location = new System.Drawing.Point(18, 205);
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
            this.LabelTitle.BackColor = System.Drawing.Color.LightSeaGreen;
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
            this.ButtonSeqSearch.Location = new System.Drawing.Point(18, 332);
            this.ButtonSeqSearch.Name = "ButtonSeqSearch";
            this.ButtonSeqSearch.Size = new System.Drawing.Size(123, 25);
            this.ButtonSeqSearch.TabIndex = 10;
            this.ButtonSeqSearch.Text = "Sequential Search";
            this.ButtonSeqSearch.UseVisualStyleBackColor = false;
            this.ButtonSeqSearch.Click += new System.EventHandler(this.ButtonSeqSearch_Click);
            // 
            // ButtonMidExtreme
            // 
            this.ButtonMidExtreme.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ButtonMidExtreme.FlatAppearance.BorderSize = 2;
            this.ButtonMidExtreme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMidExtreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMidExtreme.Location = new System.Drawing.Point(308, 130);
            this.ButtonMidExtreme.Name = "ButtonMidExtreme";
            this.ButtonMidExtreme.Size = new System.Drawing.Size(123, 25);
            this.ButtonMidExtreme.TabIndex = 11;
            this.ButtonMidExtreme.Text = "Mid Extreme";
            this.ButtonMidExtreme.UseVisualStyleBackColor = false;
            this.ButtonMidExtreme.Click += new System.EventHandler(this.ButtonMidExtreme_Click);
            // 
            // TextBoxMidExtreme
            // 
            this.TextBoxMidExtreme.Location = new System.Drawing.Point(308, 158);
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
            this.ButtonMode.Location = new System.Drawing.Point(308, 209);
            this.ButtonMode.Name = "ButtonMode";
            this.ButtonMode.Size = new System.Drawing.Size(123, 25);
            this.ButtonMode.TabIndex = 13;
            this.ButtonMode.Text = "Mode";
            this.ButtonMode.UseVisualStyleBackColor = false;
            this.ButtonMode.Click += new System.EventHandler(this.ButtonMode_Click);
            // 
            // ButtonAverage
            // 
            this.ButtonAverage.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ButtonAverage.FlatAppearance.BorderSize = 2;
            this.ButtonAverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAverage.Location = new System.Drawing.Point(307, 325);
            this.ButtonAverage.Name = "ButtonAverage";
            this.ButtonAverage.Size = new System.Drawing.Size(123, 25);
            this.ButtonAverage.TabIndex = 15;
            this.ButtonAverage.Text = "Average";
            this.ButtonAverage.UseVisualStyleBackColor = false;
            this.ButtonAverage.Click += new System.EventHandler(this.ButtonAverage_Click);
            // 
            // TextBoxAverage
            // 
            this.TextBoxAverage.Location = new System.Drawing.Point(308, 354);
            this.TextBoxAverage.Name = "TextBoxAverage";
            this.TextBoxAverage.Size = new System.Drawing.Size(121, 20);
            this.TextBoxAverage.TabIndex = 16;
            // 
            // ButtonRange
            // 
            this.ButtonRange.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ButtonRange.FlatAppearance.BorderSize = 2;
            this.ButtonRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRange.Location = new System.Drawing.Point(308, 398);
            this.ButtonRange.Name = "ButtonRange";
            this.ButtonRange.Size = new System.Drawing.Size(123, 25);
            this.ButtonRange.TabIndex = 17;
            this.ButtonRange.Text = "Range";
            this.ButtonRange.UseVisualStyleBackColor = false;
            this.ButtonRange.Click += new System.EventHandler(this.ButtonRange_Click);
            // 
            // TextBoxRange
            // 
            this.TextBoxRange.Location = new System.Drawing.Point(308, 426);
            this.TextBoxRange.Name = "TextBoxRange";
            this.TextBoxRange.Size = new System.Drawing.Size(121, 20);
            this.TextBoxRange.TabIndex = 18;
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataLabel.Location = new System.Drawing.Point(308, 237);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Padding = new System.Windows.Forms.Padding(3, 3, 4, 3);
            this.DataLabel.Size = new System.Drawing.Size(122, 21);
            this.DataLabel.TabIndex = 20;
            this.DataLabel.Text = "Data     Frequency";
            // 
            // ButtonFindNext
            // 
            this.ButtonFindNext.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ButtonFindNext.FlatAppearance.BorderSize = 2;
            this.ButtonFindNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFindNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFindNext.Location = new System.Drawing.Point(376, 468);
            this.ButtonFindNext.Name = "ButtonFindNext";
            this.ButtonFindNext.Size = new System.Drawing.Size(74, 25);
            this.ButtonFindNext.TabIndex = 22;
            this.ButtonFindNext.Text = "Find Next";
            this.ButtonFindNext.UseVisualStyleBackColor = false;
            this.ButtonFindNext.Click += new System.EventHandler(this.ButtonFindNext_Click);
            // 
            // ListBoxMode
            // 
            this.ListBoxMode.FormattingEnabled = true;
            this.ListBoxMode.Location = new System.Drawing.Point(308, 258);
            this.ListBoxMode.Name = "ListBoxMode";
            this.ListBoxMode.Size = new System.Drawing.Size(122, 30);
            this.ListBoxMode.TabIndex = 23;
            // 
            // ButtonSystemConfig
            // 
            this.ButtonSystemConfig.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ButtonSystemConfig.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.ButtonSystemConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSystemConfig.ForeColor = System.Drawing.Color.Transparent;
            this.ButtonSystemConfig.Image = global::AstronomicalProcessing.Properties.Resources.SystemSetup25;
            this.ButtonSystemConfig.Location = new System.Drawing.Point(424, 0);
            this.ButtonSystemConfig.Name = "ButtonSystemConfig";
            this.ButtonSystemConfig.Size = new System.Drawing.Size(25, 25);
            this.ButtonSystemConfig.TabIndex = 24;
            this.ButtonSystemConfig.UseVisualStyleBackColor = false;
            this.ButtonSystemConfig.Click += new System.EventHandler(this.ButtonSystemConfig_Click);
            // 
            // SystemConfigPanel
            // 
            this.SystemConfigPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SystemConfigPanel.Controls.Add(this.ButtonSaveDataSize);
            this.SystemConfigPanel.Controls.Add(this.TextBoxMaxDataSize);
            this.SystemConfigPanel.Controls.Add(this.LabelMaxDataSize);
            this.SystemConfigPanel.Controls.Add(this.LabelMinDataSize);
            this.SystemConfigPanel.Controls.Add(this.TextBoxMinDataSize);
            this.SystemConfigPanel.Location = new System.Drawing.Point(0, 0);
            this.SystemConfigPanel.Name = "SystemConfigPanel";
            this.SystemConfigPanel.Size = new System.Drawing.Size(424, 25);
            this.SystemConfigPanel.TabIndex = 25;
            // 
            // ButtonSaveDataSize
            // 
            this.ButtonSaveDataSize.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ButtonSaveDataSize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonSaveDataSize.FlatAppearance.BorderSize = 2;
            this.ButtonSaveDataSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSaveDataSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSaveDataSize.Location = new System.Drawing.Point(348, 1);
            this.ButtonSaveDataSize.Name = "ButtonSaveDataSize";
            this.ButtonSaveDataSize.Size = new System.Drawing.Size(75, 25);
            this.ButtonSaveDataSize.TabIndex = 4;
            this.ButtonSaveDataSize.Text = "Save";
            this.ButtonSaveDataSize.UseVisualStyleBackColor = false;
            this.ButtonSaveDataSize.Click += new System.EventHandler(this.ButtonSaveDataSize_Click);
            // 
            // TextBoxMaxDataSize
            // 
            this.TextBoxMaxDataSize.Location = new System.Drawing.Point(258, 2);
            this.TextBoxMaxDataSize.Name = "TextBoxMaxDataSize";
            this.TextBoxMaxDataSize.Size = new System.Drawing.Size(70, 20);
            this.TextBoxMaxDataSize.TabIndex = 3;
            this.TextBoxMaxDataSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInput_KeyPress);
            this.TextBoxMaxDataSize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextBoxes_MouseMove);
            // 
            // LabelMaxDataSize
            // 
            this.LabelMaxDataSize.AutoSize = true;
            this.LabelMaxDataSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMaxDataSize.Location = new System.Drawing.Point(169, 6);
            this.LabelMaxDataSize.Name = "LabelMaxDataSize";
            this.LabelMaxDataSize.Size = new System.Drawing.Size(89, 13);
            this.LabelMaxDataSize.TabIndex = 2;
            this.LabelMaxDataSize.Text = "Max Data Size";
            // 
            // LabelMinDataSize
            // 
            this.LabelMinDataSize.AutoSize = true;
            this.LabelMinDataSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMinDataSize.Location = new System.Drawing.Point(4, 6);
            this.LabelMinDataSize.Name = "LabelMinDataSize";
            this.LabelMinDataSize.Size = new System.Drawing.Size(86, 13);
            this.LabelMinDataSize.TabIndex = 1;
            this.LabelMinDataSize.Text = "Min Data Size";
            // 
            // TextBoxMinDataSize
            // 
            this.TextBoxMinDataSize.Location = new System.Drawing.Point(91, 3);
            this.TextBoxMinDataSize.Name = "TextBoxMinDataSize";
            this.TextBoxMinDataSize.Size = new System.Drawing.Size(70, 20);
            this.TextBoxMinDataSize.TabIndex = 0;
            this.TextBoxMinDataSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInput_KeyPress);
            this.TextBoxMinDataSize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextBoxes_MouseMove);
            // 
            // AstronomicalProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 493);
            this.Controls.Add(this.SystemConfigPanel);
            this.Controls.Add(this.ButtonSystemConfig);
            this.Controls.Add(this.ListBoxMode);
            this.Controls.Add(this.ButtonFindNext);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.TextBoxRange);
            this.Controls.Add(this.ButtonRange);
            this.Controls.Add(this.TextBoxAverage);
            this.Controls.Add(this.ButtonAverage);
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
            this.SystemConfigPanel.ResumeLayout(false);
            this.SystemConfigPanel.PerformLayout();
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
        private System.Windows.Forms.Button ButtonAverage;
        private System.Windows.Forms.TextBox TextBoxAverage;
        private System.Windows.Forms.Button ButtonRange;
        private System.Windows.Forms.TextBox TextBoxRange;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Button ButtonFindNext;
        private System.Windows.Forms.ListBox ListBoxMode;
        private System.Windows.Forms.Button ButtonSystemConfig;
        private System.Windows.Forms.Panel SystemConfigPanel;
        private System.Windows.Forms.Label LabelMinDataSize;
        private System.Windows.Forms.TextBox TextBoxMinDataSize;
        private System.Windows.Forms.Button ButtonSaveDataSize;
        private System.Windows.Forms.TextBox TextBoxMaxDataSize;
        private System.Windows.Forms.Label LabelMaxDataSize;
    }
}


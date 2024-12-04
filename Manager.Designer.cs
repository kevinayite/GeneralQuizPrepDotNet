namespace GeneralQuiz
{
    partial class Manager
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
            this.Candidates = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.comboBoxRequest = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCampaign = new System.Windows.Forms.ComboBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBoxMarks = new System.Windows.Forms.TextBox();
            this.textBoxNames = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCampaigns = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Candidates)).BeginInit();
            this.SuspendLayout();
            // 
            // Candidates
            // 
            this.Candidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Candidates.Location = new System.Drawing.Point(12, 389);
            this.Candidates.Name = "Candidates";
            this.Candidates.Size = new System.Drawing.Size(727, 150);
            this.Candidates.TabIndex = 0;
            this.Candidates.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Candidates_CellClick);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(377, 44);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 1;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // comboBoxRequest
            // 
            this.comboBoxRequest.FormattingEnabled = true;
            this.comboBoxRequest.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Denied"});
            this.comboBoxRequest.Location = new System.Drawing.Point(227, 324);
            this.comboBoxRequest.Name = "comboBoxRequest";
            this.comboBoxRequest.Size = new System.Drawing.Size(100, 21);
            this.comboBoxRequest.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Request";
            // 
            // comboBoxCampaign
            // 
            this.comboBoxCampaign.FormattingEnabled = true;
            this.comboBoxCampaign.Items.AddRange(new object[] {
            "AUCASA Guild President",
            "AUCA sports Minister",
            "AUCA International Stud Minister",
            "AUCA club minister"});
            this.comboBoxCampaign.Location = new System.Drawing.Point(227, 208);
            this.comboBoxCampaign.Name = "comboBoxCampaign";
            this.comboBoxCampaign.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCampaign.TabIndex = 24;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBoxGender.Location = new System.Drawing.Point(227, 148);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(100, 21);
            this.comboBoxGender.TabIndex = 23;
            // 
            // textBoxMarks
            // 
            this.textBoxMarks.Location = new System.Drawing.Point(227, 263);
            this.textBoxMarks.Name = "textBoxMarks";
            this.textBoxMarks.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarks.TabIndex = 22;
            // 
            // textBoxNames
            // 
            this.textBoxNames.Location = new System.Drawing.Point(227, 91);
            this.textBoxNames.Name = "textBoxNames";
            this.textBoxNames.Size = new System.Drawing.Size(100, 20);
            this.textBoxNames.TabIndex = 21;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(227, 46);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Marks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Campaign Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Names";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID";
            // 
            // ButtonReport
            // 
            this.ButtonReport.Location = new System.Drawing.Point(668, 345);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.Size = new System.Drawing.Size(75, 23);
            this.ButtonReport.TabIndex = 27;
            this.ButtonReport.Text = "Report";
            this.ButtonReport.UseVisualStyleBackColor = true;
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Campaigns";
            // 
            // textBoxCampaigns
            // 
            this.textBoxCampaigns.Location = new System.Drawing.Point(619, 46);
            this.textBoxCampaigns.Name = "textBoxCampaigns";
            this.textBoxCampaigns.Size = new System.Drawing.Size(120, 20);
            this.textBoxCampaigns.TabIndex = 29;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(664, 94);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 30;
            this.InsertButton.Text = "Inert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 551);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.textBoxCampaigns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonReport);
            this.Controls.Add(this.comboBoxRequest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxCampaign);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxMarks);
            this.Controls.Add(this.textBoxNames);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.Candidates);
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Candidates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Candidates;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.ComboBox comboBoxRequest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCampaign;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox textBoxMarks;
        private System.Windows.Forms.TextBox textBoxNames;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCampaigns;
        private System.Windows.Forms.Button InsertButton;
    }
}
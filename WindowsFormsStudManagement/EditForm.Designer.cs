namespace WindowsFormsStudManagement
{
    partial class EditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDeditBox = new System.Windows.Forms.TextBox();
            this.NameEditbox = new System.Windows.Forms.TextBox();
            this.RoleEditCombo = new System.Windows.Forms.ComboBox();
            this.GenderEditCombo = new System.Windows.Forms.ComboBox();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Syne", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "*double Click on the Employee to Edit";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(850, 232);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(277, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(277, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(277, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(277, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender";
            // 
            // IDeditBox
            // 
            this.IDeditBox.AccessibleName = "IDeditBox";
            this.IDeditBox.Location = new System.Drawing.Point(423, 298);
            this.IDeditBox.Name = "IDeditBox";
            this.IDeditBox.Size = new System.Drawing.Size(121, 22);
            this.IDeditBox.TabIndex = 6;
            // 
            // NameEditbox
            // 
            this.NameEditbox.AccessibleName = "NameEditBox";
            this.NameEditbox.Location = new System.Drawing.Point(423, 332);
            this.NameEditbox.Name = "NameEditbox";
            this.NameEditbox.Size = new System.Drawing.Size(150, 22);
            this.NameEditbox.TabIndex = 7;
            // 
            // RoleEditCombo
            // 
            this.RoleEditCombo.AccessibleName = "RoleEditCombo";
            this.RoleEditCombo.FormattingEnabled = true;
            this.RoleEditCombo.Items.AddRange(new object[] {
            "HR",
            "Finance",
            "IT",
            "Marketing"});
            this.RoleEditCombo.Location = new System.Drawing.Point(423, 362);
            this.RoleEditCombo.Name = "RoleEditCombo";
            this.RoleEditCombo.Size = new System.Drawing.Size(150, 24);
            this.RoleEditCombo.TabIndex = 8;
            // 
            // GenderEditCombo
            // 
            this.GenderEditCombo.AccessibleName = "GenderEditCombo";
            this.GenderEditCombo.FormattingEnabled = true;
            this.GenderEditCombo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderEditCombo.Location = new System.Drawing.Point(423, 396);
            this.GenderEditCombo.Name = "GenderEditCombo";
            this.GenderEditCombo.Size = new System.Drawing.Size(150, 24);
            this.GenderEditCombo.TabIndex = 9;
            // 
            // Updatebutton
            // 
            this.Updatebutton.AccessibleName = "UpdateButton";
            this.Updatebutton.BackColor = System.Drawing.Color.LightBlue;
            this.Updatebutton.Font = new System.Drawing.Font("Syne", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.Location = new System.Drawing.Point(317, 447);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(97, 43);
            this.Updatebutton.TabIndex = 10;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.PowderBlue;
            this.DeleteButton.Font = new System.Drawing.Font("Syne", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(435, 446);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(97, 44);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(884, 519);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.GenderEditCombo);
            this.Controls.Add(this.RoleEditCombo);
            this.Controls.Add(this.NameEditbox);
            this.Controls.Add(this.IDeditBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDeditBox;
        private System.Windows.Forms.TextBox NameEditbox;
        private System.Windows.Forms.ComboBox RoleEditCombo;
        private System.Windows.Forms.ComboBox GenderEditCombo;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button DeleteButton;
    }
}
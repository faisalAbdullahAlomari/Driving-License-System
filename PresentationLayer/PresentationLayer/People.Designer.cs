namespace PresentationLayer
{
    partial class People
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(People));
            lvPeople = new ListView();
            btnClose = new Button();
            btnAddNewPerson = new Button();
            label1 = new Label();
            cbFilterBy = new ComboBox();
            lblCountRecords = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lvPeople
            // 
            lvPeople.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lvPeople.Location = new Point(12, 118);
            lvPeople.Name = "lvPeople";
            lvPeople.Size = new Size(890, 306);
            lvPeople.TabIndex = 0;
            lvPeople.UseCompatibleStateImageBehavior = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(827, 439);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 33);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNewPerson.FlatAppearance.BorderSize = 0;
            btnAddNewPerson.FlatStyle = FlatStyle.Flat;
            btnAddNewPerson.Image = (Image)resources.GetObject("btnAddNewPerson.Image");
            btnAddNewPerson.Location = new Point(856, 54);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new Size(46, 48);
            btnAddNewPerson.TabIndex = 2;
            btnAddNewPerson.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Location = new Point(74, 79);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(150, 23);
            cbFilterBy.TabIndex = 4;
            // 
            // lblCountRecords
            // 
            lblCountRecords.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCountRecords.AutoSize = true;
            lblCountRecords.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountRecords.Location = new Point(12, 448);
            lblCountRecords.Name = "lblCountRecords";
            lblCountRecords.Size = new Size(65, 15);
            lblCountRecords.TabIndex = 5;
            lblCountRecords.Text = "# Records:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(362, 25);
            label3.Name = "label3";
            label3.Size = new Size(190, 32);
            label3.TabIndex = 6;
            label3.Text = "Manage People";
            // 
            // People
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 480);
            Controls.Add(label3);
            Controls.Add(lblCountRecords);
            Controls.Add(cbFilterBy);
            Controls.Add(label1);
            Controls.Add(btnAddNewPerson);
            Controls.Add(btnClose);
            Controls.Add(lvPeople);
            MinimumSize = new Size(850, 500);
            Name = "People";
            Text = "Form1";
            Load += People_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvPeople;
        private Button btnClose;
        private Button btnAddNewPerson;
        private Label label1;
        private ComboBox cbFilterBy;
        private Label lblCountRecords;
        private Label label3;
    }
}

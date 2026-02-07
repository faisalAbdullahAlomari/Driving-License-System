namespace PresentationLayer
{
    partial class AddNewAndUpdatePerson
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
            ctrlAddAndUpdatePerson1 = new ctrlAddAndUpdatePerson();
            SuspendLayout();
            // 
            // ctrlAddAndUpdatePerson1
            // 
            ctrlAddAndUpdatePerson1.BorderStyle = BorderStyle.FixedSingle;
            ctrlAddAndUpdatePerson1.Location = new Point(16, 90);
            ctrlAddAndUpdatePerson1.Name = "ctrlAddAndUpdatePerson1";
            ctrlAddAndUpdatePerson1.Size = new Size(842, 405);
            ctrlAddAndUpdatePerson1.TabIndex = 0;
            // 
            // AddNewAndUpdatePerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 507);
            Controls.Add(ctrlAddAndUpdatePerson1);
            MaximumSize = new Size(890, 546);
            MinimumSize = new Size(890, 546);
            Name = "AddNewAndUpdatePerson";
            Text = "AddNewAndUpdatePerson";
            ResumeLayout(false);
        }

        #endregion

        private ctrlAddAndUpdatePerson ctrlAddAndUpdatePerson1;
    }
}
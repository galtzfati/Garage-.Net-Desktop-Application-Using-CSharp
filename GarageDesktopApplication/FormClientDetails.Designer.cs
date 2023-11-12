namespace GarageDesktopApplication
{
    partial class FormClientDetails
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
            labelName = new System.Windows.Forms.Label();
            labelId = new System.Windows.Forms.Label();
            labelPhoneNumber = new System.Windows.Forms.Label();
            regexTextBoxName = new Proxies.RegexTextBox();
            regexTextBoxPhoneNumber = new Proxies.RegexTextBox();
            regexTextBoxId = new Proxies.RegexTextBox();
            buttonUpdate = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new System.Drawing.Point(12, 36);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(63, 25);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new System.Drawing.Point(12, 81);
            labelId.Name = "labelId";
            labelId.Size = new System.Drawing.Size(34, 25);
            labelId.TabIndex = 1;
            labelId.Text = "ID:";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new System.Drawing.Point(12, 126);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new System.Drawing.Size(136, 25);
            labelPhoneNumber.TabIndex = 2;
            labelPhoneNumber.Text = "Phone Number:";
            // 
            // regexTextBoxName
            // 
            regexTextBoxName.Location = new System.Drawing.Point(190, 33);
            regexTextBoxName.Name = "regexTextBoxName";
            regexTextBoxName.RegexPattern = "^[a-zA-Z \\b]*$";
            regexTextBoxName.Size = new System.Drawing.Size(177, 31);
            regexTextBoxName.TabIndex = 0;
            // 
            // regexTextBoxPhoneNumber
            // 
            regexTextBoxPhoneNumber.Location = new System.Drawing.Point(190, 123);
            regexTextBoxPhoneNumber.Name = "regexTextBoxPhoneNumber";
            regexTextBoxPhoneNumber.RegexPattern = "^[0-9\\b]*$";
            regexTextBoxPhoneNumber.Size = new System.Drawing.Size(177, 31);
            regexTextBoxPhoneNumber.TabIndex = 2;
            // 
            // regexTextBoxId
            // 
            regexTextBoxId.Location = new System.Drawing.Point(190, 78);
            regexTextBoxId.Name = "regexTextBoxId";
            regexTextBoxId.RegexPattern = "^[0-9\\b]*$";
            regexTextBoxId.Size = new System.Drawing.Size(177, 31);
            regexTextBoxId.TabIndex = 1;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new System.Drawing.Point(129, 176);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(120, 52);
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // FormClientDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(379, 240);
            Controls.Add(buttonUpdate);
            Controls.Add(regexTextBoxId);
            Controls.Add(regexTextBoxPhoneNumber);
            Controls.Add(regexTextBoxName);
            Controls.Add(labelPhoneNumber);
            Controls.Add(labelId);
            Controls.Add(labelName);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "FormClientDetails";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Client Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelPhoneNumber;
        private Proxies.RegexTextBox regexTextBoxName;
        private Proxies.RegexTextBox regexTextBoxPhoneNumber;
        private Proxies.RegexTextBox regexTextBoxId;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
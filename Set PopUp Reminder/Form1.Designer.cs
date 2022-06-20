namespace Set_PopUp_Reminder
{
    partial class FormPopUpReminder
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
            this.TextBoxInformation = new System.Windows.Forms.TextBox();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelInformation = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.ButtonSetReminder = new System.Windows.Forms.Button();
            this.DateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TextBoxInformation
            // 
            this.TextBoxInformation.Location = new System.Drawing.Point(12, 163);
            this.TextBoxInformation.MaxLength = 100;
            this.TextBoxInformation.Name = "TextBoxInformation";
            this.TextBoxInformation.Size = new System.Drawing.Size(351, 22);
            this.TextBoxInformation.TabIndex = 1;
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Location = new System.Drawing.Point(12, 97);
            this.TextBoxTitle.MaxLength = 35;
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(168, 22);
            this.TextBoxTitle.TabIndex = 0;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitle.Font = new System.Drawing.Font("Georgia Pro Cond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelTitle.Location = new System.Drawing.Point(12, 74);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(45, 20);
            this.LabelTitle.TabIndex = 5;
            this.LabelTitle.Text = "Title";
            // 
            // LabelInformation
            // 
            this.LabelInformation.AutoSize = true;
            this.LabelInformation.BackColor = System.Drawing.Color.Transparent;
            this.LabelInformation.Font = new System.Drawing.Font("Georgia Pro Cond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInformation.Location = new System.Drawing.Point(12, 140);
            this.LabelInformation.Name = "LabelInformation";
            this.LabelInformation.Size = new System.Drawing.Size(106, 20);
            this.LabelInformation.TabIndex = 6;
            this.LabelInformation.Text = "Information";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "PopUp Reminder";
            this.notifyIcon1.Visible = true;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(12, 234);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(252, 22);
            this.DateTimePicker.TabIndex = 3;
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.BackColor = System.Drawing.Color.Transparent;
            this.LabelDate.Font = new System.Drawing.Font("Georgia Pro Cond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelDate.Location = new System.Drawing.Point(12, 211);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(46, 20);
            this.LabelDate.TabIndex = 8;
            this.LabelDate.Text = "Date";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.BackColor = System.Drawing.Color.Transparent;
            this.LabelTime.Font = new System.Drawing.Font("Georgia Pro Cond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelTime.Location = new System.Drawing.Point(270, 211);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(49, 20);
            this.LabelTime.TabIndex = 10;
            this.LabelTime.Text = "Time";
            // 
            // ButtonSetReminder
            // 
            this.ButtonSetReminder.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonSetReminder.Font = new System.Drawing.Font("Georgia Pro Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSetReminder.Location = new System.Drawing.Point(12, 12);
            this.ButtonSetReminder.Name = "ButtonSetReminder";
            this.ButtonSetReminder.Size = new System.Drawing.Size(123, 33);
            this.ButtonSetReminder.TabIndex = 2;
            this.ButtonSetReminder.Text = "Set Reminder";
            this.ButtonSetReminder.UseVisualStyleBackColor = true;
            this.ButtonSetReminder.Click += new System.EventHandler(this.ButtonSetReminder_Click);
            // 
            // DateTimePickerTime
            // 
            this.DateTimePickerTime.CustomFormat = "";
            this.DateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DateTimePickerTime.Location = new System.Drawing.Point(270, 234);
            this.DateTimePickerTime.Name = "DateTimePickerTime";
            this.DateTimePickerTime.Size = new System.Drawing.Size(93, 22);
            this.DateTimePickerTime.TabIndex = 11;
            this.DateTimePickerTime.ValueChanged += new System.EventHandler(this.DateTimePickerTime_ValueChanged);
            // 
            // FormPopUpReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(473, 310);
            this.Controls.Add(this.DateTimePickerTime);
            this.Controls.Add(this.ButtonSetReminder);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.LabelInformation);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.TextBoxInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPopUpReminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUp Reminder";
            this.Load += new System.EventHandler(this.FormPopUpReminder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxInformation;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelInformation;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Button ButtonSetReminder;
        private System.Windows.Forms.DateTimePicker DateTimePickerTime;
    }
}


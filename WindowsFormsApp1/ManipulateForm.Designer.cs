
namespace WindowsFormsApp1
{
    partial class ManipulateForm
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
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelManipulateButton = new System.Windows.Forms.Button();
            this.BirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PositionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(12, 20);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(230, 20);
            this.FirstNameTextBox.TabIndex = 0;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(12, 75);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(230, 20);
            this.SurnameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(12, 123);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(230, 20);
            this.LastNameTextBox.TabIndex = 2;
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(12, 263);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelManipulateButton
            // 
            this.CancelManipulateButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelManipulateButton.Location = new System.Drawing.Point(93, 263);
            this.CancelManipulateButton.Name = "CancelManipulateButton";
            this.CancelManipulateButton.Size = new System.Drawing.Size(75, 23);
            this.CancelManipulateButton.TabIndex = 6;
            this.CancelManipulateButton.Text = "Cancel";
            this.CancelManipulateButton.UseVisualStyleBackColor = true;
            // 
            // BirthTimePicker
            // 
            this.BirthTimePicker.Location = new System.Drawing.Point(12, 172);
            this.BirthTimePicker.Name = "BirthTimePicker";
            this.BirthTimePicker.Size = new System.Drawing.Size(230, 20);
            this.BirthTimePicker.TabIndex = 7;
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.Items.AddRange(new object[] {
            "Программист",
            "Доставка пиццы",
            "Поедатель еды",
            "Приколист"});
            this.PositionComboBox.Location = new System.Drawing.Point(12, 222);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(230, 21);
            this.PositionComboBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Должность";
            // 
            // ManipulateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 303);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PositionComboBox);
            this.Controls.Add(this.BirthTimePicker);
            this.Controls.Add(this.CancelManipulateButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Name = "ManipulateForm";
            this.Text = "ManipulateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.TextBox FirstNameTextBox;
        protected internal System.Windows.Forms.TextBox SurnameTextBox;
        protected internal System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelManipulateButton;
        protected internal System.Windows.Forms.DateTimePicker BirthTimePicker;
        protected internal System.Windows.Forms.ComboBox PositionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
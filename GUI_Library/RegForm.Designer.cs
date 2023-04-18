namespace GUI_Library
{
    partial class RegForm
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
            label1 = new Label();
            RegisterButton = new Button();
            loginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            passField = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            wayToLogLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(119, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 45);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = SystemColors.ControlLight;
            RegisterButton.FlatAppearance.BorderSize = 0;
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterButton.Location = new Point(119, 272);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(188, 35);
            RegisterButton.TabIndex = 5;
            RegisterButton.Text = "Зарегистрироваться";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // loginField
            // 
            loginField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            loginField.Location = new Point(152, 138);
            loginField.Name = "loginField";
            loginField.Size = new Size(179, 32);
            loginField.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._285655_user_icon;
            pictureBox1.Location = new Point(67, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(wayToLogLabel);
            panel1.Controls.Add(RegisterButton);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 365);
            panel1.TabIndex = 1;
            // 
            // passField
            // 
            passField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            passField.Location = new Point(152, 208);
            passField.Name = "passField";
            passField.Size = new Size(179, 32);
            passField.TabIndex = 4;
            passField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._299105_lock_icon;
            pictureBox2.Location = new Point(67, 176);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(441, 100);
            panel2.TabIndex = 0;
            // 
            // wayToLogLabel
            // 
            wayToLogLabel.AutoSize = true;
            wayToLogLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            wayToLogLabel.ForeColor = Color.Black;
            wayToLogLabel.Location = new Point(152, 321);
            wayToLogLabel.Name = "wayToLogLabel";
            wayToLogLabel.Size = new Size(126, 17);
            wayToLogLabel.TabIndex = 7;
            wayToLogLabel.Text = "Уже есть аккаунт?";
            wayToLogLabel.Click += wayToLogLabel_Click;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 365);
            Controls.Add(panel1);
            Name = "RegForm";
            Text = "RegForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button RegisterButton;
        private TextBox loginField;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox passField;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label wayToLogLabel;
    }
}
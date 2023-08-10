namespace Symmetric_Encryption
{
    partial class Form1
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
            algorithmComboBox = new ComboBox();
            GenerateButton = new Button();
            EncryptButton = new Button();
            DecryptButton = new Button();
            EncryptTimeButton = new Button();
            DecryptTimeButton = new Button();
            KeyASCIITextBox = new TextBox();
            IVHexTextBox = new TextBox();
            plainASCIITextBox = new TextBox();
            plainHexTextBox = new TextBox();
            cipherASCIITextBox = new TextBox();
            cipherHexTextBox = new TextBox();
            keyLabel = new Label();
            plainTextLabel = new Label();
            cipherTextLabel = new Label();
            encryptionTimeLabel = new Label();
            decryptionTimeLabel = new Label();
            IVASCIITextBox = new TextBox();
            KeyHexTextBox = new TextBox();
            IVLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            EncryptionTimeTextlabel = new Label();
            DecryptionTimeTextlabel = new Label();
            SuspendLayout();
            // 
            // algorithmComboBox
            // 
            algorithmComboBox.FormattingEnabled = true;
            algorithmComboBox.Items.AddRange(new object[] { "DES", "TDES" });
            algorithmComboBox.Location = new Point(35, 10);
            algorithmComboBox.Name = "algorithmComboBox";
            algorithmComboBox.Size = new Size(151, 28);
            algorithmComboBox.TabIndex = 0;
            // 
            // GenerateButton
            // 
            GenerateButton.Location = new Point(35, 53);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(151, 39);
            GenerateButton.TabIndex = 1;
            GenerateButton.Text = "Generate key and IV";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // EncryptButton
            // 
            EncryptButton.Location = new Point(35, 117);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new Size(151, 39);
            EncryptButton.TabIndex = 2;
            EncryptButton.Text = "Encrypt";
            EncryptButton.UseVisualStyleBackColor = true;
            EncryptButton.Click += EncryptButton_Click;
            // 
            // DecryptButton
            // 
            DecryptButton.Location = new Point(35, 162);
            DecryptButton.Name = "DecryptButton";
            DecryptButton.Size = new Size(151, 39);
            DecryptButton.TabIndex = 3;
            DecryptButton.Text = "Decrypt";
            DecryptButton.UseVisualStyleBackColor = true;
            DecryptButton.Click += DecryptButton_Click;
            // 
            // EncryptTimeButton
            // 
            EncryptTimeButton.Location = new Point(35, 344);
            EncryptTimeButton.Name = "EncryptTimeButton";
            EncryptTimeButton.Size = new Size(151, 39);
            EncryptTimeButton.TabIndex = 4;
            EncryptTimeButton.Text = "Get encyption time";
            EncryptTimeButton.UseVisualStyleBackColor = true;
            EncryptTimeButton.Click += EncryptTimeButton_Click;
            // 
            // DecryptTimeButton
            // 
            DecryptTimeButton.Location = new Point(35, 389);
            DecryptTimeButton.Name = "DecryptTimeButton";
            DecryptTimeButton.Size = new Size(151, 39);
            DecryptTimeButton.TabIndex = 5;
            DecryptTimeButton.Text = "Get decrypt time";
            DecryptTimeButton.UseVisualStyleBackColor = true;
            DecryptTimeButton.Click += DecryptTimeButton_Click;
            // 
            // KeyASCIITextBox
            // 
            KeyASCIITextBox.Location = new Point(300, 14);
            KeyASCIITextBox.Name = "KeyASCIITextBox";
            KeyASCIITextBox.Size = new Size(488, 27);
            KeyASCIITextBox.TabIndex = 6;
            // 
            // IVHexTextBox
            // 
            IVHexTextBox.Location = new Point(300, 129);
            IVHexTextBox.Name = "IVHexTextBox";
            IVHexTextBox.Size = new Size(488, 27);
            IVHexTextBox.TabIndex = 7;
            // 
            // plainASCIITextBox
            // 
            plainASCIITextBox.Location = new Point(300, 192);
            plainASCIITextBox.Name = "plainASCIITextBox";
            plainASCIITextBox.Size = new Size(488, 27);
            plainASCIITextBox.TabIndex = 8;
            // 
            // plainHexTextBox
            // 
            plainHexTextBox.Location = new Point(300, 225);
            plainHexTextBox.Name = "plainHexTextBox";
            plainHexTextBox.Size = new Size(488, 27);
            plainHexTextBox.TabIndex = 9;
            // 
            // cipherASCIITextBox
            // 
            cipherASCIITextBox.Location = new Point(300, 278);
            cipherASCIITextBox.Name = "cipherASCIITextBox";
            cipherASCIITextBox.Size = new Size(488, 27);
            cipherASCIITextBox.TabIndex = 10;
            // 
            // cipherHexTextBox
            // 
            cipherHexTextBox.Location = new Point(300, 311);
            cipherHexTextBox.Name = "cipherHexTextBox";
            cipherHexTextBox.Size = new Size(488, 27);
            cipherHexTextBox.TabIndex = 11;
            // 
            // keyLabel
            // 
            keyLabel.AutoSize = true;
            keyLabel.Location = new Point(539, -9);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new Size(33, 20);
            keyLabel.TabIndex = 12;
            keyLabel.Text = "Key";
            // 
            // plainTextLabel
            // 
            plainTextLabel.AutoSize = true;
            plainTextLabel.Location = new Point(514, 169);
            plainTextLabel.Name = "plainTextLabel";
            plainTextLabel.Size = new Size(72, 20);
            plainTextLabel.TabIndex = 14;
            plainTextLabel.Text = "Plain Text";
            // 
            // cipherTextLabel
            // 
            cipherTextLabel.AutoSize = true;
            cipherTextLabel.Location = new Point(514, 255);
            cipherTextLabel.Name = "cipherTextLabel";
            cipherTextLabel.Size = new Size(83, 20);
            cipherTextLabel.TabIndex = 15;
            cipherTextLabel.Text = "Cipher Text";
            // 
            // encryptionTimeLabel
            // 
            encryptionTimeLabel.AutoSize = true;
            encryptionTimeLabel.Location = new Point(300, 353);
            encryptionTimeLabel.Name = "encryptionTimeLabel";
            encryptionTimeLabel.Size = new Size(116, 20);
            encryptionTimeLabel.TabIndex = 16;
            encryptionTimeLabel.Text = "Encryption Time";
            // 
            // decryptionTimeLabel
            // 
            decryptionTimeLabel.AutoSize = true;
            decryptionTimeLabel.Location = new Point(589, 353);
            decryptionTimeLabel.Name = "decryptionTimeLabel";
            decryptionTimeLabel.Size = new Size(119, 20);
            decryptionTimeLabel.TabIndex = 17;
            decryptionTimeLabel.Text = "Decryption Time";
            // 
            // IVASCIITextBox
            // 
            IVASCIITextBox.Location = new Point(300, 96);
            IVASCIITextBox.Name = "IVASCIITextBox";
            IVASCIITextBox.Size = new Size(488, 27);
            IVASCIITextBox.TabIndex = 18;
            // 
            // KeyHexTextBox
            // 
            KeyHexTextBox.Location = new Point(300, 47);
            KeyHexTextBox.Name = "KeyHexTextBox";
            KeyHexTextBox.Size = new Size(488, 27);
            KeyHexTextBox.TabIndex = 19;
            // 
            // IVLabel
            // 
            IVLabel.AutoSize = true;
            IVLabel.Location = new Point(539, 72);
            IVLabel.Name = "IVLabel";
            IVLabel.Size = new Size(22, 20);
            IVLabel.TabIndex = 20;
            IVLabel.Text = "IV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 18);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 21;
            label1.Text = "ASCII";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 96);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 22;
            label2.Text = "ASCII";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 192);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 23;
            label3.Text = "ASCII";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 278);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 24;
            label4.Text = "ASCII";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 50);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 25;
            label5.Text = "Hex";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 132);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 26;
            label6.Text = "Hex";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(250, 225);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 27;
            label7.Text = "Hex";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(250, 311);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 28;
            label8.Text = "Hex";
            // 
            // EncryptionTimeTextlabel
            // 
            EncryptionTimeTextlabel.Location = new Point(300, 389);
            EncryptionTimeTextlabel.Name = "EncryptionTimeTextlabel";
            EncryptionTimeTextlabel.Size = new Size(116, 39);
            EncryptionTimeTextlabel.TabIndex = 30;
            // 
            // DecryptionTimeTextlabel
            // 
            DecryptionTimeTextlabel.Location = new Point(589, 389);
            DecryptionTimeTextlabel.Name = "DecryptionTimeTextlabel";
            DecryptionTimeTextlabel.Size = new Size(116, 39);
            DecryptionTimeTextlabel.TabIndex = 31;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DecryptionTimeTextlabel);
            Controls.Add(EncryptionTimeTextlabel);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(IVLabel);
            Controls.Add(KeyHexTextBox);
            Controls.Add(IVASCIITextBox);
            Controls.Add(decryptionTimeLabel);
            Controls.Add(encryptionTimeLabel);
            Controls.Add(cipherTextLabel);
            Controls.Add(plainTextLabel);
            Controls.Add(keyLabel);
            Controls.Add(cipherHexTextBox);
            Controls.Add(cipherASCIITextBox);
            Controls.Add(plainHexTextBox);
            Controls.Add(plainASCIITextBox);
            Controls.Add(IVHexTextBox);
            Controls.Add(KeyASCIITextBox);
            Controls.Add(DecryptTimeButton);
            Controls.Add(EncryptTimeButton);
            Controls.Add(DecryptButton);
            Controls.Add(EncryptButton);
            Controls.Add(GenerateButton);
            Controls.Add(algorithmComboBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox algorithmComboBox;
        private Button GenerateButton;
        private Button EncryptButton;
        private Button DecryptButton;
        private Button EncryptTimeButton;
        private Button DecryptTimeButton;
        private TextBox KeyASCIITextBox;
        private TextBox IVHexTextBox;
        private TextBox plainASCIITextBox;
        private TextBox plainHexTextBox;
        private TextBox cipherASCIITextBox;
        private TextBox cipherHexTextBox;
        private Label keyLabel;
        private Label iVLabel;
        private Label plainTextLabel;
        private Label cipherTextLabel;
        private Label encryptionTimeLabel;
        private Label decryptionTimeLabel;
        private TextBox IVASCIITextBox;
        private TextBox KeyHexTextBox;
        private Label IVLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label EncryptionTimeTextlabel;
        private Label DecryptionTimeTextlabel;
    }
}
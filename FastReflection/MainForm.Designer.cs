namespace FastReflection
{
    partial class MainForm
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
            this.Test1Button = new System.Windows.Forms.Button();
            this.Test2Button = new System.Windows.Forms.Button();
            this.ByeButton = new System.Windows.Forms.Button();
            this.ConsoleText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Test3Button = new System.Windows.Forms.Button();
            this.OuterLoopsChooser = new System.Windows.Forms.NumericUpDown();
            this.InnerLoopsChooser = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SerializedText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ReserializedText = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.OuterLoopsChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerLoopsChooser)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Test1Button
            // 
            this.Test1Button.Location = new System.Drawing.Point(373, 27);
            this.Test1Button.Name = "Test1Button";
            this.Test1Button.Size = new System.Drawing.Size(64, 23);
            this.Test1Button.TabIndex = 0;
            this.Test1Button.Text = "Test #1";
            this.Test1Button.UseVisualStyleBackColor = true;
            this.Test1Button.Click += new System.EventHandler(this.Test1Button_Click);
            // 
            // Test2Button
            // 
            this.Test2Button.Location = new System.Drawing.Point(443, 27);
            this.Test2Button.Name = "Test2Button";
            this.Test2Button.Size = new System.Drawing.Size(64, 23);
            this.Test2Button.TabIndex = 1;
            this.Test2Button.Text = "Test #2";
            this.Test2Button.UseVisualStyleBackColor = true;
            this.Test2Button.Click += new System.EventHandler(this.Test2Button_Click);
            // 
            // ByeButton
            // 
            this.ByeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ByeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ByeButton.Location = new System.Drawing.Point(505, 567);
            this.ByeButton.Name = "ByeButton";
            this.ByeButton.Size = new System.Drawing.Size(75, 23);
            this.ByeButton.TabIndex = 2;
            this.ByeButton.Text = "Exit";
            this.ByeButton.UseVisualStyleBackColor = true;
            this.ByeButton.Click += new System.EventHandler(this.ByeButton_Click);
            // 
            // ConsoleText
            // 
            this.ConsoleText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsoleText.Location = new System.Drawing.Point(12, 79);
            this.ConsoleText.Multiline = true;
            this.ConsoleText.Name = "ConsoleText";
            this.ConsoleText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConsoleText.Size = new System.Drawing.Size(568, 74);
            this.ConsoleText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Console";
            // 
            // Test3Button
            // 
            this.Test3Button.Location = new System.Drawing.Point(513, 27);
            this.Test3Button.Name = "Test3Button";
            this.Test3Button.Size = new System.Drawing.Size(64, 23);
            this.Test3Button.TabIndex = 1;
            this.Test3Button.Text = "Test #3";
            this.Test3Button.UseVisualStyleBackColor = true;
            this.Test3Button.Click += new System.EventHandler(this.Test3Button_Click);
            // 
            // OuterLoopsChooser
            // 
            this.OuterLoopsChooser.Location = new System.Drawing.Point(15, 27);
            this.OuterLoopsChooser.Name = "OuterLoopsChooser";
            this.OuterLoopsChooser.Size = new System.Drawing.Size(69, 22);
            this.OuterLoopsChooser.TabIndex = 7;
            this.OuterLoopsChooser.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.OuterLoopsChooser.ValueChanged += new System.EventHandler(this.OuterLoopsChooser_ValueChanged);
            // 
            // InnerLoopsChooser
            // 
            this.InnerLoopsChooser.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.InnerLoopsChooser.Location = new System.Drawing.Point(90, 27);
            this.InnerLoopsChooser.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.InnerLoopsChooser.Name = "InnerLoopsChooser";
            this.InnerLoopsChooser.Size = new System.Drawing.Size(67, 22);
            this.InnerLoopsChooser.TabIndex = 8;
            this.InnerLoopsChooser.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.InnerLoopsChooser.ValueChanged += new System.EventHandler(this.InnerLoopsChooser_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Outer Loops";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inner Loops";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Serialized Object";
            // 
            // SerializedText
            // 
            this.SerializedText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SerializedText.Location = new System.Drawing.Point(0, 19);
            this.SerializedText.Multiline = true;
            this.SerializedText.Name = "SerializedText";
            this.SerializedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SerializedText.Size = new System.Drawing.Size(281, 373);
            this.SerializedText.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Re-Serialized Object";
            // 
            // ReserializedText
            // 
            this.ReserializedText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ReserializedText.Location = new System.Drawing.Point(3, 19);
            this.ReserializedText.Multiline = true;
            this.ReserializedText.Name = "ReserializedText";
            this.ReserializedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReserializedText.Size = new System.Drawing.Size(274, 373);
            this.ReserializedText.TabIndex = 12;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 159);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SerializedText);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ReserializedText);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Size = new System.Drawing.Size(568, 395);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ByeButton;
            this.ClientSize = new System.Drawing.Size(592, 602);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InnerLoopsChooser);
            this.Controls.Add(this.OuterLoopsChooser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsoleText);
            this.Controls.Add(this.ByeButton);
            this.Controls.Add(this.Test3Button);
            this.Controls.Add(this.Test2Button);
            this.Controls.Add(this.Test1Button);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Reflection / Serializer Sample";
            ((System.ComponentModel.ISupportInitialize)(this.OuterLoopsChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerLoopsChooser)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Test1Button;
        private System.Windows.Forms.Button Test2Button;
        private System.Windows.Forms.Button ByeButton;
        private System.Windows.Forms.TextBox ConsoleText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Test3Button;
        private System.Windows.Forms.NumericUpDown OuterLoopsChooser;
        private System.Windows.Forms.NumericUpDown InnerLoopsChooser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SerializedText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ReserializedText;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}


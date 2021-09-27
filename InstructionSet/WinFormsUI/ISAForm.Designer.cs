﻿
namespace WinFormsUI {
    partial class ISAForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.stateBox = new System.Windows.Forms.RichTextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.CompileButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stateBox
            // 
            this.stateBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stateBox.BackColor = System.Drawing.SystemColors.Menu;
            this.stateBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateBox.DetectUrls = false;
            this.stateBox.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stateBox.Location = new System.Drawing.Point(1229, 12);
            this.stateBox.Name = "stateBox";
            this.stateBox.ReadOnly = true;
            this.stateBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.stateBox.Size = new System.Drawing.Size(198, 728);
            this.stateBox.TabIndex = 3;
            this.stateBox.Text = "";
            // 
            // RunButton
            // 
            this.RunButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RunButton.BackColor = System.Drawing.SystemColors.Menu;
            this.RunButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RunButton.Location = new System.Drawing.Point(1229, 787);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(92, 32);
            this.RunButton.TabIndex = 4;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.outputBox);
            this.panel1.Controls.Add(this.inputBox);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 807);
            this.panel1.TabIndex = 2;
            // 
            // outputBox
            // 
            this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputBox.DetectUrls = false;
            this.outputBox.Location = new System.Drawing.Point(0, 400);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(1211, 407);
            this.outputBox.TabIndex = 2;
            this.outputBox.Text = "";
            // 
            // inputBox
            // 
            this.inputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputBox.DetectUrls = false;
            this.inputBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.inputBox.Location = new System.Drawing.Point(0, 0);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(1211, 394);
            this.inputBox.TabIndex = 1;
            this.inputBox.Text = "";
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.BackColor = System.Drawing.SystemColors.Menu;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextButton.Location = new System.Drawing.Point(1339, 787);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(88, 32);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next Step";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CompileButton
            // 
            this.CompileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CompileButton.BackColor = System.Drawing.SystemColors.Menu;
            this.CompileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CompileButton.Location = new System.Drawing.Point(1229, 746);
            this.CompileButton.Name = "CompileButton";
            this.CompileButton.Size = new System.Drawing.Size(92, 32);
            this.CompileButton.TabIndex = 6;
            this.CompileButton.Text = "Compile";
            this.CompileButton.UseVisualStyleBackColor = false;
            this.CompileButton.Click += new System.EventHandler(this.CompileButton_Click);
            // 
            // ISAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1439, 831);
            this.Controls.Add(this.CompileButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.stateBox);
            this.MaximumSize = new System.Drawing.Size(1455, 870);
            this.MinimumSize = new System.Drawing.Size(1455, 870);
            this.Name = "ISAForm";
            this.Text = "ISA UI";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox stateBox;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.RichTextBox inputBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button CompileButton;
    }
}


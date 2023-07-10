
using MaterialSkin.Controls;

namespace IllusionWF
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.sleepTimeBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.sizeOffsetBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.resetButton = new System.Windows.Forms.Button();
            this.usePythonBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pythonExePathBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Name = "label1";
            // 
            // sleepTimeBox
            // 
            resources.ApplyResources(this.sleepTimeBox, "sleepTimeBox");
            this.sleepTimeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sleepTimeBox.Depth = 0;
            this.sleepTimeBox.Hint = "";
            this.sleepTimeBox.MaxLength = 32767;
            this.sleepTimeBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.sleepTimeBox.Name = "sleepTimeBox";
            this.sleepTimeBox.PasswordChar = '\0';
            this.sleepTimeBox.SelectedText = "";
            this.sleepTimeBox.SelectionLength = 0;
            this.sleepTimeBox.SelectionStart = 0;
            this.sleepTimeBox.TabStop = false;
            this.sleepTimeBox.UseSystemPasswordChar = false;
            this.sleepTimeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sleepTimeBox_KeyPress);
            // 
            // sizeOffsetBox
            // 
            resources.ApplyResources(this.sizeOffsetBox, "sizeOffsetBox");
            this.sizeOffsetBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sizeOffsetBox.Depth = 0;
            this.sizeOffsetBox.Hint = "";
            this.sizeOffsetBox.MaxLength = 32767;
            this.sizeOffsetBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.sizeOffsetBox.Name = "sizeOffsetBox";
            this.sizeOffsetBox.PasswordChar = '\0';
            this.sizeOffsetBox.SelectedText = "";
            this.sizeOffsetBox.SelectionLength = 0;
            this.sizeOffsetBox.SelectionStart = 0;
            this.sizeOffsetBox.TabStop = false;
            this.sizeOffsetBox.UseSystemPasswordChar = false;
            // 
            // resetButton
            // 
            resources.ApplyResources(this.resetButton, "resetButton");
            this.resetButton.Name = "resetButton";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // usePythonBox
            // 
            resources.ApplyResources(this.usePythonBox, "usePythonBox");
            this.usePythonBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usePythonBox.Name = "usePythonBox";
            this.usePythonBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Name = "label5";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox1.Controls.Add(this.pythonExePathBox);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sizeOffsetBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sleepTimeBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.usePythonBox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // pythonExePathBox
            // 
            resources.ApplyResources(this.pythonExePathBox, "pythonExePathBox");
            this.pythonExePathBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pythonExePathBox.Depth = 0;
            this.pythonExePathBox.Hint = "";
            this.pythonExePathBox.MaxLength = 32767;
            this.pythonExePathBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.pythonExePathBox.Name = "pythonExePathBox";
            this.pythonExePathBox.PasswordChar = '\0';
            this.pythonExePathBox.SelectedText = "";
            this.pythonExePathBox.SelectionLength = 0;
            this.pythonExePathBox.SelectionStart = 0;
            this.pythonExePathBox.TabStop = false;
            this.pythonExePathBox.UseSystemPasswordChar = false;
            this.pythonExePathBox.Click += new System.EventHandler(this.pythonExePathBox_Click);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(183)))), ((int)(((byte)(205)))));
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // Form3
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resetButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Opacity = 0.97D;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField sleepTimeBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField sizeOffsetBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.CheckBox usePythonBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MaterialSingleLineTextField pythonExePathBox;
    }
}
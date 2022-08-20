
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
            this.pythonExePathBox = new System.Windows.Forms.TextBox();
            this.usePythonBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(72, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "等待时长(ms)";
            // 
            // sleepTimeBox
            // 
            this.sleepTimeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sleepTimeBox.Depth = 0;
            this.sleepTimeBox.Hint = "";
            this.sleepTimeBox.Location = new System.Drawing.Point(192, 95);
            this.sleepTimeBox.MaxLength = 32767;
            this.sleepTimeBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.sleepTimeBox.Name = "sleepTimeBox";
            this.sleepTimeBox.PasswordChar = '\0';
            this.sleepTimeBox.SelectedText = "";
            this.sleepTimeBox.SelectionLength = 0;
            this.sleepTimeBox.SelectionStart = 0;
            this.sleepTimeBox.Size = new System.Drawing.Size(357, 23);
            this.sleepTimeBox.TabIndex = 1;
            this.sleepTimeBox.TabStop = false;
            this.sleepTimeBox.UseSystemPasswordChar = false;
            this.sleepTimeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sleepTimeBox_KeyPress);
            // 
            // sizeOffsetBox
            // 
            this.sizeOffsetBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sizeOffsetBox.Depth = 0;
            this.sizeOffsetBox.Hint = "";
            this.sizeOffsetBox.Location = new System.Drawing.Point(480, 159);
            this.sizeOffsetBox.MaxLength = 32767;
            this.sizeOffsetBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.sizeOffsetBox.Name = "sizeOffsetBox";
            this.sizeOffsetBox.PasswordChar = '\0';
            this.sizeOffsetBox.SelectedText = "";
            this.sizeOffsetBox.SelectionLength = 0;
            this.sizeOffsetBox.SelectionStart = 0;
            this.sizeOffsetBox.Size = new System.Drawing.Size(69, 23);
            this.sizeOffsetBox.TabIndex = 1;
            this.sizeOffsetBox.TabStop = false;
            this.sizeOffsetBox.UseSystemPasswordChar = false;
            this.sizeOffsetBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sizeOffsetBox_KeyPress);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(538, 332);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(139, 27);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "重置缓存并重启";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // pythonExePathBox
            // 
            this.pythonExePathBox.Location = new System.Drawing.Point(174, 283);
            this.pythonExePathBox.Name = "pythonExePathBox";
            this.pythonExePathBox.Size = new System.Drawing.Size(363, 20);
            this.pythonExePathBox.TabIndex = 3;
            // 
            // usePythonBox
            // 
            this.usePythonBox.AutoSize = true;
            this.usePythonBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usePythonBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usePythonBox.Location = new System.Drawing.Point(76, 254);
            this.usePythonBox.Name = "usePythonBox";
            this.usePythonBox.Size = new System.Drawing.Size(187, 23);
            this.usePythonBox.TabIndex = 4;
            this.usePythonBox.Text = "使用自定义Python.exe路径";
            this.usePythonBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(72, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Python路径";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(73, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "需要带有PIL的Python 3.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(72, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "图片大小偏移";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(73, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "0到9之间的数字.";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(702, 377);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usePythonBox);
            this.Controls.Add(this.pythonExePathBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.sleepTimeBox);
            this.Controls.Add(this.sizeOffsetBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField sleepTimeBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField sizeOffsetBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox pythonExePathBox;
        private System.Windows.Forms.CheckBox usePythonBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
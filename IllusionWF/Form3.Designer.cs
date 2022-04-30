
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
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(69, 105);
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
            this.sleepTimeBox.Location = new System.Drawing.Point(162, 101);
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
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(73, 216);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(139, 27);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "重置缓存并重启";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(645, 271);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.sleepTimeBox);
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
        private System.Windows.Forms.Button resetButton;
    }
}

namespace IllusionWF
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.targetPathBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.appNameBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowNameBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.themeBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorGrid1 = new Cyotek.Windows.Forms.ColorGrid();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BrowseButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button2 = new System.Windows.Forms.Button();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(31, 165);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 289);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // targetPathBox
            // 
            this.targetPathBox.Depth = 0;
            this.targetPathBox.Hint = "";
            this.targetPathBox.Location = new System.Drawing.Point(88, 84);
            this.targetPathBox.MaxLength = 32767;
            this.targetPathBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.targetPathBox.Name = "targetPathBox";
            this.targetPathBox.PasswordChar = '\0';
            this.targetPathBox.SelectedText = "";
            this.targetPathBox.SelectionLength = 0;
            this.targetPathBox.SelectionStart = 0;
            this.targetPathBox.Size = new System.Drawing.Size(519, 23);
            this.targetPathBox.TabIndex = 1;
            this.targetPathBox.TabStop = false;
            this.targetPathBox.UseSystemPasswordChar = false;
            // 
            // appNameBox
            // 
            this.appNameBox.Depth = 0;
            this.appNameBox.Hint = "";
            this.appNameBox.Location = new System.Drawing.Point(88, 125);
            this.appNameBox.MaxLength = 32767;
            this.appNameBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.appNameBox.Name = "appNameBox";
            this.appNameBox.PasswordChar = '\0';
            this.appNameBox.SelectedText = "";
            this.appNameBox.SelectionLength = 0;
            this.appNameBox.SelectionStart = 0;
            this.appNameBox.Size = new System.Drawing.Size(519, 23);
            this.appNameBox.TabIndex = 5;
            this.appNameBox.TabStop = false;
            this.appNameBox.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(707, 282);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(63, 36);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "Apply";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(25, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "EXE路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(27, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "磁贴名称";
            // 
            // ShowNameBox
            // 
            this.ShowNameBox.AutoSize = true;
            this.ShowNameBox.Depth = 0;
            this.ShowNameBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.ShowNameBox.Location = new System.Drawing.Point(382, 197);
            this.ShowNameBox.Margin = new System.Windows.Forms.Padding(0);
            this.ShowNameBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ShowNameBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowNameBox.Name = "ShowNameBox";
            this.ShowNameBox.Ripple = true;
            this.ShowNameBox.Size = new System.Drawing.Size(26, 30);
            this.ShowNameBox.TabIndex = 9;
            this.ShowNameBox.UseVisualStyleBackColor = true;
            // 
            // themeBox
            // 
            this.themeBox.AutoSize = true;
            this.themeBox.Depth = 0;
            this.themeBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.themeBox.Location = new System.Drawing.Point(540, 197);
            this.themeBox.Margin = new System.Windows.Forms.Padding(0);
            this.themeBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.themeBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeBox.Name = "themeBox";
            this.themeBox.Ripple = true;
            this.themeBox.Size = new System.Drawing.Size(26, 30);
            this.themeBox.TabIndex = 10;
            this.themeBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(411, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "大磁贴显示文字";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(569, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "深色文字";
            // 
            // colorGrid1
            // 
            this.colorGrid1.Location = new System.Drawing.Point(384, 261);
            this.colorGrid1.Name = "colorGrid1";
            this.colorGrid1.Size = new System.Drawing.Size(247, 165);
            this.colorGrid1.TabIndex = 13;
            this.colorGrid1.ColorChanged += new System.EventHandler(this.colorGrid1_ColorChanged);
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.AboutToolStripMenuItem.Text = "关于";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "关于";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Enabled = false;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(187, 475);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(353, 23);
            this.materialSingleLineTextField1.TabIndex = 16;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(74, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "自定义图片 路径:";
            // 
            // CustomBox
            // 
            this.CustomBox.AutoSize = true;
            this.CustomBox.Depth = 0;
            this.CustomBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.CustomBox.Location = new System.Drawing.Point(45, 471);
            this.CustomBox.Margin = new System.Windows.Forms.Padding(0);
            this.CustomBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CustomBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.CustomBox.Name = "CustomBox";
            this.CustomBox.Ripple = true;
            this.CustomBox.Size = new System.Drawing.Size(26, 30);
            this.CustomBox.TabIndex = 18;
            this.CustomBox.UseVisualStyleBackColor = true;
            this.CustomBox.CheckedChanged += new System.EventHandler(this.CustomBox_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PNG文件|*.png|所有文件|*.*";
            this.openFileDialog1.InitialDirectory = "C:";
            this.openFileDialog1.Title = "选择图片路径...";
            // 
            // BrowseButton
            // 
            this.BrowseButton.AutoSize = true;
            this.BrowseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowseButton.Depth = 0;
            this.BrowseButton.Icon = null;
            this.BrowseButton.Location = new System.Drawing.Point(555, 465);
            this.BrowseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Primary = true;
            this.BrowseButton.Size = new System.Drawing.Size(76, 36);
            this.BrowseButton.TabIndex = 19;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "设置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 537);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.CustomBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colorGrid1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.themeBox);
            this.Controls.Add(this.ShowNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.appNameBox);
            this.Controls.Add(this.targetPathBox);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Illusion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField targetPathBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField appNameBox;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialCheckBox ShowNameBox;
        private MaterialSkin.Controls.MaterialCheckBox themeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Cyotek.Windows.Forms.ColorGrid colorGrid1;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialCheckBox CustomBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialRaisedButton BrowseButton;
        private System.Windows.Forms.Button button2;
    }
}


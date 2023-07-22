
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.targetPathBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.appNameBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
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
            this.CustomicoBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BrowseicoButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.ButtonDel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.LinkLabelRefresh = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.searchBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabelExtractLnkIcon = new System.Windows.Forms.LinkLabel();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // targetPathBox
            // 
            resources.ApplyResources(this.targetPathBox, "targetPathBox");
            this.targetPathBox.Depth = 0;
            this.targetPathBox.Hint = "";
            this.targetPathBox.MaxLength = 32767;
            this.targetPathBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.targetPathBox.Name = "targetPathBox";
            this.targetPathBox.PasswordChar = '\0';
            this.targetPathBox.SelectedText = "";
            this.targetPathBox.SelectionLength = 0;
            this.targetPathBox.SelectionStart = 0;
            this.targetPathBox.TabStop = false;
            this.targetPathBox.UseSystemPasswordChar = false;
            this.targetPathBox.Click += new System.EventHandler(this.targetPathBox_Click);
            this.targetPathBox.TextChanged += new System.EventHandler(this.targetPathBox_TextChanged);
            // 
            // appNameBox
            // 
            resources.ApplyResources(this.appNameBox, "appNameBox");
            this.appNameBox.Depth = 0;
            this.appNameBox.Hint = "";
            this.appNameBox.MaxLength = 32767;
            this.appNameBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.appNameBox.Name = "appNameBox";
            this.appNameBox.PasswordChar = '\0';
            this.appNameBox.SelectedText = "";
            this.appNameBox.SelectionLength = 0;
            this.appNameBox.SelectionStart = 0;
            this.appNameBox.TabStop = false;
            this.appNameBox.UseSystemPasswordChar = false;
            this.appNameBox.TextChanged += new System.EventHandler(this.appNameBox_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Name = "label2";
            // 
            // ShowNameBox
            // 
            resources.ApplyResources(this.ShowNameBox, "ShowNameBox");
            this.ShowNameBox.Checked = true;
            this.ShowNameBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowNameBox.Depth = 0;
            this.ShowNameBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ShowNameBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowNameBox.Name = "ShowNameBox";
            this.ShowNameBox.Ripple = true;
            this.ShowNameBox.UseVisualStyleBackColor = true;
            // 
            // themeBox
            // 
            resources.ApplyResources(this.themeBox, "themeBox");
            this.themeBox.Depth = 0;
            this.themeBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.themeBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeBox.Name = "themeBox";
            this.themeBox.Ripple = true;
            this.themeBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // colorGrid1
            // 
            resources.ApplyResources(this.colorGrid1, "colorGrid1");
            this.colorGrid1.Name = "colorGrid1";
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
            resources.ApplyResources(this.materialContextMenuStrip1, "materialContextMenuStrip1");
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            resources.ApplyResources(this.AboutToolStripMenuItem, "AboutToolStripMenuItem");
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(63)))), ((int)(((byte)(117)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialSingleLineTextField1
            // 
            resources.ApplyResources(this.materialSingleLineTextField1, "materialSingleLineTextField1");
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CustomBox
            // 
            resources.ApplyResources(this.CustomBox, "CustomBox");
            this.CustomBox.Depth = 0;
            this.CustomBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CustomBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.CustomBox.Name = "CustomBox";
            this.CustomBox.Ripple = true;
            this.CustomBox.UseVisualStyleBackColor = true;
            this.CustomBox.CheckedChanged += new System.EventHandler(this.CustomBox_CheckedChanged);
            // 
            // openFileDialog1
            // 
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            this.openFileDialog1.InitialDirectory = "C:";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // BrowseButton
            // 
            resources.ApplyResources(this.BrowseButton, "BrowseButton");
            this.BrowseButton.Depth = 0;
            this.BrowseButton.Icon = null;
            this.BrowseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Primary = true;
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(63)))), ((int)(((byte)(117)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CustomicoBox
            // 
            resources.ApplyResources(this.CustomicoBox, "CustomicoBox");
            this.CustomicoBox.Depth = 0;
            this.CustomicoBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CustomicoBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.CustomicoBox.Name = "CustomicoBox";
            this.CustomicoBox.Ripple = true;
            this.CustomicoBox.UseVisualStyleBackColor = true;
            this.CustomicoBox.CheckedChanged += new System.EventHandler(this.CustomicoBox_CheckedChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // materialSingleLineTextField2
            // 
            resources.ApplyResources(this.materialSingleLineTextField2, "materialSingleLineTextField2");
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // BrowseicoButton
            // 
            resources.ApplyResources(this.BrowseicoButton, "BrowseicoButton");
            this.BrowseicoButton.Depth = 0;
            this.BrowseicoButton.Icon = null;
            this.BrowseicoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrowseicoButton.Name = "BrowseicoButton";
            this.BrowseicoButton.Primary = true;
            this.BrowseicoButton.UseVisualStyleBackColor = true;
            this.BrowseicoButton.Click += new System.EventHandler(this.BrowseicoButton_Click);
            // 
            // openFileDialog2
            // 
            resources.ApplyResources(this.openFileDialog2, "openFileDialog2");
            this.openFileDialog2.InitialDirectory = "C:";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Name = "label6";
            // 
            // ButtonApply
            // 
            resources.ApplyResources(this.ButtonApply, "ButtonApply");
            this.ButtonApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(94)))), ((int)(((byte)(148)))));
            this.ButtonApply.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.UseVisualStyleBackColor = false;
            this.ButtonApply.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // ButtonDel
            // 
            resources.ApplyResources(this.ButtonDel, "ButtonDel");
            this.ButtonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(94)))), ((int)(((byte)(148)))));
            this.ButtonDel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.UseVisualStyleBackColor = false;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // LinkLabelRefresh
            // 
            this.LinkLabelRefresh.ActiveLinkColor = System.Drawing.Color.White;
            resources.ApplyResources(this.LinkLabelRefresh, "LinkLabelRefresh");
            this.LinkLabelRefresh.LinkColor = System.Drawing.Color.Gray;
            this.LinkLabelRefresh.Name = "LinkLabelRefresh";
            this.LinkLabelRefresh.TabStop = true;
            this.LinkLabelRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelRefresh_LinkClicked);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchBox
            // 
            resources.ApplyResources(this.searchBox, "searchBox");
            this.searchBox.Depth = 0;
            this.searchBox.Hint = "";
            this.searchBox.MaxLength = 32767;
            this.searchBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.SelectedText = "";
            this.searchBox.SelectionLength = 0;
            this.searchBox.SelectionStart = 0;
            this.searchBox.TabStop = false;
            this.searchBox.UseSystemPasswordChar = false;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Name = "label8";
            // 
            // linkLabelExtractLnkIcon
            // 
            this.linkLabelExtractLnkIcon.ActiveLinkColor = System.Drawing.Color.White;
            resources.ApplyResources(this.linkLabelExtractLnkIcon, "linkLabelExtractLnkIcon");
            this.linkLabelExtractLnkIcon.LinkColor = System.Drawing.Color.Gray;
            this.linkLabelExtractLnkIcon.Name = "linkLabelExtractLnkIcon";
            this.linkLabelExtractLnkIcon.TabStop = true;
            this.linkLabelExtractLnkIcon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelExtractLnkIcon_LinkClicked);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.linkLabelExtractLnkIcon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LinkLabelRefresh);
            this.Controls.Add(this.ButtonDel);
            this.Controls.Add(this.ButtonApply);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BrowseicoButton);
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CustomicoBox);
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
            this.Controls.Add(this.appNameBox);
            this.Controls.Add(this.targetPathBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.searchBox);
            this.Name = "Form1";
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
        private MaterialSkin.Controls.MaterialCheckBox CustomicoBox;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialRaisedButton BrowseicoButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonApply;
        private System.Windows.Forms.Button ButtonDel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.LinkLabel LinkLabelRefresh;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private MaterialSkin.Controls.MaterialSingleLineTextField searchBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabelExtractLnkIcon;
    }
}


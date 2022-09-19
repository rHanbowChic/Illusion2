
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
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(66, 186);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 268);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // targetPathBox
            // 
            this.targetPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetPathBox.Depth = 0;
            this.targetPathBox.Hint = "";
            this.targetPathBox.Location = new System.Drawing.Point(137, 103);
            this.targetPathBox.MaxLength = 32767;
            this.targetPathBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.targetPathBox.Name = "targetPathBox";
            this.targetPathBox.PasswordChar = '\0';
            this.targetPathBox.SelectedText = "";
            this.targetPathBox.SelectionLength = 0;
            this.targetPathBox.SelectionStart = 0;
            this.targetPathBox.Size = new System.Drawing.Size(448, 23);
            this.targetPathBox.TabIndex = 1;
            this.targetPathBox.TabStop = false;
            this.targetPathBox.UseSystemPasswordChar = false;
            this.targetPathBox.Click += new System.EventHandler(this.targetPathBox_Click);
            this.targetPathBox.TextChanged += new System.EventHandler(this.targetPathBox_TextChanged);
            // 
            // appNameBox
            // 
            this.appNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appNameBox.Depth = 0;
            this.appNameBox.Hint = "";
            this.appNameBox.Location = new System.Drawing.Point(137, 144);
            this.appNameBox.MaxLength = 32767;
            this.appNameBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.appNameBox.Name = "appNameBox";
            this.appNameBox.PasswordChar = '\0';
            this.appNameBox.SelectedText = "";
            this.appNameBox.SelectionLength = 0;
            this.appNameBox.SelectionStart = 0;
            this.appNameBox.Size = new System.Drawing.Size(513, 23);
            this.appNameBox.TabIndex = 2;
            this.appNameBox.TabStop = false;
            this.appNameBox.UseSystemPasswordChar = false;
            this.appNameBox.TextChanged += new System.EventHandler(this.appNameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(62, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "目标路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(62, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "显示名称";
            // 
            // ShowNameBox
            // 
            this.ShowNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowNameBox.AutoSize = true;
            this.ShowNameBox.Checked = true;
            this.ShowNameBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowNameBox.Depth = 0;
            this.ShowNameBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.ShowNameBox.Location = new System.Drawing.Point(391, 212);
            this.ShowNameBox.Margin = new System.Windows.Forms.Padding(0);
            this.ShowNameBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ShowNameBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowNameBox.Name = "ShowNameBox";
            this.ShowNameBox.Ripple = true;
            this.ShowNameBox.Size = new System.Drawing.Size(26, 30);
            this.ShowNameBox.TabIndex = 4;
            this.ShowNameBox.UseVisualStyleBackColor = true;
            // 
            // themeBox
            // 
            this.themeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.themeBox.AutoSize = true;
            this.themeBox.Depth = 0;
            this.themeBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.themeBox.Location = new System.Drawing.Point(549, 212);
            this.themeBox.Margin = new System.Windows.Forms.Padding(0);
            this.themeBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.themeBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeBox.Name = "themeBox";
            this.themeBox.Ripple = true;
            this.themeBox.Size = new System.Drawing.Size(26, 30);
            this.themeBox.TabIndex = 5;
            this.themeBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(420, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "大磁贴显示文字";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(578, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "深色文字";
            // 
            // colorGrid1
            // 
            this.colorGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorGrid1.Location = new System.Drawing.Point(392, 289);
            this.colorGrid1.Name = "colorGrid1";
            this.colorGrid1.Size = new System.Drawing.Size(247, 165);
            this.colorGrid1.TabIndex = 6;
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
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(63)))), ((int)(((byte)(117)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(654, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "关于";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Enabled = false;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(216, 522);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(398, 23);
            this.materialSingleLineTextField1.TabIndex = 11;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(102, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "自定义背景  路径:";
            // 
            // CustomBox
            // 
            this.CustomBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomBox.AutoSize = true;
            this.CustomBox.Depth = 0;
            this.CustomBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.CustomBox.Location = new System.Drawing.Point(73, 522);
            this.CustomBox.Margin = new System.Windows.Forms.Padding(0);
            this.CustomBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CustomBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.CustomBox.Name = "CustomBox";
            this.CustomBox.Ripple = true;
            this.CustomBox.Size = new System.Drawing.Size(26, 30);
            this.CustomBox.TabIndex = 10;
            this.CustomBox.UseVisualStyleBackColor = true;
            this.CustomBox.CheckedChanged += new System.EventHandler(this.CustomBox_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PNG文件|*.png|所有文件|*.*";
            this.openFileDialog1.InitialDirectory = "C:";
            this.openFileDialog1.Title = "选择图片...";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.AutoSize = true;
            this.BrowseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowseButton.Depth = 0;
            this.BrowseButton.Icon = null;
            this.BrowseButton.Location = new System.Drawing.Point(620, 513);
            this.BrowseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Primary = true;
            this.BrowseButton.Size = new System.Drawing.Size(32, 36);
            this.BrowseButton.TabIndex = 12;
            this.BrowseButton.Text = "...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(63)))), ((int)(((byte)(117)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(609, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 27);
            this.button2.TabIndex = 15;
            this.button2.Text = "设置";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CustomicoBox
            // 
            this.CustomicoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomicoBox.AutoSize = true;
            this.CustomicoBox.Depth = 0;
            this.CustomicoBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.CustomicoBox.Location = new System.Drawing.Point(73, 478);
            this.CustomicoBox.Margin = new System.Windows.Forms.Padding(0);
            this.CustomicoBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CustomicoBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.CustomicoBox.Name = "CustomicoBox";
            this.CustomicoBox.Ripple = true;
            this.CustomicoBox.Size = new System.Drawing.Size(26, 30);
            this.CustomicoBox.TabIndex = 7;
            this.CustomicoBox.UseVisualStyleBackColor = true;
            this.CustomicoBox.CheckedChanged += new System.EventHandler(this.CustomicoBox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(102, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "自定义Icon  路径:";
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Enabled = false;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(216, 478);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(398, 23);
            this.materialSingleLineTextField2.TabIndex = 8;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // BrowseicoButton
            // 
            this.BrowseicoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseicoButton.AutoSize = true;
            this.BrowseicoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowseicoButton.Depth = 0;
            this.BrowseicoButton.Icon = null;
            this.BrowseicoButton.Location = new System.Drawing.Point(620, 465);
            this.BrowseicoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrowseicoButton.Name = "BrowseicoButton";
            this.BrowseicoButton.Primary = true;
            this.BrowseicoButton.Size = new System.Drawing.Size(32, 36);
            this.BrowseicoButton.TabIndex = 9;
            this.BrowseicoButton.Text = "...";
            this.BrowseicoButton.UseVisualStyleBackColor = true;
            this.BrowseicoButton.Click += new System.EventHandler(this.BrowseicoButton_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "PNG文件|*.png|所有文件|*.*";
            this.openFileDialog2.InitialDirectory = "C:";
            this.openFileDialog2.Title = "选择图片...";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(388, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "背景颜色";
            // 
            // ButtonApply
            // 
            this.ButtonApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(94)))), ((int)(((byte)(148)))));
            this.ButtonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonApply.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonApply.Location = new System.Drawing.Point(74, 569);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(578, 28);
            this.ButtonApply.TabIndex = 13;
            this.ButtonApply.Text = "APPLY";
            this.ButtonApply.UseVisualStyleBackColor = false;
            this.ButtonApply.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // ButtonDel
            // 
            this.ButtonDel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(94)))), ((int)(((byte)(148)))));
            this.ButtonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonDel.Location = new System.Drawing.Point(74, 603);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(578, 28);
            this.ButtonDel.TabIndex = 14;
            this.ButtonDel.Text = "DELETE";
            this.ButtonDel.UseVisualStyleBackColor = false;
            this.ButtonDel.Visible = false;
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
            this.LinkLabelRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LinkLabelRefresh.AutoSize = true;
            this.LinkLabelRefresh.LinkColor = System.Drawing.Color.Gray;
            this.LinkLabelRefresh.Location = new System.Drawing.Point(64, 455);
            this.LinkLabelRefresh.Name = "LinkLabelRefresh";
            this.LinkLabelRefresh.Size = new System.Drawing.Size(44, 13);
            this.LinkLabelRefresh.TabIndex = 30;
            this.LinkLabelRefresh.TabStop = true;
            this.LinkLabelRefresh.Text = "Refresh";
            this.LinkLabelRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelRefresh_LinkClicked);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(605, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "More";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 648);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(720, 648);
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
    }
}


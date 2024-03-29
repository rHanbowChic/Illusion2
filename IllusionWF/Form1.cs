﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cyotek.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using Newtonsoft.Json;
using Microsoft.VisualBasic;

namespace IllusionWF
{
    public partial class Form1 : MaterialForm
    {
       


        string showName;
        string theme;
        bool isSystemMode;

        string illusionTempPath = Path.GetTempPath() + "\\Illusion";

        string appxFolder = "None";

        bool ApplySuccessing = false;

        string selectedDir = "C:\\";

        ArrayList lnkList = new ArrayList();
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple11886228, Primary.Purple9846645, Primary.Green600, Accent.Purple11886228, TextShade.BLACK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.listBox1.Items.Clear();

            
            isSystemMode = false;
            string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            if (Directory.Exists(userFolder + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs"))
            {

                DirectoryInfo desktopFolder = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
                foreach (FileInfo NextFile in desktopFolder.GetFiles())
                    lnkList.Add("Desktop::" + NextFile.Name);
                foreach (DirectoryInfo NextFolder in desktopFolder.GetDirectories())
                    foreach (FileInfo NextFile in NextFolder.GetFiles())
                        lnkList.Add("Desktop::" + NextFolder.Name + "\\" + NextFile.Name);

                DirectoryInfo TheFolderU = new DirectoryInfo(userFolder + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs");
                foreach (FileInfo NextFile in TheFolderU.GetFiles())
                    lnkList.Add("User::" + NextFile.Name);
                foreach (DirectoryInfo NextFolder in TheFolderU.GetDirectories())
                    foreach (FileInfo NextFile in NextFolder.GetFiles())
                        lnkList.Add("User::" + NextFolder.Name + "\\" + NextFile.Name);


            }
            else
            {
                this.Text = "Illusion (SYSTEM Mode)";
                isSystemMode = true;
            }


            DirectoryInfo TheFolder = new DirectoryInfo("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs");
            foreach (FileInfo NextFile in TheFolder.GetFiles())
                lnkList.Add(NextFile.Name);
            foreach (DirectoryInfo NextFolder in TheFolder.GetDirectories())
                foreach (FileInfo NextFile in NextFolder.GetFiles())
                    lnkList.Add(NextFolder.Name + "\\" + NextFile.Name);



            for (int i = lnkList.Count - 1; i >= 0; i--)//.lnk files
            {
                if (!Regex.IsMatch(lnkList[i].ToString(), @"(.*)(\.lnk)"))
                {
                    lnkList.RemoveAt(i);
                }
            }
            for (int i = lnkList.Count - 1; i >= 0; i--)//remove .lnk
            {
                lnkList[i] = lnkList[i].ToString().Substring(0, lnkList[i].ToString().Length - 4);
            }
            string[] bannedApps = File.ReadAllLines(@".\denylist.txt");
            if (!isSystemMode)
            {
                for (int lnkListItem = lnkList.Count - 1; lnkListItem >= 0; lnkListItem--)
                {
                    for (int bannedAppsItem = 0; bannedAppsItem < bannedApps.Length; bannedAppsItem++)
                    {
                        if (lnkList[lnkListItem].ToString().Contains(bannedApps[bannedAppsItem]))
                        {
                            lnkList.RemoveAt(lnkListItem);
                            break;
                        }
                    }
                }
            }

            lnkList.Add("显示桌面");
            lnkList.Add("Windows 搜索");
            lnkList.Add("设置");

            
            for (int i = 0; i < lnkList.Count; i++)//To lnkBox
            {
                this.listBox1.Items.Add(lnkList[i]);
            }

           



            string appdataPath = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            string illusionRoamingPath = appdataPath + "\\Roaming\\illusion";
            DefaultConfigObject dconfig = new DefaultConfigObject();
            string dconfigText = JsonConvert.SerializeObject(dconfig);

            if (!Directory.Exists(illusionRoamingPath))
            {
                Directory.CreateDirectory(illusionRoamingPath);
            }
            if (!File.Exists(illusionRoamingPath + "\\Illusion.json"))
            {
                File.WriteAllText(illusionRoamingPath + "\\Illusion.json", dconfigText);
            }

            timer2.Start();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lnkPath = "";
            string targetPath = "";
            string targetPathArgs = "";

            if (listBox1.SelectedItem == null)
                return;
            if (listBox1.SelectedItem.ToString().Contains("User::"))
            {
                string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                lnkPath = userFolder + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\" + listBox1.SelectedItem.ToString().Substring(6, listBox1.SelectedItem.ToString().Length - 6) + ".lnk";
            }
            else
            {
                if (listBox1.SelectedItem.ToString().Contains("Desktop::"))
                {
                    string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                    lnkPath = desktopFolder + "\\" + listBox1.SelectedItem.ToString().Substring(9, listBox1.SelectedItem.ToString().Length - 9) + ".lnk";
                }
                else
                {
                    lnkPath = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\" + listBox1.SelectedItem + ".lnk";
                }
            }
            bool oktoRun = false;
            switch (listBox1.SelectedItem.ToString())
            {
                case var v when v.Contains("System Tools\\Control Panel"):
                    targetPath = "C:\\Windows\\System32\\control.exe";
                    break;
                case var v when v.Contains("System Tools\\Run"):
                    targetPath = "C:\\Windows\\explorer.exe Shell:::{2559a1f3-21d7-11d4-bdaf-00c04f60b9f0}";
                    break;
                case var v when v.Contains("File Explorer"):
                    targetPath = "C:\\Windows\\explorer.exe";
                    break;
                case var v when v.Contains("显示桌面"):
                    targetPath = "C:\\Windows\\explorer.exe Shell:::{3080F90D-D7AD-11D9-BD98-0000947B0257}";
                    break;
                case var v when v.Contains("Windows 搜索"):
                    targetPath = "C:\\Windows\\explorer.exe Shell:::{2559a1f8-21d7-11d4-bdaf-00c04f60b9f0}";
                    break;
                case var v when v.Contains("设置"):
                    targetPath = "C:\\Windows\\explorer.exe Shell:appsfolder\\windows.immersivecontrolpanel_cw5n1h2txyewy!microsoft.windows.immersivecontrolpanel";
                    break;
                default:
                    oktoRun = true;
                    break;

            }
            if (oktoRun)
            {
                Shell32.Shell sh = new Shell32.Shell();
                Shell32.Folder fold = sh.NameSpace(Path.GetDirectoryName(lnkPath));
                Shell32.FolderItem itm = fold.Items().Item(Path.GetFileName(lnkPath));
                try
                { //Start TRY!! REMOVE this before debugging!!
                  //Start TRY!! REMOVE this before debugging!!
                  //Start TRY!! REMOVE this before debugging!!
                    Shell32.ShellLinkObject linkObj = (Shell32.ShellLinkObject)itm.GetLink;
                    targetPath = linkObj.Path;
                    targetPathArgs = linkObj.Arguments;
                    if (targetPath == "")
                    {
                        appxFolder = "None";
                        string currentPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                        Process p1 = new Process();
                        p1.StartInfo.WorkingDirectory = currentPath;
                        p1.StartInfo.UseShellExecute = false;
                        p1.StartInfo.RedirectStandardInput = true;
                        p1.StartInfo.RedirectStandardOutput = true;
                        p1.StartInfo.RedirectStandardError = true;
                        p1.StartInfo.CreateNoWindow = true;
                        p1.StartInfo.FileName = currentPath + "\\strings.exe";
                        p1.StartInfo.Arguments = $" \"{lnkPath}\"";
                        p1.Start();
                        p1.WaitForExit();
                        string[] stringsOutput = p1.StandardOutput.ReadToEnd().Split('\n');
                        foreach (string s in stringsOutput)
                        {
                            string fs = "";
                            if (s.Contains("\r"))
                            {
                                fs = s.Substring(0, s.Length - 1);
                            }

                            if (Regex.IsMatch(fs, @".*?_.*?!.*?"))
                            {
                                targetPath = @"C:\Windows\explorer.exe Shell:AppsFolder\" + fs;
                            }
                            if (Regex.IsMatch(fs, @"^(C|D|E|F):\.*?\.*?"))  //Anyone tell me a better way to solve this?
                            {
                                appxFolder = fs;
                            }
                        }

                        switch (listBox1.SelectedItem.ToString())
                        {
                            case var v when v.Contains("System Tools\\Control Panel"):
                                targetPath = "C:\\Windows\\System32\\control.exe";
                                break;
                            case var v when v.Contains("System Tools\\Run"):
                                targetPath = "C:\\Windows\\explorer.exe Shell:::{2559a1f3-21d7-11d4-bdaf-00c04f60b9f0}";
                                break;
                            case var v when v.Contains("File Explorer"):
                                targetPath = "C:\\Windows\\explorer.exe Shell:MyComputerFolder";
                                break;


                        }
                    }
                    else
                    {
                        appxFolder = "None";
                    }
                }
                catch { }//REMOVE try before debugging!!!
                if (targetPathArgs == "")
                {
                    targetPathBox.Text = targetPath;
                }else
                targetPathBox.Text = targetPath + " " + targetPathArgs;
            }
            else 
            {
                targetPathBox.Text = targetPath;
            }
            if (!(targetPathBox.Text.IndexOf("C:\\Windows\\explorer.exe Shell:", StringComparison.OrdinalIgnoreCase) >= 0 || File.Exists(targetPathBox.Text)))
            {
                if (targetPathBox.Text.Contains(@"Program Files (x86)\"))
                {
                    if (File.Exists(targetPathBox.Text.Substring(0, 16) + targetPathBox.Text.Substring(22)))
                        targetPathBox.Text = targetPathBox.Text.Substring(0, 16) + targetPathBox.Text.Substring(22);
                }
                else
                {
                    if (targetPathBox.Text.Contains(@"Program Files\"))
                    {
                        if (File.Exists(targetPathBox.Text.Substring(0, 16) + " (x86)" + targetPathBox.Text.Substring(16)))
                            targetPathBox.Text = targetPathBox.Text.Substring(0, 16) + " (x86)" + targetPathBox.Text.Substring(16);
                    }
                }
            }

            string appName = "Name";
            string itemName = listBox1.SelectedItem.ToString();
            if (itemName.Contains("User::"))
            {
                itemName = itemName.Substring(itemName.LastIndexOf("::") + 2);
            }
            if (itemName.Contains("Desktop::"))
            {
                itemName = itemName.Substring(itemName.LastIndexOf("::") + 2);
            }
            if (itemName.Contains("\\"))
            {
                appName = itemName.Substring(itemName.LastIndexOf("\\") + 1);
            }
            else
            {
                appName = itemName;
            }
            appNameBox.Text = appName;
            
        }



        private void colorGrid1_ColorChanged(object sender, EventArgs e)
        {
            byte r = colorGrid1.Color.R;
            byte g = colorGrid1.Color.G;
            byte b = colorGrid1.Color.B;
            if (r + g + b < 384)
            {
                themeBox.Checked = false;
            }
            else
            {
                themeBox.Checked = true;
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string r = colorGrid1.Color.R.ToString();
            string g = colorGrid1.Color.G.ToString();
            string b = colorGrid1.Color.B.ToString();
            string currentPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string customPicPath = materialSingleLineTextField1.Text;
            string customIcoPath = materialSingleLineTextField2.Text;

            if (ShowNameBox.Checked)
                showName = "on";
            else
                showName = "off";

            if (themeBox.Checked)
                theme = "dark";
            else
                theme = "light";


            string appName = appNameBox.Text;
            string targetPath = targetPathBox.Text;
            if (appNameBox.Text == "")
            {
                return;
            }
            Process p1 = new Process();
            p1.StartInfo.WorkingDirectory = currentPath;
            p1.StartInfo.UseShellExecute = false;
            p1.StartInfo.RedirectStandardInput = true;
            p1.StartInfo.RedirectStandardOutput = true;
            p1.StartInfo.RedirectStandardError = true;
            p1.StartInfo.CreateNoWindow = true;
            p1.StartInfo.FileName = currentPath + "\\HeavenlyThread.exe";
            if (CustomBox.Checked)
            {
                p1.StartInfo.Arguments = $" \"{appName}\" \"{targetPath}\" {r} {g} {b} {showName} {theme} \"{appxFolder}\" \"{customPicPath}\"";
            }
            else
            {
                if (CustomicoBox.Checked)
                {
                    p1.StartInfo.Arguments = $" \"{appName}\" \"{targetPath}\" {r} {g} {b} {showName} {theme} \"{appxFolder}\" \"{customIcoPath}\" -ico";

                }
                else
                    p1.StartInfo.Arguments = $" \"{appName}\" \"{targetPath}\" {r} {g} {b} {showName} {theme} \"{appxFolder}\"";
                
            }
            
            p1.Start();
            ApplySuccessing = true;
            timer1.Enabled = true;
            timer1.Start();

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }



        private void CustomBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomBox.Checked)
            {
                materialSingleLineTextField1.Enabled = true;
                CustomicoBox.Checked = false;
            }
            else
            {
                materialSingleLineTextField1.Enabled = false;
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CustomBox.Checked = true;
                materialSingleLineTextField1.Text = openFileDialog1.FileName;
            }
            
        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    e.Effect = DragDropEffects.Link;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            if (path.EndsWith(".lnk"))
            {
                Shell32.Shell sh = new Shell32.Shell();
                Shell32.Folder fold = sh.NameSpace(Path.GetDirectoryName(path));
                Shell32.FolderItem itm = fold.Items().Item(Path.GetFileName(path));
                Shell32.ShellLinkObject linkObj = (Shell32.ShellLinkObject)itm.GetLink;

                string targetPath = linkObj.Path;
                targetPathBox.Text = targetPath;
                appNameBox.Text = Path.GetFileNameWithoutExtension(path);
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            if (File.Exists($@"{userFolder}\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Illusion\{appNameBox.Text}.lnk"))
            {
                File.Delete($@"{userFolder}\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Illusion\{appNameBox.Text}.lnk");
            }
            ButtonDel.Visible = false;
        }

        private void targetPathBox_Click(object sender, EventArgs e)
        {

        }

        private void targetPathBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void appNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void CustomicoBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomicoBox.Checked)
            {
                materialSingleLineTextField2.Enabled = true;
                CustomBox.Checked = false;
            }
            else
            {
                materialSingleLineTextField2.Enabled = false;
            }
        }

        private void BrowseicoButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                CustomicoBox.Checked = true;
                materialSingleLineTextField2.Text = openFileDialog2.FileName;
            }
            
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ApplySuccessing = false;
            timer1.Enabled = false;
        }
        string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (File.Exists($@"{userFolder}\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Illusion\{appNameBox.Text}.lnk"))
            {
                
                ButtonDel.Visible = true;
                ButtonDel.Text = "删除";
                ButtonDel.Enabled = true;
                if (ApplySuccessing)
                {
                    ButtonApply.Enabled = false;
                    ButtonApply.Text = "已应用";
                }
                else
                {
                    ButtonApply.Enabled = true;
                    ButtonApply.Text = "应用";
                }
            }
            else
            {
                if (File.Exists(illusionTempPath + $@"\{appNameBox.Text}.lnk"))
                {
                    ButtonDel.Visible = true;
                    ButtonDel.Text = "请等待...";
                    ButtonDel.Enabled = false;
                    if (ApplySuccessing)
                    {
                        ButtonApply.Enabled = false;
                        ButtonApply.Text = "已应用";
                    }
                    else
                    {
                        ButtonApply.Enabled = false;
                        ButtonApply.Text = "请等待...";
                    }
                }
                else
                {
                    ButtonDel.Visible = false;
                    if (ApplySuccessing)
                    {
                        ButtonApply.Enabled = false;
                        ButtonApply.Text = "已应用";
                    }
                    else
                    {
                        ButtonApply.Enabled = true;
                        ButtonApply.Text = "应用";
                    }
                }
            }
            //This reminds me of command block......
        }

        private void LinkLabelRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.listBox1.Items.Clear();

            ArrayList lnkList = new ArrayList();
            isSystemMode = false;
            string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            if (Directory.Exists(userFolder + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs"))
            {

                DirectoryInfo desktopFolder = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
                foreach (FileInfo NextFile in desktopFolder.GetFiles())
                    lnkList.Add("Desktop::" + NextFile.Name);
                foreach (DirectoryInfo NextFolder in desktopFolder.GetDirectories())
                    foreach (FileInfo NextFile in NextFolder.GetFiles())
                        lnkList.Add("Desktop::" + NextFolder.Name + "\\" + NextFile.Name);

                DirectoryInfo TheFolderU = new DirectoryInfo(userFolder + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs");
                foreach (FileInfo NextFile in TheFolderU.GetFiles())
                    lnkList.Add("User::" + NextFile.Name);
                foreach (DirectoryInfo NextFolder in TheFolderU.GetDirectories())
                    foreach (FileInfo NextFile in NextFolder.GetFiles())
                        lnkList.Add("User::" + NextFolder.Name + "\\" + NextFile.Name);


            }
            else
            {
                this.Text = "Illusion (SYSTEM Mode)";
                isSystemMode = true;
            }


            DirectoryInfo TheFolder = new DirectoryInfo("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs");
            foreach (FileInfo NextFile in TheFolder.GetFiles())
                lnkList.Add(NextFile.Name);
            foreach (DirectoryInfo NextFolder in TheFolder.GetDirectories())
                foreach (FileInfo NextFile in NextFolder.GetFiles())
                    lnkList.Add(NextFolder.Name + "\\" + NextFile.Name);



            for (int i = lnkList.Count - 1; i >= 0; i--)//.lnk files
            {
                if (!Regex.IsMatch(lnkList[i].ToString(), @"(.*)(\.lnk)"))
                {
                    lnkList.RemoveAt(i);
                }
            }
            for (int i = lnkList.Count - 1; i >= 0; i--)//remove .lnk
            {
                lnkList[i] = lnkList[i].ToString().Substring(0, lnkList[i].ToString().Length - 4);
            }
            string[] bannedApps = File.ReadAllLines(@".\denylist.txt");
            if (!isSystemMode)
            {
                for (int lnkListItem = lnkList.Count - 1; lnkListItem >= 0; lnkListItem--)
                {
                    for (int bannedAppsItem = 0; bannedAppsItem < bannedApps.Length; bannedAppsItem++)
                    {
                        if (lnkList[lnkListItem].ToString().Contains(bannedApps[bannedAppsItem]))
                        {
                            lnkList.RemoveAt(lnkListItem);
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < lnkList.Count; i++)//To lnkBox
            {
                this.listBox1.Items.Add(lnkList[i]);
            }

            ArrayList commonlnkList = new ArrayList();

            commonlnkList.Add("显示桌面");
            commonlnkList.Add("Windows 搜索");
            commonlnkList.Add("设置");


            for (int i = 0; i < commonlnkList.Count; i++)
            {
                this.listBox1.Items.Add(commonlnkList[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog3.FileName = "";
            openFileDialog3.InitialDirectory = selectedDir;
            string targetPath = targetPathBox.Text;
            if (targetPath.Contains(".exe "))
            {
                targetPath = targetPath.Substring(0, targetPath.IndexOf(".exe ") + 4);
            }
            if (File.Exists(targetPath))
                openFileDialog3.InitialDirectory = Path.GetDirectoryName(targetPath);
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                targetPathBox.Text = openFileDialog3.FileName;
                selectedDir = Path.GetDirectoryName(openFileDialog3.FileName);
                appxFolder = "None";
                appNameBox.Text = Path.GetFileName(openFileDialog3.FileName);
                listBox1.SelectedItem = null;
            }
            
            
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(string i in lnkList)
            {
                if (i.ToUpper().Contains(searchBox.Text.ToUpper()))
                    listBox1.Items.Add(i);
            }

            label8.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ShowNameBox.Checked = !ShowNameBox.Checked;//much easier!i'll use this next time!
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (themeBox.Checked == false)
                themeBox.Checked = true;
            else
                themeBox.Checked = false;//cOmPliCAteD
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (CustomicoBox.Checked == false)
                CustomicoBox.Checked = true;
            else
                CustomicoBox.Checked = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (CustomBox.Checked == false)
                CustomBox.Checked = true;
            else
                CustomBox.Checked = false;
        }

        private void linkLabelExtractLnkIcon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string lnkPath="";
            if (listBox1.SelectedItem == null)
                return;
            string boxText = listBox1.SelectedItem.ToString();
            if (boxText.StartsWith("Desktop::"))
            {
                lnkPath = desktopFolder + "\\" + boxText.Substring(9) + ".lnk";
            }
            else if (boxText.StartsWith("User::"))
            {
                lnkPath = userFolder + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\" + boxText.Substring(6) + ".lnk";
            }
            else
            {
                lnkPath = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\" + boxText + ".lnk";
            }

            var rand = new Random();
            Process p2 = new Process();
            p2.StartInfo.FileName = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)+"\\ExtractIcon.exe";
            p2.StartInfo.WorkingDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            p2.StartInfo.Arguments = $" \"{lnkPath}\" \"{desktopFolder}\\ExtractedIcon_{rand.Next().ToString()}.png\"";
            p2.StartInfo.UseShellExecute = false;
            p2.StartInfo.RedirectStandardInput = true;
            p2.StartInfo.RedirectStandardOutput = true;
            p2.StartInfo.RedirectStandardError = true;
            p2.StartInfo.CreateNoWindow = true;
            p2.Start();
            p2.WaitForExit();
            p2.Close();
            MessageBox.Show("已将LNK图标提取到桌面。","提取LNK图标");
        }
    }
}

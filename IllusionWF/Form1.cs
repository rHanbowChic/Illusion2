using MaterialSkin;
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

        string appxFolder= "None";
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Green600, Accent.LightBlue200, TextShade.BLACK) ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList lnkList = new ArrayList();
            DirectoryInfo TheFolder = new DirectoryInfo("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs");
            foreach (FileInfo NextFile in TheFolder.GetFiles())
                lnkList.Add(NextFile.Name);
            foreach (DirectoryInfo NextFolder in TheFolder.GetDirectories())
                foreach (FileInfo NextFile in NextFolder.GetFiles())
                    lnkList.Add(NextFolder.Name + "\\" + NextFile.Name);

            isSystemMode = false;
            string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            if (Directory.Exists(userFolder + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs"))
            {
                DirectoryInfo TheFolderU = new DirectoryInfo(userFolder + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs");
                foreach (FileInfo NextFile in TheFolderU.GetFiles())
                    lnkList.Add("User::" + NextFile.Name);
                foreach (DirectoryInfo NextFolder in TheFolderU.GetDirectories())
                    foreach (FileInfo NextFile in NextFolder.GetFiles())
                        lnkList.Add("User::" + NextFolder.Name + "\\" + NextFile.Name);

                DirectoryInfo desktopFolder = new DirectoryInfo(userFolder + "\\Desktop");
                foreach (FileInfo NextFile in desktopFolder.GetFiles())
                    lnkList.Add("Desktop::" + NextFile.Name);
                foreach (DirectoryInfo NextFolder in desktopFolder.GetDirectories())
                    foreach (FileInfo NextFile in NextFolder.GetFiles())
                        lnkList.Add("Desktop::" + NextFolder.Name + "\\" + NextFile.Name);
            }
            else
            {
                this.Text = "Illusion (SYSTEM Mode)";
                isSystemMode = true;
            }
            
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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lnkPath = "";
            if (listBox1.SelectedItem.ToString().Contains("User::"))
            {
                string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                lnkPath = userFolder + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\" + listBox1.SelectedItem.ToString().Substring(6, listBox1.SelectedItem.ToString().Length - 6) + ".lnk";
            }
            else { 
                if (listBox1.SelectedItem.ToString().Contains("Desktop::")) 
                {
                    string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                    lnkPath = userFolder + "\\Desktop\\" + listBox1.SelectedItem.ToString().Substring(9, listBox1.SelectedItem.ToString().Length - 9) + ".lnk";
                } 
                else 
                { lnkPath = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\" + listBox1.SelectedItem + ".lnk"; 
                } 
            }
            Shell32.Shell sh = new Shell32.Shell();
            Shell32.Folder fold = sh.NameSpace(Path.GetDirectoryName(lnkPath));
            Shell32.FolderItem itm = fold.Items().Item(Path.GetFileName(lnkPath));
            Shell32.ShellLinkObject linkObj = (Shell32.ShellLinkObject)itm.GetLink;
            string targetPath = linkObj.Path;
            if (targetPath == "")
            {
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
                    string fs="";
                    if (s.Contains("\r"))
                    {
                        fs = s.Substring(0, s.Length - 1);
                    }

                    if (Regex.IsMatch(fs, @".*?_.*?!.*?"))
                    {
                        targetPath=@"shell:AppsFolder\"+fs;
                    }
                    if (Regex.IsMatch(fs, @"^(C|D|E|F):\.*?\.*?"))  //Anyone tell me a better way to solve this?
                    {
                        appxFolder = fs;
                    }
                }
            }
            else
            {
                appxFolder = "None";
            }

            targetPathBox.Text = targetPath;

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
            }else
            {
                themeBox.Checked = true;
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string r = colorGrid1.Color.R.ToString();
            string g = colorGrid1.Color.G.ToString();
            string b = colorGrid1.Color.B.ToString();
            string currentPath= System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string customPicPath = materialSingleLineTextField1.Text;

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
            Process p1 = new Process();
            p1.StartInfo.WorkingDirectory = currentPath;
            p1.StartInfo.UseShellExecute = false;
            p1.StartInfo.RedirectStandardInput = true;
            p1.StartInfo.RedirectStandardOutput = true;
            p1.StartInfo.RedirectStandardError = true;
            p1.StartInfo.CreateNoWindow = true;
            p1.StartInfo.FileName = currentPath + "\\HeavenlyThread.exe";
            if (CustomBox.Checked == true) 
            { 
                   p1.StartInfo.Arguments = $" \"{appName}\" \"{targetPath}\" {r} {g} {b} {showName} {theme} \"{appxFolder}\" \"{customPicPath}\"";
            }else
            p1.StartInfo.Arguments = $" \"{appName}\" \"{targetPath}\" {r} {g} {b} {showName} {theme} \"{appxFolder}\"";
            MessageBox.Show(p1.StartInfo.Arguments);
            p1.Start();
            MessageBox.Show("Success");

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
            }
            materialSingleLineTextField1.Text = openFileDialog1.FileName;
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
    }
}

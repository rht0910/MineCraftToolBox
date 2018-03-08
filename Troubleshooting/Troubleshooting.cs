using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Troubleshooting
{
    public partial class TroubleShooting : Form
    {
        private String minecraftLocation;
        private CheckBox removeLog;
        private CheckBox removeCrashReport;
        private Label label2;
        private Button CheckboxExecutor;
        private TabControl maintenance;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private CheckBox removeAllLogs;
        private LinkLabel linkLabel1;
        private Label label1;

#region コードエディタで変更しないでください。

        public TroubleShooting()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.removeLog = new System.Windows.Forms.CheckBox();
            this.removeCrashReport = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckboxExecutor = new System.Windows.Forms.Button();
            this.maintenance = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.removeAllLogs = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.maintenance.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // removeLog
            // 
            this.removeLog.AutoSize = true;
            this.removeLog.Location = new System.Drawing.Point(6, 6);
            this.removeLog.Name = "removeLog";
            this.removeLog.Size = new System.Drawing.Size(168, 16);
            this.removeLog.TabIndex = 0;
            this.removeLog.Text = "アーカイブされたログを削除する";
            this.removeLog.UseVisualStyleBackColor = true;
            // 
            // removeCrashReport
            // 
            this.removeCrashReport.AutoSize = true;
            this.removeCrashReport.Location = new System.Drawing.Point(6, 28);
            this.removeCrashReport.Name = "removeCrashReport";
            this.removeCrashReport.Size = new System.Drawing.Size(154, 16);
            this.removeCrashReport.TabIndex = 1;
            this.removeCrashReport.Text = "クラッシュレポートを削除する";
            this.removeCrashReport.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "削除のフォルダは親ウィンドウに依存しています。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "「Minecraftルートフォルダ」を設定しないと、別のフォルダを削除してしまいます！";
            // 
            // CheckboxExecutor
            // 
            this.CheckboxExecutor.Location = new System.Drawing.Point(11, 170);
            this.CheckboxExecutor.Name = "CheckboxExecutor";
            this.CheckboxExecutor.Size = new System.Drawing.Size(75, 23);
            this.CheckboxExecutor.TabIndex = 4;
            this.CheckboxExecutor.Text = "実行";
            this.CheckboxExecutor.UseVisualStyleBackColor = true;
            this.CheckboxExecutor.Click += new System.EventHandler(this.CheckboxExecutor_Click);
            // 
            // maintenance
            // 
            this.maintenance.Controls.Add(this.tabPage2);
            this.maintenance.Controls.Add(this.tabPage1);
            this.maintenance.Location = new System.Drawing.Point(-3, 0);
            this.maintenance.Name = "maintenance";
            this.maintenance.SelectedIndex = 0;
            this.maintenance.Size = new System.Drawing.Size(494, 225);
            this.maintenance.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.removeAllLogs);
            this.tabPage2.Controls.Add(this.removeLog);
            this.tabPage2.Controls.Add(this.CheckboxExecutor);
            this.tabPage2.Controls.Add(this.removeCrashReport);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(486, 199);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "メンテナンス";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(486, 199);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "トラブルシューティング";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // removeAllLogs
            // 
            this.removeAllLogs.AutoSize = true;
            this.removeAllLogs.Location = new System.Drawing.Point(6, 50);
            this.removeAllLogs.Name = "removeAllLogs";
            this.removeAllLogs.Size = new System.Drawing.Size(123, 16);
            this.removeAllLogs.TabIndex = 5;
            this.removeAllLogs.Text = "ログをすべて削除する";
            this.removeAllLogs.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(212, 89);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 12);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "未完成";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // TroubleShooting
            // 
            this.ClientSize = new System.Drawing.Size(490, 261);
            this.Controls.Add(this.maintenance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TroubleShooting";
            this.Text = "メンテナンス";
            this.Load += new System.EventHandler(this.TroubleShooting_Load_1);
            this.maintenance.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private void TroubleShooting_Load_1(object sender, EventArgs e)
        {
            
        }

        public bool Test(String text)
        {
            if (text == "マインクラフト色々ツール")
            {
                return true;
            } else {
                return false;
            }
        }

        public void Config(String what)
        {
            minecraftLocation = what;
        }

        private async void CheckboxExecutor_Click(object sender, EventArgs e)
        {
            await Task.Run(() => 
            {
                if (removeLog.Checked == true)
                {
                    string[] files = Directory.GetFiles(minecraftLocation + "\\logs", "*.log.gz");
                    foreach (var item in files)
                    {
                        File.Delete(item);
                    }
                    files = null;
                }
                if (removeAllLogs.Checked == true)
                {
                    string[] loggz = Directory.GetFiles(minecraftLocation + "\\logs", "*.log.gz");
                    foreach (var item in loggz)
                    {
                        File.Delete(item);
                    }
                    string[] text = Directory.GetFiles(minecraftLocation + "\\logs", "*.txt");
                    foreach (var item in text)
                    {
                        File.Delete(item);
                    }
                    loggz = null;
                    text = null;
                }
                if (removeCrashReport.Checked == true)
                {
                    string[] files = Directory.GetFiles(minecraftLocation + "\\crash-reports", "*.txt");
                    foreach (var item in files)
                    {
                        File.Delete(item);
                    }
                    files = null;
                }
            });
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/rht0910/MineCraftToolBox");
        }
    }
}

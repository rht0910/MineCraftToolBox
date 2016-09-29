using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace MCTB
{
    public partial class Trubleshooting : Form
    {
        public Trubleshooting()
        {
            InitializeComponent();
        }

        private void Trubleshooting_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\System32\Taskmgr.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\System32\cmd.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string file = text3.Text + @"\logs";

            while (true)
            {
                try
                {
                    Process.Start(file);
                    break;
                }

                catch (Exception ex)
                {
                    if (MessageBox.Show("エラーが発生しました。例外情報：\n" + ex, "エラーが発生しました", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string file = text3.Text + @"\crash-reports";
            while (true)
            {
                try
                {
                    Process.Start(file);
                    break;
                }

                catch (Exception ex)
                {
                    if(MessageBox.Show("エラーが発生しました。例外情報：\n" + ex, "エラーが発生しました", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var f = new CommonOpenFileDialog();
            f.DefaultDirectory = @"C:\Users\" + @Environment.UserName;
            f.EnsureReadOnly = false;
            f.AllowNonFileSystemItems = false;
            f.IsFolderPicker = true;
            var Result = f.ShowDialog();
            if (Result == CommonFileDialogResult.Ok)
            {
                text3.Text = f.FileName;
            }
            f.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string file = text3.Text + @"\saves";
            while (true)
            {
                try
                {
                    Process.Start(file);
                    break;
                }

                catch (Exception ex)
                {
                    if (MessageBox.Show("エラーが発生しました。例外情報：\n" + ex, "エラーが発生しました", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string delete = @text3.Text + @"\config";
            string delete1 = @text3.Text + @"\config\*";
            string delete2 = @text3.Text + @"\config\*\*";
            string delete3 = @text3.Text + @"\config\*\*\*";

            #region 削除確認

            if (MessageBox.Show("注意：Modの設定ファイルを削除しようとしています。また、この操作はベータ機能です。\n\n本当にすべてのModの設定を初期化しますか？\n初期化した場合、以前のワールドとの整合性がなくなり、遊べなくなったり、バグったり、最悪の場合は、セーブデータが破損する可能性があります。\n事前に設定ファイルをバックアップすることをおすすめします。\nこの操作を実行した後は、必ず新しいワールドから始めてください。\n\n上記のことを理解し、実行する場合は、「はい」をクリックしてください。\n中断する場合は、「いいえ」をクリックしてください。\n\n本当に続行しますか？", "使用上の注意", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) // Confirmation
            {
                if (MessageBox.Show("注意：Modの設定ファイルを削除しようとしています。(ベータ機能)\n\nすべてのModの設定ファイルが削除され、マイクラ起動時に再生成されます。\n\n\n続行しますか？", "最終確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    MessageBox.Show("設定ファイルを削除することを選択しました。\nこのダイアログを閉じた後、削除を実行します。\nただし、削除は不完全で、可能性があります。", "削除を開始します", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    while (true)
                    {
                        try
                        {
                            File.Delete(@delete1); // File Delete Phase 1
                            File.Delete(@delete2); // File Delete Phase 2
                            File.Delete(@delete3); // File Delete Phase 3
                            Directory.Delete(delete);
                            Directory.CreateDirectory(delete);
                            break;
                        }
                        catch (Exception ex)
                        {
                            if (MessageBox.Show("設定の削除中にエラーが発生しました。\nエラー情報：\n" + ex, "エラーが発生しました", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }

            #endregion
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}

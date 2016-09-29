using Microsoft;
using Microsoft.VisualBasic.FileIO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Windows.Forms;

namespace MCTB
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pb1.Value = 0;
            Refresh();
            button1.Enabled = false;
            pb1.Value = 30;
            Refresh();

            while (true)
            {
                try
                {
                    Process.Start("https://minecraft.net/ja/");
                    break;
                }

                catch(Exception)
                {
                    if (MessageBox.Show("ブラウザーを開けませんでした。再試行しますか？", "エラー", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            pb1.Value = 60;
            Refresh();
            button1.Enabled = true;
            pb1.Value = 80;
            Refresh();
            pb1.Value = 100;
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pb1.Value = 0;
            Refresh();
            button2.Enabled = false;
            pb1.Value = 40;
            Refresh();
            string path1 = "C:\\Users\\" + Environment.UserName + "\\Desktop\\Minecraft.exe";
            string path2 = "C:\\Users\\" + Environment.UserName + "\\Desktop\\Minecraft.lnk";
            string path3 = "Minecraft.exe"; // Reserved
            string path4 = "Minecraft.lnk"; // Reserved
            try
            {
                Process.Start(path1);
            }
            catch
            {
                try
                {
                    Process.Start(path2);
                }
                catch
                {
                    try
                    {
                        Process.Start(@"C:\Program Files (x86)\Minecraft\MinecraftLauncher.exe");
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("エラーが発生しました。\nマインクラフトが正常にインストールされていない可能性があります。インストールの確認後、再度実行してください。\n詳細情報：\n" + exception, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            pb1.Value = 70;
            Refresh();
            button2.Enabled = true;
            pb1.Value = 100;
            Refresh();
            }

        private void button3_Click(object sender, EventArgs e)
        {
            pb1.Value = 0;
            Refresh();
            button3.Enabled = false;
            pb1.Value = 40;
            Refresh();
            string mcconfig = text3.Text + @"\config";
            pb1.Value = 80;
            Refresh();
            try
            {
                Process.Start(mcconfig);
                
            }
            catch(Exception)
            {
                MessageBox.Show("Minecraftルートパスを入力するところが空欄か、configフォルダが作成されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            button3.Enabled = true;
            pb1.Value = 100;
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pb1.Value = 0;
            Refresh();
            button5.Enabled = false;
            pb1.Value = 16;
            Refresh();
            pb1.Value = 50;
            Refresh();
            text3.Text = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\.minecraft";
            pb1.Value = 60;
            Refresh();
            text4.Text = @"C:\Usets\" + Environment.UserName + @"\Downloads\[ファイル名].exe";
            pb1.Value = 70;
            Refresh();
            text5.Text = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\.minecraft\saves\【ワールドの名前】";
            pb1.Value = 80;
            Refresh();
            text6.Text = @"(ワールド名を入力してください)";
            pb1.Value = 90;
            Refresh();
            text7.Text = @"C:\Users\" + Environment.UserName + @"\Downloads\MinecraftServer\【Minecraftサーバー】.jar";
            button5.Enabled = true;
            pb1.Value = 100;
            Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pb1.Value = 0;
            Refresh();
            button4.Enabled = false;
            pb1.Value = 40;
            Refresh();
            string mcmods = text3.Text + @"\mods";
            pb1.Value = 80;
            Refresh();
            try
            {
                Process.Start(mcmods);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Minecraftルートパスを入力するところが空欄か、modsフォルダが作成されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pb1.Value = 100;
            Refresh();
            button4.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pb1.Value = 0;
            Refresh();
            button6.Enabled = false;
            pb1.Value = 40;
            Refresh();
            while (true)
            {
                try
                {
                    Process.Start("http://www26.atwiki.jp/minecraft/");
                    break;
                }

                catch (Exception)
                {
                    if (MessageBox.Show("ブラウザーを開けませんでした。再試行しますか？", "エラー", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            pb1.Value = 80;
            Refresh();
            button6.Enabled = true;
            pb1.Value = 100;
            Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pb1.Value = 0;
            Refresh();
            button7.Enabled = false;
            pb1.Value = 16;
            Refresh();
            string cp = "-s -c:"+text3.Text;
            pb1.Value = 32;
            Refresh();
            MessageBox.Show("Minecraftルートフォルダを入力する欄が空でもエラーが出ないのでご注意ください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (MessageBox.Show("本当に圧縮しますか？(SSDには使用しないでください！)",
            "確認", MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                while (true)
                {
                    try
                    {
                        Process.Start(@"C:\Windows\System32\compact.exe", cp);
                        break;
                    }
                    catch (Exception)
                    {
                        if (MessageBox.Show("コマンドでエラーが発生しました。", "エラー", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
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
            pb1.Value = 80;
            Refresh();
            button7.Enabled = true;
            pb1.Value = 100;
            Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pb1.Value = 0;
            Refresh();
            button8.Enabled = false;
            pb1.Value = 16;
            Refresh();
            pb1.Value = 32;
            Refresh();
            string javaint = text4.Text;
            pb1.Value = 48;
            Refresh();
            try
            {
                Process.Start(javaint);
            }
            catch(Exception)
            {
                MessageBox.Show("パスが間違っているか、未入力です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pb1.Value = 60;
            Refresh();
            button8.Enabled = true;
            pb1.Value = 80;
            Refresh();
            pb1.Value = 100;
            Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pb1.Value = 0;
            Refresh();
            button9.Enabled = false;
            pb1.Value = 16;
            Refresh();
            string program = "javaw.exe";
            pb1.Value = 32;
            Refresh();
            string args = "-t -f -im" + program;
            pb1.Value = 48;
            Refresh();
            string killer = @"C:\Windows\System32\taskkill.exe";
            pb1.Value = 64;
            Refresh();
            while(true)
            {
                try
                {
                    Process.Start(killer, args);
                    break;
                }

                catch(Exception)
                {
                    if (MessageBox.Show("不明なエラーが発生しました。再試行しますか？", "エラー", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            while (true)
            {
                try
                {
                    Process p = new Process();
                    p.StartInfo.FileName = "javaw.exe";
                    break;
                }
                catch (Exception)
                {
                    if(MessageBox.Show("不明なエラーが発生しました。再試行しますか？", "エラー", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            pb1.Value = 90;
            Refresh();
            button9.Enabled = true;
            pb1.Value = 100;
            Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pb1.Value = 0;
            Refresh();
            button10.Enabled = false;
            pb1.Value = 12;
            Refresh();
            string process = @"C:\Windows\System32\taskkill.exe";
            pb1.Value = 32;
            Refresh();
            string killprocess1 = "-T -F -IM Minecraft.exe";
            pb1.Value = 48;
            Refresh();
            string killprocess2 = "-T -F -IM java.exe";
            pb1.Value = 64;
            Refresh();
            while (true)
            {
                try
                {
                    Process.Start(process, killprocess1);
                    pb1.Value = 90;
                    Process.Start(process, killprocess2);
                    break;
                }
                catch (Exception)
                {
                    if(MessageBox.Show("不明なエラーが発生しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            pb1.Value = 100;
            button10.Enabled = true;
            Refresh();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pb1.Value = 0;
            Refresh();
            string source = @text5.Text;
            pb1.Value = 16;
            Refresh();
            string worldname = @text5.Text+"_バックアップ";
            pb1.Value = 32;
            Refresh();
            string leveldata = @text5.Text + @"\level\level.dat";
            pb1.Value = 48;
            Refresh();
            string worlddata = @text5.Text + @"\level.dat";
            pb1.Value = 64;
            Refresh();
            string levelcrec = @text5.Text + @"\level";
            pb1.Value = 80;
            Refresh();
            if (MessageBox.Show("バックアップを開始します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                while (true)
                {
                    try
                    {
                        Directory.CreateDirectory(levelcrec);
                        Directory.CreateDirectory(worldname);
                        File.Copy(worlddata, leveldata, true);
                        FileSystem.CopyDirectory(source, worldname, true);
                        break;
                    }

                    catch (Exception)
                    {
                        if (MessageBox.Show("エラーが発生しました。パスの指定が間違っている可能性があります。", "エラーが発生しました", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                     
                }
            } ;
            pb1.Value = 100;
            Refresh();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                pb1.Value = 0;
                Update();
                string source = @text3.Text + @"\saves\" + text6.Text;
                pb1.Value = 16;
                Update();
                string worldname = @text5.Text + "_バックアップ復元";
                string oldbakname = @text5.Text + "_バックアップ";
                pb1.Value = 32;
                Update();
                string leveldata = worldname + @"\level\level.dat";
                pb1.Value = 48;
                Update();
                string worlddata = worldname + @"\level.dat";
                pb1.Value = 60;

                Update();
                MessageBox.Show("MinecraftルートパスとバックアップパスのMinecraftルートを変更しないでください！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                pb1.Value = 80;
                Update();
                if (MessageBox.Show("バックアップの復元を開始します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    while (true)
                    {
                        try
                        {
                            Directory.CreateDirectory(worldname);
                            FileSystem.CopyDirectory(source, worldname);
                            FileSystem.DeleteDirectory(oldbakname, DeleteDirectoryOption.DeleteAllContents);
                            File.Copy(leveldata, worlddata, true);
                            break;
                        }

                        catch (Exception)
                        {
                            if (MessageBox.Show("エラーが発生しました。パスの指定が間違っている可能性があります。", "エラーが発生しました", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
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
                pb1.Value = 100;
                Update();
            }
            catch
            {
                MessageBox.Show("処理中に不明なエラーが発生しました。", "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pb1.Value = 10;
            Refresh();
            button14.Enabled = false;
            pb1.Value = 20;
            Refresh();
            while (true)
            {
                try
                {
                    Process.Start("http://minecraft-ja.gamepedia.com/");
                    break;
                }

                catch (Exception)
                {
                    if (MessageBox.Show("ブラウザーを開けませんでした。再試行しますか？", "エラー", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            pb1.Value = 90;
            Refresh();
            button14.Enabled = true;
            pb1.Value = 100;
            Refresh();
        }

        private void text6_TextChanged(object sender, EventArgs e)
        {
            //ダミー
        }

        private void text5_TextChanged(object sender, EventArgs e)
        {
            
            // ダミー
        }

        private void text4_TextChanged(object sender, EventArgs e)
        {
            // ダミー
        }

        private void text2_TextChanged(object sender, EventArgs e)
        {
            //ダミー
        }

        private void text1_TextChanged(object sender, EventArgs e)
        {
            //ダミー
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            // ダミー
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //ダミー
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //ダミー
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //ダミー
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //ダミー
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //ダミー
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //ダミー
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //ダミー
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pb1.Value = 0;
            Refresh();
            button15.Enabled = false;
            pb1.Value = 35;
            Refresh();
            string minecraftserver = @text7.Text;
            pb1.Value = 60;
            Refresh();
            MessageBox.Show("実験中機能のため、バッチファイル(*.bat)からの実行はうまくいかない可能性があります。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            while (true)
            {
                try
                {
                    Process.Start(minecraftserver);
                    break;
                }
                catch (Exception)
                {
                    if(MessageBox.Show("パスが間違っているか、未入力です。", "エラー", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            pb1.Value = 80;
            Refresh();
            button15.Enabled = true;
            pb1.Value = 100;
            Refresh();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pb1.Value = 0;
            Refresh();
            button16.Enabled = false;
            pb1.Value = 40;
            Refresh();
            string mcroot = text3.Text;
            pb1.Value = 80;
            Refresh();
            while (true)
            {
                try
                {
                    Process.Start(mcroot);
                    break;
                }

                catch
                {
                    if (MessageBox.Show("パスが間違っているか、未入力です。", "エラー", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            pb1.Value = 100;
            Refresh();
            button16.Enabled = true;
        }

        private void label3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var f = new CommonOpenFileDialog();
            f.DefaultDirectory = @"C:\Users\" + Environment.UserName + @"\AppData\.minecraft\saves";
            f.EnsureReadOnly = false;
            f.AllowNonFileSystemItems = false;
            f.IsFolderPicker = true;
            var Result = f.ShowDialog();
            if (Result == CommonFileDialogResult.Ok)
            {
                text5.Text = f.FileName;
            }
            f.Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            OpenFileDialog f = new OpenFileDialog();
            f.DefaultExt = "jar";
            f.ReadOnlyChecked = true;
            f.AddExtension = true;
            f.Multiselect = false;
            f.CheckPathExists = true;
            f.CheckFileExists = true;
            f.DereferenceLinks = true;
            f.FileName = "*.*";
            if (f.ShowDialog() == DialogResult.OK)
            {
                text7.Text = f.FileName;
            }
            else
            {
                f.Dispose();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.DefaultExt = "exe";
            f.Multiselect = true;
            f.CheckPathExists = true;
            f.CheckFileExists = true;
            f.DereferenceLinks = true;
            f.FileName = "*.exe";
            if (f.ShowDialog() == DialogResult.OK)
            {
                text4.Text = f.FileName;
            }
            else
            {
                f.Dispose();
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
            if(Result == CommonFileDialogResult.Ok)
            {
                text3.Text = f.FileName;
            }
            f.Dispose();
        }

        private void text7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var f = new CommonOpenFileDialog();
            f.DefaultDirectory = @"C:\Users\" + @Environment.UserName + @"\AppData\.minecraft\saves";
            f.EnsureReadOnly = false;
            f.AllowNonFileSystemItems = false;
            f.IsFolderPicker = true;
            var Result = f.ShowDialog();
            if (Result == CommonFileDialogResult.Ok)
            {
                text6.Text = f.FileName;
            }
            f.Dispose();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pb1.Value = 0;
            Refresh();
            button4.Enabled = false;
            pb1.Value = 40;
            Refresh();
            string mcscr = text3.Text + @"\screenshots";
            pb1.Value = 80;
            Refresh();
            try
            {
                Process.Start(mcscr);

            }
            catch (Exception)
            {
                MessageBox.Show("Minecraftルートパスを入力するところが空欄か、modsフォルダが作成されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pb1.Value = 100;
            Refresh();
            button4.Enabled = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Trubleshooting s_form = new Trubleshooting();
            s_form.ShowDialog (this);
            
        }
    }
}

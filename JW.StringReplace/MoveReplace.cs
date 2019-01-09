using JW.StringReplace.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JW.StringReplace
{
    public partial class MoveReplace : Form
    {
        public MoveReplace()
        {
            InitializeComponent();
            this.txt_excludeFileExt.Text = ConfigurationManager.AppSettings["excludeFileExt"];
            this.txt_excludeFolder.Text = ConfigurationManager.AppSettings["excludeFolder"];
            this.txt_allowFileExt.Text = ConfigurationManager.AppSettings["allowFileExt"];
            this.txt_allowFolder.Text = ConfigurationManager.AppSettings["allowFolder"];
            this.txt_sourcDdirectory.Text = ConfigurationManager.AppSettings["sourcDdirectory"];
            this.txt_targetDdirectory.Text = ConfigurationManager.AppSettings["targetDdirectory"];
            this.txt_sourceString.Text = ConfigurationManager.AppSettings["sourceString"];
            this.txt_targetString.Text = ConfigurationManager.AppSettings["targetString"];
        }

        private void MoveReplace_SizeChanged(object sender, EventArgs e)
        {

        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认现在开始移动并替换到" + txt_targetDdirectory.Text, "提示", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            Task.Run(() =>
            {
                try
                {
                    btn_move.Invoke(new EventHandler(delegate
                    {
                        btn_move.Enabled = false;
                    }));
                    Run();
                    MessageBox.Show("移动并替换成功", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "执行异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btn_move.Invoke(new EventHandler(delegate
                    {
                        btn_move.Enabled = true;
                    }));
                }
            });

        }

        /// <summary>
        /// 运行
        /// </summary>
        private void Run()
        {
            var oldValue = txt_sourceString.Text;
            var newValue = txt_targetString.Text;
            var files = FindFiles();
            foreach (var file in files)
            {
                var relativePath = file.Replace(txt_sourcDdirectory.Text, "");
                if (relativePath.IndexOf(txt_sourceString.Text) != -1)
                {
                    var destFileName = relativePath.Replace(txt_sourceString.Text, txt_targetString.Text);
                    destFileName = string.Format("{0}{1}", txt_targetDdirectory.Text, destFileName);
                    if (!File.Exists(destFileName))
                    {
                        CheckDirectory(destFileName);
                    }
                    var fileInfo = new FileInfo(file);
                    fileInfo.CopyTo(destFileName, true);
                    ReplaceFileConten(destFileName);
                }
            }
        }


        /// <summary>
        /// 替换文件内容
        /// </summary>
        /// <param name="file"></param>
        private void ReplaceFileConten(string file)
        {
            var fileInfo = new FileInfo(file);
            var file_encoding_str = string.Empty;
            try
            {
                file_encoding_str = new FileHelper().GetEncodingName(new FileInfo(file));
            }
            catch (Exception ex)
            {
                PrintLog($"{file}获取编码失败");
                return;
            }
            Encoding file_encoding = Encoding.UTF8;
            try
            {
                file_encoding = Encoding.GetEncoding(file_encoding_str);
            }
            catch (Exception ex)
            {
                PrintErrorLog(file);
                PrintErrorLog(ex.ToString());
            }
            var content = File.ReadAllText(file, file_encoding);
            if (content.IndexOf(txt_sourceString.Text) != -1)
            {
                content = content.Replace(txt_sourceString.Text, txt_targetString.Text);
                File.WriteAllText(file, content, file_encoding);
                PrintLog(string.Format("替换文件内容:{0}", file));
            }
        }

        /// <summary>
        /// 查找所有文件
        /// </summary>
        /// <returns></returns>
        private List<string> FindFiles()
        {
            var files = ReadDirectoryFiles(txt_sourcDdirectory.Text);
            files.RemoveAll(file => CheckExcludeFileExt(file));
            files.RemoveAll(file => !CheckAllowFileExt(file));
            RecordDivision(string.Format("共发现{0}个文件", files.Count));
            return files;
        }

        #region Common

        /// <summary>
        /// 检查并创建路径
        /// </summary>
        /// <param name="fileName"></param>
        private void CheckDirectory(string fileName)
        {
            var path = fileName.Substring(0, fileName.LastIndexOf("\\"));
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        /// <summary>
        /// 记录分隔符日志
        /// </summary>
        /// <param name="title"></param>
        private void RecordDivision(string title)
        {
            PrintLog(string.Format("-----------------[{0}]-----------------", title));
        }

        /// <summary>
        /// 获取指定目录下的所有文件夹
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="ext"></param>
        /// <returns></returns>
        private List<string> ReadDirectory(string directory)
        {
            var ret = new List<string>();
            var folders = Directory.GetDirectories(directory).ToList();
            ret.AddRange(folders);
            foreach (var path in folders)
            {
                ret.AddRange(ReadDirectory(path));
            }
            return ret;
        }

        /// <summary>
        /// 获取指定目录下的所有文件
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="ext"></param>
        /// <returns></returns>
        private List<string> ReadDirectoryFiles(string directory)
        {
            if (CheckExcludeFolder(directory))
            {
                return new List<string>();
            }
            if (!CheckAllowFolder(directory))
            {
                return new List<string>();
            }
            var files = Directory.GetFiles(directory).ToList();
            var folders = Directory.GetDirectories(directory);
            foreach (var path in folders)
            {
                files.AddRange(ReadDirectoryFiles(path));
            }
            return files;
        }

        /// <summary>
        /// 打印日志
        /// </summary>
        /// <param name="content"></param>
        private void PrintLog(string content)
        {
            txt_logs.Invoke(new EventHandler(delegate
            {
                txt_logs.AppendText(string.Format("{0}\r\n", content));
            }));
        }

        /// <summary>
        /// 打印日志
        /// </summary>
        /// <param name="content"></param>
        private void PrintErrorLog(string content)
        {
            txt_logs.Invoke(new EventHandler(delegate
            {
                txt_exLogs.AppendText(string.Format("{0}\r\n", content));
            }));
        }

        /// <summary>
        /// 检查文件夹是否被排除
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private bool CheckExcludeFolder(string path)
        {
            if (!string.IsNullOrEmpty(txt_excludeFolder.Text))
            {
                var reg_folder = new Regex(txt_excludeFolder.Text);
                return reg_folder.Match(path).Success;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 检查文件是否被排除
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private bool CheckExcludeFileExt(string fileName)
        {
            if (!string.IsNullOrEmpty(txt_excludeFileExt.Text))
            {
                var excludeFileExt = txt_excludeFileExt.Text.Split('|').ToList();
                var ext = FileHelper.GetFileExt(fileName);
                return excludeFileExt.Contains(ext);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 检查容许的文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private bool CheckAllowFileExt(string fileName)
        {
            if (!string.IsNullOrEmpty(txt_allowFileExt.Text))
            {
                var allowFileEx = txt_allowFileExt.Text.Split('|').ToList();
                var ext = FileHelper.GetFileExt(fileName);
                return allowFileEx.Contains(ext);
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 检查容许文件夹
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private bool CheckAllowFolder(string path)
        {
            if (!string.IsNullOrEmpty(txt_allowFolder.Text))
            {
                var reg_folder = new Regex(txt_allowFolder.Text);
                return reg_folder.Match(path).Success;
            }
            else
            {
                return true;
            }
        }

        #endregion

        private void btn_allMatchInfo_Click(object sender, EventArgs e)
        {
            var files = FindFiles();
            new MatchList(files).Show();
        }
    }
}

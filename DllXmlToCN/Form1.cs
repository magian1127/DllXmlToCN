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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DllXmlToCN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> files源 = new List<string>();
        List<XmlNodeList> files源XML = new List<XmlNodeList>();

        List<string> files目标 = new List<string>();

        private void buttonEnabled()
        {
            buttonS.Enabled = !buttonS.Enabled;
            buttonT.Enabled = !buttonT.Enabled;
            buttonDiv.Enabled = !buttonDiv.Enabled;
            buttonStart.Enabled = !buttonStart.Enabled;
            checkBoxE.Enabled = !checkBoxE.Enabled;
            textBox源.Enabled = !textBox源.Enabled;
            textBox目标.Enabled = !textBox目标.Enabled;
        }

        void ParseDirectory(string path, List<string> list)
        {

            List<string> tttt = new List<string>();
            string[] dirs = Directory.GetDirectories(path);//得到子目录
            IEnumerator iter = dirs.GetEnumerator();
            while (iter.MoveNext())
            {
                string str = (string)(iter.Current);
                ParseDirectory(str, list);
            }
            string[] files = Directory.GetFiles(path, "*.xml");
            if (files.Length > 0)
            {
                list.AddRange(files);
            }
        }

        private void StoT()
        {
            buttonEnabled();
            textBox1.Clear();

            foreach (var item in files目标)
            {
                textBox1.AppendText("目标:" + item + "\r\n");
                if (!File.Exists(item))
                {
                    textBox1.AppendText("错误:目标不存在" + "\r\n");
                    continue;
                }

                XmlDocument xmlt = new XmlDocument();
                xmlt.Load(item);
                XmlNodeList childlistt = xmlt["doc"]?["members"]?.ChildNodes;

                if (childlistt != null)
                {
                    progressBar1.Visible = true;
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = childlistt.Count;

                    int pv = 0;
                    foreach (XmlNode entry in childlistt)
                    {
                        pv++;

                        bool f是否找到 = false;
                        foreach (var xmlNodeList in files源XML)
                        {
                            Parallel.For(0, xmlNodeList.Count, (i, ParallelLoopState) =>
                            {
                                var a = xmlNodeList.Item(i);

                                if (a?.Attributes["name"]?.Value?.ToLower() == entry.Attributes["name"]?.Value?.ToLower())
                                {
                                    entry.InnerXml = a.InnerXml;
                                    a.ParentNode.RemoveChild(a);
                                    f是否找到 = true;
                                    ParallelLoopState.Stop();
                                    return;
                                }

                            });

                            //for (int i = 0; i < xmlNodeList.Count; i++)
                            //{
                            //    var a = xmlNodeList.Item(i);

                            //    if (a.Attributes["name"]?.Value?.ToLower() == entry.Attributes["name"]?.Value?.ToLower())
                            //    {
                            //        entry.InnerXml = a.InnerXml;
                            //        a.ParentNode.RemoveChild(a);
                            //        f是否找到 = true;
                            //        break;
                            //    }

                            //}
                            if (f是否找到)
                            {
                                break;
                            }
                        }

                        progressBar1.Value = pv;
                    }

                    xmlt.Save(item);
                    textBox1.AppendText("保存成功" + "\r\n");
                    textBox1.AppendText(" " + "\r\n");
                }
                else
                {
                    textBox1.AppendText("XML不包含members" + "\r\n");
                    textBox1.AppendText(" " + "\r\n");
                }

            }

            if (checkBoxE.Checked)
            {
                textBox1.AppendText("合并剩余源" + "\r\n");

                XmlDocument xml = new XmlDocument();
                string file = textBox目标.Text + "\\" + textBoxFile.Text;
                if (File.Exists(file))
                {
                    xml.Load(file);
                    var xmlElement = xml["doc"]["members"];

                    foreach (var xmlNodeList in files源XML)
                    {
                        for (int i = 0; i < xmlNodeList.Count; i++)
                        {
                            xmlElement.AppendChild(xml.ImportNode(xmlNodeList.Item(i), true));
                        }
                    }
                }
                else
                {
                    XmlDeclaration decl = xml.CreateXmlDeclaration("1.0", "utf-8", null);
                    xml.AppendChild(decl);
                    XmlElement doc = xml.CreateElement("doc");
                    xml.AppendChild(doc);
                    XmlElement members = xml.CreateElement("members");
                    doc.AppendChild(members);

                    foreach (var xmlNodeList in files源XML)
                    {
                        for (int i = 0; i < xmlNodeList.Count; i++)
                        {
                            members.AppendChild(xml.ImportNode(xmlNodeList.Item(i), true));
                        }
                    }

                }
                xml.Save(file);

                textBox1.AppendText("目标:" + file + "\r\n");
                textBox1.AppendText(" 保存成功" + "\r\n");
            }

            buttonEnabled();

            files源 = new List<string>();
            files源XML = new List<XmlNodeList>();
            files目标 = new List<string>();
            buttonStart.Enabled = false;
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox源.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox目标.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            files源 = new List<string>();
            ParseDirectory(textBox源.Text, files源);

            files源XML = new List<XmlNodeList>();
            foreach (var item in files源)
            {
                if (!File.Exists(item))
                {
                    continue;
                }

                XmlDocument xmls = new XmlDocument();
                xmls.Load(item);
                XmlNodeList childlists = xmls["doc"]["members"].ChildNodes;
                files源XML.Add(childlists);
            }

            files目标 = new List<string>();
            ParseDirectory(textBox目标.Text, files目标);

            buttonStart.Enabled = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Form1.CheckForIllegalCrossThreadCalls = false;
            ThreadStart ts = new ThreadStart(StoT);
            Thread th = new Thread(ts);
            th.Start();
        }
    }
}

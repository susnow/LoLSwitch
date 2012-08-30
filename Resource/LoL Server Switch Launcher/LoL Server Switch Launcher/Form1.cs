using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;
using System.IO;
using System.Diagnostics;

namespace LoL_Server_Switch_Launcher
{
    public partial class lancherForm : Form
    {
        //我的文档目录
        string myDocument = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //当前服务器
        string currentServer;
        //当前文件路径
        string filePath = "empty";

        public lancherForm()
        {
            InitializeComponent();

            string configFileName = myDocument + "\\LoLServerSwitchConfig.xml";
            if (File.Exists(configFileName)){
                XmlDocument xml = new XmlDocument();
                xml.Load(configFileName);
                XmlNode nodeConfig = xml.SelectSingleNode("Config");
                XmlNodeList nodes = nodeConfig.ChildNodes;
                if (nodes.Count > 0) 
                {
                    foreach (XmlElement element in nodes) {
                        switch (element.Name) {
                            case "currentServer": currentServer = element.InnerText; break;
                            case "LoLFilePath": filePath = element.InnerText; break;
                        }
                    }
                }
            }
            else {
                XmlDocument xml = new XmlDocument();
                xml.LoadXml("<?xml version=\"1.0\" encoding=\"utf-8\" ?><Config></Config>");
                XmlNode nodeConfig = xml.SelectSingleNode("Config");
                XmlElement nodeCurrentServer = xml.CreateElement("currentServer");
                nodeCurrentServer.InnerText = "default";
                nodeConfig.AppendChild(nodeCurrentServer);
                XmlElement nodeFilePath = xml.CreateElement("LoLFilePath");
                nodeFilePath.InnerText = "empty";
                nodeConfig.AppendChild(nodeFilePath);
                currentServer = nodeCurrentServer.InnerText;
                filePath = nodeFilePath.InnerText;
                xml.Save(configFileName);
            }


            //首次加载时单选按钮的默认状态
            switch (currentServer) 
            {
                case "default": RadioButton_defaultHost.Checked = true; break;
                case "match": RadioButton_matchHost.Checked = true; break;
                case "test": RadioButton_testHost.Checked = true; break;
            }

            //首次加载时文件夹路径的文字
            Label_filePath.Text = filePath == "empty" ? "x://英雄联盟/TCLS/config/dirserver.xml":filePath;
            
            //首次加载时启动按钮的状态
            Button_startGame.Enabled = filePath == "empty" ? false : true;
        }

        //
        private void SaveConfig(string value, string key)
        {
            XmlDocument xml = new XmlDocument();
            string configFileName = myDocument + "\\LoLServerSwitchConfig.xml";
            xml.Load(configFileName);
            XmlNode nodeConfig = xml.SelectSingleNode("Config");
            XmlNodeList nodes = nodeConfig.ChildNodes;
            if (nodes.Count > 0) {
                foreach (XmlElement element in nodes) {
                    if (element.Name == key) {
                        element.InnerText = value;
                    }
                }
            }
            xml.Save(configFileName);
        }

        //私有方法 定义单选按钮点击时执行的函数
        private void RadioButton_Checked(object sender) 
        {
            RadioButton radiobutton = sender as RadioButton;
            if (filePath == "empty")
            {
                MessageBox.Show("请先指定配置文件的默认路径");    
            }
            else 
            {
                //实例化host对象 用radiobutton的tag属性获取host对象的InnerXML字符串
                Host host = new Host(radiobutton.Tag.ToString());
                
                XmlDocument xml = new XmlDocument();
                xml.Load(filePath);
                XmlNode ParentNode = xml.SelectSingleNode("Server");
                ParentNode.InnerXml = host.InnerXML.ToString();
                xml.Save(filePath);

                //保存配置文件的当前选择服务器键值
                SaveConfig(radiobutton.Tag.ToString(), "currentServer");
            }

        }

        //正式服单选按钮点击事件
        private void RadioButton_defaultHost_Click(object sender, EventArgs e)
        {
            RadioButton_Checked(sender);
        }
        //比赛服单选按钮点击事件
        private void RadioButton_matchHost_Click(object sender, EventArgs e)
        {
            RadioButton_Checked(sender);
        }
        //测试服单选按钮点击事件
        private void RadioButton_testHost_Click(object sender, EventArgs e)
        {
            RadioButton_Checked(sender);
        }

        //选择配置文件按钮单击事件
        private void Button_selectFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML文件|dirserver.xml";
            ofd.FileName = "dirserver.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                
                string name = filePath.Substring(filePath.LastIndexOf("\\") + 1, filePath.LastIndexOf(".") - filePath.LastIndexOf("\\") - 1);
                if (name != "dirserver")
                {
                    MessageBox.Show("选择配置文件错误");
                }
                else
                {
                    SaveConfig(ofd.FileName, "LoLFilePath");
                    Label_filePath.Text = filePath;
                    ofd.InitialDirectory = filePath;
                    Button_startGame.Enabled = true;
                }
            }

        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                notifyIcon.Visible = false;
                this.ShowInTaskbar = true;
            }
        }

        private void Button_startGame_Click(object sender, EventArgs e)
        {
            string client = filePath.Substring(0, filePath.Length - 20);
            client += "client.exe";
            Process.Start(client);
            this.WindowState = FormWindowState.Minimized;
            notifyIcon.Visible = true;
            this.Hide();
            this.ShowInTaskbar = false;
        }

        private void lancherForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) {
                this.ShowInTaskbar = false;
                notifyIcon.Visible = true;
            }
        }

        private void gankButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.ngacn.cc/thread.php?fid=-152678");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.ngacn.cc/thread.php?fid=-152678");
        }



       
        
        

    }
}

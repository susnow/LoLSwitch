using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoL_Server_Switch_Launcher
{
    public class Host
    {
        public StringBuilder InnerXML = new StringBuilder();
        //默认构造函数(无参数)
        public Host() {
            this.InnerXML = new StringBuilder();
        }
        //默认构造函数(带参数)
        public Host(string name) {
            if (name == "default") {
                this.InnerXML.Append("<DirServer count=\"5\" SuccessfulServerID=\"1\" SuccessfulPort=\"5223\">");
                this.InnerXML.Append("<server1 host=\"tdir2.lol.qq.com\" />");
                this.InnerXML.Append("<server2 host=\"113.105.154.159\" />");
                this.InnerXML.Append("<server3 host=\"123.129.223.67\" />");
                this.InnerXML.Append("<server4 host=\"115.236.133.254\" />");
                this.InnerXML.Append("<server5 host=\"118.123.238.43\" />");
                this.InnerXML.Append("<portlist count=\"2\" port1=\"5223\" port2=\"8000\">0</portlist>");
                this.InnerXML.Append("</DirServer>");
            }
            else if (name == "match") {
                this.InnerXML.Append("<DirServer count=\"1\" SuccessfulServerID=\"1\" SuccessfulPort=\"5223\">");
                this.InnerXML.Append("<server1 host=\"113.105.154.158\" />");
                this.InnerXML.Append("<portlist count=\"1\" port1=\"5223\">0</portlist>");
                this.InnerXML.Append("</DirServer> ");
            }
            else if (name == "test") {
                this.InnerXML.Append("<DirServer count=\"1\" SuccessfulServerID=\"1\" SuccessfulPort=\"5223\">");
                this.InnerXML.Append("<server1 host=\"tdir-test.lol.qq.com\" />");
                this.InnerXML.Append("<portlist count=\"1\" port1=\"5223\">0</portlist>");
                this.InnerXML.Append("</DirServer> ");
            }

        }
    }
}

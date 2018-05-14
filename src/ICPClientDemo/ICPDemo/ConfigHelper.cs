using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

using Com.Huawei.Device.ServiceModel;
using System.Threading;
using System.Globalization;
using System.Resources;
using System.Reflection;

namespace ICPDemo
{
    class ConfigHelper
    {
        /// <summary>
        /// 
        /// </summary>
        public static string ConfigFileName
        {
            get { return Path.Combine(Path.GetDirectoryName(typeof(ConfigHelper).Assembly.Location), "Config.xml"); }
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentInfo AgentInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string> Settings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string> PhoneSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string> UportalSettings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public void Save()
        {
            var agentInfo = this.AgentInfo;
            var settings = this.Settings;
            var phoneSettings = this.PhoneSettings;

            XmlDocument xmlDoc = new XmlDocument();

            var rootNode = xmlDoc.CreateElement("configuration");
            var agentNode = xmlDoc.CreateElement("agentInfo");
            var settingNode = xmlDoc.CreateElement("settings");
            var phoneSettingNode = xmlDoc.CreateElement("phoneSettings");
            var uportalNode = xmlDoc.CreateElement("uportalSettings");

            if (agentInfo != null)
            {
                agentNode.SetAttribute("agentId", agentInfo.AgentId);
                agentNode.SetAttribute("agentType", agentInfo.AgentType.ToString());
                agentNode.SetAttribute("phoneNumber", agentInfo.PhoneNumber);
                agentNode.SetAttribute("vcPhoneNumber", agentInfo.VCPhoneNumber);
            }

            if (settings != null)
            {
                foreach (var item in settings)
                {
                    var node = xmlDoc.CreateElement("setting");

                    node.SetAttribute("key", item.Key);
                    node.SetAttribute("value", item.Value);

                    settingNode.AppendChild(node);
                }
            }

            if (phoneSettings != null)
            {
                foreach (var item in phoneSettings)
                {
                    var node = xmlDoc.CreateElement("phoneSetting");

                    if (item.Key != "PhonePassword")
                    {
                        node.SetAttribute("key", item.Key);
                        node.SetAttribute("value", item.Value);
                    }
                    
                    phoneSettingNode.AppendChild(node);
                }
            }

            if (UportalSettings != null)
            {
                foreach (var item in UportalSettings)
                {
                    var node = xmlDoc.CreateElement("uportalSetting");

                    if (item.Key != "UportalPassword")
                    {
                        node.SetAttribute("key", item.Key);
                        node.SetAttribute("value", item.Value);
                    }

                    uportalNode.AppendChild(node);
                }
            }

            rootNode.AppendChild(agentNode);
            rootNode.AppendChild(settingNode);
            rootNode.AppendChild(phoneSettingNode);
            rootNode.AppendChild(uportalNode);

            xmlDoc.AppendChild(rootNode);

            using (var stream = new FileStream(ConfigFileName, FileMode.Create, FileAccess.Write))
            {
                xmlDoc.Save(stream);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static ConfigHelper Load()
        {
            try
            {
                string fileName = ConfigFileName;

                if (!File.Exists(fileName))
                {
                    return null;
                }

                XmlDocument xmlDoc = new XmlDocument();

                XmlReaderSettings setting = new XmlReaderSettings();
                setting.DtdProcessing = DtdProcessing.Prohibit;
                setting.XmlResolver = null;
                setting.ValidationType = ValidationType.Schema;
                XmlReader reader = XmlReader.Create(fileName, setting);
                xmlDoc.Load(reader);
                reader.Close();

                ConfigHelper config = new ConfigHelper();
                config.AgentInfo = new AgentInfo();
                config.Settings = new Dictionary<string, string>();
                config.PhoneSettings = new Dictionary<string, string>();
                config.UportalSettings = new Dictionary<string, string>();

                var agentNode = xmlDoc.SelectSingleNode("/configuration/agentInfo") as XmlElement;

                if (agentNode != null)
                {
                    config.AgentInfo.AgentId = agentNode.GetAttribute("agentId");
                    config.AgentInfo.PassWord = agentNode.GetAttribute("password");
                    config.AgentInfo.PhoneNumber = agentNode.GetAttribute("phoneNumber");
                    config.AgentInfo.VCPhoneNumber = agentNode.GetAttribute("vcPhoneNumber");
                    if ("Video".Equals(agentNode.GetAttribute("agentType")))
                    {
                        config.AgentInfo.AgentType = AgentType.Video;
                    }
                    else
                    {
                        config.AgentInfo.AgentType = AgentType.Audio;
                    }
                }

                var settingNodes = xmlDoc.SelectNodes("/configuration/settings/setting");

                if (settingNodes != null && settingNodes.Count > 0)
                {
                    foreach (XmlNode node in settingNodes)
                    {
                        var node2 = node as XmlElement;

                        if (node2 != null)
                        {
                            var key = node2.GetAttribute("key");
                            var value = node2.GetAttribute("value");

                            if (key != null)
                            {
                                config.Settings[key] = value;
                            }
                        }
                    }
                }

                var phoneSettingNodes = xmlDoc.SelectNodes("/configuration/phoneSettings/phoneSetting");

                if (phoneSettingNodes != null && phoneSettingNodes.Count > 0)
                {
                    foreach (XmlNode node in phoneSettingNodes)
                    {
                        var node2 = node as XmlElement;

                        if (node2 != null)
                        {
                            var key = node2.GetAttribute("key");
                            var value = node2.GetAttribute("value");

                            if (key != null)
                            {
                                config.PhoneSettings[key] = value;
                            }
                        }
                    }
                }

                var uportalSettingNodes = xmlDoc.SelectNodes("/configuration/uportalSettings/uportalSetting");

                if (uportalSettingNodes != null && uportalSettingNodes.Count > 0)
                {
                    foreach (XmlNode node in uportalSettingNodes)
                    {
                        var node2 = node as XmlElement;

                        if (node2 != null)
                        {
                            var key = node2.GetAttribute("key");
                            var value = node2.GetAttribute("value");

                            if (key != null)
                            {
                                config.UportalSettings[key] = value;
                            }
                        }
                    }
                }
                return config;
            }
            catch 
            {
                throw new Exception("Load config failed. ");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static string GetNodeText(XmlNode node)
        {
            return node == null ? null : node.InnerText;
        }

        static CultureInfo cultureInfo = new CultureInfo("en-US");
        //设置当前语言
        public static void SetCurrentCulture(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "en-US";
            }
            cultureInfo = new CultureInfo(name);
        }
        static ResourceManager rm = null;
        static string lauguage;
        //获取值
        public static string GetString(string id)
        {
            string strCurLanguage = "";
            try
            {
                CultureInfo ci = cultureInfo;
                if (ci != null && !string.IsNullOrEmpty(id))
                {
                    if (!ci.IetfLanguageTag.Equals(lauguage))
                    {
                        rm = null;
                    }
                    if (null == rm)
                    {
                        lauguage = ci.IetfLanguageTag;
                        rm = new ResourceManager("ICPDemo.Resources." + ci.IetfLanguageTag, Assembly.GetExecutingAssembly());
                    } 
                    strCurLanguage = rm.GetString(id, ci);
                }
            }
            catch
            {
                strCurLanguage = "null";
            }
            return strCurLanguage;
       }
    }
}
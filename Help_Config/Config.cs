using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using TOEC_Common;

namespace TOEC_Common
{
    /// <summary>
    /// 静态参数类
    /// </summary>
    public static class Config
    {
        /// <summary>
        /// 对应.config配置文件
        /// </summary>
        public static Configuration cf_Base = null, cf_DB = null;
        /// <summary>
        /// 构造函数:设置配置文件对应的路径
        /// </summary>
        static Config()
        {
            ExeConfigurationFileMap
                map_Base = new ExeConfigurationFileMap(),
                map_DB = new ExeConfigurationFileMap();
            //基础配置
            map_Base.ExeConfigFilename = AppDomain.CurrentDomain.BaseDirectory + @"Config\Base.config";
            cf_Base = ConfigurationManager.OpenMappedExeConfiguration(map_Base, ConfigurationUserLevel.None);
            //串口配置
            map_DB.ExeConfigFilename = AppDomain.CurrentDomain.BaseDirectory + @"Config\DB.config";
            cf_DB = ConfigurationManager.OpenMappedExeConfiguration(map_DB, ConfigurationUserLevel.None);
        }

        #region C/S 客户端
        public static string Client_Title
        {
            get
            {
                return cf_Base.AppSettings.Settings["Client_Title"].Value;
            }
        }
        public static string Client_SubTitle
        {
            get
            {
                return cf_Base.AppSettings.Settings["Client_SubTitle"].Value;
            }
        }
        /// <summary>
        /// 图像基础路径
        /// </summary>
        public static string Client_Path_Image
        {
            get
            {
                return cf_Base.AppSettings.Settings["Client_Path_Image"].Value;
            }
        }
        /// <summary>
        /// 图像基础路径-走形
        /// </summary>
        public static string Client_Path_ZXImage
        {
            get
            {
                return cf_Base.AppSettings.Settings["Client_Path_ZXImage"].Value;
            }
        }
        #endregion

        #region 数据库
        /// <summary>
        /// 保存问题延时N分钟
        /// 以便保证入库结束
        /// </summary>
        public static int DelayTime4Save
        {
            get
            {
                return Convert.ToInt16(cf_DB.AppSettings.Settings["DelayTime4Save"].Value);
            }
        }
        public static string DB_IP
        {
            get
            {
                return cf_DB.AppSettings.Settings["DB_IP"].Value;
            }
            set
            {
                try
                {
                    cf_DB.AppSettings.Settings["DB_IP"].Value = value;
                    cf_DB.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }
                catch (Exception ex) { throw ex; }
            }
        }
        public static string DB_USER
        {
            get
            {
                return cf_DB.AppSettings.Settings["DB_USER"].Value;
            }
            set
            {
                try
                {
                    cf_DB.AppSettings.Settings["DB_USER"].Value = value;
                    cf_DB.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }
                catch (Exception ex) { throw ex; }
            }
        }
        public static string DB_PASSWORD
        {
            get
            {
                return cf_DB.AppSettings.Settings["DB_PASSWORD"].Value;
            }
            set
            {
                try
                {
                    cf_DB.AppSettings.Settings["DB_PASSWORD"].Value = value;
                    cf_DB.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }
                catch (Exception ex) { throw ex; }
            }
        }
        public static string DB_SCHEMA
        {
            get
            {
                return cf_DB.AppSettings.Settings["DB_SCHEMA"].Value;
            }
            set
            {
                try
                {
                    cf_DB.AppSettings.Settings["DB_SCHEMA"].Value = value;
                    cf_DB.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }
                catch (Exception ex) { throw ex; }
            }
        }
        public static string DisplayAlarmLevel
        {
            get
            {
                return cf_DB.AppSettings.Settings["DisplayAlarmLevel"].Value;
            }
            set
            {
                try
                {
                    cf_DB.AppSettings.Settings["DisplayAlarmLevel"].Value = value;
                    cf_DB.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }
                catch (Exception ex) { throw ex; }
            }
        }
        public static string ConStr
        {
            get
            {
                return "server=" + Config.DB_IP + ";user id=" + Config.DB_USER + ";password=" + Config.DB_PASSWORD + ";persistsecurityinfo=True;database=" + Config.DB_SCHEMA + "; Convert Zero Datetime=True; Allow Zero Datetime=True;";
            }
        }
        public static string ConStr_EF_SASTAD
        {
            get
            {
                //:base(Config.ConStr_EF_SASTAD)
                return "metadata=res://*/Model.SASTAD_Model.csdl|res://*/Model.SASTAD_Model.ssdl|res://*/Model.SASTAD_Model.msl;provider=MySql.Data.MySqlClient;provider connection string=\"" + ConStr + "\"";
            }
        }
        public static string ConStr_EF_SMART
        {
            get
            {
                //:base(Config.ConStr_EF_SMART)
                return "metadata=res://*/Model.SMART_Model.csdl|res://*/Model.SMART_Model.ssdl|res://*/Model.SMART_Model.msl;provider=MySql.Data.MySqlClient;provider connection string=\"" + ConStr + "\"";
            }
        }
        public static string ConStr_INFORMATION_SCHEMA
        {
            get
            {
                return "server=" + Config.DB_IP + ";user id=" + Config.DB_USER + ";password=" + Config.DB_PASSWORD + ";persistsecurityinfo=True;database=INFORMATION_SCHEMA; Convert Zero Datetime=True; Allow Zero Datetime=True;";
            }
        }
        #endregion

        #region 科峰服务
        /// <summary>
        /// 电报码
        /// </summary>
        public static string TelexCode
        {
            get
            {
                return cf_Base.AppSettings.Settings["TelexCode"].Value;
            }
        }
        /// <summary>
        /// 图片存储路径
        /// 多个路径，用#隔开
        /// </summary>
        public static string Path_GQPics
        {
            get
            {
                return cf_Base.AppSettings.Settings["Path_GQPics"].Value;
            }
        }
        /// <summary>
        /// 视频存储路径
        /// </summary>
        public static string Path_Videos
        {
            get
            {
                return cf_Base.AppSettings.Settings["Path_Videos"].Value;
            }
        }
        /// <summary>
        /// 输出路径
        /// </summary>
        public static string Path_Output
        {
            get
            {
                return cf_Base.AppSettings.Settings["Path_Output"].Value;
            }
        }
        /// <summary>
        /// 最大超时时间
        /// </summary>
        public static int Timeout_Min
        {
            get
            {
                return int.Parse(cf_Base.AppSettings.Settings["Timeout_Min"].Value);
            }
        }
        /// <summary>
        /// 等待入库完成时间
        /// </summary>
        public static int Pending_Min
        {
            get
            {
                return int.Parse(cf_Base.AppSettings.Settings["Pending_Min"].Value);
            }
        }
        #endregion
    }
}

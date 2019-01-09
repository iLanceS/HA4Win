using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ha4win.Model
{
    public class Info
    {
        /// <summary>
        /// 业务虚拟IP网络接口
        /// </summary>
        public String VSInterface = "";
        /// <summary>
        /// 业务启动脚本
        /// </summary>
        public String VSStartScript = "";

        /// <summary>
        /// 运行模式
        /// </summary>
        public RunType RunType = RunType.主控端;

        /// <summary>
        /// 心跳信息-->心跳丢失后启用对外服务网络接口 并设置IP
        /// </summary>
        public HeartInfo HeartInfo = new HeartInfo();
        /// <summary>
        /// 业务虚拟IP
        /// </summary>
        public IPInfo VSIPInfo = new IPInfo();
    }



    public class IPInfo
    {
        public string ip;
        public string mask;
        public string getway;
    }

    public class HeartInfo
    {
        public string romoteIP;
        public int localPort = 5678;
        public int romotePort = 5678;

        public DateTime LastReciveTime = new DateTime();
    }


    public enum RunType
    {
        主控端,
        从控端
    }


}

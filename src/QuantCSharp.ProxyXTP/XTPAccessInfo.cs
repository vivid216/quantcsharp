using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantCSharp.ProxyXTP
{
    public sealed class XTPAccessInfo
    {
        public string FrontIp { get; private set; }
        public int FrontPort { get; private set; }

        public string InvestorID { get; private set; }

        public string Password { get; private set; }

        public byte ClientID { get; private set; }

        public string SoftWareKey { get; private set; }

        public uint HeartInterval { get; private set; }

        public bool Validate { get; private set; }

        public int FrontId { get; set; }
        public ulong SessionId { get; set; }
        public static XTPAccessInfo LoadAccessInfo(string sectionNode)
        {
            Utilities.INIHelper iNIHelper = new Utilities.INIHelper(System.IO.Path.Combine("configs", "xtpconfig.ini"));
            string fdress = iNIHelper.ReadIniSection($"{sectionNode}:FrontIp");
            XTPAccessInfo accessInfo = new XTPAccessInfo();
            if (!String.IsNullOrEmpty(fdress))
            {
                accessInfo.FrontIp = iNIHelper[$"{sectionNode}:FrontIp"];
                accessInfo.FrontPort = iNIHelper.ReadInt32($"{sectionNode}:FrontPort");
                accessInfo.InvestorID = iNIHelper[$"{sectionNode}:InvestorID"];
                accessInfo.Password = iNIHelper[$"{sectionNode}:Password"];
                accessInfo.SoftWareKey = iNIHelper[$"{sectionNode}:SoftWareKey"];
                accessInfo.ClientID = Convert.ToByte(iNIHelper.ReadInt32($"{sectionNode}:ClientID"));
                accessInfo.HeartInterval = Convert.ToUInt32( iNIHelper.ReadInt32($"{sectionNode}:HeartInterval"));
                accessInfo.Validate = true;
            }
            return accessInfo;
        }
    }
}

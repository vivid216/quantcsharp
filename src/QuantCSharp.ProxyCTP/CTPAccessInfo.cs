using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantCSharp.ProxyCTP
{
    public sealed class CTPAccessInfo : IEqualityComparer<CTPAccessInfo>
    {
        public string FrontAddress { get; private set; }

        public string BrokerID { get; private set; }

        public string InvestorID { get; private set; }

        public string Password { get; private set; }

        public string UserID { get; private set; }

        public string UserProductInfo { get; private set; }

        public string AuthCode { get; private set; }
        public string AppID { get; private set; }

        public bool Validate { get; private set; }

        public int FrontId { get; set; }
        public int SessionId { get; set; }


        public static CTPAccessInfo LoadAccessInfo(string sectionNode, string configPath)
        {
            Utilities.INIHelper iNIHelper = new Utilities.INIHelper(configPath);
            string fdress = iNIHelper.ReadIniSection($"{sectionNode}:FrontAddress");
            CTPAccessInfo accessInfo = new CTPAccessInfo();
            if (!String.IsNullOrEmpty(fdress))
            {
                accessInfo.FrontAddress = iNIHelper[$"{sectionNode}:FrontAddress"];
                accessInfo.BrokerID = iNIHelper[$"{sectionNode}:BrokerID"];
                accessInfo.InvestorID = iNIHelper[$"{sectionNode}:InvestorID"];
                accessInfo.UserID = iNIHelper[$"{sectionNode}:UserID"];
                accessInfo.Password = iNIHelper[$"{sectionNode}:Password"];
                accessInfo.UserProductInfo = iNIHelper[$"{sectionNode}:UserProductInfo"];
                accessInfo.AuthCode = iNIHelper[$"{sectionNode}:AuthCode"];
                accessInfo.AppID = iNIHelper[$"{sectionNode}:AppID"];
                accessInfo.Validate = true;
            }
            return accessInfo;
        }

        bool IEqualityComparer<CTPAccessInfo>.Equals(CTPAccessInfo x, CTPAccessInfo y)
        {
            return x.InvestorID.Equals(y.InvestorID);
        }

        int IEqualityComparer<CTPAccessInfo>.GetHashCode(CTPAccessInfo obj)
        {
            return obj.InvestorID.GetHashCode();
        }
    }
}

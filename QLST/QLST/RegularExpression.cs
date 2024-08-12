using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QLST
{
    public class RegularExpression
    {
        private static RegularExpression instance;

        public static RegularExpression Instance { get {
                if (instance == null)
                {
                    instance = new RegularExpression();
                }
                return instance;
            }  }

        public bool checkUnicode(string strChecked)
        {
            Regex regex = new Regex(@"([^\w\s])|([0-9])");
            Match result = regex.Match(strChecked);
            bool kTra = result.Success;
            if (kTra == true)
            {
                return false;
            }
            return true;
            
        }
        public bool checkNumber(string strChecked)
        {
            Regex regex = new Regex(@"[^0-9]");
            Match result = regex.Match(strChecked);
            bool kTra = result.Success;
            if (kTra == true)
            {
                return false;
            }
            return true;
        }
        public bool checkcharacterSpecial(string strChecked)
        {
            Regex regex = new Regex(@"[^0-9a-zA-Z]");
            Match result = regex.Match(strChecked);
            bool ktra = result.Success;
            if (ktra == true)
                return false;
            return true;
        }
    }
}

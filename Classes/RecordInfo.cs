using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C898_Capstone.Classes
{
    class RecordInfo
    {
        public static DateTime recordModified {
            get { return recordModified; }
            set { recordModified = DateTime.Now; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityManagement
{
    
    internal class NewReading
    {
        public int unitNum;
        public int tempReading;
        public static  List<NewReading> newReadingList = new List<NewReading>();
        public NewReading (int unitNum, int tempReading)
        {
            this.unitNum = unitNum;
            this.tempReading = tempReading;
            newReadingList.Add(this);
        }
    }
}

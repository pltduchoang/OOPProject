using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityManagement
{
    class AppartmentCreator
    {
        public int unitNum;
        public string fName;
        public string lName;
        public string beganDate;
        public double deposite;
        public int phone;
        public int rent;
        public int waterLaundry;
        public int lastPower;
        public int power;

        List<AppartmentCreator> appartmentList = new List<AppartmentCreator>();

        public AppartmentCreator(int unitNum, string fName, string lName, string beganDate, int deposite, int phone, int rent, int waterLaundry, int lastPower, int power)
        {
            this.unitNum = unitNum;
            this.fName = fName;
            this.lName = lName;
            this.beganDate = beganDate;
            this.deposite = deposite;
            this.phone = phone;
            this.rent = rent;
            this.waterLaundry = waterLaundry;
            this.lastPower = lastPower;
            this.power = power;
        }
    }
}

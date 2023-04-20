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
        public string phone;
        public double rent;
        public double waterLaundry;
        public int lastPower;
        public int power;

        

        public AppartmentCreator(int unitNum, string fName, string lName, string beganDate, double deposite, string phone, double rent, double waterLaundry, int lastPower, int power)
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

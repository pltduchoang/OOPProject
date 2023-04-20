using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityManagement.Database
{
    //class DataRead
    //{
    //    //private DBConnect connect;

    //    public DataRead()
    //    {
    //        DBConnect connect = new DBConnect();
    //        //connect = connector;

    //    }
    //    /// <summary>
    //    /// Data from Tenant Table
    //    /// To get data for only one use index
    //    /// </summary>
    //    /// <returns></returns>
    //    public List<string> Appartment()
    //    {
    //        DBConnect connect = new DBConnect();
    //        List<string>[] TenantList = connect.DataTenent();
    //        List<string> AppartmentNum = TenantList[0];
    //        return AppartmentNum;
    //    }
    //    public List<string> FirstName()
    //    {
    //        DBConnect connect = new DBConnect();
    //        List<string>[] TenantList = connect.DataTenent();
    //        List<string> fName = TenantList[1];
    //        return fName;
    //    }
    //    public List<string> LastName()
    //    {
    //        DBConnect connect = new DBConnect();
    //        List<string>[] TenantList = connect.DataTenent();
    //        List<string> lName = TenantList[2];
    //        return lName;
    //    }
    //    public List<string> Date()
    //    {
    //        DBConnect connect = new DBConnect();
    //        List<string>[] TenantList = connect.DataTenent();
    //        List<string> date = TenantList[3];
    //        return date;
    //    }
    //    public List<string> Deposit()
    //    {
    //        DBConnect connect = new DBConnect();
    //        List<string>[] TenantList = connect.DataTenent();
    //        List<string> deposit = TenantList[4];
    //        return deposit;
    //    }
    //    public List<string> Phone()
    //    {
    //        DBConnect connect = new DBConnect();
    //        List<string>[] TenantList = connect.DataTenent();
    //        List<string> phone = TenantList[5];
    //        return phone;
    //    }

    //    /// <summary>
    //    /// Data from Bill Table
    //    /// To get data for only one use index
    //    /// Appartment/Unit Number already displayed from Tenant Table
    //    /// 
    //    /// Rent($): Price of Rent
    //    /// Water($): Price of water and laundray
    //    /// PowerUsage(kWh): Power used in kilowatts per hour
    //    /// Power($): Price of Power, pre-calculated: (13.5*PowerUsage) / 100
    //    /// </summary>
    //    /// <returns></returns>
    //    public List<string> Rent()
    //    {
    //        DBConnect connect = new DBConnect();
    //        List<string>[] BillList = connect.DataBill();
    //        List<string> rent = BillList[0];
    //        return rent;
    //    }
    //    public List<string> Water()
    //    {
    //        DBConnect connect = new DBConnect();
    //        List<string>[] BillList = connect.DataBill();
    //        List<string> water = BillList[1];
    //        return water;
    //    }
    //    public List<string> PowerUsage() // Power units in kiloWatts per hour (kWh)
    //    {
    //        DBConnect connect = new DBConnect();
    //        List<string>[] BillList = connect.DataBill();
    //        List<string> usage = BillList[2];
    //        return usage;
    //    }
    //    public List<string> Power() // Price pre-calculated by 13.5c from power usage
    //    {
    //        DBConnect connect = new DBConnect();
    //        List<string>[] BillList = connect.DataBill();
    //        List<string> power = BillList[3];
    //        return power;
    //    }
    //}
}

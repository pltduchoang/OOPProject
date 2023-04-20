using Microsoft.Maui.Graphics.Text;
using System.Security.Cryptography.X509Certificates;

namespace UtilityManagement.Utility;

public partial class Utility101 : ContentPage
{
    AppartmentCreator appGlobal = null;
    public Utility101()
    
    
	{
		InitializeComponent();
        Database.DBConnect dBConnect = new Database.DBConnect();
        List<AppartmentCreator> tempList = dBConnect.DataTenent();

        int index = 0;
        while (tempList[index].unitNum != 101 && index < tempList.Count())
        {
            index++;
        }
        AppartmentCreator app = tempList[index];
        this.appGlobal = app;
        this.TenantName.Text = ($"{app.fName} {app.lName}");
        this.Rent.Text = app.rent.ToString();
        this.WaterLaundry.Text = app.waterLaundry.ToString();
        this.LastElectricity.Text= app.power.ToString();
               
    }

    public void Calculation(object sender, EventArgs e)
    {
        int input = Int32.Parse(this.NewElectricity.Text);
        int usage = input - this.appGlobal.power;
        double cost = usage * 1.4;
        this.ElectricityCost.Text = cost.ToString();
        double ammountDue = appGlobal.rent + appGlobal.waterLaundry + cost;
        this.TotalAmmount.Text = ammountDue.ToString();

        string message = ($"Dear {appGlobal.fName} {appGlobal.lName} residing at Apparment {appGlobal.unitNum}! \nPlease check the below for this month rent details \nRent: {appGlobal.rent} \nFixed charge of Water and Laundry: {appGlobal.waterLaundry} \nElectricity Usage: {input} - {appGlobal.power} = {usage} ==> Cost: {cost} \nTotal Due: {ammountDue}");
        this.SmS.Text = message;
    }

}
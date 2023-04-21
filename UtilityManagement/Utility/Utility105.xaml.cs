using UtilityManagement.ThisException;

namespace UtilityManagement.Utility;

public partial class Utility105 : ContentPage
{
    AppartmentCreator appGlobal = null;
    public Utility105()
	{
        InitializeComponent();
        Database.DBConnect dBConnect = new Database.DBConnect();
        List<AppartmentCreator> tempList = dBConnect.DataTenent();

        int roomNo = 105;
        int index = 0;
        while (tempList[index].unitNum != roomNo && index < tempList.Count())
        {
            index++;
        }
        if (tempList[index].unitNum != roomNo)
        {
            DisplayAlert("Ooops", "Data not found", "Cancel");
            throw new DataNotFoundException();
        }
        else
        {
            this.appGlobal = tempList[index];
            this.TenantName.Text = ($"{appGlobal.fName} {appGlobal.lName}");
            this.Rent.Text = appGlobal.rent.ToString();
            this.WaterLaundry.Text = appGlobal.waterLaundry.ToString();
            this.LastElectricity.Text = appGlobal.power.ToString();
        }
    }

    public void Calculation(object sender, EventArgs e)
    {
        if (this.NewElectricity.Text == null)
        {
            throw new BlankRequiredFieldException();
        }
        else
        {
            int input;
            if (int.TryParse(this.NewElectricity.Text, out input))
            {
                if (input >= this.appGlobal.power)
                {
                    int usage = input - this.appGlobal.power;
                    double cost = usage * 1.4;
                    this.ElectricityCost.Text = cost.ToString();
                    double ammountDue = appGlobal.rent + appGlobal.waterLaundry + cost;
                    this.TotalAmmount.Text = ammountDue.ToString();
                    string message = ($"Dear {appGlobal.fName} {appGlobal.lName} residing at Apparment {appGlobal.unitNum}! \nPlease check the below for this month rent details\n{"New Electricity Reading: ",-25}{input}-{appGlobal.power}\n{"Electricity Usage: ",-25}{usage}\n{"Electricity Cost: ",-25}{cost}\n{"Rent: ",-25}{appGlobal.rent}\n{"Fixed Water and Laundry: ",-25}{appGlobal.waterLaundry}\n{"Total Due: ",-25}{ammountDue}");
                    this.SmS.Text = message;
                }
                else
                {
                    throw new InvalidInputException();
                }
            }
            else
            {
                throw new InvalidInputException();
            }
        }
    }
}
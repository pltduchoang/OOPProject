using UtilityManagement.Database;
namespace UtilityManagement.Appartment;


public partial class Appartment101 : ContentPage
{
    //variable to hole matched apartment object
    AppartmentCreator appGlobal = null;

    public Appartment101()
	{
		InitializeComponent();
        
        //Connect to database
        Database.DBConnect dBConnect = new Database.DBConnect();

        //List of Apartment object
        List<AppartmentCreator> tempList = dBConnect.DataTenent();

        //Identify room number
        int roomNo = 101;
        int index = 0;
        

        //Matching the correct apartment
        while (tempList[index].unitNum != roomNo && index < tempList.Count())
        {
            index++;
        }

        //If no matching apartment found / problem with database
        if (tempList[index].unitNum != roomNo)
        {
            DisplayAlert("Ooops", "Data not found", "Cancel");
        }

        //Populate the label fields
        else
        {
            this.appGlobal = tempList[index];
            this.TenantName.Text = ($"{appGlobal.fName} {appGlobal.lName}");
            this.MoveInDate.Text = appGlobal.beganDate.ToString();
            this.PhoneNumber.Text = ($"{appGlobal.phone.Substring(0,3)}.{appGlobal.phone.Substring(3,3)}.{appGlobal.phone.Substring(6,4)}");
            this.Deposit.Text = ($"{appGlobal.deposite:C2}");
        }

        
    }
}
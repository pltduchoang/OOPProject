using UtilityManagement.Database; 
namespace UtilityManagement.Appartment;


public partial class Appartment101 : ContentPage
{
	public Appartment101()
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
        this.TenantName.Text = ($"{app.fName} {app.lName}");
        this.MoveInDate.Text = app.beganDate.ToString();
        this.PhoneNumber.Text = app.phone.ToString();
        this.Deposit.Text = app.deposite.ToString();
    }
}
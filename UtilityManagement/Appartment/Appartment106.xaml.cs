namespace UtilityManagement.Appartment;

public partial class Appartment106 : ContentPage
{
	public Appartment106()
    {
        InitializeComponent();
        Database.DBConnect dBConnect = new Database.DBConnect();
        List<AppartmentCreator> tempList = dBConnect.DataTenent();

        int index = 0;
        while (tempList[index].unitNum != 106 && index < tempList.Count())
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
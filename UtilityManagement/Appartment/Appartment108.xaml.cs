namespace UtilityManagement.Appartment;

public partial class Appartment108 : ContentPage
{
	public Appartment108()
    {
        InitializeComponent();
        Database.DBConnect dBConnect = new Database.DBConnect();
        List<AppartmentCreator> tempList = dBConnect.DataTenent();

        int index = 0;
        while (tempList[index].unitNum != 108 && index < tempList.Count())
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
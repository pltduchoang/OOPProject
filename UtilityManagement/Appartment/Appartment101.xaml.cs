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
        while (tempList[i].unitNum != 101)
        {
            index++;
        }
        AppartmentCreator app = tempList[index];
        this.TenantName.Text = ($"{app.fName} {app.lName}");

    }
}
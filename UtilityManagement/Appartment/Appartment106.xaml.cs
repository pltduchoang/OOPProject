using UtilityManagement.Database;
using UtilityManagement.ThisException;
namespace UtilityManagement.Appartment;

public partial class Appartment106 : ContentPage
{
    AppartmentCreator appGlobal = null;
    public Appartment106()
    {
        InitializeComponent();
        Database.DBConnect dBConnect = new Database.DBConnect();
        List<AppartmentCreator> tempList = dBConnect.DataTenent();

        int roomNo = 106;
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
            this.MoveInDate.Text = appGlobal.beganDate.ToString();
            this.PhoneNumber.Text = ($"{appGlobal.phone.Substring(0, 3)}.{appGlobal.phone.Substring(3, 3)}.{appGlobal.phone.Substring(6, 4)}");
            this.Deposit.Text = ($"{appGlobal.deposite:C2}");
        }
    }
}
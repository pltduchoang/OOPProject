using UtilityManagement.Database;
namespace UtilityManagement.Setting;

public partial class UpdateAppartment : ContentPage
{
    public UpdateAppartment()
    {
        InitializeComponent();

        DBConnect dBConnect = new DBConnect();
        List<AppartmentCreator> tempList = dBConnect.DataTenent();

        this.TenantName.Text = ($"{tempList[this.Picker.SelectedIndex].fName} {tempList[this.Picker.SelectedIndex].lName}");
        this.MoveInDate.Text = tempList[this.Picker.SelectedIndex].beganDate.ToString();
        this.PhoneNumber.Text = ($"{tempList[this.Picker.SelectedIndex].phone.Substring(0, 3)}.{tempList[this.Picker.SelectedIndex].phone.Substring(3, 3)}.{tempList[this.Picker.SelectedIndex].phone.Substring(6, 4)}");
        this.Deposit.Text = ($"{tempList[this.Picker.SelectedIndex].deposite:C2}");
    }

    public void Go(object sender, EventArgs e)
    {
        DBConnect dBConnect = new DBConnect();
        List<AppartmentCreator> tempList = dBConnect.DataTenent();

        this.TenantName.Text = ($"{tempList[this.Picker.SelectedIndex].fName} {tempList[this.Picker.SelectedIndex].lName}");
        this.MoveInDate.Text = tempList[this.Picker.SelectedIndex].beganDate.ToString();
        this.PhoneNumber.Text = ($"{tempList[this.Picker.SelectedIndex].phone.Substring(0, 3)}.{tempList[this.Picker.SelectedIndex].phone.Substring(3, 3)}.{tempList[this.Picker.SelectedIndex].phone.Substring(6, 4)}");
        this.Deposit.Text = ($"{tempList[this.Picker.SelectedIndex].deposite:C2}");
    }

    public void Update(object sender, EventArgs e)
    {
        
    }
}
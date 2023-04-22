using System;
using UtilityManagement.Database;
namespace UtilityManagement.Setting;

public partial class UpdateUtility : ContentPage
{
	public UpdateUtility()
	{
		InitializeComponent();

        DBConnect dBConnect = new DBConnect();
        List<AppartmentCreator> tempList = dBConnect.DataTenent();

        this.Rent.Text = ($"{tempList[this.Picker.SelectedIndex].rent:C2}");
        this.WaterLaundry.Text = ($"{tempList[this.Picker.SelectedIndex].waterLaundry:C2}");
    }

    public void Go(object sender, EventArgs e)
    {
        DBConnect dBConnect = new DBConnect();
        List<AppartmentCreator> tempList = dBConnect.DataTenent();

        this.Rent.Text = ($"{tempList[this.Picker.SelectedIndex].rent:C2}");
        this.WaterLaundry.Text = ($"{tempList[this.Picker.SelectedIndex].waterLaundry:C2}");
    }

    public void Update(object sender, EventArgs e)
    {

    }
}
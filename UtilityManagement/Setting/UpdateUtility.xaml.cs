using System;
using System.Globalization;
using UtilityManagement.Database;
using UtilityManagement.Utility;

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
        this.NewElectric.Text = tempList[this.Picker.SelectedIndex].newPower.ToString();
    }

    //Initiate populating database after change appartment page
    public void Go(object sender, EventArgs e)
    {
        DBConnect dBConnect = new DBConnect();
        List<AppartmentCreator> tempList = dBConnect.DataTenent();

        this.Rent.Text = ($"{tempList[this.Picker.SelectedIndex].rent:C2}");
        this.WaterLaundry.Text = ($"{tempList[this.Picker.SelectedIndex].waterLaundry:C2}");
        this.NewElectric.Text = tempList[this.Picker.SelectedIndex].newPower.ToString();
        foreach (NewReading item in NewReading.newReadingList)
        {
            if (tempList[this.Picker.SelectedIndex].unitNum == item.unitNum)
            {
                this.NewElectric.Text = item.tempReading.ToString();
                break;
            }
        }
    }

    //Update new input into the database
    public void Update(object sender, EventArgs e)
    {
        DBConnect dBConnect = new DBConnect();
        int unitNum = int.Parse(this.Picker.SelectedItem.ToString().Substring(11));
        double rent = double.Parse(this.Rent.Text, NumberStyles.Currency);
        double waterLaundry = double.Parse(this.WaterLaundry.Text, NumberStyles.Currency);
        int power = int.Parse(this.NewElectric.Text);

        dBConnect.UpdateUtility(unitNum, rent, waterLaundry, power);
        DisplayAlert("Confirmation", "Updated Successfully!", "OK");
    }
}
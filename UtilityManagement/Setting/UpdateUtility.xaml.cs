using System;
using System.Globalization;
using UtilityManagement.Database;
namespace UtilityManagement.Setting;

public partial class UpdateUtility : ContentPage
{
    int powerReading;
	public UpdateUtility()
	{
		InitializeComponent();

        DBConnect dBConnect = new DBConnect();
        List<AppartmentCreator> tempList = dBConnect.DataTenent();

        this.Rent.Text = ($"{tempList[this.Picker.SelectedIndex].rent:C2}");
        this.WaterLaundry.Text = ($"{tempList[this.Picker.SelectedIndex].waterLaundry:C2}");
        this.powerReading = tempList[this.Picker.SelectedIndex].power;
        this.NewElectric.Text = null;
        foreach (NewReading item in NewReading.newReadingList)
        {
            if (tempList[this.Picker.SelectedIndex].unitNum == item.unitNum)
            {
                this.NewElectric.Text = item.tempReading.ToString();
                break;
            }
        }
        
    }

    public void Go(object sender, EventArgs e)
    {
        DBConnect dBConnect = new DBConnect();
        List<AppartmentCreator> tempList = dBConnect.DataTenent();

        this.Rent.Text = ($"{tempList[this.Picker.SelectedIndex].rent:C2}");
        this.WaterLaundry.Text = ($"{tempList[this.Picker.SelectedIndex].waterLaundry:C2}");
        this.NewElectric.Text = null;
        foreach (NewReading item in NewReading.newReadingList)
        {
            if (tempList[this.Picker.SelectedIndex].unitNum == item.unitNum)
            {
                this.NewElectric.Text = item.tempReading.ToString();
                break;
            }
        }
    }

    public void Update(object sender, EventArgs e)
    {
        DBConnect dBConnect = new DBConnect();
        int unitNum = int.Parse(this.Picker.SelectedItem.ToString().Substring(11));
        double rent = double.Parse(this.Rent.Text, NumberStyles.Currency);
        double waterLaundry = double.Parse(this.WaterLaundry.Text, NumberStyles.Currency);
        //int oldReading;
        //int newReading;
        //if (this.NewElectric.Text != null)
        //{
        //    oldReading = powerReading;
        //    newReading = int.Parse(this.NewElectric.Text);

        //}

        dBConnect.UpdateUtility(unitNum, rent, waterLaundry);
        DisplayAlert("Confirmation", "Updated Successfully!", "OK");
    }
}
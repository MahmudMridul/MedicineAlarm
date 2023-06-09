using MedicineAlarm.Data;

namespace MedicineAlarm.Pages;

public partial class AddPage : ContentPage
{
	public AddPage()
	{
		InitializeComponent();
	}

	private void OnAdd(object sender, EventArgs e)
	{
        MedicineData data = new MedicineData
        {
            MedicineName = medicineName.Text,
            MedTakingTime = medTakingTime.SelectedItem.ToString(),
            Meal = meal.SelectedItem.ToString(),
            AlarmTime = alarmTime.Time
        };
        MedicineList.Instance.Medicines.Add(data);
        JsonDataHandler.Instance.SaveDataToJson(MedicineList.Instance.Medicines);
    }
}
using MedicineAlarm.Data;

namespace MedicineAlarm.Pages;

public partial class DataBindingPage : ContentPage
{
	public MedicineData data = new MedicineData()
	{
		MedicineName = "Ocustin",
		Meal = "Now",
		MedTakingTime = "Now",
		AlarmTime = TimeSpan.MinValue
	};
	public DataBindingPage()
	{
		InitializeComponent();
		//Label.BindingContext = FontSizeInput;
		//Label.SetBinding(Label.FontSizeProperty, "Text");
		this.BindingContext = data;
	}
}
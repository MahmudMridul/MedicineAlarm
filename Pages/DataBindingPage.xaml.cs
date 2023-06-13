using MedicineAlarm.Data;

namespace MedicineAlarm.Pages;

public partial class DataBindingPage : ContentPage
{
	public List<MedicineData> Data { get; set; } = new List<MedicineData>()
    {
        new MedicineData()
        {
            MedicineName = "Ocustin",
            Meal = "Now",
            MedTakingTime = "Now",
            AlarmTime = TimeSpan.MinValue
        },
        new MedicineData()
        {
            MedicineName = "Napa",
            Meal = "Now",
            MedTakingTime = "Now",
            AlarmTime = TimeSpan.MinValue
        },
        new MedicineData()
        {
            MedicineName = "Ace",
            Meal = "Now",
            MedTakingTime = "Now",
            AlarmTime = TimeSpan.MinValue
        }
    };

    public DataBindingPage()
	{
		InitializeComponent();
        //Label.BindingContext = FontSizeInput;
        //Label.SetBinding(Label.FontSizeProperty, "Text");
        //medName.BindingContext = Data;
        //medName.SetBinding(Label.TextProperty, "MedicineName");
    }
}
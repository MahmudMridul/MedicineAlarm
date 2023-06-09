using MedicineAlarm.Data;

namespace MedicineAlarm.Pages;

public partial class ListPage : ContentPage
{
    public ListPage()
    {
        InitializeComponent();
        JsonDataHandler.Instance.LoadDataFromJson();
        this.BindingContext = MedicineList.Instance;
    }
}
using MedicineAlarm.Data;
using System.Collections.ObjectModel;

namespace MedicineAlarm.Pages;

public partial class ListPage : ContentPage
{
    public ObservableCollection<MedicineData> Data { get; set; }
    public ListPage()
    {
        Data = JsonDataHandler.Instance.LoadDataFromJson();
        InitializeComponent();
        
    }

    private void OnEdit(object sender, EventArgs e)
    {

    }

    private void OnDelete(object sender, EventArgs e)
    {

    }
}
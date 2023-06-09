using System.Collections.ObjectModel;

namespace MedicineAlarm.Data
{
    public class MedicineList
    {
        public ObservableCollection<MedicineData> Medicines { get; set; }
        private static MedicineList instance;

        public static MedicineList Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new MedicineList();
                }
                return instance;
            }
        } 
        private MedicineList()
        {
            Medicines = new ObservableCollection<MedicineData>();
        }
    }
}

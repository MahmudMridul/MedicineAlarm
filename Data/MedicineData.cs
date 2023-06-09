
namespace MedicineAlarm.Data
{
    public class MedicineData
    {
        public string MedicineName { get; set; }
        public string MedTakingTime { get; set; }
        public string Meal { get; set; } 
        public TimeSpan AlarmTime { get; set; }
    }
}

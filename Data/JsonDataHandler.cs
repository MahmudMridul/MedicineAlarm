using System.Collections.ObjectModel;
using System.Text.Json;

namespace MedicineAlarm.Data
{
    public class JsonDataHandler
    {
        private string jsonFilePath;
        private static JsonDataHandler instance;

        public static JsonDataHandler Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new JsonDataHandler();
                }
                return instance;
            }
        }

        private JsonDataHandler() 
        {
            // Retrieve the app's local data directory path
            string localDataDirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            // Combine the local data directory path with your desired subdirectory
            string dbFolderPath = Path.Combine(localDataDirPath, "DB");

            jsonFilePath = Path.Combine(dbFolderPath, "data.json");

            if (!File.Exists(jsonFilePath))
            {
                // Create a new JSON file and store the data
                Directory.CreateDirectory(Path.GetDirectoryName(jsonFilePath));
            }
        }

        public ObservableCollection<MedicineData> LoadDataFromJson() 
        {
            // Append the data to the existing JSON file
            string existingData = File.ReadAllText(jsonFilePath);
            MedicineList.Instance.Medicines = JsonSerializer.Deserialize<ObservableCollection<MedicineData>>(existingData);
            return MedicineList.Instance.Medicines;
        }

        public void SaveDataToJson(ObservableCollection<MedicineData> Medicines)
        {
            string updatedData = JsonSerializer.Serialize(MedicineList.Instance.Medicines);
            File.WriteAllText(jsonFilePath, updatedData);
        }

    }
}

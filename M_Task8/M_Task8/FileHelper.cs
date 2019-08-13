using System;
using System.IO;
using Newtonsoft.Json;

namespace M_Task8
{
    public class FileHelper
    {
        public static void SerealizationIntoJSONFile(Shipment shipments, string filePath)
        {
            if (shipments == null)
            {
                throw new Exception("Shipments list not initialized");
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath); //создает и оставляет файл открытым и в итоге он занят другим процессом
            }

            using (StreamWriter file = new StreamWriter(filePath))
            {
                new JsonSerializer().Serialize(file, shipments);
            }
        }

        public static bool DeserealizationFromJSONFile(out Shipment shipments, string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Not found file: {filePath}");
            }

            using (StreamReader file = File.OpenText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                shipments = (Shipment)serializer.Deserialize(file, typeof(Shipment));
            }

            return true;
        }
    }
}

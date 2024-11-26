using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using OnlineQuizPlatform.Helper;
using OnlineQuizPlatform.Models;

namespace OnlineQuizPlatform.DB
{
    internal static class FakeDB
    {
        private const string dbFilePath = "C:\\Users\\ქეთათო\\Desktop\\New folder (2)\\Data.Json";
        public static DBDataModel Data;

        static FakeDB()
        {
            var fileHelper = new FileHelper(dbFilePath);
            var json = fileHelper.ReadFromFile();
            if (!string.IsNullOrWhiteSpace(json))
            {
                Data = JsonSerializer.Deserialize<DBDataModel>(json);
            }

            Data ??= new DBDataModel();

        }


        public static bool SaveState()
        {
            var fileHelper = new FileHelper(dbFilePath);
            fileHelper.WriteInFile(JsonSerializer.Serialize(Data));

            return true;
        }

    }
}

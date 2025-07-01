using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace UserDefinedDataTypePath
{
    public class ConfigPath
    {
        public string Path1 { get; set; }
        public string Path2 { get; set; }
    }
    public class Config
    {
        public ConfigPath Paths { get; set; }
        //public Config()
        //{
        //    // Initialize Paths with default values
        //    Paths = new ConfigPath
        //    {
        //        Path1 = @"C:\Input\input.txt",
        //        Path2 = @"C:\Output\output.csv"
        //    };
        //}
    
    }
    public class UserDefinedDataTypeRead
    {
        public static void ReadPathFromConfig()
        {
            string json = File.ReadAllText("D:\\Projects\\C#\\CSharpCrash\\CSharpCrash\\UserDefinedDataTypePath\\Config\\config.json");
            Config config= JsonSerializer.Deserialize<Config>(json);

            Console.WriteLine("Read Path from config.json"+config.Paths.Path2);
        }

    }
}

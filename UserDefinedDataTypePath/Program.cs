using UserDefinedDataTypePath;

public class ConfigPath
{
     public string Path1 { get; set; }
     public string Path2 { get; set; }
}

public class Config
{ public ConfigPath Paths { get; set; }
    public Config()
    {
        // Initialize Paths with default values
        Paths = new ConfigPath
        {
            Path1 = @"C:\Input\input.txt",
            Path2 = @"C:\Output\output.csv"
        };
    }
}
    public class UserDefinedDataTypeIntro {
        public static void Main() {
            Console.WriteLine("Hello World!");
            
            Config config = new Config();

            Console.WriteLine(config.Paths.Path1);
        UserDefinedDataTypeRead.ReadPathFromConfig();
            
        }
    }


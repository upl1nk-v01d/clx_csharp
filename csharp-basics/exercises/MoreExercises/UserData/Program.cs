using Newtonsoft.Json;
using UserData.Models;
using System.IO;
using System.Linq;

namespace UserData
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var content = GetFileContent();
            var users = JsonConvert.DeserializeObject<List<User>>(content);

            string workingDir = FM.CurrentDir();
            string desktopDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) ?? "";
            
            //Console.WriteLine("\n-- Current directory -- ");
            //FM.ListFiles(FM.CurrentDir());
            //Console.WriteLine("\n-- Parrent directory -- ");
            //FM.SetWorkDir("../");
            //FM.ListFiles(FM.CurrentDir());
            //Console.WriteLine("\n-- Desktop directory -- ");
            //FM.SetWorkDir(desktopDir);
            //FM.ListFiles(FM.CurrentDir());

            var demoFile1 = "demo.txt";
            FM.CreateFile(demoFile1);
            File.WriteAllText(demoFile1, $"Hello, from {FM.GetFileAbsPath(demoFile1)}");
            var demoFile2 = FM.CopyFile(demoFile1, ".", "demo2.txt");
            File.AppendAllText(demoFile2, $"\nThis is the copy");
        }

        private static string GetFileContent()
        {
            var relativePath = "UserData.json";
            var jsonContent = File.ReadAllText(relativePath);
            return jsonContent;
        }
    }
}
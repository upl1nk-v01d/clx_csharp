namespace UserData
{
    static class FM
    {
        public static void CreateFile(string fileName)
        {
            if(File.Exists(fileName))
            {
                Console.WriteLine($"File {fileName} already exists!");
            }
            else
            {
                File.Create(fileName).Dispose();
                Console.WriteLine($"File {fileName} is created!");
            }
        }

        public static string CopyFile(string fileName, string destination, string newName = "")
        {
            if(File.Exists(fileName))
            {
                newName = newName.Length < 1 ? newName = $"[copy]_{fileName}" : newName;
                
                if(File.Exists(destination + "/" + newName))
                {
                    Console.WriteLine($"File {newName} in {destination} already exist!");
                }
                else
                {
                    File.Copy(fileName, destination + "/" + newName, false);
                    Console.WriteLine($"File {fileName} copied to {destination}!");
                }
            }
            else
            {
                Console.WriteLine($"File {fileName} does not exist!");
            }

            return newName;
        }

        public static string GetFileAbsPath(string fileName)
        {
            if(File.Exists(fileName))
            {
                Console.WriteLine($"File {fileName} path is: {Path.GetFullPath(fileName)}");
                return Path.GetFullPath(fileName);
            }
            else
            {
                Console.WriteLine($"File {fileName} does not exist!");
            }

            return "";
        }
        
        public static void ListFiles(string path)
        {
            if(path == "")
            {
                Console.WriteLine($"Error in defining path!");
            }
            else
            {
                string[] dir = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);
                dir.ToList().ForEach(Console.WriteLine);
                files.ToList().ForEach(Console.WriteLine);
            }
        }
        
        public static string CurrentDir()
        {
            return Directory.GetCurrentDirectory();
        }
        
        public static void SetWorkDir(string path)
        {
            if(path == "")
            {
                Console.WriteLine($"Error in defining path!");
            }
            else
            {
                Directory.SetCurrentDirectory(path);
            }
        }

    }
}
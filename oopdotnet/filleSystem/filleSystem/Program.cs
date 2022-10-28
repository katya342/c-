using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace filleSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            // string path = "";
            string path = @"C:\allfiles\TNSShort";
            // Exmpl01();
            // Exmpl02();
            //  Exmpl03();
            //// Exmpl04();
            //Exmpl05();
            // Exmpl07();
            int k = 0;
            foreach (string item in GetAllFiles(path))
            {
                Console.WriteLine("->>>>>>" + item);
            }
            // GetAllFiles(path);
            int ch = 0;
            Console.WriteLine("Выберите необходимый формат: ");
            ch = Convert.ToInt32(Console.ReadLine());
            DirectoryInfo dir = new DirectoryInfo(path);
            int count = dir.GetFiles(GetAllFiles(path)[ch]).Count();
            Console.WriteLine("Файлов с расширением = " + count);
        }
        public static void Exmpl01()
        {
            FileStream fs = new FileStream(@"C:\\Users\\bezve\\Documents\array1.txt", FileMode.Create);
            FileStream fs2 = new FileStream(@"C:\\Users\\bezve\\Documents\array2.txt", FileMode.Create, FileAccess.Write);
            FileStream fs3 = new FileStream(@"C:\\Users\\bezve\\Documents\array3.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            fs3.Close();
        }
        public static void Exmpl02()
        {
            FileInfo f = new FileInfo(@"C:\\Users\\bezve\\Documents\array1.txt");
            if(!f.Exists)
            {
                FileStream fs = f.Create();
                fs.Close();
            }
            using (FileStream fs = f.Open(FileMode.Open, FileAccess.Read, FileShare.None))
            {

            }
            
        }
        public static void Exmpl03()
        {
            DirectoryInfo dir = new DirectoryInfo(".");
            DirectoryInfo dir2 = new DirectoryInfo(@"C:\Program Files (x86)\KeePass-2.47");
            dir2.Create();
        }
        public static void Exmpl04()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\progi\js\event_loop");
            Console.WriteLine("Информация о каталоге");
            Console.WriteLine("Полный путь: {0}" + "Название папки: {1}" + "Родительский каталог: {2}", dir.FullName, dir.Name, dir.Parent);
            foreach (FileInfo file in dir.GetFiles())
            {
                Console.WriteLine("->>" + file.Name);
            }
            FileInfo[] fileHtml = dir.GetFiles("*.html", SearchOption.TopDirectoryOnly);
        }

        public static void Exmpl05()
        {
            string path = @"C:\\progi\\js\\event_loop\index.html";
            try
            {
                // считываем весь файл
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
                using(StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                using (StreamReader sr = new StreamReader(path))
                {
                    char[] array = new char[4];
                    sr.Read(array, 0, array.Length);
                    Console.WriteLine(array);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Exmpl06()
        {
            string path = @"C:\\progi\\js\\event_loop\index.html";
            using(StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                sw.Write("----->" + DateTime.Now.ToString());
            }
        }
        public static void Exmpl07()
        {
            DriveInfo[] di = DriveInfo.GetDrives();
            foreach (var item in di)
            {
                Console.WriteLine(item.Name);
            }
            DriveInfo c = new DriveInfo("C");
            Console.WriteLine("Общий размер" + c.TotalSize);
            Console.WriteLine("Доступное место" + c.AvailableFreeSpace);
            Console.WriteLine("Разметка томов: " + c.VolumeLabel);
        }
        public static List<string> GetAllFiles(string path)
            {
                List<string> filesExt = new List<string>();
          
                DirectoryInfo dir = new DirectoryInfo(path);
                if (!string.IsNullOrWhiteSpace(path))
                {
                    Console.WriteLine("Укажите путь");
              
                    if (dir.Exists)
                        Console.WriteLine("Указанный путь не корректный");
                }
            
                else
                {
                
                    foreach (FileInfo item in dir.GetFiles())
                    {
                        if(!filesExt.Contains(item.Extension))
                        filesExt.Add(item.Extension);
                    }
                    Dictionary<string, FileInfo> filesDic = new Dictionary<string, FileInfo>();
                    foreach (FileInfo item in dir.GetFiles())
                    {
                        if (filesDic.ContainsKey(item.Extension))
                            filesDic.Add(item.Extension, item);
                    }
                }
                return filesExt;
            }
        public static void GetName (string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            List<string> pattern = new List<string>() { "-", "_" };
            foreach  (FileInfo f in dir.GetFiles())
            {
                if (f.Name.Contains("-"))
                    f.MoveTo(dir.FullName + @"\" + f.Name.Replace("-", "+"));
            }
        }
        public static void PrintDirNames(string Path)
        {
            DirectoryInfo dir = new DirectoryInfo (Path);

        }
        public static void PrintFileNames(string Path)
        {
            DirectoryInfo dir = new DirectoryInfo(Path);
            //Console.WriteLine("------>" + dir.Name); ;
            foreach (DirectoryInfo item in dir.GetDirectories())
            {
                Console.WriteLine($"{dir.FullName}");
                PrintDirNames(item.FullName);
            }
        }
    }
}

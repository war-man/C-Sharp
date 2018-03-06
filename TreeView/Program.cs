using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace TreeView
{
    // Each instance of this class represents a file/folder
    public class Info
    {
        public string Path { get; set; }
        public int Level { get; set; }
        public Info(string path, int level)
        {
            Path = path;
            Level = level;
        }
    }

    class Program
    {
        // Access a folder, get subfile and subfolder in one level
        public static List<Info> GetFilesAndDirInOneFolderInOneLevel(string path, int level)
        {
            List<Info> result = new List<Info>();

            // Get subfolder
            string[] subfolder = Directory.GetDirectories(path);
            foreach (var item in subfolder)
            {
                result.Add(new Info(item, level + 1));   
            }

            // Get sub file
            string[] file = Directory.GetFiles(path);
            foreach (var item in file)
            {
                result.Add(new Info(item, level + 1));   
            }

            return result;
        }

        public static List<Info> GetAllFilesAndDir(string path)
        {
            List<Info> result = new List<Info>(){new Info(path, 0)};

            for (int i = 0; i < result.Count; i++)
            {
                FileAttributes attr = File.GetAttributes(result[i].Path);

                // Check if item is a folder
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    // check if the folder being accessed is empty or not
                    // If not empty, add item to the List
                    // If empty, do nothing
                    if (Directory.GetDirectories(result[i].Path).Length > 0 || Directory.GetFiles(result[i].Path).Length > 0)
                    {
                        result.InsertRange(i+1, GetFilesAndDirInOneFolderInOneLevel(result[i].Path, result[i].Level));
                    }   
                }

                // if item not a folder, do nothing
            }

            for (int i = 1; i<result.Count; i++)
            {
                // Get the last index of the "/"
                var slashPosition = result[i].Path.LastIndexOf("/");

                // Get the file/folder name by getting the substring from the slashPosition
                result[i].Path = result[i].Path.Substring(slashPosition+1);
            }

            return result;
        }

        public static string Draw (Info item)
        {
            return String.Concat(Enumerable.Repeat("│ ", item.Level-1)) + "├ " + item.Path + "\r\n";
        }

        static void Main(string[] args)
        {
            try
            {
                string folderName = args[0];
                
                if (args[0] == ".")
                {
                    folderName = Directory.GetCurrentDirectory();
                } else if (args[0] == "..")
                {
                    folderName = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
                } else if (args[0] == "~")
                {
                    folderName = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                }

                var list = GetAllFilesAndDir(folderName);
                string result = list[0].Path + "\r\n";

                for (int i = 1; i < list.Count; i++)
                {
                    result += Draw(list[i]);
                }

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
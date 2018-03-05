using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace TreeView
{
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
        public static List<Info> GetFilesAndDirInOneFolder(string path, int level)
        {
            List<Info> result = new List<Info>();
            string[] subfolder = Directory.GetDirectories(path);
            foreach (var item in subfolder)
            {
                result.Add(new Info(item, level + 1));   
            }

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
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    if (Directory.GetDirectories(result[i].Path).Length > 0 || Directory.GetFiles(result[i].Path).Length > 0)
                    {
                        result.InsertRange(i+1, GetFilesAndDirInOneFolder(result[i].Path, result[i].Level));
                    }   
                }

            }

            for (int i = 1; i<result.Count; i++)
            {
                var slashPosition = result[i].Path.LastIndexOf("/");
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
            string folderName = args[0];
            var list = GetAllFilesAndDir(folderName);
            string result = list[0].Path + "\r\n";

            for (int i = 1; i < list.Count; i++)
            {
                result += Draw(list[i]);
            }

            Console.WriteLine(result);
        }
    }
}
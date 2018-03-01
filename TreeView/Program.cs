using System;
using System.IO;
using System.Collections.Generic;

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
        // public static string Draw(string path)
        // {
        //     string originalPath = path;
        //     string[] subfolder = Directory.GetDirectories(originalPath);

        //     path += "\r\n" + "└── " + subfolder[0];

        //     for (int i = 1; i < subfolder.Length; i++)
        //     {
        //         path += "\r\n" + "└── " + subfolder[i];
        //     }

        //     string[] file = Directory.GetFiles(originalPath);
        //     for (int i = 0; i < file.Length; i++)
        //     {
        //         path += "\r\n" + "└── " + file[i];
        //     }

        //     return path;
        // }

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

            return result;
        }



        static void Main(string[] args)
        {
            var list = GetAllFilesAndDir("/home/moe/Desktop/CSharpProject-master/treeapp");
            string result = list[0].Path + "\r\n";

            for (int i = 1; i < list.Count; i++)
            {
                result += new string(' ', list[i].Level) + list[i].Level + new string('-', 1) + list[i].Path + "\r\n";
            }
            Console.WriteLine(result);
        }
    }
}
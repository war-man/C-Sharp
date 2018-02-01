using System;
using System.Collections.Generic;
using System.IO;

namespace GetAverageFileSize
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> subFolderList = new List<string>();
                List<string> fileList = new List<string>();
                string folderPath = args[0];
                
                string[] fileNames = Directory.GetFiles(folderPath);
                foreach (var item in fileNames)
                {
                    fileList.Add(item);
                }

                string[] subFolder = Directory.GetDirectories(folderPath);
                foreach (var item in subFolder)
                {
                    subFolderList.Add(item);   
                }

                while(true) {
                    for (int i = 0; i < subFolderList.Count; i++)
                    {
                        fileNames = Directory.GetFiles(subFolderList[i]);
                        foreach (var item in fileNames)
                        {
                            fileList.Add(item);
                        }

                        subFolder = Directory.GetDirectories(subFolderList[i]);
                        subFolderList.RemoveAt(i);
                        subFolderList.InsertRange(i, subFolder);
                    }

                    if (subFolderList.Count == 0) {
                        break;
                    }
                }

                long fileSize = 0;
                foreach (var item in fileList)
                {
                    FileInfo f = new FileInfo(item);
                    fileSize += f.Length;
                    Console.WriteLine(item + ": " + f.Length);
                }
                // FileInfo f = new FileInfo(fileList[2]);
                Console.WriteLine(fileSize/fileList.Count);

            }
            catch (IndexOutOfRangeException ex)
            {
            
                Console.WriteLine(ex.Message + "You must include a path to a folder");
            }
            
        }
    }
}

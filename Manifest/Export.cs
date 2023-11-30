using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Manifest
{
    internal static class Export
    {
        private static string path;
        public static string directiryName = "ManifestTemp";
        private static string pathWithDirectory;
        public static string extension = ".json";
        private static string savedName = "manifestSavedPath";

        public static string GetPath()
        {
            return path;
        }
        public static void selectPath(bool opebBrowserAnyCase) 
        {
            if (opebBrowserAnyCase == false && File.Exists(Directory.GetCurrentDirectory()+"\\"+ savedName + ".txt")) 
            {
                loadPath();
            }
                
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    path = fbd.SelectedPath;
                    pathWithDirectory = path + "\\"+ directiryName;
                    System.IO.File.WriteAllText(Directory.GetCurrentDirectory() + "\\"+ savedName + ".txt", path);
                    
                }
            }
        }

        public static string loadPath() 
        {
            if(!File.Exists(Directory.GetCurrentDirectory() + "\\" + savedName + ".txt"))
                return "";

            path = System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + "\\"+ savedName + ".txt");
            pathWithDirectory = path + "\\" + directiryName;
            return path;
        }

        public static void exportData(string[,] data)
        {
            createCatalog();

            for (int i = 0; i < data.GetLength(0); i++)
            {
                generateManifest("VR", "LearningMode", "VR", "Ed", i, data);
                generateManifest("3D", "LearningMode", "3D", "Ed", i, data);
                generateManifest("VR", "Exam", "VR", "Ex", i, data);
                generateManifest("3D", "Exam", "3D", "Ex", i, data);
            }

            try
            {
                ZipFile.CreateFromDirectory(pathWithDirectory, Path.Combine(path, "Manifests"+ DateTime.Now.ToString("hh.mm.ss") + ".zip"), CompressionLevel.Fastest, false);
            }
            catch (Exception e)
            {
               
            }
        }

        private static void createCatalog() 
        {
            if (path == null)
            {
                selectPath(false);
            }

            if (pathWithDirectory == null)
            {
                pathWithDirectory = path + "\\" + directiryName;
            }
            Directory.CreateDirectory(pathWithDirectory);

            System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(pathWithDirectory);
            foreach (System.IO.FileInfo file in directory.GetFiles()) file.Delete();
            foreach (System.IO.DirectoryInfo subDirectory in directory.GetDirectories()) subDirectory.Delete(true);
        }

        private static void generateManifest(string mode, string learningMode, string modeShort, string learningModeShort, int index, string[,] data)
        {
            ManifestParameters ManifestVREd = new ManifestParameters(Int32.Parse(data[index, 0]), Int32.Parse(data[index, 1]), Int32.Parse(data[index, 2]), mode, index, learningMode);
            string outJson = ManifestVREd.getJson();
            string fileName = index.ToString() + "_LaunchArgs" + modeShort+ learningModeShort + extension;
            createFile(outJson, fileName);
        }


        private static void createFile(string text, string name) 
        {
            try {
                System.IO.File.WriteAllText(pathWithDirectory + "\\" + name, text);
            }
            catch (Exception e) 
            {
                selectPath(true);
                System.IO.File.WriteAllText(pathWithDirectory + "\\" + name, text);
            }
        }
    }
}

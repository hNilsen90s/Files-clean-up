using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesktopClean
{
    class MoveFiles
    {

        /// <summary>
        /// Moving files from one location to another
        /// </summary>
        /// <param name="folderName">Name of the folder to create</param>
        /// <param name="extenstion">What file extenstions to move (use | to add more than one)</param>
        /// <param name="path">File path we are looking for files, default is Desktop</param>

        public void CleanDesktop(string folderName, string extenstion, string path = null)
        {

            // Predefine vars
            string cleanUpPath;
            string[] arrExtenstion = extenstion.Split("|".ToCharArray());

            // Reloop the extenstions to pre add a dot on the extenstions 
            for (int i = 0; i < arrExtenstion.Length; i++)
            {
                arrExtenstion[i] = "." + arrExtenstion[i];
            }

            // Hacky way of checking a default value
            if (path == null)
            {
                cleanUpPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString(); 
            } else
            {
                cleanUpPath = path;
            }

            // Path to desktop EXE's
            string desktopPathExtenstion = cleanUpPath + @"\" + folderName + @"\";

            // Find all files in given directory
            foreach (var fileInDirectoryPath in Directory.GetFiles(cleanUpPath))
            {

                // Get extenstion on given file
                string pathExtenstion = System.IO.Path.GetExtension(fileInDirectoryPath).ToLower();

                // Search for the exstention
                bool foundExtenstion = false;

                for (int i = 0; i < arrExtenstion.Length; i++)
                {
                    if (pathExtenstion == arrExtenstion[i])
                    {
                        Console.WriteLine("check");
                        foundExtenstion = true;
                    }
                }

                // If the extenstion on the file in the directory was found in the array
                if (foundExtenstion)
                {

                    try
                    {
                        // Create a new folder if it doesnt exsist
                        System.IO.Directory.CreateDirectory(desktopPathExtenstion);

                        // Get full path name
                        string fileToCopyPath = System.IO.Path.GetFullPath(fileInDirectoryPath);

                        // Copy file
                        File.Copy(fileToCopyPath, desktopPathExtenstion + @"\" + System.IO.Path.GetFileName(fileInDirectoryPath), true);
                        File.Delete(fileToCopyPath);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("There was something wrong when modifying or copying the files/folder.");
                        Console.WriteLine(e);
                    }

                }
            }
        } // END CleanDesktop

    }
}
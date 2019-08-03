﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesktopClean
{
    class MoveFiles
    {

        /// <summary>
        /// Copy and delete files from one location to another, default location is desktop.
        /// </summary>
        /// <param name="folderName">Name of the folder to create</param>
        /// <param name="extenstion">What file extenstions to move (use | to add more than one)</param>
        /// <param name="path">File path we are looking for files, default is Desktop</param>

        public void CopyFiles(string folderName, string extenstion, string path = null)
        {

            // Predefine vars
            string cleanUpPath;
            string[] arrExtenstion = extenstion.Split("|".ToCharArray());

            // Hacky way of checking a default value
            if (path == null)
            {
                cleanUpPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString();
            }
            else
            {
                cleanUpPath = path;
            }

            // Loop the extenstions to pre add a dot on the extenstions
            for (int i = 0; i < arrExtenstion.Length; i++)
            {
                arrExtenstion[i] = "." + arrExtenstion[i];
            }

            // Path to desktop extentions
            string directoryEndpoint = cleanUpPath + @"\" + folderName + @"\";

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
                        foundExtenstion = true;
                    }
                }

                // If extenstion is found, try to copy the file
                if (foundExtenstion)
                {

                    try
                    {

                        // Check if the folder exsist
                        if(!Directory.Exists(directoryEndpoint))
                        {
                            Console.Write("Creating new folder: {0}", folderName);
                            
                            // Create a new folder if it doesnt exsist
                            System.IO.Directory.CreateDirectory(directoryEndpoint);
                        }

                        // Get full path name
                        string fileToCopyPath = System.IO.Path.GetFullPath(fileInDirectoryPath);

                        // Move file from one location to another
                        System.IO.Directory.Move(fileToCopyPath, directoryEndpoint + @"\" + System.IO.Path.GetFileName(fileInDirectoryPath));

                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("There was something wrong when modifying or copying the files/folder.");
                        Console.WriteLine(e);
                    }

                }
            }

        }

    }
}
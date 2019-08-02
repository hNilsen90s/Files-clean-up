using System;
using System.IO;

namespace DesktopClean
{
    class Program
    {

        static void Main(string[] args)
        {

            MoveFiles moveFiles = new MoveFiles();
            moveFiles.CopyFiles("jpg", "jpg|gif|png|jpeg");

        }

    } // END CLASS 
}

using System;
using System.IO;

namespace DesktopClean
{
    class Program
    {

        static void Main(string[] args)
        {

            MoveFiles moveFiles = new MoveFiles();
            moveFiles.CleanDesktop("jpg", "jpg|gif|img");

        }

    } // END CLASS 
}

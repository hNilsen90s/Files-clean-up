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
            moveFiles.CopyFiles("photoshop", "psd");
            moveFiles.CopyFiles("docs", "doc|docx|log|msg|rtf|tex|txt");
            moveFiles.CopyFiles("audio", "mp3|mpa|wav|wma|aif|iff|m3u|m4a");
            moveFiles.CopyFiles("video", "3g2|avi|flv|m4v|asf|mp4|rm|swf|vob|mov|wmv");
            moveFiles.CopyFiles("exe", "exe|apk|app|bat|cgi|com|lnk");
            moveFiles.CopyFiles("web", "html|php|asp|aspx|cer|cfm|csr|css|htm|js|jsp|php|rss|xhtml");
            moveFiles.CopyFiles("compressed", "cbr|7z|deb|gz|pkg|rar|rpm|sitx|tar.gz|zip|zipx");

        }

    } // END CLASS 
}

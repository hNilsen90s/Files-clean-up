# Desktop cleanup

Desktop cleanup is a simple solution to clean up all files on the desktop, or other folders.

  - Leave the path empty, and it will automaticly look at your desktop.
  - Specify a path to move files from this specified path.
  - Make sure to run as Admin if you have any issues coping files.

# New Features!

  - Added the ability to move "all files" by using the * symbol.

# Todo's!
  - Move files based on time and date
  - Check if the files is empty (delete future?)
  - Renaming files if wanted

### Installation

Open the project in Microsoft visual studio, and edit the Program.cs to fit your needs.

Example (folder|extenstions):

```sh
moveFiles.CopyFiles("jpg", "jpg|gif|png|jpeg");
moveFiles.CopyFiles("photoshop", "psd");
moveFiles.CopyFiles("docs", "doc|docx|log|msg|rtf|tex|txt");
moveFiles.CopyFiles("audio", "mp3|mpa|wav|wma|aif|iff|m3u|m4a");
moveFiles.CopyFiles("video", "3g2|avi|flv|m4v|asf|mp4|rm|swf|vob|mov|wmv");
moveFiles.CopyFiles("exe", "exe|apk|app|bat|cgi|com|lnk");
moveFiles.CopyFiles("web", "html|php|asp|aspx|cer|cfm|csr|css|htm|js|jsp|php|rss|xhtml");
moveFiles.CopyFiles("compressed", "cbr|7z|deb|gz|pkg|rar|rpm|sitx|tar.gz|zip|zipx");
```

License
----
MIT

**Free Software, Hell Yeah!**
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace Trek.Models
{
    public class DataClasses
    {
        public static List<FileNames> GetFiles()
        {
            List<FileNames> lstFiles = new List<FileNames>();
            DirectoryInfo dirInfo = new DirectoryInfo(HostingEnvironment.MapPath("~/Documents"));

            int i = 0;
            foreach (var file in dirInfo.GetFiles())
            {
                lstFiles.Add(new FileNames()
                                 {
                                     FileId = i + 1,
                                     FileName = file.Name.Split('.')[0],
                                     FilePath = dirInfo.FullName + @"\" + file.Name
                                 });
                i++;
            }
            return lstFiles;
        }
       
    }
}
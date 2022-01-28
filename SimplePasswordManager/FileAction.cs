using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimplePasswordManager
{
    enum Rows
    {
        Id,
        Name,
        Login,
        Password,
        URI,
        Phone,
        Notes
    }

    class FileAction
    {
        private FileAction() { }

        private static FileAction _instance;

        public static FileAction GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FileAction();
            }

            return _instance;
        }

        public List<string> GetCSVFileNames(string path = "DataBases")
        {
            List<string> files = Directory.GetFiles(path).ToList();

            if (!files.Any())
            {
                return files;
            }

            return files.Where(i => (i.IndexOf(".csv") != -1)).Select(i => i.Replace(path+@"\", "")).ToList();
        }

        public void FileCreating(string name)
        {

        }
    }
}

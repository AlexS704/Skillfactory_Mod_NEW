using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod8
{
    public class Folder
    {
        public List<string> Files {  get; set; } = new List<string>();

        Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

                
        public void CreateNewDirectory(string nameFolder)
        {
             Folders.Add(nameFolder, new Folder());     
                                
                  
        }
    }
}

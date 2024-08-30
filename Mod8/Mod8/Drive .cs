using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod8
{
    internal class Drive
    {
        public Drive(string NameDisk, long SizeDisc, long FreeSpaceDisc)
        {
            NameDisk = _nameDisc;
            SizeDisc = _sizeDisc;
            FreeSpaceDisc = _freeSpaceDisc;
        
        }

        public string _nameDisc {  get; }
        public long _sizeDisc {  get; }
        public long _freeSpaceDisc {  get; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class FileParseException
    {
        private string filename;
        private string line;

        public FileParseException(string filename, string line)
        {
            this.filename = filename;
            this.line = line;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class File
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int SizeBytes { get; set; }
        public DateTime CreateDate { get; set; }
        public string ConverSize {
            get
            {
                string[] sizeType = new string[] { "b","kb","mb","gb"};
                int a=0;
                for(int i = 0; SizeBytes > 1024;)
                {
                    i++;
                    SizeBytes /= 1024;
                    a = i;
                }
                return $"{SizeBytes} {sizeType[a]}";
            }
        }
        public File()
        {

        }
        public File(string name, string type, int sizeBytes, DateTime createDate)
        {
            Name = name;
            Type = type;
            SizeBytes = sizeBytes;
            CreateDate = createDate;
        }

        public override string ToString()
        {
            return $" Name : {Name}{Type} with size {ConverSize}, created date: {CreateDate}";
        }

    }
}

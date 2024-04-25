using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    internal class readF
    {
        String path = @"D:\mammals.csv";
        StreamReader sr;
        string[] kume;
        List<string> adi;
        List<string> populasyon;
        List<string> length;
        public readF()
        {
            sr = new StreamReader(path);
            kume = new string[3];
            adi = new List<string>();
            populasyon = new List<string>();
            length = new List<string>();

            while (!sr.EndOfStream)
            {
                try {string line = sr.ReadLine();
                kume = line.Split(',');
                adi.Add(kume[0]);
                populasyon.Add(kume[1]);
                length.Add(kume[2]); }
                catch { }
                
            }
            sr.Close();

        }

        public List<string> Adi { get => adi; set => adi = value; }
        public List<string> Populasyon { get => populasyon; set => populasyon = value; }
        public List<string> Length { get => length; set => length = value; }

        public int ara(String str)
        {
            
            return adi.IndexOf(str);
            
        }





    }
}

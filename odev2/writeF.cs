using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    internal class writeF
    {
        readF reader = new readF();
        String path = @"D:\mammals.csv";
        StreamWriter sw;
        public bool varmi = false;
        public writeF()
        {

        }
        public void ekle(String a, String p, String l)
        {
            reader.Adi.Add(a);
            reader.Populasyon.Add(p);
            reader.Length.Add(l);
            kaydetmek();
        }
        public void sil(string a)
        {
           
            int index = reader.Adi.IndexOf(a);
            if (index == -1)
            {
                varmi = false;
            }
            else
            {
                reader.Adi.RemoveAt(index);
                reader.Populasyon.RemoveAt(index);
                reader.Length.RemoveAt(index);
                kaydetmek();
                varmi = true;
            }
        }

        public void guncell(int index, String a, String p, String l) {
            reader.Adi[index] = a;  
            reader.Populasyon[index] = p;  
            reader.Length[index] = l;
            kaydetmek();
        }

        private void kaydetmek()
        {
            sw = new StreamWriter(path);
            for (int i = 0; i < reader.Adi.Count; i++)
            {
                sw.WriteLine("{0},{1},{2}", reader.Adi[i], reader.Populasyon[i], reader.Length[i]);
            }
            sw.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Text;

namespace snakeControl
{
    public class FileManager
    {
        private string path = "config.cfg";
        public List<string> list { get; set; }
        public FileManager()
        {
            list = new List<string>();
            readFile();
           
        }
        public void readFile()
        {
           
            if (File.Exists(path))
            {
                list = File.ReadAllLines(path).ToList();
            }
            else
            {
             
                using (FileStream f = new FileStream(path, FileMode.Append, FileAccess.Write))
                    using (StreamWriter s = new StreamWriter(f))
                {
                    s.WriteLine("1280");
                    s.WriteLine("720");
                    s.WriteLine("1");
                    s.WriteLine("Green");
                    s.WriteLine("False");
                }
            }
        }
        public void saveFile(int width,int height,int speed,string color,bool wall)
        {
            list.Clear();
            list.Add(Convert.ToString(width));
            list.Add(Convert.ToString(height));
            list.Add(Convert.ToString(speed));
            list.Add(color);
            list.Add(Convert.ToString(wall));
            File.WriteAllLines(path, list.Select(x => string.Join("", x)));

        }

    }
}

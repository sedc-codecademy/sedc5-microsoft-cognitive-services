using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sedc.ImageEditor
{
    public class Program
    {
        static void Main(string[] args)
        {

            var image = Image.FromFile("mr-bean.jpg");
            var image2 = Image.FromFile("dog.png");
            Graphics g = Graphics.FromImage(image);
            g.DrawImage(image2, 0, 0, 300, 300);
            g.Save();
            image.Save("new.png");
            Console.ReadLine();
        }
    }
}

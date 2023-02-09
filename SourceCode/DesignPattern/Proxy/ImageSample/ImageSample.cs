using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Proxy.ImageSample
{
    public static class ImageSample
    {
        public static void TestCase()
        {
            var image = new ProxyImage("test_10mb.jpg");

            image.Display();
            Console.WriteLine();
            image.Display();
        }
    }
}
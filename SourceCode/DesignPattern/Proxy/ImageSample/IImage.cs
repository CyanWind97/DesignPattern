using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Proxy.ImageSample
{
    public interface IImage
    {
        public void Display();
    }

    public class RealImage : IImage
    {
        private string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
        }

        public void Display()
            => Console.WriteLine($"Displaying {_fileName}");

        
        private void LoadFromDisk(string fileName)
            => Console.WriteLine($"Loading {_fileName}");
    }
}
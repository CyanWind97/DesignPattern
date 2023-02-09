using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Proxy.ImageSample
{
    public class ProxyImage : IImage
    {
        private RealImage _realImage;
        private string _fileName;


        public ProxyImage(string fileName)
            => _fileName = fileName;

        public void Display()
        {
            _realImage ??= new RealImage(_fileName);
            _realImage.Display();
        }
    }
}
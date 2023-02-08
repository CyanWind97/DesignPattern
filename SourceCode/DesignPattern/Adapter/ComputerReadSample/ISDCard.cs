using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Adapter.ComputerReadSample
{
    public interface ISDCard
    {
        public string ReadSD();

        public void WriteSD(string message);
    }

    public class SDCard : ISDCard
    {   
        public string ReadSD() 
            => "sd card read a message :hello word SD";

        public void WriteSD(string message)
            => Console.WriteLine($"sd card write message : {message}" );    
           
    }
}
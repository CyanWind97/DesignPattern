using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Adapter.ComputerReadSample
{
    public interface ITFCard
    {
        public string ReadTF();

        public void WriteTF(string message);
    }

    public class TFCard : ITFCard
    {   
        public string ReadTF() 
            => "tf card read a message :hello word TF";

        public void WriteTF(string message)
            => Console.WriteLine($"tf card write message : {message}" );    
           
    }
}
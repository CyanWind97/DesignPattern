using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Template.GameSample
{
    public class CricketGame : Game
    {
        protected override void Initialize()
            => Console.WriteLine("Cricket Game Initialized! Start playing.");

        protected override void Start()
            => Console.WriteLine("Cricket Game Started! Enjoy the game!");

        protected override void End()
            => Console.WriteLine("Cricket Game Finished!");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Template.GameSample
{
    public class FootballGame : Game
    {

        protected override void Initialize()
            => Console.WriteLine("Football Game Initialized! Start playing.");

        protected override void Start()
            => Console.WriteLine("Football Game Started! Enjoy the game!");

        protected override void End()
            => Console.WriteLine("Football Game Finished!");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Template.GameSample
{
    public static class GamePlay
    {
        public static void TestCase()
        {
            Game game = new FootballGame();
            game.Play();
            
            Console.WriteLine();

            game = new CricketGame();
            game.Play();
        }
    }
}
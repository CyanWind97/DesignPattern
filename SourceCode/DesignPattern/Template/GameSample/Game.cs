using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Template.GameSample
{
    public abstract class Game
    {

        public void Play()
        {
            Initialize();
            Start();
            End();
        }

        protected abstract void Initialize();

        protected abstract void Start();

        protected abstract void End();
    }
}
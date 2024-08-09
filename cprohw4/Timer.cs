using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cprohw4
{
    public delegate void OnTimeElapsedEvent(Timer self);
    public class Timer
    {
        
        public OnTimeElapsedEvent OnTimeElapsed;
        public Timer() {
            OnTimeElapsed = new(test);
        }
        public Timer(int seconds) :this() {
            Start(seconds);
        }

        private void test(Timer tmr)
        {

        }

        private void End()
        {
            OnTimeElapsed(this);
        }

        public async Task Start(int seconds) {
            Console.WriteLine("TimerStart");
            await Task.Delay(seconds);
            Console.WriteLine("TimerEnd");
            End();
        }
    }
}

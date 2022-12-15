using System;
using System.Threading;

namespace DM6500Remote
{
    internal class VirtualMachine : WorkMachine
    {
        public new event Message WriteMessage;
        public new event Action Finish;

        public VirtualMachine(double delay, int amount):base(delay,amount)
        {
        }
        public new void StartExchange()
        {
            string[] data = new string[3];
            double time = 0;
            for (int i = 0; i < _amount; i++)
            {
                Thread.Sleep((int)(SECOND * _delay));
                Random randomizer = new Random();
                data[0] = time.ToString();
                data[1] = randomizer.NextDouble().ToString();
                data[2] = randomizer.NextDouble().ToString();
                this.WriteMessage?.Invoke(data);
                time += _delay;
                time = Math.Round(time, 2);
            }
            this.StopExchange();
        }
        public new void StopExchange()
        {
            this.Finish?.Invoke();
        }
    }
}

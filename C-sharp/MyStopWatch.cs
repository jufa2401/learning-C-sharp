using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace C_sharp
{
    class MyStopWatch
    {
        private Stopwatch _watch;

        public MyStopWatch()
        {
            this._watch = new Stopwatch();
        }

        public void Start()
        {
            this._watch.Start();
        }

        public void Stop()
        {
            this._watch.Stop();
        }

        public void LogMs(string formattedMessage)
        {
            Console.WriteLine(string.Format(formattedMessage,this._watch.ElapsedMilliseconds));
        }
    }
}

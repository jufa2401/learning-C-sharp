using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace C_sharp
{
    public static class MyStopWatchFunctional
    {
        public static T LogMs<T>(string formattedMessage, Func<T> action)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            T result = action();
            watch.Stop();
            Debug.WriteLine(string.Format(formattedMessage,watch.ElapsedMilliseconds));
            return result;
        }

        public static void LogMs(string formattedMessage, Action action)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            action();
            watch.Stop();
            Debug.WriteLine(string.Format(formattedMessage, watch.ElapsedMilliseconds));
        }
    }
}

using System.Diagnostics;
namespace Algorithms.API.Services
{
    public class TimeCounter
    {
        private Stopwatch _stopwatch { get; set; }
        public void StartCounter()=> _stopwatch = Stopwatch.StartNew();
        public double StopCounter()
        {
            return _stopwatch.Elapsed.TotalMilliseconds;
            _stopwatch.Stop();
        }
    }
}

using System.Diagnostics;
namespace Algorithms.API.Services
{
    public class TimeCounter
    {
        private Stopwatch _stopwatch { get; set; }
        public void StartCounter()=> _stopwatch = Stopwatch.StartNew();
        public float StopCounter()
        {
            _stopwatch.Stop();
            return _stopwatch.ElapsedMilliseconds;
        }
    }
}

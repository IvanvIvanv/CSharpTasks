using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace ProxyTask
{
    internal class ProxyService(IService service) : IService
    {
        private string? cache;
        private readonly System.Timers.Timer cleanupTimer = new(5000);

        public string GetData()
        {
            var data = GetDataNoCleanup();

            cleanupTimer.Elapsed -= CleanupCache;
            cleanupTimer.Stop();
            cleanupTimer.Elapsed += CleanupCache;
            cleanupTimer.Start();

            return data;
        }

        private string GetDataNoCleanup()
        {
            if (cache != null) return cache;
            cache = service.GetData();

            return cache;
        }

        private void CleanupCache(object? sender, ElapsedEventArgs args)
        {
            cache = null;
            Console.WriteLine("Cache cleaned");
        }
    }
}

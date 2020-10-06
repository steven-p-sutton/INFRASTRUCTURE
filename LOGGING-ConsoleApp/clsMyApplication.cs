using System;
using Microsoft.Extensions.Logging;

namespace Conductus.Logging.ConsoleApp
{   public class clsMyApplication
    {
        private readonly ILogger _logger;
        public clsMyApplication(ILogger<clsMyApplication> logger)
        {
            _logger = logger;
        }
        internal void Run()
        {
            _logger.LogInformation("{dateTime} Application Started", DateTime.UtcNow);
            _logger.LogInformation("{dateTime} An information message", DateTime.UtcNow);
            _logger.LogDebug("{dateTime} A debug message", DateTime.UtcNow);
            _logger.LogWarning("{dateTime} A warning message", DateTime.UtcNow);
            _logger.LogError("{dateTime} An error message", DateTime.UtcNow);
            _logger.LogInformation("{dateTime} Application Ended at", DateTime.UtcNow);
        }
    }
}

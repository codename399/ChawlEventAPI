using ChawlEvent.Model;
using ChawlEventAPI.Model.Enum;
using Microsoft.Extensions.Options;

namespace ChawlEvent.Util
{
    public class Util
    {
        private static ConnectionConfig _connectionConfig { get; set; }

        public Util(IOptions<ConnectionConfig> connectionConfig)
        {
            _connectionConfig = connectionConfig.Value;
        }

        public static string GetConnectionString()
        {
            string connectionString = string.Empty;

            if (_connectionConfig != null)
            {
                if (_connectionConfig.Env == Env.Dev)
                {
                    return _connectionConfig.DevConnectionString;
                }

                return _connectionConfig.LocalConnectionString;

            }

            return string.Empty;
        }
    }
}

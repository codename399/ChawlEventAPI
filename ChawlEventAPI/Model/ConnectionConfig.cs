using ChawlEventAPI.Model.Enum;

namespace ChawlEvent.Model
{
    public class ConnectionConfig
    {
        public string LocalConnectionString { get; set; }
        public string DevConnectionString { get; set; }
        public Env Env { get; set; }
    }
}

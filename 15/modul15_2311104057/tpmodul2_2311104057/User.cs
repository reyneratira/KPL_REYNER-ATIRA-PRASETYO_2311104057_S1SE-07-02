using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace tpmodul2_2311104057
{
    class User
    {
        public string Username { get; set; }

        [JsonIgnore]
        public string PlainPassword { get; set; } // hanya digunakan untuk input sementara (tidak disimpan)

        public string PasswordHash { get; set; }
    }
}

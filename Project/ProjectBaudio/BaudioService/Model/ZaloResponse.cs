using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaudioService.Model
{
    public class ZaloResponse
    {
        public int error_code { get; set; }
        public string error_message { get; set; }
        public AudioURL data { get; set; }
    }
}

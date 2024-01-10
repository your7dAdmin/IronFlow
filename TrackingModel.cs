using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronFlow
{
    public class TrackingModel
    {
        public int? AppId { get; set; }
        public string? ApplicationId { get; set; }
        public bool? IsMain { get; set; }
        public bool? ShowAssociates { get; set; }
    }
}

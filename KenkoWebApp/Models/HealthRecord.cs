using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KenkoWebApp.Models
{
    public class HealthRecord
    {
        public int HealthRecordID { get; set; } //primary key
        public string Title { get; set; }

        public byte[] RecordData { get; set; }

        public string MimeType { get; set; }

    }
}

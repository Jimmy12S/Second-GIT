using System;
using System.Collections.Generic;
using System.Text;

namespace WebTrial.Models
{
    class Event : BaseEntity
    {
        public string EventName { get; set; }
        public string SchoolID { get; set; }
        public string Place { get; set; }
    }
}

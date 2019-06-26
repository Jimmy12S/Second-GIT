using System;
using System.Collections.Generic;
using System.Text;

namespace WebTrial.Models
{
    public class Competition : BaseEntity
    {
        public string CompetitionType { get; set; }
        public string LocationName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace WebTrial.Models
{
    public class Competition : BaseEntity
    {
        [Display(Name ="Type")]
        public string CompetitionType { get; set; }
        [Display(Name ="Location")]
        public string LocationName { get; set; }
      
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Required]
        public DateTime StartDate { get; set; }
       
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Required]
        [Display(Name = "Finish Date")]
        public DateTime FinishDate { get; set; }
    }
}

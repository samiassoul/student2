using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace student2.Models
{
    public class Inquiry
    {
        [Key]
        //Add the properties to this class
        public Guid     InquiryId { get; set; }
        public string   Question { get; set; }
        public string   Response { get; set; }
        public Guid     ContactId { get; set; }
        public string   UserId { get; set; }
    }

}

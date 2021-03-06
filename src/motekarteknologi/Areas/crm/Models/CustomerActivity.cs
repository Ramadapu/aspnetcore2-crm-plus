﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace motekarteknologi.Areas.crm.Models
{
    public class CustomerActivity : motekarteknologi.Models.BaseModel
    {
        public CustomerActivity()
        {
            this.From = DateTime.UtcNow;
            this.To = DateTime.UtcNow;
        }
        public Customer Customer { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime From { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime To { get; set; }
        public ActivityType ActivityType { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WestdalePharmacyApp.Models
{
    //TODO Finished add-Migration 
    public class Message
    {
        [Key]
        public Guid MessageId { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        [Display(Name ="Registered User")]
        public bool IsRegistered { get; set; }



        [Display(Name = "Date/Time")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy hh:mm tt}")]
        public DateTimeOffset Timestamp { get; set; }


        
        [ForeignKey("UserId")]
        public virtual ApplicationUser To_User { get; set; }

        [Display(Name = "From")]
        public string From_UserEmail { get; set; }

        public string To_UserId { get; set; }

        public bool IsReply { get; set; }


    }
}

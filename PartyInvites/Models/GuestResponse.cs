﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required,StringLength(30,MinimumLength =4)]
        public string Name { get; set; }
        //[Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required]
        //[Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }
        [Required]
        //[Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
        //WillAttend是一个可空的Nullable的bool型，值可以是true,false,null
    }
}
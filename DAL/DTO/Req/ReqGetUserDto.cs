﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO.Req
{
    public class ReqGetUserDto
    {
        [Required(ErrorMessage = "Id")]
        public string Id { get; set; }
    }
}

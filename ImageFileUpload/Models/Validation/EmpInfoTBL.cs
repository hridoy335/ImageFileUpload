﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImageFileUpload.Models
{
    [MetadataType(typeof(metadataEmpInfoTBL))]
    public partial class EmpInfoTBL
    {
    }

    public class metadataEmpInfoTBL
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public double Age { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
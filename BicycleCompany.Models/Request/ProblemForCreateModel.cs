﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BicycleCompany.Models.Request
{
    public class ProblemForCreateModel
    {
        [Required]
        public Guid ClientId { get; set; }

        [Required]
        public Guid BicycleId { get; set; }

        [Required]
        public DateTime ReceivingDate { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(200)]
        public string Place { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        public List<PartDetailsForCreateModel> Parts { get; set; }
    }
}

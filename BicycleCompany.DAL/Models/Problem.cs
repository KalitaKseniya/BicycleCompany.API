﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BicycleCompany.DAL.Models
{
    public class Problem
    {
        public Guid Id { get; set; }

        public Guid ClientId { get; set; }
        public Client Client { get; set; }

        public Guid BicycleId { get; set; }
        public Bicycle Bicycle { get; set; }

        [Required]
        public DateTime ReceivingDate { get; set; }

        [Required]
        [MaxLength(200)]
        public string Place { get; set; }

        [Required]
        public Stage Stage { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        public List<Part> Parts { get; set; }
        public List<PartDetails> PartProblems { get; set; }
    }
}

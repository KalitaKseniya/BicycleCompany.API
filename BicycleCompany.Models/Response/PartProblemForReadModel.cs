﻿using System;

namespace BicycleCompany.Models.Response
{
    public class PartProblemForReadModel
    {
        public Guid Id { get; set; }
        public PartForReadModel Part { get; set; }
        public int Amount { get; set; }
    }
}

﻿namespace BicycleCompany.Models.Request.RequestFeatures
{
    public class ClientParameters : RequestParameters
    {
        public ClientParameters()
        {
            OrderBy = "name";
        }

        public string SearchTerm { get; set; }
    }
}

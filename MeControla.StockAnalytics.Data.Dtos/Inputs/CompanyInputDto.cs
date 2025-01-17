﻿using MeControla.Core.Data.Dtos;

namespace MeControla.StockAnalytics.Data.Dtos.Inputs
{
    public class CompanyInputDto : IInputDto
    {
        public string Name { get; set; }
        public int CVMCode { get; set; }
        public string Document { get; set; }
    }
}
﻿using System.Collections.Generic;

namespace ClientWebApplication.Areas.WebService.Data.ViewModels
{
    public class AddViewModel
    {
        public int Result { get; set; }

        public List<string> RecentCalculations { get; set; }
    }
}
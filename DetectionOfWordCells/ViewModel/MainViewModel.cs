﻿using ResearchForOffice.Common;
using ResearchForOffice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchForOffice.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public string Text { get; set; } = "Initialized";
        internal WordByNetOffice NetOffice = new WordByNetOffice();
    }
}

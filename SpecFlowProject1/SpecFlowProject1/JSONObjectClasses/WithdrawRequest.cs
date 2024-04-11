﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.JSONObjectClasses
{
    public class WithdrawRequest
    {
        public string Title { get; set; } = string.Empty;
        public string Actions { get; set; } = string.Empty;
        public string PopUpMessage { get; set; } = string.Empty;

    }
}

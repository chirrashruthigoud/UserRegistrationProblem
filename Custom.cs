﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class Custom : Exception
    {
        public Custom(string message) : base(message) { }

    }
}

﻿using isa3.Domain.Others;
using System.Collections.Generic;

namespace isa3.Domain.People
{
    public class Coach : PersonRole
    {
        public List<Training> Trainings { get; set; }
        public List<Service> Services { get; set; }
    }
}

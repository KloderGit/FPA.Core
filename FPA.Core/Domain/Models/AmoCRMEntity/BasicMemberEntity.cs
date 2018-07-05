using System;
using System.Collections.Generic;
using System.Text;

namespace FPA.Core.Domain.Models.AmoCRMEntity
{
    public class BasicMemberEntity : CoreAmoEntity
    {
        public string Name { get; set; }
        public TimeSpan ClosestTaskAt { get; set; }
    }
}

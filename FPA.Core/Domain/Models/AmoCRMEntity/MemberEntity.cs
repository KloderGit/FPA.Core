using System;
using System.Collections.Generic;
using System.Text;

namespace FPA.Core.Domain.Models.AmoCRMEntity
{
    public class MemberEntity : BasicMemberEntity
    {
        public int updated_by { get; set; }
        public IEnumerable<Lead> Leads { get; set; }
    }
}

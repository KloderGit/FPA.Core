using System;
using System.Collections.Generic;
using System.Text;

namespace FPA.Core.Domain.Models.AmoCRMEntity
{
    public class Lead : BasicMemberEntity
    {
        public int Main_contact { get; set; }
        public bool Is_deleted { get; set; }
        public TimeSpan Closed_at { get; set; }
        public int Status_id { get; set; }
        public int Sale { get; set; }
        public int Loss_reason_id { get; set; }
        public PipeLine PipeLine { get; set; }        

        public IEnumerable<Contact> Contacts { get; set; }
        public IEnumerable<Company> Companies { get; set; }
    }
}

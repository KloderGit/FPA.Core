using System;
using System.Collections.Generic;
using System.Text;

namespace FPA.Core.Domain.Models.AmoCRMEntity
{
    public class CoreAmoEntity
    {
        public int Id { get; set; }
        public int Responsible_user_id { get; set; }
        public int Created_by { get; set; }
        public TimeSpan Created_at { get; set; }
        public TimeSpan Updated_at { get; set; }
        public int Account_id { get; set; }
        public int Group_id { get; set; }
    }
}

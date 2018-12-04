using System;
using System.Collections.Generic;

namespace Clean.Domain.Entities
{
    public partial class Users
    {
        public int Id { get; set; }
        public string AdAccountDomain { get; set; }
        public string AdAccountName { get; set; }
    }
}

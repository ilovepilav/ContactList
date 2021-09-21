using ContactList.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Domain.Entities
{
    public class Contact:BaseEntity
    {
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }

        public Person Person { get; set; }
        public Guid PersonId { get; set; }
    }
}

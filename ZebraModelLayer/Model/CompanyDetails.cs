using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZebraModelLayer.Model
{
    public class CompanyDetails
    {

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string RecordNumber { get; set; }
        public string CompanyMoto { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Fax { get; set; }
    }
}

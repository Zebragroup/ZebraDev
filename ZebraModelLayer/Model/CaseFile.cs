using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZebraModelLayer.Model
{
    public class CaseFile
    {
        public int FileID { get; set; }
        public string RecordNumber { get; set; }
        public string ClientFile { get; set; }
        public string AccountFileNumber { get; set; }
        public string FileNumber { get; set; }
        public string OtherParty { get; set; }
        public string FileName { get; set; }
        public DateTime DateRegistered { get; set; }
        public string Department { get; set; }
        public string LeadProfessional { get; set; }
        public string UserDataEntry { get; set; }
        public string FileStatus { get; set; }
        public string  FileType { get; set; }
        public string UpdatedUser { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRequests.Desktop.Dtos
{
    public class DtoRequest
    {
        public int Id { get; set; }
        public string Student { get; set; }
        public string Book { get; set; }
        public string RequestType { get; set; }
        public string Language { get; set; }
        public string Note { get; set; }
        public string Priority { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? DateOfScan { get; set; }
        public DateTime? DateOfPrint { get; set; }
        public string Status { get; set; }
        public DateTime? StimateDate { get; set; }
        public DateTime? ArrivedDate { get; set; }
    }
}

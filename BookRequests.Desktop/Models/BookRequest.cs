using BookRequests.Desktop.Enums;
using System;

namespace BookRequests.Desktop.Models
{
    public class BookRequest
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Book Book { get; set; }
        public RequestType RequestType { get; set; }
        public string Language { get; set; }
        public string Note { get; set; }
        public Priority Priority { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? DateOfScan { get; set; }
        public DateTime? DateOfPrint { get; set; }
        public Status Status { get; set; }
        public DateTime? StimateDate { get; set; }
        public DateTime? ArrivedDate { get; set; }
    }
}

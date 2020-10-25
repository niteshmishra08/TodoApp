using System;

namespace Data.Models
{
    public class ToDo
    {
        public int TodoId { get; set; }

        public string Task { get; set; }

        public string Priority { get; set; }

        public DateTime  Date { get; set; }

        public int  CompletePercentage { get; set; }


    }
}
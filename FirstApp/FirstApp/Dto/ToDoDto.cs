using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FirstApp.Dto
{
    public class ToDoDto
    {
        public int TodoId { get; set; }

        public string Task { get; set; }

        public string Priority { get; set; }

        public DateTime  Date { get; set; }

        public int  CompletePercentage { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Models
{
    public class CodeQuiz
    {
        public int Id{ get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
    }
}
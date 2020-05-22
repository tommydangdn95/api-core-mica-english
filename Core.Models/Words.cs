using System;
using System.Collections.Generic;

namespace Core.Models
{
    public class Words
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Words> Sysnonym { get; set; }
        public string Mean { get; set; }
    }
}

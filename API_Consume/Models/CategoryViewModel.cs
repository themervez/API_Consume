using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Consume.Models
{
    public class CategoryViewModel
    {
        //from WebAPI properties//should be same as api properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}

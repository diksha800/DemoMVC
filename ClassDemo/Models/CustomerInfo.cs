using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo.Models
{
   public class  CustomerInfo
    {
        public int CustomerID { get; set; }
        public Guid CutomerTracker { get; set; }
        public string Name { get; set; }
        public DateTime? Dob { get; set; }
        public virtual List<Address> Addresses { get; set; }
        public int WorkFlowStage { get; set; }
    }
}

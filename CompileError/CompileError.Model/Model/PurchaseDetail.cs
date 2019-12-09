using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileError.Model.Model
{
    public class PurchaseDetail
    {
        public int Id { get; set; }
        public string Code { get; set; }

        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int TotalPrice { get; set; }
        public int MRP { get; set; }

       
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_exercicio02.Entities {
    class UsedProduct : Product{
        
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price) {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag() {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " (Used) - R$" + Price + " (Manufacture Date: " + ManufactureDate.ToString("dd/mm/yyyy") + ")");            
            
            return sb.ToString();
        }
    }
}

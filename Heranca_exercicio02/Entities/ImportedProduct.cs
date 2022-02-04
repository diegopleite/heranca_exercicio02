using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_exercicio02.Entities {
    class ImportedProduct : Product{       

        public double CustomFee { get; set; }

        public ImportedProduct(string name, double price, double customFee) : base(name, price) {
            CustomFee = customFee;
        }

        public double TotalPrice() {
            return Price + CustomFee;
        }

        public override string PriceTag() {
            StringBuilder sb = new StringBuilder();
            sb.Append("R$" + TotalPrice() + " (Custom fee: R$" + CustomFee + ")");
            return sb.ToString();
        }
    }
}

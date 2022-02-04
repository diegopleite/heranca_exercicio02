using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_exercicio02.Entities {
    class Product {
        public string Name { get; set; }
        public double  Price { get; set; }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine("R$ " + Price);
            return sb.ToString();
        }
    }
}

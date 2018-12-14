using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
	public class Order
	{
		private List<Product> products = new List<Product>();
		public BonusProvider Bonus { get; set; }
		public void AddProduct(Product p)
		{
			products.Add(p);
		}
		public double GetValueOfProducts()
		{
			double value = 0;
			foreach (Product p in products)
				value += p.Value;
			return value;
		}
		public double GetBonus()
		{
			return Bonus(GetValueOfProducts());
		}
		public double GetTotalPrice()
		{
			return GetValueOfProducts() - GetBonus();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

	class Computer
	{
		private string _name;
		public string Name
		{
			get { return this._name; }
			set
			{
				ValidationUtils.isValidStr(value, "Invalide name!");
				this._name = value;
			}

		}
		private List<Component> _components = new List<Component>();
		public List<Component> Components
		{
			get
			{
				return _components;
			}
			set
			{
				this._components = value;

			}
		}

		public Computer(String name, List<Component> components)
		{
			this.Name = name;
			this.Components = components;
		}

		private decimal calculatePrice()
		{
			decimal totalPrice = 0;
			foreach (Component component in this.Components)
			{
				totalPrice = totalPrice + component.Price;
			}
			return totalPrice;
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("Comuter name:");
			builder.Append(Environment.NewLine);
			builder.Append("\t" +  this.Name);
			builder.Append(Environment.NewLine);
			builder.Append("Components: ");
			builder.Append(Environment.NewLine);
			foreach (Component component in this.Components)
			{
				builder.Append("\t" + component.ToString());
				builder.Append(Environment.NewLine);
			}
			builder.Append("============== TOTAL: ");
			builder.Append(calculatePrice().ToString("0.00"));

			return builder.ToString();
		}
	}

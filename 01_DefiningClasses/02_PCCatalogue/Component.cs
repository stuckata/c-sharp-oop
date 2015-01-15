using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

	class Component
	{
		private string _name;
		public string Name
		{
			get { return this._name; }
			set { 
				ValidationUtils.isValidStr(value, "Invalide name!");
				this._name = value;
			}

		}
		private string _details;
		public string Details
		{
			get;
			set;
		}
		private decimal _price;
		public decimal Price
		{
			get { return this._price; }
			set
			{
				ValidationUtils.isDecimal(value, "Invalid price!");
				this._price = value;
			}

		}

		public Component(string name, string details, decimal price)
		{
			this.Name = name;
			this.Details = details;
			this.Price = price;

		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("Component name - " + this.Name);
			builder.Append(", ");
			builder.Append("Component price - ");
			builder.Append(this.Price.ToString("0.00"));

			return builder.ToString();
		}

	}

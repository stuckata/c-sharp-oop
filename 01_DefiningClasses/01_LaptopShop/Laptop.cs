using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Laptop
{

	private String _manufacturer;
	public String Manufacturer
	{
		get
		{
			return this._manufacturer;
		}
		set
		{
			ValidationUtils.isValidStr(value, "Invalid manufacturer!");
			this._manufacturer = value;
		}
	}

	private string _model;
	public string Model
	{
		get
		{
			return _model;
		}
		set
		{
			ValidationUtils.isValidStr(value, "Invalid model!");
			this._model = value;
		}
	}

	private String _processor;
	public String Processor
	{
		get
		{
			return this._processor;
		}
		set
		{
			ValidationUtils.isValidStr(value, "Invalid processor!");
			this._processor = value;
		}
	}
	private String _graphicsCard;
	public String GraphicsCard
	{
		get
		{
			return this._graphicsCard;
		}
		set
		{
			ValidationUtils.isValidStr(value, "Invalid graphics card!");
			this._graphicsCard = value;
		}
	}
	private String _screenSize;
	public String ScreenSize
	{
		get
		{
			return this._screenSize;
		}
		set
		{
			ValidationUtils.isFloat(value, "Invalid screen size!");
			this._screenSize = value;
		}
	}

	private String _price;
	public String Price
	{
		get
		{
			return this._price;
		}
		set
		{
			ValidationUtils.isDecimal(value, "Invalid price!");
			this._price = value;
		}
	}
	public Battery Battery { get; set; }

	public Laptop() { }

	public Laptop(String manufacturer, String model, String processor, String graphicsCard, String screenSize, String price, String battery, String batteryLife)
	{
		this.Manufacturer = manufacturer;
		this.Model = model;
		this.Processor = processor;
		this.GraphicsCard = graphicsCard;
		this.ScreenSize = screenSize;
		this.Price = price;
		this.Battery = new Battery(battery, batteryLife);
	}


	public override string ToString()
	{
		StringBuilder builder = new StringBuilder();
		builder.Append("Manufacturer - " + Manufacturer);
		builder.Append("\nModel - " + Model);
		builder.Append("\nProcessor - " + Processor);
		builder.Append("\nGraphicsCard - " + GraphicsCard);
		builder.Append("\nScreenSize - " + ScreenSize);
		builder.Append("\nPrice - " + Price);
		builder.Append("\n");
		builder.Append(Battery.ToString());

		return builder.ToString();
	}
}


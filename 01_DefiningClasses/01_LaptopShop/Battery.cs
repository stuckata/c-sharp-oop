using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Battery
{
	private String _batteryName;

	public String BatteryName
	{
		get
		{
			return this._batteryName;
		}
		set
		{
			ValidationUtils.isValidStr(value, "Invalid battery!");
			this._batteryName = value;
		}
	}

	private String _batteryLife;

	public String BatteryLife
	{
		get
		{
			return this._batteryLife;
		}
		set
		{
			ValidationUtils.isInt(value, "Invalid battery life!");
			this._batteryLife = value;
		}
	}

	public Battery() { }

	public Battery(String battery, String batteryLife)
	{
		BatteryName = battery;
		BatteryLife = batteryLife;
	}

	public override string ToString()
	{
		return "The battery is: " + _batteryName + "\nBattery life is: " + _batteryLife;
	}
}


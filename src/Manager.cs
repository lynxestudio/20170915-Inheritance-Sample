using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



public class Manager : Employee {

	private string department;
	private string name;
	private double salary;

	public Manager(){

	}

	~Manager(){

	}

	public string Department{
		get{
			return department;
		}
		set{
			department = value;
		}
	}

	public string GetDetails(){

		return "";
	}

	public string Name{
		get{
			return name;
		}
		set{
			name = value;
		}
	}

	public double Salary{
		get{
			return salary;
		}
		set{
			salary = value;
		}
	}

}//end Manager
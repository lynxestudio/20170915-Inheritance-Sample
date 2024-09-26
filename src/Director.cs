
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



public class Director : Manager {

	private bool carAllowance;

	public Director(){

	}

	~Director(){

	}

	public override string Department{
		get{
			return department;
		}
		set{
			department = value;
		}
	}

	public override string GetDetails(){

		return "";
	}

	public void IncreaseAllowance(){

	}

	public override string Name{
		get{
			return name;
		}
		set{
			name = value;
		}
	}

	public override double Salary{
		get{
			return salary;
		}
		set{
			salary = value;
		}
	}

}//end Director
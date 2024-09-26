
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



public class Engineer : Employee {

	public Engineer(){

	}

	~Engineer(){

	}

	public override DateTime BirthDate{
		get{
			return birthDate;
		}
		set{
			birthDate = value;
		}
	}

	public override string GetDetails(){

		return "";
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

}//end Engineer
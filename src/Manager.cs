using System;

namespace Samples.OOP
{
	public class Manager : Employee
	{
  		private string m_Departament;
 
  		public string Departament
  		{
    		get { return m_Departament; }
    		set { m_Departament = value; }
  		}
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPProject
{
    class Food
    {
		/*Encapsulation: putting all common properties of food in food class
		Inheritance: Every "food" item will have access to these properties*/

		public string Name { get; set; }
		public int Calories { get; set; }
		public int TotalFat { get; set; }
		public int TotalCarbs { get; set; }
		public int TotalProtein { get; set; }
		public int SaturatedFat { get; set; }
		public int UnsaturatedFat { get; set; }

		public int GetTotalFat(Food food)
		{

		}
	}
}

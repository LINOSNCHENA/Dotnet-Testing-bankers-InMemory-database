using System.ComponentModel.DataAnnotations;

namespace ASP4.Models
{ 
	public class Product
	{
		[Key]
		[Required]
		[Display(Name = "indexNumber")]
		public string ProductNumber { get; set; }

		[Required]
		[Display(Name = "name")]
		public string Name { get; set; }

		[Required]
		[Range(10, 90)]
		[Display(Name = "price")]
		public double? Price { get; set; }

		[Required]
		[Display(Name = "department")]
		public string Department { get; set; }
	}
}

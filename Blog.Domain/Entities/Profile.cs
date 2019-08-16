using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
	public class Profile : BaseEntity
	{
		//First Name
		public string FirstName { get; set; }
		//Last Name
		public string SecondName { get; set; }
		// Sex(men or women)
		public string Sex { get; set; }
		// Like kross
		public string Kross { get; set; }
		// Like treck
		public string Treck { get; set; }
		// Like street
		public string Street { get; set; }
		// Like chopper
		public string Chopper { get; set; }
		// Like enduro
		public string Enduro { get; set; }
		// Like turing
		public string Turing { get; set; }
		// Profile soft-delete
		public bool IsDelete { get; set; } = false;
	}
}

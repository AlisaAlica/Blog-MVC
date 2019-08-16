using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
	public class Guest : BaseEntity
	{
		//Name 
		public string Name { get; set; }
		//Guest date
		public DateTime Date { get; set; }
		//Guest text
		public string GuestText { get; set; }
		//Guest soft-delete
		public bool IsDelete { get; set; } = false;
	}
}

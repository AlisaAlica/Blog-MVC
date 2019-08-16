using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
	public class News: BaseEntity
	{
		// News title
		public string Title { get; set; }
		//News time
		public DateTime Date { get; set; }
		//News text
		public string NewsText { get; set; }
		//news soft-delete
		public bool IsDelete { get; set; } = false;
	}
}

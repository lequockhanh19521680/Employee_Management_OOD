using Salary_management.Controller.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Infrastructure.Entities
{
	public class PositionHistory : History
	{
		public int Id { get; set; }
		public Employee Employee { get; set; } = null!;

		public string PositionId { get; set; } = null!;
		public Position Position { get; set; } = null!;
	}
}

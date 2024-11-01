﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Entities
{
	public partial class Info
	{
		public int Id { get; set; }
		public string? AboutUs { get; set; }
		public string? Address { get; set; }
		public string? Phone { get; set; }
		public string? Email { get; set; }
	}
}
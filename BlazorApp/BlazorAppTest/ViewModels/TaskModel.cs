﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppTest.ViewModels
{
	public class TaskModel
	{
		public int ID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public bool Completed { get; set; }
	}
}

﻿using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDo.Common.Models
{
    public class TaskBar
    {
		private string icon;

		public string Icon
		{
			get { return icon; }
			set { icon = value; }
		}
		private string color;

		public string Color
		{
			get { return color; }
			set { color = value; }
		}

		private string title;

		public string Title
		{
			get { return title; }
			set { title = value; }
		}
		private string content;

		public string Content
		{
			get { return content; }
			set { content = value; }
		}

	}
}

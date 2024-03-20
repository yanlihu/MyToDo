using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDo.Common.Models
{
    public class BaseToDo
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		private DateTime createTime;

		public DateTime CreateTime
		{
			get { return createTime; }
			set { createTime = value; }
		}
		private DateTime updateTime;
        public DateTime UpdateTime
        {
            get { return updateTime; }
            set { updateTime = value; }
        }
		private int status;

		public int Status
		{
			get { return status; }
			set { status = value; }
		}

	}
}

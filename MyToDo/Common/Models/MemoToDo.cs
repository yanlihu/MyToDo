using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDo.Common.Models
{
    public class MemoToDo: BaseToDo
    {
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

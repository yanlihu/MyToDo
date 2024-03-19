using MyToDo.Common.Models;
using Prism.Common;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDo.ViewModels
{
    class IndexViewModel:BindableBase
    {
        public IndexViewModel()
        {
            TaskBars = new ObservableCollection<TaskBar>();
            CreateTaskBars();
        }
        private ObservableCollection<TaskBar> taskBars;

		public ObservableCollection<TaskBar> TaskBars
        {
			get { return taskBars; }
			set { taskBars = value; RaisePropertyChanged(); }
		}
		private void CreateTaskBars()
		{
            TaskBars.Add(new TaskBar { Icon = "ArchiveCogOutline", Color = "Red", Title = "汇总", Content = "Home" });
            TaskBars.Add(new TaskBar { Icon = "CheckCircleOutline", Color = "Green", Title = "已完成", Content = "List" });
            TaskBars.Add(new TaskBar { Icon = "PercentCircle", Color = "Blue", Title = "完成比例", Content = "Add" });
            TaskBars.Add(new TaskBar { Icon = "NotebookPlusOutline", Color = "Pink", Title = "备忘录", Content = "Settings" });
        }   
	}
}

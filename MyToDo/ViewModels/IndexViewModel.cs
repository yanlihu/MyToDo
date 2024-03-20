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
            MemoToDos = new ObservableCollection<MemoToDo>();
            CreateMemoToDos();
        }
        private ObservableCollection<TaskBar> taskBars;

		public ObservableCollection<TaskBar> TaskBars
        {
			get { return taskBars; }
			set { taskBars = value; RaisePropertyChanged(); }
		}
        private ObservableCollection<MemoToDo> memoToDos;
        public ObservableCollection<MemoToDo> MemoToDos
        {
            get { return memoToDos; }
            set { memoToDos = value; RaisePropertyChanged(); }
        }
        private void CreateTaskBars()
		{
            TaskBars.Add(new TaskBar { Icon = "ArchiveCogOutline", Color = "PaleGreen", Title = "汇总", Content = "Home" });
            TaskBars.Add(new TaskBar { Icon = "CheckCircleOutline", Color = "Brown", Title = "已完成", Content = "List" });
            TaskBars.Add(new TaskBar { Icon = "PercentCircle", Color = "Pink", Title = "完成比例", Content = "Add" });
            TaskBars.Add(new TaskBar { Icon = "NotebookPlusOutline", Color = "Green", Title = "备忘录", Content = "Settings" });
        }   
        private void CreateMemoToDos()
        {
            MemoToDos.Add(new MemoToDo { Title = "备忘录1", Content = "备忘录1内容" });
            MemoToDos.Add(new MemoToDo { Title = "备忘录2", Content = "备忘录2内容" });
            MemoToDos.Add(new MemoToDo { Title = "备忘录3", Content = "备忘录3内容" });
        }
	}
}

using MyToDo.Common.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDo.ViewModels
{
    public class ToDoViewModel:BindableBase
    {
        public ToDoViewModel()
        {
            TODODoTos = new ObservableCollection<TODODoTo>();
            CreateTODODoTos();
        }
        private ObservableCollection<TODODoTo> tODODoTos;
        public ObservableCollection<TODODoTo> TODODoTos
        {
            get { return tODODoTos; }
            set { tODODoTos = value;RaisePropertyChanged(); }
        }
        private bool isRightOpen=false;
        /// <summary>
        /// 右侧栏是否打开
        /// </summary>
        public bool IsRightOpen
        {
            get { return isRightOpen; }
            set { isRightOpen = value;RaisePropertyChanged(); }
        }
        public DelegateCommand OpenRightDrawerCommand
        {
            get
            {
                return new DelegateCommand(() => {
                    IsRightOpen = !isRightOpen;
                });
            }
        }
        private void CreateTODODoTos()
        {
            TODODoTos.Add(new TODODoTo { Title = "Task 1", Content = "Task 1 Description"});
            TODODoTos.Add(new TODODoTo { Title = "Task 2", Content = "Task 2 Description" });
            TODODoTos.Add(new TODODoTo { Title = "Task 3", Content = "Task 3 Description" });
            TODODoTos.Add(new TODODoTo { Title = "Task 4", Content = "Task 4 Description" });
            TODODoTos.Add(new TODODoTo { Title = "Task 5", Content = "Task 5 Description" });
            TODODoTos.Add(new TODODoTo { Title = "Task 6", Content = "Task 6 Description" });
            TODODoTos.Add(new TODODoTo { Title = "Task 7", Content = "Task 7 Description" });
            TODODoTos.Add(new TODODoTo { Title = "Task 8", Content = "Task 8 Description" });
            TODODoTos.Add(new TODODoTo { Title = "Task 9", Content = "Task 9 Description" });
        }
    }
}

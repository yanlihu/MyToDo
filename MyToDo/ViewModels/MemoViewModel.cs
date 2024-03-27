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
    public class MemoViewModel:BindableBase
    {
        public MemoViewModel()
        {
            memoToDos = new ObservableCollection<MemoToDo>();
            CreateMemoToDos();
        }
        private ObservableCollection<MemoToDo> memoToDos;

        public ObservableCollection<MemoToDo> MemoToDos
        {
            get { return memoToDos; }
            set { memoToDos = value; RaisePropertyChanged();}
        }

        private bool isRightOpen = false;
        /// <summary>
        /// 右侧栏是否打开
        /// </summary>
        public bool IsRightOpen
        {
            get { return isRightOpen; }
            set { isRightOpen = value; RaisePropertyChanged(); }
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
        private void CreateMemoToDos()
        { 
            memoToDos.Add(new MemoToDo { Title = "Memo1", Content = "Memo1 Content" });
            //memoToDos.Add(new MemoToDo { Title = "Memo2", Content = "Memo2 Content" });
            //memoToDos.Add(new MemoToDo { Title = "Memo3", Content = "Memo3 Content" });
            //memoToDos.Add(new MemoToDo { Title = "Memo4", Content = "Memo4 Content" });
            //memoToDos.Add(new MemoToDo { Title = "Memo5", Content = "Memo5 Content" });
        }
    }
}

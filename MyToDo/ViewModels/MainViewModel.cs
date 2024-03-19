using MyToDo.Common.Models;
using MyToDo.Extensions;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDo.ViewModels
{
    class MainViewModel:BindableBase
    {
        public MainViewModel(IRegionManager regionManager)
        {
            MenuBars=new ObservableCollection<MenuBar>();
            CreateMenuBars();
            NavigateCommand = new DelegateCommand<MenuBar>(Navigate);
            this.regionManager = regionManager;
        }

        private void Navigate(MenuBar menubar)
        {
            if (menubar == null || string.IsNullOrWhiteSpace(menubar.NameSpace))
            {
                return;
            }
            regionManager.Regions[PrismManager.MainViewRegionName].RequestNavigate(menubar.NameSpace, back => 
            { 
                journal = back.Context.NavigationService.Journal;
                IsLeftDrawerOpen = false;
            });
        }
       
        public DelegateCommand<MenuBar> NavigateCommand { get; set; } 
        public DelegateCommand GoBackCommand
        { 
            get
            {
                return new DelegateCommand(() =>
                {
                    if (journal != null && journal.CanGoBack)
                    {
                        journal.GoBack();
                    }
                });
            }
        }
        public DelegateCommand GoForwardCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (journal != null && journal.CanGoForward)
                    {
                        journal.GoForward();
                    }
                });
            }
        }
        private ObservableCollection<MenuBar> menuBars;
        private readonly IRegionManager regionManager;
        private IRegionNavigationJournal journal;
        /// <summary>
        /// 导航菜单集合
        /// </summary>
        public ObservableCollection<MenuBar> MenuBars
        {
			get { return menuBars; }
			set { menuBars = value;RaisePropertyChanged(); }
		}
		void CreateMenuBars()
		{
			MenuBars.Add(new MenuBar() { Icon = "Home", Title = "首页", NameSpace = "IndexView" });
            MenuBars.Add(new MenuBar() { Icon = "NotebookCheckOutline", Title = "待办事项", NameSpace = "ToDoView" });
            MenuBars.Add(new MenuBar() { Icon = "NotebookPlus", Title = "备忘录", NameSpace = "MemoView" });
            MenuBars.Add(new MenuBar() { Icon = "Cog", Title = "设置", NameSpace = "SettingsView" });
        }
        private bool isLeftDrawerOpen=false;
        /// <summary>
        /// 左边栏是否打开
        /// </summary>
        public bool IsLeftDrawerOpen
        {
            get { return isLeftDrawerOpen; }
            set { isLeftDrawerOpen = value;RaisePropertyChanged(); }
        }

    }
}

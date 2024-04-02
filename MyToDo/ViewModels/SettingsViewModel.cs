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
    public class SettingsViewModel:BindableBase
    {
        public SettingsViewModel(IRegionManager regionManager)
        {
            SettingBars = new ObservableCollection<MenuBar>();
            CreateSettingBars();
            NavigateCommand = new DelegateCommand<MenuBar>(Navigate);
            this.regionManager = regionManager;
        }
        private readonly IRegionManager regionManager;
        public DelegateCommand<MenuBar> NavigateCommand { get; set; }
        private ObservableCollection<MenuBar> settingBars;

		public ObservableCollection<MenuBar> SettingBars
        {
			get { return settingBars; }
            set { settingBars = value; RaisePropertyChanged(); }
		}
        private void Navigate(MenuBar menubar)
        {
            if (menubar == null || string.IsNullOrWhiteSpace(menubar.NameSpace))
            {
                return;
            }
            regionManager.Regions[PrismManager.SettingsViewRegionName].RequestNavigate(menubar.NameSpace);
        }
        private void CreateSettingBars()
        {
            SettingBars.Add(new MenuBar() { Icon = "AccountAlert", Title = "个性化", NameSpace = "SkinView" });
            SettingBars.Add(new MenuBar() { Icon = "Cog", Title = "系统设置", NameSpace = "Settings" });
            SettingBars.Add(new MenuBar() { Icon = "InformationOutline", Title = "关于", NameSpace = "About" });
        }
    }
}

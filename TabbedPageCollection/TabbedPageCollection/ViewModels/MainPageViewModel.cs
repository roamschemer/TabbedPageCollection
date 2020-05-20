using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using TabbedPageCollection.Models;

namespace TabbedPageCollection.ViewModels {
    public class MainPageViewModel : ViewModelBase {
        public ReactiveCommand<string> Command { get; }
        public MainPageViewModel(INavigationService navigationService, CoreModel coreModel) : base(navigationService) {
            Command = new ReactiveCommand<string>().WithSubscribe(async x => await navigationService.NavigateAsync(x)); 
        }
    }
}

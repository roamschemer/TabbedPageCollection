using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using TabbedPageCollection.Models;

namespace TabbedPageCollection.ViewModels {
    public class TabbedCollectionPage2ViewModel : ViewModelBase {
        public ReadOnlyReactiveCollection<CategoryViewModel> CategoryViewModels { get; }
        public TabbedCollectionPage2ViewModel(INavigationService navigationService, CoreModel coreModel) : base(navigationService) {
            CategoryViewModels = coreModel.Categorys.ToReadOnlyReactiveCollection(x => new CategoryViewModel(x)).AddTo(this.Disposable);
        }
    }
}

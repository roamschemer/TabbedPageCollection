using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System.Collections.Generic;
using System.Linq;
using TabbedPageCollection.Models;

namespace TabbedPageCollection.ViewModels {
    public partial class TabbedCollectionPage1ViewModel : ViewModelBase {
        public ReadOnlyReactiveCollection<CategoryViewModel> CategoryViewModels { get; }
        public TabbedCollectionPage1ViewModel(INavigationService navigationService, CoreModel coreModel) : base(navigationService) {
            CategoryViewModels = coreModel.Categorys.ToReadOnlyReactiveCollection(x => new CategoryViewModel(x)).AddTo(this.Disposable);
        }
    }
}

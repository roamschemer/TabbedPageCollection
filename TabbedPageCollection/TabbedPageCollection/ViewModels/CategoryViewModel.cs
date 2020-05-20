using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Reactive.Disposables;
using TabbedPageCollection.Models;

namespace TabbedPageCollection.ViewModels {
    public class CategoryViewModel : IDisposable {
        public ReactiveProperty<string> Name { get; }
        public ReadOnlyReactiveCollection<PersonViewModel> PersonViewModels { get; }
        public CategoryViewModel(Category category) {
            Name = category.ObserveProperty(x => x.Name).ToReactiveProperty().AddTo(this.Disposable);
            PersonViewModels = category.Persons.ToReadOnlyReactiveCollection(x => new PersonViewModel(x)).AddTo(this.Disposable);
        }
        //後始末
        private CompositeDisposable Disposable { get; } = new CompositeDisposable();
        public void Dispose() => this.Disposable.Dispose();

        public class PersonViewModel {
            public ReactiveProperty<string> Name { get; }
            public PersonViewModel(Person person) {
                Name = person.ToReactivePropertyAsSynchronized(x => x.Name).AddTo(this.Disposable);
            }
            //後始末
            private CompositeDisposable Disposable { get; } = new CompositeDisposable();
            public void Dispose() => this.Disposable.Dispose();
        }
    }
}

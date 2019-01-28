
# Project structure

``` bash
├── App_Start
│   ├── ServiceLocator
│   │   └── NinjectServiceLocator.cs
│   ├── ApplicationLifeCycle.cs
│   ├── ApplicationViewModelBuilder.cs
│   ├── DependencyInjectionConfiguration.cs
│   ├── IDependencyInjectionConfiguration.cs
│   └──RoutingConfiguration.cs
├── Content
│   └── logo.png
├── View
│   └── ....
├── ViewModel
│   ├── AboutViewModel.cs
│   └── MainViewModel.cs
```

* `App_Start` contains all files linked to application bootstrapping.
  * Alter [ApplicationLifeCycle](./Neutronium.SPA.ApplicationLifeCycle.html) to add behavior to the application
  * Alter [DependencyInjectionConfiguration](Neutronium.SPA.DependencyInjectionConfiguration.html) to alter Application dependency injection
* `View` contains all HTML,CSS, javascript files
* `ViewModel` contains all application main viewModels (viewModel associated with pages)

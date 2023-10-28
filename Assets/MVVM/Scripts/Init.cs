using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Init : AbstractBootstrapper
{
    public override void Configure(IIoCContainer container)
    {
        IApp app = new App();

        container.RegisterSingleton(app);

        // Initializers
        container.RegisterSingleton<MainInitializer>();
        container.RegisterSingleton<DemoGameInitializer>();

        // Managers
        container.RegisterSingleton<DemoManager>();

        // ViewModels
        container.RegisterSingleton<IContext, MainViewModel>("main");
        container.RegisterSingleton<IContext, DemoGameMainViewModel>("miniGame");

        IServiceLocator serviceLocator = container as IServiceLocator;

        app.SetContext(serviceLocator.Resolve<IContext>("main"));
    }
}

/// <summary>
/// Example Code
/// </summary>
public class MainInitializer : IInitializer
{
    public void Init()
    {
        SceneManager.LoadSceneAsync("main");
    }
}

public class DemoGameInitializer : IInitializer
{
    public void Init()
    {
        SceneManager.LoadSceneAsync("mini_game");

    }
}

public class MainViewModel : IContext
{
    public IApp App { get; set; }
    public IServiceLocator ServiceLocator { get; set; }
    public IInitializer Initializer { get; set; }

    public MainViewModel(IApp app, IServiceLocator serviceLocator, MainInitializer initializer)
    {
        App = app;
        ServiceLocator = serviceLocator;
        Initializer = initializer;
    }

    public void Init()
    {
        Initializer.Init();
    }
}

public class DemoGameMainViewModel : IContext
{
    public IApp App { get; set; }
    public IServiceLocator ServiceLocator { get; set; }
    public IInitializer Initializer { get; set; }

    public DemoGameMainViewModel(IApp app, IServiceLocator serviceLocator, DemoGameInitializer initializer)
    {
        App = app;
        ServiceLocator = serviceLocator;
        Initializer = initializer;
    }

    public void Init()
    {
        Initializer.Init();
    }
}

public class DemoManager
{
    public void DemoFunction()
    {
        Debug.Log("This Works!");
    }
}

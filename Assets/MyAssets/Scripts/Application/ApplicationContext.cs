using MyAssets.Scripts.Application;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class ApplicationContext : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        base.Configure(builder);
        
        //Initialize
        Application.targetFrameRate = 30;
        builder.Register<ApplicationService>(Lifetime.Singleton);
        builder.RegisterEntryPoint<ApplicationPresenter>();
    }
}

using UnityEngine;
using VContainer;
using VContainer.Unity;

public class ApplicationContext : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        base.Configure(builder);

        Application.targetFrameRate = 30;
        
        //System Register
    }
}

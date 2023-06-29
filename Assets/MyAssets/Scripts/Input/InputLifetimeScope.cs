using UnityEngine;
using VContainer;
using VContainer.Unity;

public class InputLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        Debug.Log("Hello Input!");
    }
}

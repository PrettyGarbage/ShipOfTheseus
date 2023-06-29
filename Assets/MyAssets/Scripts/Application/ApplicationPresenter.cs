using UnityEngine;
using VContainer.Unity;

namespace MyAssets.Scripts.Application
{
    public class ApplicationPresenter : IStartable
    {
        private readonly ApplicationService _service;

        private ApplicationPresenter(ApplicationService service)
        {
            _service = service;
        }
        
        public void Start()
        {
            Debug.Log("ApplicationPresenter Start");
        }
    }
}
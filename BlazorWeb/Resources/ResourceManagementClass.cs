using Microsoft.AspNetCore.Components;
using System.Resources;

namespace ResourceManagementClass
{
    public class MyComponent : ComponentBase
    {
        private readonly ResourceManager _resourceManager;

        public MyComponent()
        {
            // Replace "ResourceManagementClass.Resources.Resource1" with the actual namespace and name of your resource file
            _resourceManager = new ResourceManager("ResourceManagementClass.Resources.Resource1", typeof(MyComponent).Assembly);
        }

        protected string GetString(string key)
        {
            return _resourceManager.GetString(key);
        }

        // You can then use this method to retrieve strings in your component
    }

    // Other classes in ResourceManagementClass namespace can go here
}

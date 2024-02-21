using System;
using System.Resources;

namespace BlazorWeb.Errors
{
    public class ErrorClass
    {
        private readonly ResourceManager _resourceManager;

        public ErrorClass(ResourceManager resourceManager)
        {
            _resourceManager = resourceManager ?? throw new ArgumentNullException(nameof(resourceManager));
        }

        public string GetErrorMessage(string errorKey)
        {
            return _resourceManager.GetString(errorKey);
        }

        public string CheckForNullInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return GetErrorMessage("NullErrorInput");
            }

            // Additional checks or logic can be added here as needed

            return string.Empty; // No error
        }
    }
}

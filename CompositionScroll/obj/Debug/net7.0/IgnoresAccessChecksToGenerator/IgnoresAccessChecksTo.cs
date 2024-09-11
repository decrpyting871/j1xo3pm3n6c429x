[assembly: System.Runtime.CompilerServices.IgnoresAccessChecksTo("Avalonia.Controls")]
[assembly: System.Runtime.CompilerServices.IgnoresAccessChecksTo("Avalonia.Base")]

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    internal sealed class IgnoresAccessChecksToAttribute : Attribute
    {
        public IgnoresAccessChecksToAttribute(string assemblyName)
        {
        }
    }
}
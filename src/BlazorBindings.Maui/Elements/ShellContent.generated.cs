// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.Maui.Elements
{
    /// <summary>
    /// Corresponds to a <see cref="T:Microsoft.Maui.Controls.ContentPage" /> contained in a <see cref="T:Microsoft.Maui.Controls.ShellSection" />.
    /// </summary>
    public partial class ShellContent : BaseShellItem
    {
        static ShellContent()
        {
            RegisterAdditionalHandlers();
        }

        public new MC.ShellContent NativeControl => (MC.ShellContent)((BindableObject)this).NativeControl;

        protected override MC.ShellContent CreateNativeElement() => new();


        static partial void RegisterAdditionalHandlers();
    }
}

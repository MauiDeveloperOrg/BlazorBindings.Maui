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

namespace BlazorBindings.Maui.Elements
{
    public partial class StackLayout : StackBase
    {
        static StackLayout()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public MC.StackOrientation Orientation { get; set; }

        public new MC.StackLayout NativeControl => (MC.StackLayout)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new MC.StackLayout();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Orientation):
                    if (!Equals(Orientation, value))
                    {
                        Orientation = (MC.StackOrientation)value;
                        NativeControl.Orientation = Orientation;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        static partial void RegisterAdditionalHandlers();
    }
}

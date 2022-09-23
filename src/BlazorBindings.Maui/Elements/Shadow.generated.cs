// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui.Graphics;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class Shadow : Element
    {
        static Shadow()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public Point? Offset { get; set; }
        [Parameter] public float? Opacity { get; set; }
        [Parameter] public float? Radius { get; set; }

        public new MC.Shadow NativeControl => (MC.Shadow)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new MC.Shadow();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Offset):
                    if (!Equals(Offset, value))
                    {
                        Offset = (Point?)value;
                        NativeControl.Offset = Offset ?? (Point)MC.Shadow.OffsetProperty.DefaultValue;
                    }
                    break;
                case nameof(Opacity):
                    if (!Equals(Opacity, value))
                    {
                        Opacity = (float?)value;
                        NativeControl.Opacity = Opacity ?? (float)MC.Shadow.OpacityProperty.DefaultValue;
                    }
                    break;
                case nameof(Radius):
                    if (!Equals(Radius, value))
                    {
                        Radius = (float?)value;
                        NativeControl.Radius = Radius ?? (float)MC.Shadow.RadiusProperty.DefaultValue;
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
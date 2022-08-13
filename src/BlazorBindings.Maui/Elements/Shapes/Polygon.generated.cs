// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements;
using BlazorBindings.Maui.Elements.Shapes.Handlers;
using MC = Microsoft.Maui.Controls;
using MCS = Microsoft.Maui.Controls.Shapes;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements.Shapes
{
    public partial class Polygon : Shape
    {
        static Polygon()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public MCS.FillRule FillRule { get; set; }

        public new MCS.Polygon NativeControl => (MCS.Polygon)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new MCS.Polygon();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(FillRule):
                    if (!Equals(FillRule, value))
                    {
                        FillRule = (MCS.FillRule)value;
                        NativeControl.FillRule = FillRule;
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

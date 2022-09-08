// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements.Handlers;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class FlyoutPage : Page
    {
        static FlyoutPage()
        {
            ElementHandlerRegistry.RegisterPropertyContentHandler<FlyoutPage>(nameof(Detail),
                _ => new ContentPropertyHandler<MC.FlyoutPage>((x, value) => x.Detail = (MC.Page)value));
            ElementHandlerRegistry.RegisterPropertyContentHandler<FlyoutPage>(nameof(Flyout),
                _ => new ContentPropertyHandler<MC.FlyoutPage>((x, value) => x.Flyout = (MC.Page)value));
            RegisterAdditionalHandlers();
        }

        [Parameter] public MC.FlyoutLayoutBehavior FlyoutLayoutBehavior { get; set; }
        [Parameter] public bool IsGestureEnabled { get; set; }
        [Parameter] public bool IsPresented { get; set; }
        [Parameter] public RenderFragment Detail { get; set; }
        [Parameter] public RenderFragment Flyout { get; set; }
        [Parameter] public EventCallback<bool> IsPresentedChanged { get; set; }

        public new MC.FlyoutPage NativeControl => (MC.FlyoutPage)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new MC.FlyoutPage();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(FlyoutLayoutBehavior):
                    if (!Equals(FlyoutLayoutBehavior, value))
                    {
                        FlyoutLayoutBehavior = (MC.FlyoutLayoutBehavior)value;
                        NativeControl.FlyoutLayoutBehavior = FlyoutLayoutBehavior;
                    }
                    break;
                case nameof(IsGestureEnabled):
                    if (!Equals(IsGestureEnabled, value))
                    {
                        IsGestureEnabled = (bool)value;
                        NativeControl.IsGestureEnabled = IsGestureEnabled;
                    }
                    break;
                case nameof(IsPresented):
                    if (!Equals(IsPresented, value))
                    {
                        IsPresented = (bool)value;
                        NativeControl.IsPresented = IsPresented;
                    }
                    break;
                case nameof(Detail):
                    Detail = (RenderFragment)value;
                    break;
                case nameof(Flyout):
                    Flyout = (RenderFragment)value;
                    break;
                case nameof(IsPresentedChanged):
                    if (!Equals(IsPresentedChanged, value))
                    {
                        void NativeControlIsPresentedChanged(object sender, EventArgs e) => IsPresentedChanged.InvokeAsync(NativeControl.IsPresented);

                        IsPresentedChanged = (EventCallback<bool>)value;
                        NativeControl.IsPresentedChanged -= NativeControlIsPresentedChanged;
                        NativeControl.IsPresentedChanged += NativeControlIsPresentedChanged;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        protected override void RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
            RenderTreeBuilderHelper.AddContentProperty(builder, sequence++, typeof(FlyoutPage), Detail);
            RenderTreeBuilderHelper.AddContentProperty(builder, sequence++, typeof(FlyoutPage), Flyout);;
        }

        static partial void RegisterAdditionalHandlers();
    }
}

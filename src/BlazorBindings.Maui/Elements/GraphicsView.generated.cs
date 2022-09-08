// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui.Graphics;
using System;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class GraphicsView : View
    {
        static GraphicsView()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public IDrawable Drawable { get; set; }
        [Parameter] public EventCallback<MC.TouchEventArgs> OnStartHoverInteraction { get; set; }
        [Parameter] public EventCallback<MC.TouchEventArgs> OnMoveHoverInteraction { get; set; }
        [Parameter] public EventCallback OnEndHoverInteraction { get; set; }
        [Parameter] public EventCallback<MC.TouchEventArgs> OnStartInteraction { get; set; }
        [Parameter] public EventCallback<MC.TouchEventArgs> OnDragInteraction { get; set; }
        [Parameter] public EventCallback<MC.TouchEventArgs> OnEndInteraction { get; set; }
        [Parameter] public EventCallback OnCancelInteraction { get; set; }

        public new MC.GraphicsView NativeControl => (MC.GraphicsView)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new MC.GraphicsView();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Drawable):
                    if (!Equals(Drawable, value))
                    {
                        Drawable = (IDrawable)value;
                        NativeControl.Drawable = Drawable;
                    }
                    break;
                case nameof(OnStartHoverInteraction):
                    if (!Equals(OnStartHoverInteraction, value))
                    {
                        void NativeControlStartHoverInteraction(object sender, MC.TouchEventArgs e) => OnStartHoverInteraction.InvokeAsync(e);

                        OnStartHoverInteraction = (EventCallback<MC.TouchEventArgs>)value;
                        NativeControl.StartHoverInteraction -= NativeControlStartHoverInteraction;
                        NativeControl.StartHoverInteraction += NativeControlStartHoverInteraction;
                    }
                    break;
                case nameof(OnMoveHoverInteraction):
                    if (!Equals(OnMoveHoverInteraction, value))
                    {
                        void NativeControlMoveHoverInteraction(object sender, MC.TouchEventArgs e) => OnMoveHoverInteraction.InvokeAsync(e);

                        OnMoveHoverInteraction = (EventCallback<MC.TouchEventArgs>)value;
                        NativeControl.MoveHoverInteraction -= NativeControlMoveHoverInteraction;
                        NativeControl.MoveHoverInteraction += NativeControlMoveHoverInteraction;
                    }
                    break;
                case nameof(OnEndHoverInteraction):
                    if (!Equals(OnEndHoverInteraction, value))
                    {
                        void NativeControlEndHoverInteraction(object sender, EventArgs e) => OnEndHoverInteraction.InvokeAsync();

                        OnEndHoverInteraction = (EventCallback)value;
                        NativeControl.EndHoverInteraction -= NativeControlEndHoverInteraction;
                        NativeControl.EndHoverInteraction += NativeControlEndHoverInteraction;
                    }
                    break;
                case nameof(OnStartInteraction):
                    if (!Equals(OnStartInteraction, value))
                    {
                        void NativeControlStartInteraction(object sender, MC.TouchEventArgs e) => OnStartInteraction.InvokeAsync(e);

                        OnStartInteraction = (EventCallback<MC.TouchEventArgs>)value;
                        NativeControl.StartInteraction -= NativeControlStartInteraction;
                        NativeControl.StartInteraction += NativeControlStartInteraction;
                    }
                    break;
                case nameof(OnDragInteraction):
                    if (!Equals(OnDragInteraction, value))
                    {
                        void NativeControlDragInteraction(object sender, MC.TouchEventArgs e) => OnDragInteraction.InvokeAsync(e);

                        OnDragInteraction = (EventCallback<MC.TouchEventArgs>)value;
                        NativeControl.DragInteraction -= NativeControlDragInteraction;
                        NativeControl.DragInteraction += NativeControlDragInteraction;
                    }
                    break;
                case nameof(OnEndInteraction):
                    if (!Equals(OnEndInteraction, value))
                    {
                        void NativeControlEndInteraction(object sender, MC.TouchEventArgs e) => OnEndInteraction.InvokeAsync(e);

                        OnEndInteraction = (EventCallback<MC.TouchEventArgs>)value;
                        NativeControl.EndInteraction -= NativeControlEndInteraction;
                        NativeControl.EndInteraction += NativeControlEndInteraction;
                    }
                    break;
                case nameof(OnCancelInteraction):
                    if (!Equals(OnCancelInteraction, value))
                    {
                        void NativeControlCancelInteraction(object sender, EventArgs e) => OnCancelInteraction.InvokeAsync();

                        OnCancelInteraction = (EventCallback)value;
                        NativeControl.CancelInteraction -= NativeControlCancelInteraction;
                        NativeControl.CancelInteraction += NativeControlCancelInteraction;
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

// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using AC = AlohaKit.Controls;
using BlazorBindings.Core;
using BlazorBindings.Maui.Elements;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using System;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements.AlohaKit
{
    public partial class Button : BlazorBindings.Maui.Elements.GraphicsView
    {
        static Button()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public AC.ButtonDrawable ButtonDrawable { get; set; }
        [Parameter] public CornerRadius CornerRadius { get; set; }
        [Parameter] public bool HasShadow { get; set; }
        [Parameter] public TextAlignment HorizontalTextAlignment { get; set; }
        [Parameter] public Color ShadowColor { get; set; }
        [Parameter] public double StrokeThickness { get; set; }
        [Parameter] public string Text { get; set; }
        [Parameter] public Color TextColor { get; set; }
        [Parameter] public TextAlignment VerticalTextAlignment { get; set; }
        [Parameter] public EventCallback OnClick { get; set; }
        [Parameter] public EventCallback OnPress { get; set; }
        [Parameter] public EventCallback OnRelease { get; set; }

        public new AC.Button NativeControl => (AC.Button)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new AC.Button();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(ButtonDrawable):
                    if (!Equals(ButtonDrawable, value))
                    {
                        ButtonDrawable = (AC.ButtonDrawable)value;
                        NativeControl.ButtonDrawable = ButtonDrawable;
                    }
                    break;
                case nameof(CornerRadius):
                    if (!Equals(CornerRadius, value))
                    {
                        CornerRadius = (CornerRadius)value;
                        NativeControl.CornerRadius = CornerRadius;
                    }
                    break;
                case nameof(HasShadow):
                    if (!Equals(HasShadow, value))
                    {
                        HasShadow = (bool)value;
                        NativeControl.HasShadow = HasShadow;
                    }
                    break;
                case nameof(HorizontalTextAlignment):
                    if (!Equals(HorizontalTextAlignment, value))
                    {
                        HorizontalTextAlignment = (TextAlignment)value;
                        NativeControl.HorizontalTextAlignment = HorizontalTextAlignment;
                    }
                    break;
                case nameof(ShadowColor):
                    if (!Equals(ShadowColor, value))
                    {
                        ShadowColor = (Color)value;
                        NativeControl.ShadowColor = ShadowColor;
                    }
                    break;
                case nameof(StrokeThickness):
                    if (!Equals(StrokeThickness, value))
                    {
                        StrokeThickness = (double)value;
                        NativeControl.StrokeThickness = StrokeThickness;
                    }
                    break;
                case nameof(Text):
                    if (!Equals(Text, value))
                    {
                        Text = (string)value;
                        NativeControl.Text = Text;
                    }
                    break;
                case nameof(TextColor):
                    if (!Equals(TextColor, value))
                    {
                        TextColor = (Color)value;
                        NativeControl.TextColor = TextColor;
                    }
                    break;
                case nameof(VerticalTextAlignment):
                    if (!Equals(VerticalTextAlignment, value))
                    {
                        VerticalTextAlignment = (TextAlignment)value;
                        NativeControl.VerticalTextAlignment = VerticalTextAlignment;
                    }
                    break;
                case nameof(OnClick):
                    if (!Equals(OnClick, value))
                    {
                        void NativeControlClicked(object sender, EventArgs e) => OnClick.InvokeAsync();

                        OnClick = (EventCallback)value;
                        NativeControl.Clicked -= NativeControlClicked;
                        NativeControl.Clicked += NativeControlClicked;
                    }
                    break;
                case nameof(OnPress):
                    if (!Equals(OnPress, value))
                    {
                        void NativeControlPressed(object sender, EventArgs e) => OnPress.InvokeAsync();

                        OnPress = (EventCallback)value;
                        NativeControl.Pressed -= NativeControlPressed;
                        NativeControl.Pressed += NativeControlPressed;
                    }
                    break;
                case nameof(OnRelease):
                    if (!Equals(OnRelease, value))
                    {
                        void NativeControlReleased(object sender, EventArgs e) => OnRelease.InvokeAsync();

                        OnRelease = (EventCallback)value;
                        NativeControl.Released -= NativeControlReleased;
                        NativeControl.Released += NativeControlReleased;
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

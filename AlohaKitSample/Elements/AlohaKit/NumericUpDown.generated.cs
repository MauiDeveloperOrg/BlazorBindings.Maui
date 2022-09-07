// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using AC = AlohaKit.Controls;
using BlazorBindings.Core;
using BlazorBindings.Maui.Elements;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui.Graphics;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements.AlohaKit
{
    public partial class NumericUpDown : BlazorBindings.Maui.Elements.GraphicsView
    {
        static NumericUpDown()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public Color Color { get; set; }
        [Parameter] public double FontSize { get; set; }
        [Parameter] public double Interval { get; set; }
        [Parameter] public double Maximum { get; set; }
        [Parameter] public double Minimum { get; set; }
        [Parameter] public AC.NumericUpDownDrawable NumericUpDownDrawable { get; set; }
        [Parameter] public Color TextColor { get; set; }
        [Parameter] public double Value { get; set; }

        public new AC.NumericUpDown NativeControl => (AC.NumericUpDown)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new AC.NumericUpDown();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Color):
                    if (!Equals(Color, value))
                    {
                        Color = (Color)value;
                        NativeControl.Color = Color;
                    }
                    break;
                case nameof(FontSize):
                    if (!Equals(FontSize, value))
                    {
                        FontSize = (double)value;
                        NativeControl.FontSize = FontSize;
                    }
                    break;
                case nameof(Interval):
                    if (!Equals(Interval, value))
                    {
                        Interval = (double)value;
                        NativeControl.Interval = Interval;
                    }
                    break;
                case nameof(Maximum):
                    if (!Equals(Maximum, value))
                    {
                        Maximum = (double)value;
                        NativeControl.Maximum = Maximum;
                    }
                    break;
                case nameof(Minimum):
                    if (!Equals(Minimum, value))
                    {
                        Minimum = (double)value;
                        NativeControl.Minimum = Minimum;
                    }
                    break;
                case nameof(NumericUpDownDrawable):
                    if (!Equals(NumericUpDownDrawable, value))
                    {
                        NumericUpDownDrawable = (AC.NumericUpDownDrawable)value;
                        NativeControl.NumericUpDownDrawable = NumericUpDownDrawable;
                    }
                    break;
                case nameof(TextColor):
                    if (!Equals(TextColor, value))
                    {
                        TextColor = (Color)value;
                        NativeControl.TextColor = TextColor;
                    }
                    break;
                case nameof(Value):
                    if (!Equals(Value, value))
                    {
                        Value = (double)value;
                        NativeControl.Value = Value;
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

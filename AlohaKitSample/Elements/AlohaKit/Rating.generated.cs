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
    public partial class Rating : BlazorBindings.Maui.Elements.GraphicsView
    {
        static Rating()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public bool IsReadOnly { get; set; }
        [Parameter] public int ItemsCount { get; set; }
        [Parameter] public AC.RatingDrawable RatingDrawable { get; set; }
        [Parameter] public Color SelectedFill { get; set; }
        [Parameter] public Color SelectedStroke { get; set; }
        [Parameter] public double SelectedStrokeWidth { get; set; }
        [Parameter] public Color UnSelectedFill { get; set; }
        [Parameter] public Color UnSelectedStroke { get; set; }
        [Parameter] public double UnSelectedStrokeWidth { get; set; }
        [Parameter] public int Value { get; set; }

        public new AC.Rating NativeControl => (AC.Rating)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new AC.Rating();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(IsReadOnly):
                    if (!Equals(IsReadOnly, value))
                    {
                        IsReadOnly = (bool)value;
                        NativeControl.IsReadOnly = IsReadOnly;
                    }
                    break;
                case nameof(ItemsCount):
                    if (!Equals(ItemsCount, value))
                    {
                        ItemsCount = (int)value;
                        NativeControl.ItemsCount = ItemsCount;
                    }
                    break;
                case nameof(RatingDrawable):
                    if (!Equals(RatingDrawable, value))
                    {
                        RatingDrawable = (AC.RatingDrawable)value;
                        NativeControl.RatingDrawable = RatingDrawable;
                    }
                    break;
                case nameof(SelectedFill):
                    if (!Equals(SelectedFill, value))
                    {
                        SelectedFill = (Color)value;
                        NativeControl.SelectedFill = SelectedFill;
                    }
                    break;
                case nameof(SelectedStroke):
                    if (!Equals(SelectedStroke, value))
                    {
                        SelectedStroke = (Color)value;
                        NativeControl.SelectedStroke = SelectedStroke;
                    }
                    break;
                case nameof(SelectedStrokeWidth):
                    if (!Equals(SelectedStrokeWidth, value))
                    {
                        SelectedStrokeWidth = (double)value;
                        NativeControl.SelectedStrokeWidth = SelectedStrokeWidth;
                    }
                    break;
                case nameof(UnSelectedFill):
                    if (!Equals(UnSelectedFill, value))
                    {
                        UnSelectedFill = (Color)value;
                        NativeControl.UnSelectedFill = UnSelectedFill;
                    }
                    break;
                case nameof(UnSelectedStroke):
                    if (!Equals(UnSelectedStroke, value))
                    {
                        UnSelectedStroke = (Color)value;
                        NativeControl.UnSelectedStroke = UnSelectedStroke;
                    }
                    break;
                case nameof(UnSelectedStrokeWidth):
                    if (!Equals(UnSelectedStrokeWidth, value))
                    {
                        UnSelectedStrokeWidth = (double)value;
                        NativeControl.UnSelectedStrokeWidth = UnSelectedStrokeWidth;
                    }
                    break;
                case nameof(Value):
                    if (!Equals(Value, value))
                    {
                        Value = (int)value;
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

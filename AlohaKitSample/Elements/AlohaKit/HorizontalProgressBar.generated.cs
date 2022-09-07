// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using AC = AlohaKit.Controls;
using BlazorBindings.Core;
using BlazorBindings.Maui.Elements;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements.AlohaKit
{
    public partial class HorizontalProgressBar : BlazorBindings.Maui.Elements.GraphicsView
    {
        static HorizontalProgressBar()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public double Progress { get; set; }
        [Parameter] public AC.HorizontalProgressBarDrawable ProgressBarDrawable { get; set; }

        public new AC.HorizontalProgressBar NativeControl => (AC.HorizontalProgressBar)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new AC.HorizontalProgressBar();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Progress):
                    if (!Equals(Progress, value))
                    {
                        Progress = (double)value;
                        NativeControl.Progress = Progress;
                    }
                    break;
                case nameof(ProgressBarDrawable):
                    if (!Equals(ProgressBarDrawable, value))
                    {
                        ProgressBarDrawable = (AC.HorizontalProgressBarDrawable)value;
                        NativeControl.ProgressBarDrawable = ProgressBarDrawable;
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

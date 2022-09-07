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
    public partial class Avatar : BlazorBindings.Maui.Elements.GraphicsView
    {
        static Avatar()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public AC.AvatarSize AvatarSize { get; set; }
        [Parameter] public string Name { get; set; }
        [Parameter] public AC.AvatarDrawable PersonaDrawable { get; set; }
        [Parameter] public Color TextColor { get; set; }

        public new AC.Avatar NativeControl => (AC.Avatar)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new AC.Avatar();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(AvatarSize):
                    if (!Equals(AvatarSize, value))
                    {
                        AvatarSize = (AC.AvatarSize)value;
                        NativeControl.AvatarSize = AvatarSize;
                    }
                    break;
                case nameof(Name):
                    if (!Equals(Name, value))
                    {
                        Name = (string)value;
                        NativeControl.Name = Name;
                    }
                    break;
                case nameof(PersonaDrawable):
                    if (!Equals(PersonaDrawable, value))
                    {
                        PersonaDrawable = (AC.AvatarDrawable)value;
                        NativeControl.PersonaDrawable = PersonaDrawable;
                    }
                    break;
                case nameof(TextColor):
                    if (!Equals(TextColor, value))
                    {
                        TextColor = (Color)value;
                        NativeControl.TextColor = TextColor;
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

﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;
using Xamarin.Forms;

namespace Microsoft.MobileBlazorBindings.Elements
{
    public static partial class AttributeHelper
    {
        public static object ObjectToAttribute<T>(T value)
        {
            if (value == null || value is string || value is int || value is Delegate)
                return value;

            if (value is bool boolValue)
                return boolValue ? "1" : "0";

            return value switch
            {
                double d => DoubleToString(d),
                float f => SingleToString(f),
                uint ui => UInt32ToString(ui),
                Color color => ColorToString(color),
                CornerRadius cornerRadius => CornerRadiusToString(cornerRadius),
                DateTime dateTime => DateTimeToString(dateTime),
                GridLength gridLength => GridLengthToString(gridLength),
                LayoutOptions layoutOptions => LayoutOptionsToString(layoutOptions),
                Thickness thickness => ThicknessToString(thickness),
                TimeSpan timeSpan => TimeSpanToString(timeSpan),

                _ => ObjectToDelegate(value)
            };
        }

        /// <summary>
        /// Helper method to serialize objects.
        /// </summary>
        public static AttributeValueHolder ObjectToDelegate(object value)
        {
            if (value is null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            return AttributeValueHolderFactory.FromObject(value);
        }

        /// <summary>
        /// Helper method to deserialize objects.
        /// </summary>
        public static T DelegateToObject<T>(object value, T defaultValueIfNull = default)
        {
            return AttributeValueHolderFactory.ToValue<T>(value, defaultValueIfNull);
        }
    }
}

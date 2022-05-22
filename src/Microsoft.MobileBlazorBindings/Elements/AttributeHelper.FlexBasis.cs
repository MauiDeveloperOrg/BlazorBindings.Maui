﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Xamarin.Forms;
using static Xamarin.Forms.FlexBasis;

namespace Microsoft.MobileBlazorBindings.Elements
{
    public partial class AttributeHelper
    {
        private static readonly FlexBasisTypeConverter _flexBasisConverter = new();

        public static string FlexBasisToString(FlexBasis flexBasis)
        {
            return _flexBasisConverter.ConvertToInvariantString(flexBasis);
        }

        public static FlexBasis StringToFlexBasis(object flexBasisString)
        {
            return (FlexBasis)_flexBasisConverter.ConvertFromInvariantString((string)flexBasisString);
        }
    }
}

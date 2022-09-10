// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XCalendar.Core.Interfaces;
using XMV = XCalendar.Maui.Views;

namespace BlazorBindings.Maui.Elements.XCalendar
{
    public partial class CalendarView : BlazorBindings.Maui.Elements.ContentView
    {
        static CalendarView()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public double DayNameHorizontalSpacing { get; set; }
        [Parameter] public double DayNamesHeightRequest { get; set; }
        [Parameter] public double DayNameVerticalSpacing { get; set; }
        [Parameter] public IEnumerable<ICalendarDay> Days { get; set; }
        [Parameter] public IList<DayOfWeek> DaysOfWeek { get; set; }
        [Parameter] public double DaysViewHeightRequest { get; set; }
        [Parameter] public DateTime NavigatedDate { get; set; }

        public new XMV.CalendarView NativeControl => (XMV.CalendarView)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new XMV.CalendarView();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(DayNameHorizontalSpacing):
                    if (!Equals(DayNameHorizontalSpacing, value))
                    {
                        DayNameHorizontalSpacing = (double)value;
                        NativeControl.DayNameHorizontalSpacing = DayNameHorizontalSpacing;
                    }
                    break;
                case nameof(DayNamesHeightRequest):
                    if (!Equals(DayNamesHeightRequest, value))
                    {
                        DayNamesHeightRequest = (double)value;
                        NativeControl.DayNamesHeightRequest = DayNamesHeightRequest;
                    }
                    break;
                case nameof(DayNameVerticalSpacing):
                    if (!Equals(DayNameVerticalSpacing, value))
                    {
                        DayNameVerticalSpacing = (double)value;
                        NativeControl.DayNameVerticalSpacing = DayNameVerticalSpacing;
                    }
                    break;
                case nameof(Days):
                    if (!Equals(Days, value))
                    {
                        Days = (IEnumerable<ICalendarDay>)value;
                        NativeControl.Days = Days;
                    }
                    break;
                case nameof(DaysOfWeek):
                    if (!Equals(DaysOfWeek, value))
                    {
                        DaysOfWeek = (IList<DayOfWeek>)value;
                        NativeControl.DaysOfWeek = DaysOfWeek;
                    }
                    break;
                case nameof(DaysViewHeightRequest):
                    if (!Equals(DaysViewHeightRequest, value))
                    {
                        DaysViewHeightRequest = (double)value;
                        NativeControl.DaysViewHeightRequest = DaysViewHeightRequest;
                    }
                    break;
                case nameof(NavigatedDate):
                    if (!Equals(NavigatedDate, value))
                    {
                        NavigatedDate = (DateTime)value;
                        NativeControl.NavigatedDate = NavigatedDate;
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

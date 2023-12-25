﻿using Pentagram.Game.Platforms.Windows;

namespace Pentagram.Game
{
    public class CursorBehaviour
    {
        public static readonly BindableProperty CursorProperty = BindableProperty.CreateAttached("Cursor", typeof(CursorIcon), typeof(CursorBehaviour), CursorIcon.Arrow, propertyChanged: CursorChanged);

        private static void CursorChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            if (bindable is VisualElement visualElement)
            {
                visualElement.SetCustomCursor((CursorIcon)newvalue, Application.Current?.MainPage?.Handler?.MauiContext);
            }
        }

        public static CursorIcon GetCursor(BindableObject view) => (CursorIcon)view.GetValue(CursorProperty);

        public static void SetCursor(BindableObject view, CursorIcon value) => view.SetValue(CursorProperty, value);
    }

}

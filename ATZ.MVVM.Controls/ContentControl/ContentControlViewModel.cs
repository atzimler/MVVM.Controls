﻿using System;
using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.ViewModels.Utility;

namespace ATZ.MVVM.Controls.ContentControl
{
    public class ContentControlViewModel : BaseViewModel<ContentControlModel>
    {
        public FrameworkElementViewModel Content { get; set; }

        protected override void BindModel()
        {
        }

        protected override void UnbindModel()
        {
        }

        public override void UpdateValidity(object sender, EventArgs e)
        {
        }
    }
}

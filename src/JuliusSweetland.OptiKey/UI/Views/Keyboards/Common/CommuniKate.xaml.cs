﻿// Copyright (c) 2019 OPTIKEY LTD (UK company number 11854839) - All Rights Reserved
using JuliusSweetland.OptiKey.UI.Controls;

namespace JuliusSweetland.OptiKey.UI.Views.Keyboards.Common
{
    /// <summary>
    /// Interaction logic for CommuniKate.xaml
    /// </summary>
    public partial class CommuniKate : KeyboardView
    {
        public CommuniKate() : base(shiftAware: false)
        {
            InitializeComponent();
        }
    }
}

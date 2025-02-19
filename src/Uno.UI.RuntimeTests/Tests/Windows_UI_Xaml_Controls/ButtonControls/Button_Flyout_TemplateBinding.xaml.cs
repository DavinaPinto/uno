﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Uno.UI.RuntimeTests.Tests.Windows_UI_Xaml_Controls.ButtonControls
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class Button_Flyout_TemplateBinding : UserControl
	{
		public Button_Flyout_TemplateBinding()
		{
			this.InitializeComponent();
		}
	}

	public partial class CustomControl : Control
	{
		public int CustomProperty
		{
			get => (int)GetValue(CustomPropertyProperty);
			set => SetValue(CustomPropertyProperty, value);
		}

		public static readonly DependencyProperty CustomPropertyProperty =
			DependencyProperty.Register("CustomProperty", typeof(int), typeof(CustomControl), new PropertyMetadata(0));
	}
}

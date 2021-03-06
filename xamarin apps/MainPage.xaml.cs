﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace checkerboardApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            const double squareSize = 35;
            AbsoluteLayout absoluteLayout = new AbsoluteLayout
            {
                BackgroundColor = Color.FromRgb(0, 0, 0),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                { //Skip every other squre
                    if (((row ^ col) & 1) == 0)
                        continue;
                    BoxView boxView = new BoxView
                    {
                        Color = Color.FromRgb(255, 0, 0)
                    };

                    Rectangle rect = new Rectangle(col * squareSize,
                        row * squareSize,
                        squareSize,
                        squareSize);
                    absoluteLayout.Children.Add(boxView, rect);
                }
            }
            this.Content = absoluteLayout;
                }
	}
}

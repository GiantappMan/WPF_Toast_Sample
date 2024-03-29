﻿using Windows.UI.Notifications;
using Windows.Data.Xml.Dom;
using System.Windows;
using System;
using Microsoft.Toolkit.Uwp.Notifications;

namespace ToastSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //https://docs.microsoft.com/en-us/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts?tabs=builder-syntax
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new ToastContentBuilder()
       .AddArgument("conversationId", 9813)

       .AddText("Some text")

       .AddButton(new ToastButton()
           .SetContent("Archive")
           .AddArgument("action", "archive")
           .SetBackgroundActivation()).Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new ToastContentBuilder()
.AddArgument("conversationId", 9813)
.AddText("Some text2")
.AddButton(new ToastButton()
.SetContent("Archive")
.AddArgument("action", "archive")
.SetBackgroundActivation())
.AddAudio(new Uri("ms-appx:///Sound.mp3"))
.Show();


       //     new ToastContentBuilder()
       //.AddText("Adaptive Tiles Meeting", hintMaxLines: 1)
       //.AddText("Conf Room 2001 / Building 135")
       //.AddText("10:00 AM - 10:30 AM").Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new ToastContentBuilder()
      .AddText("Adaptive Tiles Meeting", hintMaxLines: 1)
      .AddText("Conf Room 2001 / Building 135")
      .AddText("10:00 AM - 10:30 AM")
          .AddButton(new ToastButton()
        .SetContent("Dismiss")
        .AddArgument("action", "dismiss")
        .SetImageUri(new Uri("https://i.picsum.photos/id/883/360/202.jpg?hmac=BLv2VgQdmO1df4OSlfyjWF7T09_doETTCnP2c8uKghQ", UriKind.RelativeOrAbsolute))
        .SetBackgroundActivation()).Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            // Requires Microsoft.Toolkit.Uwp.Notifications NuGet package version 7.0 or greater
            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("conversationId", 9813)
                .AddText("Andrew sent you a picture")
                .AddText("Check this out, The Enchantments in Washington!")
                .Show(); // Not seeing the Show() method? Make sure you have version 7.0, and if you're using .NET 5, your TFM must be net5.0-windows10.0.17763.0 or greater
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int conversationId = 384928;

            // Construct the content
            new ToastContentBuilder()
                .AddArgument("conversationId", conversationId)

    // Text box for replying
    .AddInputTextBox("tbReply", placeHolderContent: "Type a response")

    // Buttons
    .AddButton(new ToastButton()
        .SetContent("Reply")
        .AddArgument("action", "reply")
        .SetBackgroundActivation())

    .AddButton(new ToastButton()
        .SetContent("Like")
        .AddArgument("action", "like")
        .SetBackgroundActivation())

    .AddButton(new ToastButton()
        .SetContent("View")
        .AddArgument("action", "viewImage")
        //.AddArgument("imageUrl", image.ToString())
        )

    .Show();
        }
    }
}

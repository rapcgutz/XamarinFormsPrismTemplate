﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Prism;
using Prism.Ioc;
using XamarinFormsPrismTemplate.Android.Service;
using XamarinFormsPrismTemplate.Common.Bluetooth;
using XamarinFormsPrismTemplate.Repository;
using XamarinFormsPrismTemplate.Android.Database;

namespace XamarinFormsPrismTemplate.Android
{
    [Activity(Label = "ERNIPrismTemplate", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App(new AndroidInitializer()));
           
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IBluetoothService, BluetoothService>();
            containerRegistry.Register<IDatabaseFactory, DatabaseFactory>();
        }
    }
}


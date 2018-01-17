﻿using System;
using Neutronium.SPA.ViewModel;

namespace Neutronium.SPA 
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private ApplicationViewModelBuilder _ApplicationViewModelBuilder;

        public bool Debug => App.MainApplication.Debug;
        public Uri Uri => App.MainApplication.Uri;

        public MainWindow()
        {
            this.Initialized += MainWindow_Initialized;
            InitializeComponent();
        }

        private void MainWindow_Initialized(object sender, EventArgs e)
        {
            DataContext = BuildApplicationViewModel();
            Initialized -= MainWindow_Initialized;
        }

        private ApplicationViewModel BuildApplicationViewModel()
        {
            _ApplicationViewModelBuilder = new ApplicationViewModelBuilder(this);
            return _ApplicationViewModelBuilder.ApplicationViewModel;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.HtmlView.Dispose();
        }
    }
}

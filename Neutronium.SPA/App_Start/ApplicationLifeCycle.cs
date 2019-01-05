﻿using System.ComponentModel;
using Vm.Tools.Application.LifeCycleHook;
using Vm.Tools.Application.Navigation;
using Vm.Tools.Application.WindowServices;
using Vm.Tools.Standard;

namespace Neutronium.SPA
{
    public class ApplicationLifeCycle: IApplicationLifeCycle
    {
        private readonly IMessageBox _MessageBox;
        private readonly IApplication _Application;

        public ApplicationLifeCycle(IMessageBox messageBox, IApplication application)
        {
            _MessageBox = messageBox;
            _Application = application;
        }

        public void OnNavigating(RoutingEventArgs routingEvent)
        {
        }

        public void OnNavigated(RoutedEventArgs routedEvent)
        {
        }

        public async void OnClosing(CancelEventArgs cancelEvent)
        {
            cancelEvent.Cancel = true;
            var confirmationMessage = new ConfirmationMessage(Resource.ConfirmationNeeded, Resource.DoYouWantToCloseApplication, Resource.Ok, Resource.Cancel);
            var close = await _MessageBox.ShowMessage(confirmationMessage);
            if (close)
                _Application.ForceClose();
        }

        public void OnSessionEnding(CancelEventArgs cancelEvent)
        {
        }

        public void OnClosed()
        {
        }
    }
}

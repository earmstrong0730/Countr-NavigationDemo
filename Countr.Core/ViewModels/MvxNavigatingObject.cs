using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Android.Content;
using Countr.Core.Models;
using Countr.Core.ViewModels;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

//the  view model for MvxNavigatingObjectView
namespace Countr.Core.ViewModels
{

    public class MvxNavigatingObject : MvxViewModel
    {
        readonly IMvxNavigationService _navigationService;

        public MvxNavigatingObject( IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            ShowMainMenuCommand = new MvxAsyncCommand(ShowMainMenuClicked);
            CancelCommand = new MvxAsyncCommand(Cancel);
        }

        public IMvxAsyncCommand ShowMainMenuCommand { get; }

   
        async Task ShowMainMenuClicked()
        {
            await _navigationService.Navigate(typeof(CountersViewModel));
        }

        //----using a custom presenter and fragments to navigate the back stack. Not fully developed and seems to be a second choice to LaunchMode=SingleTask
        //public override void Show(MvxViewModelRequest request)
        //{
        //    if (vmRequest.PresentationValues != null)
        //    {
        //        if (request.PresentationValues.ContainsKey("NavigationMode") && request.PresentationValues["NavigationMode"] == "BackOrInPlace")
        //        {
        //            var hasFragmentTypeInStack =
        //                Enumerable.Range(0, _fragmentManager.BackStackEntryCount - 1)
        //                          .Reverse()
        //                          .Any(index => _fragmentManager.GetBackStackEntryAt(index).Name == fragmentType.Name);

        //            if (hasFragmentTypeInStack)
        //            {
        //                while (CurrentFragment.GetType() != fragmentType)
        //                    _fragmentManager.PopBackStackImmediate();

        //                return;
        //            }

        //            _fragmentManager.PopBackStackImmediate();
        //        }
        //    }

            
        //}

        public IMvxAsyncCommand CancelCommand { get; }

        async Task Cancel()
        {
            await _navigationService.Close(this);
        }
    }


}

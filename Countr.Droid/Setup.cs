using Android.Content;
using Countr.Droid.Views;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Views;
using MvvmCross.Platform.Platform;
using MvvmCross.Platform.Plugins;
using static Countr.Core.ViewModels.MvxNavigatingObject;

namespace Countr.Droid
{
    public class Setup : MvxAppCompatSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

//--------------------------backstack handling stuff ------------------------------------------
        //BackStackHintHandler _backStackHandler;

        ///// <summary>
        ///// Creates the view presenter.
        ///// </summary>
        ///// <returns>The view presenter.</returns>
        //protected override IMvxAndroidViewPresenter CreateViewPresenter()
        //{
        //    var presenter = base.CreateViewPresenter();

        //    _backStackHandler = new BackStackHintHandler(ApplicationContext, typeof(MvxNavigatingObjectView));
        //    presenter.AddPresentationHintHandler<ClearBackstackHint>(_backStackHandler.HandleClearBackstackHint);

        //    return presenter;
        //}
        //protected override IMvxAndroidViewPresenter CreateViewPresenter()
        //{
        //    var presenter = new MyAppAndroidPresenter(AndroidViewAssemblies);
        //    Mvx.IoCProvider.RegisterSingleton<IMvxAndroidViewPresenter>(presenter);

        //    return presenter;
        //}
    }
}

using System;
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


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace StoryHub
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
        }

        private void BtnLogin_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            var loginResult = BLL.RoleKeeper.Login(TbLogin.Text, TbPsw.Password);
            if(loginResult.Item1)
            Frame.Navigate(typeof(Wall));
        }

        private void BtnRegister_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        private void BtnLostPsw_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }


    }
}

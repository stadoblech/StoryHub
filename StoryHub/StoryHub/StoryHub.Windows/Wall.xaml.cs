using StoryHub.DAL.Model;
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
    public sealed partial class Wall : Page
    {
        public Wall()
        {
            this.InitializeComponent();
            ShowStorylines();               //init visibilities

            GetTestDataContext();
        }

        private void GetTestDataContext()
        {
            DataContext = SampleDataCreator.TestUser1_Cendric;
        }

        

        #region SERVICE METHODS

        /// <summary>
        /// This method will show only StorylinesPanel.
        /// </summary>
        private void ShowStorylines() 
        {
            //StorylinesListBox.ItemsSource = BLL.RoleKeeper.LoggedUser.Storylines;
            StorylinesListBox.DataContext = BLL.RoleKeeper.LoggedUser;
            StorylinesListBox.SelectedIndex = -1;

            StorylinesGrid.Visibility = Visibility.Visible;
            StorylineGrid.Visibility = Visibility.Collapsed;
            StoryGrid.Visibility = Visibility.Collapsed;
            StoriesGrid.Visibility = Visibility.Collapsed;
            WallGrid.Visibility = Visibility.Collapsed;
        }
        /// <summary>
        /// This method will show detail of selected storyline.
        /// </summary>
        private void ShowStoryline(Storyline storyline) 
        {
            if (storyline != null)
            {
                StoriesListBox.DataContext = storyline.Stories;
                StorylineGrid.DataContext = storyline;
            }
            
            

            StorylinesGrid.Visibility = Visibility.Collapsed;
            StorylineGrid.Visibility = Visibility.Visible;
            StoryGrid.Visibility = Visibility.Collapsed;
            StoriesGrid.Visibility = Visibility.Visible;
            WallGrid.Visibility = Visibility.Collapsed;
        }
        private void ShowStory(Story story) 
        {
            StoryGrid.DataContext = story;

            StorylinesGrid.Visibility = Visibility.Collapsed;
            StorylineGrid.Visibility = Visibility.Collapsed;
            StoryGrid.Visibility = Visibility.Visible;
            StoriesGrid.Visibility = Visibility.Collapsed;
            WallGrid.Visibility = Visibility.Visible;
        }
        #endregion 


        private void BtnBack_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            ShowStorylines();
            
        }

        private void StorylinesListBox_SelectionChanged(object sender, Windows.UI.Xaml.Controls.SelectionChangedEventArgs e)
        {
            ShowStoryline(StorylinesListBox.SelectedItem as Storyline);
        }

        private void StoriesListBox_SelectionChanged(object sender, Windows.UI.Xaml.Controls.SelectionChangedEventArgs e)
        {
            ShowStory(StoriesListBox.SelectedItem as Story);
        }

        private void AppBarButton_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            ShowStorylines();
        }

        private void AppBarButton_Tapped_1(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            ShowStoryline(StorylineGrid.DataContext as Storyline);
        }
    }
}

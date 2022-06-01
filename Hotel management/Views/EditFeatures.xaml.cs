using Hotel_management.Models.Business_Logic_Layer;
using Hotel_management.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hotel_management.Views
{
    /// <summary>
    /// Interaction logic for EditFeaturesView.xaml
    /// </summary>
    public partial class EditFeaturesView : Window
    {
        public EditFeaturesView(long id_room)
        {
            InitializeComponent();
            DataContext = new EditFeaturesVM(id_room);
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            FeatureBLL featureBLL = new FeatureBLL();
            var dc = DataContext as EditFeaturesVM;

            Feature feature = new Feature()
            {
                room_id = dc.room_id,
                name = dc.SelectedFeature.name,
                price = dc.SelectedFeature.price,
            };
            dc.Features.Add(feature);
            featureBLL.AddFeature(feature);
        }

        private void Modify(object sender, RoutedEventArgs e)
        {
            FeatureBLL featureBLL = new FeatureBLL();
            var dc = DataContext as EditFeaturesVM;
            var newFeature = new Feature();
            newFeature = dc.SelectedFeature;
            var user = dc.Features.First(x => x.id == newFeature.id);
            dc.Features[dc.Features.IndexOf(user)] = newFeature;
            featureBLL.ModifyFeature(newFeature);
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            FeatureBLL userBLL = new FeatureBLL();
            var dc = DataContext as EditFeaturesVM;
            var newFeature = new Feature();
            newFeature = dc.SelectedFeature;
            var user = dc.Features.First(x => x.id == newFeature.id);
            dc.Features.Remove(user);
            userBLL.DeleteFeature(newFeature.id);
        }
    }
}
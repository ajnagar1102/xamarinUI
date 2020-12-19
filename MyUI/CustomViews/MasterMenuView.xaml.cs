using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyUI.CustomViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterMenuView : Frame
    {

        public MasterMenuView()
        {
            InitializeComponent();
        }

        public void OpenClose()
        {
            lblApp.IsVisible = lblFacility.IsVisible
                             = lblHome.IsVisible
                             = lblSchool.IsVisible
                             = lblSetting.IsVisible = (!lblApp.IsVisible);

            suggetionLbl.Text = lblApp.IsVisible ? "<_Collapse Menu" : "Expand Menu_>";
        }

        private void ExpandCollpase_click(object sender, EventArgs e)
        {
            OpenClose();
        }

        private void Right_Swiped(object sender, SwipedEventArgs e)
        {
            lblApp.IsVisible = lblFacility.IsVisible
                             = lblHome.IsVisible
                             = lblSchool.IsVisible
                             = lblSetting.IsVisible = true;
            suggetionLbl.Text = "Collapse Menu";
        }

        private void Left_Swiped(object sender, SwipedEventArgs e)
        {
            if (this.IsVisible)
            {
                lblApp.IsVisible = lblFacility.IsVisible
                                 = lblHome.IsVisible
                                 = lblSchool.IsVisible
                                 = lblSetting.IsVisible = false;
                suggetionLbl.Text = "Expand Menu";
            }
            else
            {
                this.IsVisible = false;
            }
        }
    }
}
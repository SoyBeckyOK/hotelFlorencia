using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace hotelFlorencia.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuTabbedPagePrincipal : Xamarin.Forms.TabbedPage
	{
		public MenuTabbedPagePrincipal()
		{
			InitializeComponent ();
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
        }
	}
}
using MenuSemaine.Entity;
using MenuSemaine.Manager;
using MenuSemaine.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MenuSemaine
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            List<Plat> listPlats = PlatManager.GetFivePlats();
            this.rptPlatsSemaine.DataSource = listPlats;
            this.rptPlatsSemaine.DataBind();
        }

        protected void rptPlatsSemaine_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                Plat currentPlat = e.Item.DataItem as Plat;
                int indexOfItem = e.Item.ItemIndex + 1;

                Literal litDayOfWeek = (Literal)e.Item.FindControl("litDayOfWeek");
                Literal litTypePlat = (Literal)e.Item.FindControl("litTypePlat");
                Literal litPlatName = (Literal)e.Item.FindControl("litPlatName");

                litDayOfWeek.Text = Constants.Constants.Weeks[indexOfItem];
                litTypePlat.Text = string.Format(" ({0}) ", currentPlat.Type);
                litPlatName.Text = currentPlat.Name;


            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Donate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userKey"] == null)
            Response.Redirect("Default.aspx");
    }

    protected void DonateButton_Click(object sender, EventArgs e)
    {

        Community_AssistEntities db = new Community_AssistEntities();

        int key = (int)Session["userKey"];

        Donation d = new Donation();

        d.DonationAmount = decimal.Parse(DonateTextBox.Text);
        d.DonationDate = DateTime.Now;
        d.PersonKey = key;
        db.Donations.Add(d);
        db.SaveChanges();

        Response.Redirect("Donations.aspx");

    }
}
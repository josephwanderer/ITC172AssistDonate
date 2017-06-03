using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RegisterButton_Click(object sender, EventArgs e)
    {
        string first = FirstNameTextBox.Text;
        string last = LastNameTextBox.Text;
        string email = EmailTextBox.Text;
        string pass = ConfirmPasswordTextBox.Text;
        string street = StreetTextBox.Text;
        string apt = ApartmentNumberTextBox.Text;
        string city = CityTextBox.Text;
        string state = StateTextBox.Text;
        string zip = ZipCodeTextBox.Text;
        string homePhone = HomePhoneTextBox.Text;
        string workPhone = WorkPhoneTextBox.Text;
        Community_AssistEntities db = new Community_AssistEntities();

        int success = db.usp_Register(last, first, email, pass, apt, street, city, state, zip, homePhone, workPhone);

        if (success != -1)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
           ResultLabel.Text = "Something went terribly wrong";
        }

    }
}
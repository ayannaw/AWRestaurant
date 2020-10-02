using AWRestaurant.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWRestaurant
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        Customers customer;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string name = txtFirstName.Text + " " + txtLastName.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string birthday = txtBirthday.Text;
            string password = txtPassword.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string state = ddlState.SelectedValue;
            string zipCode = txtZipcode.Text;

            customer = new Customers(name, email, phoneNumber, birthday, password, address, city, state, zipCode);
            Session["Email"] = email;
            Session["Name"] = name;
            Response.Redirect("");
        }
    }
}
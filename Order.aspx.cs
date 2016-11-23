using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Judah : System.Web.UI.Page
{
    bool PICKUP = false,
         DELIVERY = true;

    Order myOrder = new Order();

    public class Order
    {
        private String fName;
        public String FName
        {
            get
            {
                return this.fName;
            }
            set
            {
                this.fName = value;
            }
        }

        private String lName;
        public String LName
        {
            get
            {
                return this.lName;
            }
            set
            {
                this.lName = value;
            }
        }

        private bool order_type;
        public bool Order_type
        {
            get
            {
                return this.order_type;
            }
            set
            {
                this.order_type = value;
            }
        }

        private String receive_order_time;
        public String Receive_order_time
        {
            get
            {
                return this.receive_order_time;
            }
            set
            {
                this.receive_order_time = value;
            }
        }
    }
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    public void S_Clicked(object sender, EventArgs e)
    {
        // Assign customer first and last name to the order
        myOrder.FName = inpFName.Text;
        myOrder.LName = inpLName.Text;

        // Determine method of receiving order
        if (inpPickup.Checked == true)
        {
            myOrder.Order_type = PICKUP;
        }
        else if (inpDelivery.Checked == true)
        {
            myOrder.Order_type = DELIVERY;
        }

        // Assign a time for the order
        myOrder.Receive_order_time = inpHour.SelectedValue + ":" + 
                                     inpMinute.SelectedValue + " " + 
                                     inpMeridian.SelectedValue;

        // Display information about the order
        displayResults(myOrder);
    }

    void displayResults(Order myOrder)
    {
        results.Text += "Customer Name: " + myOrder.LName + ", " 
                      + myOrder.FName;

        results.Text += "\nMethod of receiving order: ";
        if (myOrder.Order_type == PICKUP)
            results.Text += "Pickup ";
        else if (myOrder.Order_type == DELIVERY)
            results.Text += "Delivery ";
        else
            results.Text += "Not Specified";

        results.Text += "\nDeliveryTime: " + myOrder.Receive_order_time;
    }
}
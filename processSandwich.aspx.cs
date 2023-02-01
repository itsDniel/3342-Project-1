using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project1
{
    public partial class processSandwich : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            String name = Request["txtFullName"];
            String phone = Request["txtPhone"];
            String size = Request["ddlSize"];
            String toast = Request["toastOption"];
            String sauce = Request["ddlSauce"];
            String filling = Request["filling"];
            String xtra = Request["xtra"];
            String meal = Request["mOption"];
            
                lblSummary.Text = "Name: " + name + "<br>" + "Phone number: " + phone + "<br>" +
                    "Sandwich's size: " + size + " ($" + sizeOption() + " )" + "<br>" + "Toast option: " + toast + "<br>" +
                    "Sauce option: " + sauce + "<br>" + "Filling option: " + filling + " ($" + Calculation.totalFilling(fillingOption()) + ")" + "<br>" +
                    "Extra option:  " + xtra + " ($" + Calculation.totalExtra(extraOption()) + ")" + "<br>" + "Meal option: " + meal +
                    " ($" + Calculation.totalMeal(mealOption()) + ")" + "<br>" + "Tip: $" + tipMoney() + "<br>";

                Double total = Calculation.total(sizeOption(), fillingOption(), extraOption(), mealOption(), tipMoney());
                lblPrice.Text = "Your total price is: $" + total.ToString() + "<br>" + "Thank you for shopping with us, have a nice day!";
            
        }

        public int sizeOption()
        {
            String size = Request["ddlSize"];
            int price;
           if(size == "Small")
            {
                price = 5;
            }else if(size == "Medium")
            {
                price = 6;
            }else if(size == "Large")
            {
                price = 7;
            }
            else
            {
                price = 8;
            }

            return price;
            
        }

        public int fillingOption()
        {
            String filling = Request["filling"];
            if (filling != null)
            {
                String[] fillingList = filling.Split(',');

                int count = int.Parse(fillingList.Length.ToString());
                return count;
            }
            else
            {
                return 0;
            }
        }

        public int extraOption()
        {
            String extra = Request["xtra"];
            if (extra != null)
            {
                String[] extraArray = extra.Split(',');
                int count = int.Parse(extraArray.Length.ToString());
                return count;
            }
            else
            {
                return 0;
            }
        }

        public int mealOption()
        {
            String meal = Request["mOption"];
            if (meal != null)
            {
                String[] mealArray = meal.Split(',');
                int count = int.Parse(mealArray.Length.ToString());
                return count;
            }
            else
            {
                return 0;
            }
        }

        public double tipMoney()
            {
                Double tipAmount = 0;
                String tip = Request["numTip"];
                if(!String.IsNullOrEmpty(tip))
                {
                    tipAmount += Double.Parse(tip);
                    return tipAmount;
                }
                else
                {
                    return tipAmount;
                }

            }
        }

        
    }

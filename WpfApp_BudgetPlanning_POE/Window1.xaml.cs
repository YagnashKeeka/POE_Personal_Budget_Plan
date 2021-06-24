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

abstract class Expense
{   //Expense is declared as an Abstract Class. Classes are created that will inherit from the abstract class Expense through the Expenditure class
    public abstract double TaxDeduction { get; set; }
    public abstract double GroceryCost { get; set; }
    public abstract double LightsWater { get; set; }
    public abstract double TravelCost { get; set; }
    public abstract double Telephone { get; set; }
    public abstract double ExtraExpense { get; set; }
    public abstract double Rent { get; set; }
    public abstract double PropertyPrice { get; set; }
    public abstract double TotalDeposit { get; set; }
    public abstract double Interestrate { get; set; }
    public abstract double NumberOfMonths { get; set; }
    public abstract double VehiclePurchasePrice { get; set; }
    public abstract double VehicleTotalDeposit { get; set; }
    public abstract double VehhicleInterestRate { get; set; }
    public abstract double VehicleInsurancePremium { get; set; }
    public abstract double HomeLoan();
    public abstract double VehicleCalculation();
}   //get and set declared in each class

//Get and set methods created in the classes. 
//Set method is used to set the value that is entered by the user.
//Get method is used to get the value that was set by the user and return that value

class Expenditure : Expense
{ //Expenditure class created. Inherits from abstract class Expense
  //Double variables created to hold input annd output values
    double tax, costGrocery, waterLights, travel, phone, extra, monthlyRent, purchasePrice, deposit, rate, months, vehiclePrice, vehicleDeposit, vehicleInterest, vehicleInsurance = 0;

    //Classes are created and implements override properties.
    //These classes inherit from the abstract class Expense

    public override double TaxDeduction
    {
        get { return tax; }
        set { tax = value; }
    }

    public override double GroceryCost
    {
        get { return costGrocery; }
        set { costGrocery = value; }
    }

    public override double LightsWater
    {
        get { return waterLights; }
        set { waterLights = value; }
    }

    public override double TravelCost
    {
        get { return travel; }
        set { travel = value; }
    }

    public override double Telephone
    {
        get { return phone; }
        set { phone = value; }
    }

    public override double ExtraExpense
    {
        get { return extra; }
        set { extra = value; }
    }

    public override double Rent
    {
        get { return monthlyRent; }
        set { monthlyRent = value; }
    }

    //Value is added for calculation in HomeLoan() Method
    public override double PropertyPrice
    {
        get { return purchasePrice; }
        set { purchasePrice = value; }
    }

    //Value is added for calculation in HomeLoan() Method
    public override double TotalDeposit
    {
        get { return deposit; }
        set { deposit = value; }
    }

    //Value is added for calculation in HomeLoan() Method
    public override double Interestrate
    {
        get { return rate; }
        set { rate = value; }
    }

    //Value is added for calculation in HomeLoan() Method
    public override double NumberOfMonths
    {
        get { return months; }
        set { months = value; }
    }
    //Value is used for calculation in VehicleCalculation() Method
    public override double VehiclePurchasePrice
    {
        get { return vehiclePrice; }
        set { vehiclePrice = value; }
    }
    //Value is used for calculation in VehicleCalculation() Method
    public override double VehicleTotalDeposit
    {
        get { return vehicleDeposit; }
        set { vehicleDeposit = value; }
    }
    //Value is used for calculation in VehicleCalculation() Method
    public override double VehhicleInterestRate
    {
        get { return vehicleInterest; }
        set { vehicleInterest = value; }
    }
    //Value is used for calculation in VehicleCalculation() Method
    public override double VehicleInsurancePremium
    {
        get { return vehicleInsurance; }
        set { vehicleInsurance = value; }
    }

    public override double HomeLoan()
    {//Method class HomeLoan created. To calculate the monthly repayments on the home loan
     //Variables created to hold calculation values
        double monthlyRepayment, loanAmount1, loanAmount2;

        //Calculates the principal loan amount
        loanAmount1 = purchasePrice - deposit;

        //Simple interest formula: A = P(1 + in). Calculates the accumulated loan amount
        loanAmount2 = loanAmount1 * (1 + (rate * (1 / 100)) * (months / 12));

        //Calculates the monthly repayment amount
        return monthlyRepayment = loanAmount2 / months;
    }

    public override double VehicleCalculation()
    {//Method class VehicleCalculation created. To calculate the monthly repayments on the vehicle
        double monthlyRepayment, principleAmount, loanAmount;

        //Calculates the principal loan amount
        principleAmount = VehiclePurchasePrice - vehicleDeposit;

        //Simple interest formula: /A = P(1 + in)
        //Years has been assumed as 5 years (5 years = 60 months)
        loanAmount = principleAmount * (1 + (vehicleInterest * (1 / 100)) * (5));

        //Calculates the monthly repayment amount. Accumulated amount (loanAmount) divided by the number of months
        return monthlyRepayment = (loanAmount / 60) + vehicleInsurance;
    }

}


namespace WpfApp_BudgetPlanning_POE
{   //Delegate Declared
    public delegate string ExpenseExceedAlert(string alert);
    
    public partial class Window1 : Window
    {   //Abstract class instantiated
        Expenditure costExpense = new Expenditure();

        public Window1()
        {
            InitializeComponent();
    }
        /*try{} and catch(){} block used to catch incorrect input errors 
        *double.Parse() is used to convert a string value to a string value to a double value
        *Expense values of a textbox are declared through the abstract classes
        */
        private void txtGross_TextChanged(object sender, TextChangedEventArgs e)
        {//Gross income
            try
            {
                double.Parse(txtGross.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("An incorrect input. " + error.Message);
            }
        }

        private void txtTax_TextChanged(object sender, TextChangedEventArgs e)
        {//Tax
            try
            {
                costExpense.TaxDeduction = double.Parse(txtTax.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("An incorrect input. " + error.Message);
            }
        }

        private void txtGroceryCost_TextChanged(object sender, TextChangedEventArgs e)
        {//Grocery Cost
            try
            {
                costExpense.GroceryCost = double.Parse(txtGroceryCost.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("An incorrect input. " + error.Message);
            }
        }

        private void txtWaterLights_TextChanged(object sender, TextChangedEventArgs e)
        {//Water and lights
            try
            {
                costExpense.LightsWater = double.Parse(txtWaterLights.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("An incorrect input. " + error.Message);
            }
        }

        private void txtTravelCost_TextChanged(object sender, TextChangedEventArgs e)
        {//Travel Cost
            try
            {
                costExpense.TravelCost = double.Parse(txtTravelCost.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("An incorrect input. " + error.Message);
            }
        }

        private void txtPhone_TextChanged(object sender, TextChangedEventArgs e)
        {//Cellphone and Telephone
            try
            {
                costExpense.Telephone = double.Parse(txtPhone.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("An incorrect input. " + error.Message);
            }
        }

        private void txtExtra_TextChanged(object sender, TextChangedEventArgs e)
        {//Extra Expense
            try
            {
                costExpense.ExtraExpense = double.Parse(txtExtra.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("An incorrect input. " + error.Message);
            }
        }

        private void txtRentProperty_TextChanged(object sender, TextChangedEventArgs e)
        {//Rent property
            try
            {
                costExpense.Rent = double.Parse(txtRentProperty.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("An incorrect input. " + error.Message);
            }
        }
        //If statement have been used if the the rent or property button is selected
        private void radBtnRent_Checked(object sender, RoutedEventArgs e)
        {//Rent button
            if (radBtnRent.IsChecked == true)
            {   //Set visibility to visible to view the labels and textboxes of rent
                this.lblRentAProperty.Visibility = System.Windows.Visibility.Visible;
                this.txtRentProperty.Visibility = System.Windows.Visibility.Visible;

                //Set visibility to hidden to hide the labels and textboxes of purchasing a property
                this.lblPurchasePrice.Visibility = System.Windows.Visibility.Hidden;
                this.lblTotalDeposit.Visibility = System.Windows.Visibility.Hidden;
                this.lblInterestRate.Visibility = System.Windows.Visibility.Hidden;
                this.lblNoOfMonths.Visibility = System.Windows.Visibility.Hidden;
                this.txtPurProp.Visibility = System.Windows.Visibility.Hidden;
                this.txtTotalDeposit.Visibility = System.Windows.Visibility.Hidden;
                this.txtInterest.Visibility = System.Windows.Visibility.Hidden;
                this.txtMonths.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void radbtnPurchase_Checked(object sender, RoutedEventArgs e)
        {//Purchase peoperty button
            if (radbtnPurchase.IsChecked == true)
            {   //Set visibility to visible to view the labels and textboxes of purchasing a property
                this.lblPurchasePrice.Visibility = System.Windows.Visibility.Visible;
                this.lblTotalDeposit.Visibility = System.Windows.Visibility.Visible;
                this.lblInterestRate.Visibility = System.Windows.Visibility.Visible;
                this.lblNoOfMonths.Visibility = System.Windows.Visibility.Visible;
                this.txtPurProp.Visibility = System.Windows.Visibility.Visible;
                this.txtTotalDeposit.Visibility = System.Windows.Visibility.Visible;
                this.txtInterest.Visibility = System.Windows.Visibility.Visible;
                this.txtMonths.Visibility = System.Windows.Visibility.Visible;

                //Set visibility to hidden to hide the labels and textboxes of rent
                this.lblRentAProperty.Visibility = System.Windows.Visibility.Hidden;
                this.txtRentProperty.Visibility = System.Windows.Visibility.Hidden;
            }
        }
        //purchase price, total deposit, interest, and months part of homeloan calculation
        private void txtPurProp_TextChanged(object sender, TextChangedEventArgs e)
        {//Purchase property
            try
            {
                costExpense.PropertyPrice = double.Parse(txtPurProp.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("An incorrect input. " + error.Message);
            }
        }
        
        private void txtTotalDeposit_TextChanged(object sender, TextChangedEventArgs e)
        {//Total deposit
            try
            {
                costExpense.TotalDeposit = double.Parse(txtTotalDeposit.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("An incorrect input. " + error.Message);
            }
        }

        private void txtInterest_TextChanged(object sender, TextChangedEventArgs e)
        {//Interest
            try
            {
                costExpense.Interestrate = double.Parse(txtInterest.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("An incorrect input. " + error.Message);
            }
        }

        private void txtMonths_TextChanged(object sender, TextChangedEventArgs e)
        {//Months
            try
            {
                costExpense.NumberOfMonths = double.Parse(txtMonths.Text);
                if (double.Parse(txtMonths.Text) < 240 || double.Parse(txtMonths.Text) > 360)
                {
                    MessageBox.Show("Number of months has either exceeded 360 months or it is less than 240 months. Number of months should be stated within the range of 240 - 360 months");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("An incorrect input. " + error.Message);
            }
        }

        private void txtModel_TextChanged(object sender, TextChangedEventArgs e)
        {//Vehicle model and make
            string model;
            try
            {
                model = txtModel.Text;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Vehicle price, deposit, interest, insurance part of vehicle calculation
        private void txtVehiclePrice_TextChanged(object sender, TextChangedEventArgs e)
        {//Vehicle price
            try
            {
                costExpense.VehiclePurchasePrice = double.Parse(txtVehiclePrice.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("An incorrect input. " + error.Message);
            }
        }

        private void txtVehicleDeposit_TextChanged(object sender, TextChangedEventArgs e)
        {//Vehicle deposit
            try
            {
                costExpense.VehicleTotalDeposit = double.Parse(txtVehicleDeposit.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("An incorrect input. " + error.Message);
            }
        }

        private void txtVehicleInterest_TextChanged(object sender, TextChangedEventArgs e)
        {//Vehicle interest
            try
            {
                costExpense.VehhicleInterestRate = double.Parse(txtVehicleInterest.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("An incorrect input. " + error.Message);
            }
        }

        private void txtVehicleInsurance_TextChanged(object sender, TextChangedEventArgs e)
        {//Vehicle insurance
            try
            {
                costExpense.VehicleInsurancePremium = double.Parse(txtVehicleInsurance.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("An incorrect input. " + error.Message);
            }
        }

        //Savings amount, years, and interest part of savings calculation
        private void txtSavingsAmount_TextChanged(object sender, TextChangedEventArgs e)
        {//Savings amount
            try
            {
                double.Parse(txtSavingsAmount.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("An incorrect input. " + error.Message);
            }
        }

        private void txtSavingsYears_TextChanged(object sender, TextChangedEventArgs e)
        {//Savings years
            try
            {
                double.Parse(txtSavingsYears.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("An incorrect input. " + error.Message);
            }
        }
        
        private void txtSavingsInterest_TextChanged(object sender, TextChangedEventArgs e)
        {//Savings interest
            try
            {
                double.Parse(txtSavingsInterest.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("An incorrect input. " + error.Message);
            }
        }

        //Delegate class created
        public string ExpenseAlert1(String errMessage)
            {
            return errMessage.ToString();//returns message
            }
        
        private void butValidate_Click(object sender, RoutedEventArgs e)
        {   //TO validate whether the expenses are more than 75% of the income
            double sumDeductions = costExpense.TaxDeduction + costExpense.GroceryCost + costExpense.LightsWater + costExpense.TravelCost + costExpense.Telephone + 
                                   costExpense.ExtraExpense +costExpense.Rent + costExpense.VehicleCalculation() + costExpense.HomeLoan();
            double percentOfIncome = 0.75 * double.Parse(txtGross.Text);
            double remaining = double.Parse(txtGross.Text) - sumDeductions;
            
            if (sumDeductions > percentOfIncome)
            {
                ExpenseExceedAlert alert = new ExpenseExceedAlert(ExpenseAlert1);//Delegate class declared
                string message = null; // Get your alter in here
                //delegate passed to a message
                message = alert("Your expenses has exceeded your income. If you have puchased a vehicle or a property, you do not qualify for a loan.\nYou may try again to budget your expenses. Thank you.");
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("The remaining income after all expenses deducted ->\nR" + Math.Round(remaining, 2));
            }
        }

        private void butList_Click(object sender, RoutedEventArgs e)
        {   //Display a list  of expenses
            //Generic Collections. List<T>
            List<string> listExpenses = new List<string>();
            //Math.Round() used for vehicle and home loan calculation if there are decimals
            //Adding values to the list
            listExpenses.Add(costExpense.TaxDeduction.ToString() + " -> Tax");
            listExpenses.Add(costExpense.GroceryCost.ToString() + " -> Grocery");
            listExpenses.Add(costExpense.LightsWater.ToString() + " -> Lights and Water");
            listExpenses.Add(costExpense.TravelCost.ToString() + " -> Travel Cost");
            listExpenses.Add(costExpense.Telephone.ToString() + " -> Cellphone and Telephone");
            listExpenses.Add(costExpense.ExtraExpense.ToString() + " -> Extra Expense");
            listExpenses.Add(Math.Round(costExpense.HomeLoan(), 2).ToString() + " -> Home Loan");
            listExpenses.Add(costExpense.Rent.ToString() + " -> Rent");
            listExpenses.Add(Math.Round(costExpense.VehicleCalculation(), 2).ToString() + " -> Vehicle: " + txtModel.Text);
            //Sorts and Reverses the list of values displayed
            listExpenses.Sort();
            listExpenses.Reverse();
            string str = null;
            foreach (string num in listExpenses)
            {   //Shows the expense values listed by the user in decending order
                str += num + "\n\n";
            }
            MessageBox.Show(str);//Display the string
        }

        private void butExit_Click(object sender, RoutedEventArgs e)
        {//Exit button used to exit or continue using the application
            MessageBoxResult result = MessageBox.Show("Would you like to Exit the Application?", "Confirmation", MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes)
            {
                Environment.Exit(0);//Exits the application
            }
        }

        private void butEstimate_Click(object sender, RoutedEventArgs e)
        {//Calculates the monthly savings amount
            //Variables created to hold textbox values
            double amount = double.Parse(txtSavingsAmount.Text);
            double rate = double.Parse(txtSavingsInterest.Text) / 100;//Interest (1% / 100 = 0.01)
            double year = double.Parse(txtSavingsYears.Text);
            double months = 12 * year;
            //Compund Interest formula used
            //Math.Pow(x, y) used as it represents a base(x) and an exponent(y)
            double calc = amount / ((Math.Pow((1 + (rate / 12)), (12 * year)) - 1) / (rate / 12));
            MessageBox.Show(" In order to achieve an accumulated amount of R" + amount + ", with an interest rate of " + txtSavingsInterest.Text + 
                            "% that is compounded monthly. The monthly investment required is R" + Math.Round(calc, 2) + ".");
        }
    }
    }


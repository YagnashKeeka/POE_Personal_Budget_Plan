----------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------
Project Name: Budeget Planning
Program Name: BudgetPlanning_POE_Task2
----------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------------
* Readme file for program Budget Planning version 3.0
*
* Refer to the System and Software requirements that support the Budget planning program
----------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------------
* Contents of the document
----------------------------------------------------------------------------------------------------------
This document contains the following categories:
1. General Description
2. Brief Description (Lecturers Feedback)
3. System and Software requirements
4. Compile The Program
5. Bugs
6. Contact Information
7. Github link
----------------------------------------------------------------------------------------------------------
* 1. GENERAL DESCRIPTION
----------------------------------------------------------------------------------------------------------
The budget planning application is now presented throught an interface. The user would have the
ability to plan their budget. Their Salary and monthly expenses would be inputted by the user.
The user can choose whether they are renting a property or would like to buy a property. They
can also choose to enter values into details of the vehicle they would like to purchase, or may
leave it blank. The user would have an option to choose whether they would like to save a specific
amount for a specific period with the interest rate that stated. There are three buttons availible
for the user. First one is Validate Expense. The user can choose this to understand if they have 
budgeted their expense correctly. The second button is List of expenses, where user cann choose to 
view all of their expenses made. The third buttonne is estimated savings value, where the user can
determine how money they would need to save each month to save up for a specific goal.
----------------------------------------------------------------------------------------------------------
* 2. BRIEF DESCRIPTION (LECTURERS FEEDBACK)
The main thing that I changed was the list, where I changed it to show that the the list of 
expenses would display each amount as well as for the name of the expense made. For example,
it would display; 750 -> Tax . The way the delegate was called had to be changed as it was not 
receiving any response. What has been done? Created a delegate that is declared as a string, then,
created a method to return an error message. In a button, a string variabe has been created which 
equals to null. Through the instantiation of the delegate, the message was called through the variable
that was created 
----------------------------------------------------------------------------------------------------------
* 3. SYSTEM AND SOFTWARE REQUIREMENTS
The operatiing system that may be used, is the following:
	*Windows
	*macOS
	*Linux

The required Windows operating system would be Windows 7, 8 or 10.
It is preferable to use Windows 10 to run your program.
*
*
A software installation of Visual Studio is required to run the application.
You are required(*) to install any of the following software. Following software:
	*Visual Studio 2019 Community (Free to use)
	*Visual Studio 2019 Professional
	*Visual Studio 2019 Enterprise

It is availible for Windows, macOS and Linux. Use the link that is availible to download
one of the versions:
	*https://visualstudio.microsoft.com/downloads/
----------------------------------------------------------------------------------------------------------
* 4. COMPILE THE PROGRAM
Firstly the file needs to be unzipped once downloaded.
To open the application select the the file named [WpfApp_BudgetPlanning_POE.sln].
Double click the file or press the enter button (if the file is selected) to open up the 
application. The application will open through the visual studio application and the code 
will be brought up through the application.
*
--To compile the application
*Click on the [▶ Start](a button located on top of the visual studio application)
*A window will open once the program runs. In the first window, it would state the
 information about what the program can do.
*Click the button Begin Budget Plan to go to the next window.
*It would state that the user needs to enter their monthly salary and tax that applies.
*It would then state to the user that an input would be required for the monthly expense.
 These would include grocery, water and lights, travel cost, cellphone and telephone, and
 additional expenses.
*Two radio buttons will be presented, in which the user can choose whether they would like
 to rent property or purchase.
*If the user picks to rent property, then an input of their rent expense is required.
*If the user picks to purchase property, then an input of purchase price, total deposit,
 interest rate, months would be required.
*The user has an option to enter details if a car is to be purchased or may leave it blank.
*If the user chooses to purchase a car, then an input of purchase price, total deposit,
 interest rate, insurance, and model and make is required.
*If the user has a specific goal to save up to, they can calculate the amount of savings by
 inputing the amount to save, number of years and interest rate that will apply.
*They are three buttons present: 
	**Validate Expenses - It is to validate whether the expenses are more than the income.
	**List of Expenses - Displays all expense values in a messageBox as a list.
	**Estimated Savings Value - Displays the monthly savings value required to save up until the specified period (with interest compunding monthly)
*An Exit button is also avalible. If the user clicks the exit button, then it would ask the
 whether they would like to exit. If yes is clicked then it exits the application, whereas if
 no is clicked the application will continue running
----------------------------------------------------------------------------------------------------------
* 5. BUGS
There are no bugs present in this application
----------------------------------------------------------------------------------------------------------
* 6. CONTACT INFORMATION
My name is Yagnash Keeka and I am a student at Varsity College (Located in Sandton)
Email: 20108984@vcconnect.co.za
----------------------------------------------------------------------------------------------------------
* 7. GITHUB LINK

----------------------------------------------------------------------------------------------------------
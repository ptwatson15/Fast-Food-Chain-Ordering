## Fast Food Project

### About
Submitted to Sir Larry Vea for requirements in IT131-8L (Information Management Laboratory)

### Languages used
This Project was written using C# and SQL using Microsoft Visual Studio Enterprise 2017 v. 15.9.27 and Microsoft SQL Server Management Studio v. 18.6.

### Form1
Left Data Grid View -> Displays Customers and Menu Items, controlled by buttons on the right side of the Form (Load/Refresh Menu Items, Load/Refresh Customer, All Customer)

Right Data Grid View -> Displays Orders, controlled by buttons at bottom of screen (GENERATE REPORT (BY LOCATION), GENERATE REPORT (BY CUSTOMER), ALL ORDERS, LOAD ORDERS)

Textboxes -> For Input values which can be loaded onto the grid viewss via the the right side buttons or bottom left buttons. 
One can also add, edit, or delete orders using buttons (Save, Update, Delete) at the bottm right of the form.

Cancel -> Closes program
Clear text -> Clears Text of textboxes


### Menustrip
Sales - Total Sales -> Displays total sales from all the orders

Edit - Edit Menu -> Edits Food Menu items in the database

Edit - Edit Customer -> Edits Customer info in the database


### Tables

There are 3 tables in the database used:
MENU, CUSTOMER, and ORDERS

CUSTOMER Columns:
CUS_ID (PK)
Fname
Lname
Mname

MENU Columns:
Menu_Id
Food (PK)
Price
Category

ORDERS
CUS_ID (FK)
Food (FK)
Quantity
Price
DineTake
Tab_Add
ID (PK)
Order_ID
Time_Stamp

## Credits
This project was made by Patrick Watson


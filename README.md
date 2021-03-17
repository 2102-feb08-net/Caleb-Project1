# Best Eats

## Project Overview

Best Eats is a food themed customer-oriented store web application designed to have a customer
register an account, login, place orders for products, and review said orders. The customer and all store-related information
is stored on a database to be sent and retrieved when needed.


## Languages and Technologies Used

* C#
* T-SQL
* HTML/CSS
* Javascript

* .NET5 framework
* Entity Framework Core
* ASP.NET Web API
* JQuery
* Bootstrap 4.5.2
* Azure T-SQL database
* Azure DevOps CI/CD pipeline using YAML
* Azure app service
* SonarCloud through Azure pipeline CI


## Project Features

* Navigate through various HTML web tabs using a Bootstrap nav-bar
* Register a new customer with a username and password
* Login a customer using validation and customer data stored on Azure Database
* Place an order for products entering product-type, product amount, and Store to order product from
* View all orders placed by logged in customer by retrieving stored orders from Azure Database

To-Do items:

* implement the store inventory system in-app
* implement employee-access login permissions
* -- with employees, allow viewing of all customer info, and modify store inventory
* implement a 'cart' purchasing system of adding multiple products to then be purchased at once
* implement a User Interface that includes more personalization and generic store info

## Getting Started

use git clone to make a duplicate of this project repository.
This command will make a copy inside of what your current directory is
at the time the command is executed.
* git clone https://github.com/2102-feb08-net/Caleb-Project1.git


## Usage

NOTE: this Application is designed to store information in a T-SQL database. The SQL file for the creation of the database is provided in the top of the project repository. If the creator's database is not currently online, the User will need to create a database using the SQL file provided. The 'connectionstring' for the project will be stored in the secrets.json file of the BestEats.Web sub project.

* in Visual Studios 2019, when opening by solution, look for the BestEats.sln inside of the 'BestEats' folder
* make sure the debug/run configurations are set on the BestEats.Web project.
* when the web application is up on your internet browser, it should appear as this image: ![BestEatsMainPage](https://user-images.githubusercontent.com/36245067/111410971-bfc5be00-86a7-11eb-9a46-34e741189939.PNG)

* From the MainPage, Pressing 'Register' will put the User on the Register HTML page to insert a username and password for a User.
* If successful, an alert will pop up, notifying the user of registration success.
* From there, tapping on the 'Login' tab on the navbar will put the User on the Login HTML page.
* reinsert the username and password that was used to register a user, keeping in mind capitalization and spelling.
* From there, The User will be put on the Profile Page. When the button on Profile is pressed, the User's orders will be shown--if any.
* Pressing the 'Order' tab will put the User on the Order HTML page to make an Order. All fields must be provided before hitting submit.
* Once an order is submitted, an alert saying success will be shown. The User can head back to the Profile section and hit 'refresh'.
* When refresh is pressed, a table displaying the User's orders will be shown.






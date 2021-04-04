# OnlyZa
Windows application that is built on the dominos api for ordering pizza. 

# Goal
Order someone's Dominos repeat order quickly and efficiently.

# Interface
This is a super clunky interface that was built with the standard winforms tools. The delivery and carryout estimated times will update according to the store that has been selected. To order a pizza, simply press the large order button. This will take you to a second confirmation screen that contains the price of the order. This will ask you if you want to continue with the order, or cancel it. If you continue, the order will be sent to the dominos.

Capable of indicating that the store is no longer open and unable to accept orders
![Store_Closed](https://github.com/itrussell15/OnlyZa/blob/main/images/Store%20Closed.PNG?raw=true)

# Ordering
All information that will personalize this pizza ordering process. This is where the user would set their address, payment, and order information.

Using the data.json file, fill out the relevant information to you. This will gather store information for the stores surrounding you. Setting the payments section to null on this file will not allow for any delivery service options. Please see the data_template.json for understanding how to structure the json. 

# Random

There is almost no error handling on this application at the moment, I am assuming that everything will go to plan when the users uses this (great plan, right?). That being said, anyone that uses this out in the wild, I know that I have had a couple stores cause the application to fail due to a property being missing? So watch out.

User and Device were made abstract to allow for easy expansion into specific types 
while sharing common logic. DeviceService and UserService focus only on their respective collections and RentalService acts 
as a controller to handle the interaction between them and its collection of Rental's
Rental manages only its own state and penalty logic
Coupling is achieved in RentalService by using Dependency Injection

Sample code for test is in Program.Main()

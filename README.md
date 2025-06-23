## BEFORE RUNNING THE PROGRAME:

1- Change database path to your own

Go to each of these file:
LoginCustomer.cs
CustomerBooking.cs
AdminLogin.cs
AdminDashboardCustomer.cs
AdminDashboardBook.cs

Change that part of the string to your path:

string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectEDP_CarRental\PrimeWheel.mdf;Integrated Security=True;Connect Timeout=30";

to

string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=<your path>\PrimeWheel.mdf;Integrated Security=True;Connect Timeout=30";

![Screenshot 2025-06-23 210328](https://github.com/user-attachments/assets/32d37c22-65ab-4218-8815-b64ddf001ace)
![Screenshot 2025-06-23 210336](https://github.com/user-attachments/assets/9b3691f3-c1ea-4659-a04c-bb8470675c66)

2- Credential

Customer

username - password

aimanbudakbaik - abcd1234

nurzulaikha123 - abcd1234

mamatkampung - abcd1234

harrisjamban - abcd1234

cikpiahlegend - abcd1234

abangdurian - abcd1234

pokwenggeli - abcd1234

intanmolek - abcd1234

Admin

username - password

tokibah - 1234

kingarif275 - 4ad8b0ce31

Luqman_gamer - 5678

## INTRODUCTION
This Windows Forms application is a car rental service system that allows users to sign in as either an admin or a customer. Customers can select a car and enter rental details including rent date, return date, pickup and return locations, and a preferred payment method. The system automatically calculates the total rental cost based on the selected duration and car rate, and users can then submit their booking, which is stored in the database. Admins have access to view all bookings, update booking statuses to "Complete" or "Cancelled," and manage customer records, including deleting customers from the system.

## IMAGE
![Screenshot 2025-06-23 211524](https://github.com/user-attachments/assets/439552c4-ba82-46ae-9a86-e7cdf7d40168)
![Screenshot 2025-06-23 211540](https://github.com/user-attachments/assets/2d9109ba-1119-4ffd-ac02-db19dcf2087c)
![Screenshot 2025-06-23 211610](https://github.com/user-attachments/assets/0ec06392-25b4-4de2-a787-72212514c0ed)
![Screenshot 2025-06-23 211632](https://github.com/user-attachments/assets/09748436-d81c-40c9-bfe3-cff601a72fa1)

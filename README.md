# ContactManager test task 

This is a simple web app which accepts a .csv file, reads data from it and stores
it in database. You can also filter uploaded data by each column. I implemented
this app using .NEY 5.0, MacOS 12.7.5, and MSSQL(via Docker) - mcr.microsoft.com/mssql/server:2022-latest.

<img width="1280" alt="Screenshot 2024-09-27 at 16 04 35" src="https://github.com/user-attachments/assets/e6d6f188-a811-4c78-ba18-215ae2eee1e4">

<img width="1280" alt="Screenshot 2024-09-27 at 16 05 14" src="https://github.com/user-attachments/assets/cbd825c7-d3eb-4dbd-a9f0-67374e55222c">

Here is the CSV data I used for testing

```csv
Name,DateOfBirth,Married,Phone,Salary
John Doe,1985-05-15,true,1234567890,50000.00
Jane Smith,1990-10-20,false,0987654321,60000.00
Alice Johnson,1978-02-11,true,2345678901,72000.00
Bob Brown,1983-07-09,false,3456789012,54000.00
Charlie Wilson,1992-12-02,true,4567890123,61000.00
Diana Evans,1988-09-30,false,5678901234,58000.00
Ethan Davis,1991-06-14,true,6789012345,49500.00
Fiona Garcia,1995-01-23,false,7890123456,53000.00
George Lee,1980-11-27,true,8901234567,75000.00
Helen Clark,1984-03-05,false,9012345678,62000.00
Isaac Scott,1986-08-19,true,1230987654,47000.00
Julia Morgan,1993-04-22,false,0987123456,66000.00
```

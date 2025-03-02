Overview
This application is designed to maintain an inventory of classrooms at Conestoga College. It allows users to add, update, and filter classroom information, including room number, capacity, available equipment, and accessibility. The application is built using C# with a WinForms interface and incorporates a class library for data storage and file I/O operations.
Key Features
•
Add New Room: Allows users to input classroom details such as room ID, room number, capacity, number of projectors, smart board availability, and accessibility. The application validates user input and provides error messages if the input is invalid.
•
Update Room: Enables users to modify existing classroom records. To update a record, the user needs to provide the Room ID of the record that will be updated with the new properties.
•
Filter Rooms: Allows users to filter classrooms based on campus (Waterloo, Doon, Cambridge) and minimum capacity.
•
Data Storage: Classroom data is stored in a file, with each record containing classroom properties.
•
User Interface: A user-friendly WinForms interface for easy interaction.
Getting Started
1.
Prerequisites:
◦
Visual Studio (or another C# development environment)
2.
Installation:
◦
Download the solution code.
◦
Extract the solution to a folder.
◦
Open the solution in Visual Studio (the *.sln file).
3.
Configuration:
◦
The application uses a data file ("classrooms.txt") to store classroom objects. Ensure that this file is in the correct location or update the file path in the code if necessary.
4.
Running the Application:
◦
Build the solution in Visual Studio.
◦
Run the executable file from the bin\Debug or bin\Release folder.
Usage
1.
Adding a New Room:
◦
Enter the classroom details in the input fields.
◦
Click the "Add new room" button.
◦
A message label will indicate whether the record was saved or if there were any errors.
2.
Updating a Room:
◦
Enter the Room ID of the classroom you want to update.
◦
Modify the classroom details in the input fields.
◦
Click the "Update room" button.
◦
A message label will indicate whether the record was updated successfully or if there were any errors.
3.
Filtering Rooms:
◦
Select the desired campus (Waterloo, Doon, or Cambridge).
◦
Enter the minimum capacity.
◦
Click the "Show rooms" button to display the filtered classrooms in the listbox.
4.
Resetting the form:
◦
Click the "Reset for next" button to clear the input fields and uncheck the checkboxes.
5.
Exiting the application:
◦
Click the "Exit" button to close the application.
Data File Format
The "classrooms.txt" file stores classroom data. Each line in the file represents a classroom object, with properties delimited by a vertical slash "|". The order of properties should match the order defined in the Classroom class.
Example Room ID Format
Room IDs should follow the format "WMB-4G15":
•
W = Waterloo, D = Doon, C = Cambridge
•
MB = main building
•
4 = 4th floor
•
G = any single alphabetic character
•
15 = room number on the 4th floor
Notes
•
When the application is loading data from the file to the listbox, only the campus/capacity that is selected will be displayed.
•
Feedback is provided through message labels (in blue for success, red for errors).
Credits
•
Bart Simpson (123456) - as indicated in the sample form
License
[Add License Information Here]
Important Considerations
•
This README is based on the provided excerpts and might need adjustments based on the complete application code.
•
Remember to replace placeholders (e.g., license information) with accurate details.
•
It would be beneficial to include screenshots of the application in action.

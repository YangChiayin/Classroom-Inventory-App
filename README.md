# Conestoga Class Room Inventory Application

## Overview

This application is designed to maintain an inventory of classrooms at Conestoga College. It allows users to **add, update, and filter classroom information**, including room number, capacity, available equipment, and accessibility. The application uses **C# with a WinForms interface** and incorporates a class library for data storage and file I/O operations

## Key Features

*   **Add New Room:** Allows users to input classroom details such as room ID, room number, capacity, number of projectors, smart board availability, and accessibility [2]. The application **validates user input and provides error messages** if the input is invalid [2].
*   **Update Room:** Enables users to modify existing classroom records [2]. To update a record, the user needs to provide the Room ID of the record that will be updated with the new properties [2].
*   **Filter Rooms:** Allows users to filter classrooms based on **campus (Waterloo, Doon, Cambridge) and minimum capacity** [2, 3].
*   **Data Storage:** Classroom data is stored in a file, with each record containing classroom properties [1, 2]. The file must be named `classrooms.txt` [1].
*   **User Interface:** A user-friendly WinForms interface for easy interaction [1].

## Getting Started

1.  **Prerequisites:**
    *   Visual Studio (or another C# development environment)
2.  **Installation:**
    *   Download the solution code.
    *   Extract the solution to a folder.
    *   Open the solution in Visual Studio (the `*.sln` file).
3.  **Configuration:**
    *   The application uses a data file ("classrooms.txt") to store classroom objects [1, 2]. Ensure that this file is in the correct location or update the file path in the code if necessary. The file must be in the same directory as the executable [1].
4.  **Running the Application:**
    *   Build the solution in Visual Studio.
    *   Run the executable file from the `bin\Debug` or `bin\Release` folder.

## Usage

1.  **Adding a New Room:**
    *   Enter the classroom details in the input fields.
    *   Click the "Add new room" button [2].
    *   A message label will indicate whether the record was saved or if there were any errors [2].
2.  **Updating a Room:**
    *   Enter the Room ID of the classroom you want to update [2].
    *   Modify the classroom details in the input fields [2].
    *   Click the "Update room" button [2].
    *   A message label will indicate whether the record was updated successfully or if there were any errors [2].
3.  **Filtering Rooms:**
    *   Select the desired campus (Waterloo, Doon, or Cambridge) [3].
    *   Enter the minimum capacity [3].
    *   Click the "Show rooms" button to display the filtered classrooms in the listbox [2, 3].
4.  **Resetting the form:**
    *   Click the "Reset for next" button to clear the input fields and uncheck the checkboxes [3].
5.  **Exiting the application:**
    *   Click the "Exit" button to close the application [3].

## Data File Format

The "classrooms.txt" file stores classroom data [1, 2]. **Each line in the file represents a classroom object, with properties delimited by a vertical slash "|"** [1]. The order of properties should match the order defined in the `Classroom` class

## Example Room ID Format

Room IDs should follow the format "WMB-4G15":

*   **W = Waterloo, D = Doon, C = Cambridge**
*   **MB = main building**
*   **4 = 4th floor**
*   **G = any single alphabetic character**
*   **15 = room number on the 4th floor**

The letters are not case sensitive, and the dash is optional

## Notes

* When the application loads data from the file to the list box, only the campus/capacity that is selected will be displayed
*   **Feedback is provided through message labels (in blue for success, red for errors)**
*   In validating user input or adding/updating a classroom, the **Room ID is required and must be a positive integer**



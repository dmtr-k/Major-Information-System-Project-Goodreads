# Major-Information-System-Project-Goodreads

## Overview
The Goodreads Windows Forms Application is designed to provide users with functionalities related to searching and reviewing books. It allows users to register, log in, search for books based on various criteria, and leave reviews for books they have read. Each user can only submit one review per book.

## Features
1. **Registration and Login**
   - Users can register with a unique username, email, and password.
   - Password requirements include a minimum length of 8 characters, containing at least one uppercase letter, one lowercase letter, and one digit.
   - Email validation is performed to ensure a valid email format.

2. **Home Page**
   - After logging in, users are directed to the home page, where they are welcomed by their username.
   - Users can search for books based on title, author, genre, publisher, publish year, and price range.

3. **Book Search**
   - Users can search for books using various criteria such as genre, publisher, publish year, and price range.
   - Searches can be refined by providing title and author information.
   - The application dynamically generates SQL queries based on the selected search criteria.

4. **Book Information**
   - Clicking on a book in the search results opens a detailed view of the book.
   - Book details including title, author, genre, publisher, publish year, and image are displayed.
   - Users can view existing reviews for the book.

5. **Review Submission**
   - Users can leave reviews for books they have read.
   - Only one review per user per book is allowed.
   - Upon submitting a review, the application checks if the user has already reviewed the book and provides appropriate feedback.

6. **Review Management**
   - Users can delete their own reviews from the system.
   - Deleting a review removes it from the database and updates the review list accordingly.

## Code Details
### `saveButton_Click` Method
- This method handles the submission of a new review for a book.
- It checks if the user has already reviewed the book using the `UserHasReviewed` method.
- If the user has not already reviewed the book, the review is inserted into the database.
- If the user has already reviewed the book, a message is displayed indicating that they can only submit one review per book.

### `UserHasReviewed` Method
- This method checks if the user has already reviewed the book.
- It executes a SQL query to count the number of reviews by the user for the specified book.
- If the count is greater than 0, it returns `true`, indicating that the user has already reviewed the book; otherwise, it returns `false`.

## Dependencies
- The application relies on a SQL Server database named `Goodreads`.
- The database schema includes tables for `Books`, `UserInfo`, and `Review`.

## Conclusion
The Goodreads Windows Forms Application provides users with a convenient platform for searching and reviewing books. Its user-friendly interface and robust functionalities make it a valuable tool for book enthusiasts to discover new reads and share their thoughts with the community.

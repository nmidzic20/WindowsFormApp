A simple Windows Form desktop application created for the first laboratory exercise in the course Software Development.

# Laboratory Exercise Task

Create a simple Windows Forms application that allows users to log in and register within the application. It is necessary to version the source code according to the instructions in point 3.

Attempting to log in a non-existent user should result in an error message, while attempting to log in an existing user should display a message about successful login.

A new user can register by clicking on the Register button and filling out the registration form. Registered users can be stored in a list (they do not need to be permanently stored, e.g., in a database or file).

When solving the task, it is necessary to version the source code as follows:

- 1.1. After creating an empty project, create a new local repository through Visual Studio.
- 1.2. Implement business logic classes (for example, you could have classes like User, UserRepository, an enumeration UserType, etc.), and commit the changes to the main branch.
- 1.3. Based on the main branch, create a new short-lived branch named UserLogin and make it the active branch.
  - 1.3.1. Design the login form and commit it to the new branch.
  - 1.3.2. Implement the program logic for user login and commit it to the new branch.
- 1.4. After testing, merge the functionality implemented in the UserLogin branch into the main branch.
- 1.5. Based on the main branch, create a new short-lived branch named UserRegistration and make it the active branch.
  - 1.5.1. Design the registration form and commit it to the new branch.
  - 1.5.2. Implement the program logic for user registration and commit it to the new branch.
- 1.6. After testing, merge the functionality implemented in the UserRegistration branch into the main branch.
- 1.7. Additionally test the solution, make any necessary corrections, and commit them to the main.

# User Management WinUI 3 Application

This WinUI 3 application is a simple user management tool that fetches user data from an API and displays it on the UI.
Here we used [jsonplaceholder](https://jsonplaceholder.typicode.com/users) Api.

## Project Structure

Model: Contains the User class that represents user data.
ModelView: Contains the MainViewModel class responsible for fetching user data from the API.
Services: Contains the ApiService class for making HTTP requests to the API.
App.xaml: Application-level resources and settings.
MainWindow.xaml: Main window of the application where user data is displayed.

## Getting Started

1. Clone the repository to your local machine:

```bash
git clone https://github.com/your-username/UserManagement-WinUI3.git
```

2. Open the solution in Visual Studio 2022 or later.

3. Build the solution to restore packages and compile the project.

4. Run the application to see the user data fetched from the API displayed on the UI.

## Dependencies

.NET SDK 6.0 or later
Microsoft.NET.Sdk.WinUI (for WinUI 3 projects)
Newtonsoft.Json (for JSON serialization)

## Usage

The application fetches user data from the JSONPlaceholder API using the ApiService class.
User data is displayed in the MainWindow.xaml using data binding with the MainViewModel class.

## Screenshots

_MainWindow of the User Management Application_

![SC1](https://github.com/maheshadmane/WinUI-UserDashboard/assets/110077949/ee14c64a-3c35-40ba-aafe-cec0f9d6c607)

## How to Open in Visual Studio 2022

1. Launch Visual Studio 2022 on your computer.
2. Go to File > Open > Project/Solution.
3. Navigate to the folder where you cloned the repository and select the .sln file.
4. Click on Open to open the solution in Visual Studio 2022.


## Contributing

1. Fork the repository.
2. Create a new branch (git checkout -b feature/new-feature).
3. Make your changes and commit them (git commit -am 'Add new feature').
4. Push to the branch (git push origin feature/new-feature).
5. Create a new Pull Request.

## License

This project is licensed under the MIT License - see the LICENSE.txt file for details.

# Interview App - Premier League Sqauds Finder
A web application that allows users to search for any Premier League club and view its current squad, built with React and .NET Core.

Uses [API-Football](https://www.api-football.com/) as an external API for data fetching.

Due to the current limitations of free tier access, api handles up to _100 requests per day_.

## Important Notice!
Before playing with this app, you should have your own API-Football subscription and API_KEY to provide to the backend app.

## Features
- Search functionality to find any Premier League club from current season (2024/25), also by their nicknames.
- Displays up-to-date information about the club’s current squad.

## Tech Stack
### Frontend
- React
- React Router
- React Query
- Bootstrap (for styling)

### Backend
- .NET Core
- Swagger (for API documentation)

## Getting Started
### Prerequisites
- Node.js (v20 or higher)
- .NET SDK (v8.0 or higher)
- Git
- Subscription for API-Football (Free is enough)

### Installation
1. Clone the repository
```
git clone https://github.com/TheMacBender/TransferRoom_Interview.git
```

2. Navigate to the project folder
```
cd TransferRoom_Interview
```

3. Install frontend dependencies:
```
cd TransferRoomInterviewApp/transferroominterviewapp.client
npm install
```

4. Install backend dependencies
```
cd ../TransferRoomInterviewApp.Server
dotnet restore
```

5. Paste your API_KEY in *appsettings.Development.json*

### Running the application
Simply start both backend server and frontend development server by using this command while being inside _TransferRoomInterviewApp.Server_ directory:
```
dotnet run --launch-profile https
```

Visit https://localhost:5174 to start using the app!

## Usage
1. On the homepage, you are able to navigate to the search page.
2. Using the search bar, enter name of any Premier League club from season 2024/25.
3. Select a club displayed in the list.
4. View the club's badge and current squad, including player details like age, position and photo.

## Demo

Application is hosted on Azure and is accessible through this link: [DEMO](https://app-interviewapp-c7h7hshwepd3cjd0.westeurope-01.azurewebsites.net/)
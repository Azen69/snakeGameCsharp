# SNAKE GAME
SNAKE GAME created in C# with database connection. The game has a Graphical interface with multople views.
The player must collect as many points as possible. Difficulty level increases as points increase, because the snake gets bigger.
##
## Setup
To run this project with fully functional , you need a database connection with database structure,like that:
![ERD DIAGRAM](./imagesFromGame/erdDiagramSnakeGame.PNG)
And change database path in file snakeGame.cs at line 20.
```
private string pathDatabase = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
```
## Screenshots
Main Window:
![Main window](./imagesFromGame/mainWindow.PNG)
Game:
![Game](./imagesFromGame/Game.PNG)
Game Over Window:
![Game Over](./imagesFromGame/gameOver.PNG)
Player Result:
![Player result](./imagesFromGame/playerResult.PNG)
Top 10:
![Top 10](./imagesFromGame/topTen.PNG)
Options:
![Options](./imagesFromGame/optionScreen.PNG)
Available Resolution:
![Resolution](./imagesFromGame/resolution.png)
Speed Option:
![Speed](./imagesFromGame/speed.png)
Blue Board:
![Blue Board](./imagesFromGame/blueGame.PNG)
White Board:
![White Board](./imagesFromGame/WhiteGame.PNG)

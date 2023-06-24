# PacMan Game
Goofy Pacman game made by C# & .Net Framework.

This is a small, windows form app, school project I did for extra grades.

### Installation
1. right click on ```setup.exe``` in current directory
2. click ```run as adminstrator```
3. Done!

## Database structure
```
Table Player
ID, 
Nickname - Player's nickname
Password
HighScore - Player's best shot(default = 0)
```

### How it works
Pacman is an old, popular game which has two characters: Pacman(the yellow guy and the main character which the user controls) and ghosts(enemies). Pacman tries to collects all the coins in the screen while the ghosts are searching for them. the main goel is to collect all the coins without attracting with ghosts in the minimum time.

Forms:
- Login: user can creates or login into their account using this form
- Dashboard: user panel which will be shown after each game and shows user's status and game's results
- Pacman: the main game

The Game starts with dashboard, it first, runs the ```Login``` form and if player could successfully login opens the Pacman game, then when the game is over(user wins, lost, or just closes the window) the dashboard itself will be shown to the user.

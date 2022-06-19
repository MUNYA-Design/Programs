# Munya-Marinda/Visual-Basic
This repository contains all working projects I completed whilst learning how to code in Visual Basic.
Below is each projects explained.

![1_dodger_startgame](https://user-images.githubusercontent.com/84540577/174471936-3cc8d63d-8c20-4e37-b9ba-0f91c4737b6d.png)
![3_dodger_levelone](https://user-images.githubusercontent.com/84540577/174471941-77b54c0d-26c3-40c2-b2d1-139ecdec4e9e.png)
![4_dodger_gameover](https://user-images.githubusercontent.com/84540577/174471945-d1ec8c78-64d8-44f2-a5ef-b8427fb6d34d.png)
![5_dodger_gamewon](https://user-images.githubusercontent.com/84540577/174471948-e661ccd1-3cd5-494b-965e-3e38eeb5f754.png)




## 1 Dodger

- Type: Desktop App
- Cateogory: Game, Arcade
- Description: Similar to Snow Bros, Dodger is an arcade game that requires the user to navigate up multiple floors filled with their own sets of moving enemies and obstacles. To win the game, the user has to start at the bottom-left of the screen and work their way up to the top-right.

What I learnt:
- I designed my own game assets. (background, terrain, player-avatar, enemie-avatar, buttons, animations)
- How to split different game objects into classes for better management.
- Intense use of timers to manage the game.
- I used a classes to manage the state the of different game objects:
  - Class "Player" : Dodger/Classes/Players.vb
  - Class "Terrain" : Dodger/Classes/GameTerrain.vb
  - Class "EnemyBlock" : Dodger/Classes/Enemies.vb
- Created a custom module with methods "sprmsg()" - to show me debugging values in better way; and "Showpos()" - to show me the postion of any object I pass an argument.

- Biggest Challenge:
  - The mathematical equations that were needed to simulate a "jump" movement that slows down over a certain period of time and then accelerates down once that period of time has expired. I used an array of values that represents the full motion of "up-top-down", something like [-1,-2,0,0,0,+4,+4,+4] ... I wouldn't go into detail but image it being [going up, slowing down, coming down]



## 2 ~~Find Mii Code_V2~~ (broken)

- Type: Desktop App
- Cateogory: Utility, Text Manipulation
- Description: A program used to store code snippets that the user uses frequently or finds useful. The idea is to store each snippet according to its programming language and even allow the programmer to search parts of the snippets.

- What I learnt:
  - String functions and methods.
  - Mainly searching through lines of string for particular string sets.
  - File reading/writing

- Biggest Challenge:
  - Since I avoided using a Database and used a Textfile instead, I needed to figure out a way to store the data in an orderly manner. I came up with using tags similar to HTML and XML ("<>"). Each piece of data was wrapped in a tag "<></>" so that it can be read and displayed accordingly on the user interface.


## 3 GuessingGame

![RightGuess](https://user-images.githubusercontent.com/84540577/174472014-cf385bc8-bc2e-4681-9a71-a9ed5aeb28b6.PNG)

- Type: Desktop App
- Cateogory: Game, Words
- Description: This game asks the user to guess a number between 1-to-10. They start off with a balance of 1000 points and lose/win 100 points depending on their guess. If the balance is 0 then the user loses but there is no limit on winning.

- What I learnt:
  - Basics like conditional statements, procedures, onclickEvents etc.


## 4 calculatorAPP

![calculatorApp_vb_console1](https://user-images.githubusercontent.com/84540577/174472097-5d4d64bd-1e5c-4ef4-8859-3314f1c97dfa.png)


- Type: Console App
- Cateogory: Utility, Math
- Description: A simple calculator app that takes two numbers and does an Addition, Subtraction, Multiplication, and Division Function on them.
 

## 5 numbercrunchAPP

![numberCrunchApp](https://user-images.githubusercontent.com/84540577/174472105-c58cb6fc-b6ab-4349-8d88-807ce0b45c3f.png)

- Type: Console App
- Cateogory: Utility, Math
- Description:
  - This calculator app does a bit more:
    - Average of 4 numbers
    - If a number is Odd or Even
    - Finds the factors of a number
    - Prints the sum of 'n' numbers where 'n' is the number of numbers the user wants to input.
    - Prints all of the prime numbers until 'n' where 'n' is the max provided by the users.
    - Returns the largest numbers of 'n' numbers.

-What I learnt:
  - Maths methods like .ceil, .floor, .sqrt, .round, etc.

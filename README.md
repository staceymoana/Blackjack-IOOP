# Blackjack-IOOP
Intro to Object Oriented Programming | Blackjack | Assignment 2

![Image of Blackjack GUI](https://github.com/staceysike/Blackjack-IOOP/blob/master/ioopGUI.png)

The purpose of this assignment was to design a GUI card game application of my choice. 
I chose to implement a simple version of Blackjack, where the player vs. 'the computer'.

The game must provide functionality including:
* ability to start a new game, pause and continue a running game, stop an unfinished game & complete a game
* validation of played cards
* automatically keeps track of scores, to produce a top 10 high score list. 

Game Rules:
The game starts with the player and the computer both recieving one card each.
The game will randomly decide who's turn is first. Turns are represented by a border around the respective cards.

The deck of cards holds 52 cards (4 suits of 13). Each card's number is its value, except for Jack, Queen and King. Their values are 10. 
Each card's value in a player's hand will be added to each score. e.g Ace = 1, Two = 2, King = 10.

Players can choose to hit (be dealt a card from the deck) or stand(not be dealt a card).

The aim of the game is to get a total score of 21.
If a player's score is more than 21, they will lose.
If both players are standing, the game will end. Whoever is closest to 21, wins.

Highscores are based off of percentage of games won.


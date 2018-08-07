## About me        

• [My linkedin profile](https://www.linkedin.com/in/damiankreick)

• [My Itch.io profile](https://damiankreick.itch.io/)

<p align="center"><img src="Documents/Developer%20notes/GDD%20Images/Title.jpg"/></p>

<p align="center"><img src="https://img.shields.io/badge/Version-2017.3.1.f1-brightgreen.svg"/> <img src="https://img.shields.io/badge/Status-Not deployed-red.svg"/> <img src="https://img.shields.io/badge/Contribuitors-Welcome-blue.svg"/> <img src="https://img.shields.io/badge/Build Version-1.0-orange.svg"/></p> 

## Useful links for developers

[<img src="https://img.shields.io/badge/Wikia-In Progress-yellow.svg"/>](http://es.anotherdaytobe.wikia.com/wiki/Wiki_AnotherDayToBe)   
[<img src="https://img.shields.io/badge/Trello Board-Development-519839.svg"/>](https://trello.com/b/orFCsnAM/ad2b-development)  
[<img src="https://img.shields.io/badge/Trello Board-Bugs-b04632.svg"/>](https://trello.com/b/wxyOYmrM/ad2b-bugs)  
[<img src="https://img.shields.io/badge/Mindmeister Map-Concepts-e6b8cf.svg"/>](https://www.mindmeister.com/1043749988)

## How to download and play

Go to the folder [Web Build](../Web%20build), download it and open [index.html](../Web%20build/index.html). ![#ff0000](https://placehold.it/15/ff0000/ff0000?text=+) **Don't use Google Chrome**

# Game Design Document

## Table of Contents

#### ► Game Overview

• [Game Summary](#game-summary)  
• [What is the Game Genre?](#what-is-the-game-genre)  
• [What is the Player Experience?](#what-is-the-player-experience)  
• [What is the Game’s Theme?](#what-is-the-games-theme)  
• [Who is the Target Audience?](#who-is-the-target-audience)  
• [What is the Setting?](#what-is-the-setting)  
• [What are the technical details?](#what-are-the-technical-details)  
• [When will it launch?](#when-will-it-launch)  

#### ► Camera, Character and Controls

• [Menu Chart](#menu-chart)

#### ► Gameplay Features

• [30 Seconds Of Gameplay](#30-seconds-of-gameplay)  
• [Combat with buffs and debuffs](#combat-with-buffs-and-debuffs)  
• [Map full of places to explore](#map-full-of-places-to-explore)  
• [Guns, food, drugs, vehicles and more...](#guns-food-drugs-vehicles-and-more) 

• [Random events](#random-events)
     
#### ► Story and Theme

• [Time and space](#time-and-space)  
• [Background story](#background-story)  
• [Our Hero](#our-hero) 

     - Conscript
     - Medic
     - Mechanic
     - Scout
     
• [Our Villains](#our-villains)  

     - Bandits
     - Creatures   
     
• [Our Struggle and Objective](#our-struggle-and-objective)  
     
#### ► Brainstorm General Ideas

• [Puzzles and Challenges Ideas](#puzzles-and-challenges-ideas)  
• [Tools, Plugins, Assets, Notes](#tools-plugins-assets-notes)  

#### Game Overwiew

<p align="center">
  <img src="Documents/Developer%20notes/GDD%20Images/TravelPreview.jpg"/>
  <img src="Documents/Developer%20notes/GDD%20Images/CombatPreview.jpg"/>
</p>

#### Game Summary
     
Another Day To Be is a turn based tactics and exploration game in a devastated world. Your character will face different choices while tries to survive in a map full of dangers.

#### What is the Game Genre?

• 2D  
• Action Role Player Game  
• Turn Based Tactics  

#### What is the Player Experience?

• Decisions  
• Randomness  
• Logics  

#### What is the Game’s Theme?

• Present day  
• Ruined civilization  
• South America  

#### Who is the Target Audience?

• 13+, people who like to carry on decisions and expect some different results.  

#### What is the Setting?

• Survive in a journey full of hazards.  

# IMAGE PLACEHOLDER THEME

#### What are the technical details?

• Developed using: Unity3D 2018  
• Art Assets: Adobe Illustrator, Adobe Photoshop, Audacity  
• Platform(s): PC, WebGL  
• Deploy on: [Itch.io](https://itch.io)  
• Controls: Mouse, keyboard for hotkeys  

#### When will it launch?

• No estimated date  
• Expected to have a working demo before 2019

## Camera, Character and Controls

<p align="center">
  <img src="Documents/Developer%20notes/GDD%20Images/CombatPreview.jpg"/>
</p>

#### Camera

• It will consist in a fixed 2D camera, looking as is explained above.  

#### Characters

• The player can choose up to four different classes (Conscript, medic, mechanic and scout) and each one has a unique story to play. 

#### Controls

• Mouse, keyboard for hotkeys  

#### Menu chart

<p align="center">
  <img src="Documents/Developer%20notes/GDD%20Images/Menu%20Chart.png"/>
</p>

#### Context / Setup:

• What is the situation that this 30 seconds is going to take place in?

<p align="center">
     <img src="Documents/Developer%20notes/GDD%20Images/CombatPreview.jpg"/>
</p>

#### Player Actions:

• Write this from the perspective of “you see this, then you click on the button then the screen does such-and-such” and so on. 
• You navigate in the map to a certain location, in the middle of travel a popup can  show displaying some random event, depending on your actions it may will lead you to a fight for example, in that case you need to defeat the enemy in order to continue your journey.

## Gameplay Features

### 30 Seconds Of Gameplay

```_In just 30 seconds, the player can experience the creation of his character to the beginning of the journey. In middle game, 30 seconds of gameplay may take place in combat and involve many effects and outputs. Other scenario can be a simple navigation through the map and participate in differents events._```

• Map full of places to explore  
• Random events based on map location  
• Combat turn with buffs and penalties  
• Weapons, vehicles, cloth, drugs  

### Combat with buffs and debuffs

<p align="center">
     <img src="Documents/Developer%20notes/GDD%20Images/SketchCombat.png"/>
</p>

In combat, both player and enemy will have differents attributes 

### Map full of places to explore

<p align="center">
     <img src="Documents/Developer%20notes/GDD%20Images/SketchTravel.png"/>
</p>

### Guns, food, drugs, vehicles and more...

# IMAGE PLACEHOLDER DICTIONARY ITEMS

### Random events

There will be different events when the player is travelling, here is a short list of examples:

     1 - You were approached by a peaceful traveller, he looks unarmed and a little lost.  
          A - Attempt to avoid by looking away  
          B - Give him some directions  
          C - Try to rob  

     2 - You see a guy trying to rob someone, what do you want to do?  
          A - None of my concern  
          B - Interfer  
          C - Silently kill the robber  

     3 - A large man is coming your way, there is nothing you can do  
          A - Battle

     4 - A well armed caravan is ahead. Wanna trade?  
          A - Yes  
          B - No  
          C - Attack

     5 - A dead body, looks recently killed.
          A - Loot  
          B - Keep moving
  
## Story and Theme

### Time and space

The game takes place in year 2020, only two months after the breakdown in the bottom half of South America. An improvised quarantine border was built along the Tropic of Capricorn guarded by BOPE and UN troops who will shoot on sight. The purpose of this border is to maintain the security in Central and North America and stop the propagation of dangerous species.

Some places of the map are affected by differents catastrophes, such as nuclear accidents, typhoons, floods, droughts and the most important, crop contamination who caused famine and the raise of dangerous species of plants and animals.

### Background story



# IMAGE PLACEHOLDER THEME

### Our Hero

<p align="center">
     <img src="Documents/Developer%20notes/GDD%20Images/MainMenuPreview.jpg"/>
</p>

• The player can choose between four classes (Conscript, medic, mechanic and scout). Each one has a unique style to play.

### Conscript

#### Description  

_The Conscript character is perfect for those who want to focus on combat or for those who are new in the game. It offers many combat buffs and is slighty better with all ranged weapons._

#### Traits

• Skilled on assault rifles  
• Increased health
• Slighty increased accuracy

#### Story and objective



#### Skill tree and habilities 

##### Actives

     • Last stand (10 turns to CD): Negates the enemy damage up to 90%.

##### Passives

     • Marksmanship (5 levels): Increase damage output by 2% each level.

# SKILL TREE IMAGE CONCEPT PLACEHOLDER

### Medic

#### Description  

_The harder class to start due his low health, but the most powerful in late game. The medic class can heal himself on every turn_

#### Traits

• Skilled submachine guns  
• Regeneration per turn  
• Food & drink more effective

#### Story and objective



#### Skill tree and habilities  

##### Actives

     • Anesthesia (5 turns to CD): 50% chance to knock the enemy down for 1 turn

##### Passives

     • Intensive care (5 levels): Increase health regeneration .

# SKILL TREE IMAGE CONCEPT PLACEHOLDER

### Mechanic

#### Description  

_A class very interesting to travel by car. Is very efficient driving and therefore fuel last longer. Also it can be use as berserker_

#### Traits

• Skilled on shotguns  
• Less fuel consumption
• Better chance to find car parts  

#### Story and objective

#### Skill tree and habilities  

##### Actives

     • Berserker (6 turns to CD): +30% damage output with melee weapons for 3 turns.

##### Passives

     • Grease Monkey (5 levels): Decrease fuel consumption by 5% each level.

# SKILL TREE IMAGE CONCEPT PLACEHOLDER

### Scout

#### Description  

_Scout class is perfect for events that can happen. Has a increased chance to avoid a fight and can resist more hours without food or water. Unfortunately he is pretty weak._

#### Traits

• Skilled on sniper rifles  
• Better luck on travel  
• Decreased needs rate  

#### Story and objective

#### Skill tree and habilities  

##### Actives

     • Bullseye (5 turns to CD): +50% accuracy for the next turn

##### Passives

     • Globetrotter (10 levels): Decrease needs rate by 3% each level.

# SKILL TREE IMAGE CONCEPT PLACEHOLDER

### Our Villains

#### Bandits  

_With the end of modern society, most of the people were left on their own, and the will of surviving led them to steal, hurt and even kill each other. Some bandits move alone, others in packs. They may be armed or not, they may forgive you or not._

##### Design 



#### Creatures  

_Along with the corruption of the people, the wild life suffered the same fate. Many species slowly became wilder and vicious due contamination of crops._

##### Design 



#### Our Struggle and objective

• Basically our general objective is make our own journey and eventually reach the border and escape the zone.  

## Brainstorm General Ideas

• Make a timeline for background successes  
• Expand assets library to include Chile and maybe Brazil weapons/vehicles  

#### Puzzles and Challenges Ideas

• Karma System  

#### Tools, Plugins, Assets, Notes

• Make a dictionary in Unity3D with all the assets  
• Start thinking on some creatures designs.

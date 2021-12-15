# GE1Assign
C18312261 Games Engines 1 Assignment
# Formula 9999

Name: Conor Melia

Student Number: C18312261

Class Group: TU856

# Description of the project
This project is a racer that generates a procedural track as you drive.

# Instructions for use
WSAD is used to control the car around the track. "T" can be used to spawn new pieces of track(for testing purposes)

# How it works
There are modular track pieces that are used to create the track as you drive. The script for generating the track ensures that the track is always generating in the one direction, generally, to avoid doubling back on itself and generating track where there is already an asset.

# List of classes/assets in the project and whether made yourself or modified or if its from a source, please give the reference

| Class/asset | Source |
|-----------|-----------|
| PlayerCar.cs | Self written |
| TrackGenerator.cs | Modified from [reference](https://github.com/mirrorfishmedia/EndlessRunnerUnity/blob/master/ColorRun/Assets/Scripts/LevelLayoutGenerator.cs) |
| TrackPieceData.cs | From [reference](https://github.com/mirrorfishmedia/EndlessRunnerUnity/blob/master/ColorRun/Assets/Scripts/LevelChunkData.cs) |

# References
Idea for deceleration came from this forum: https://answers.unity.com/questions/750235/how-to-add-opposite-force-of-current-direction.html
# What I am most proud of in the assignment
Even though it doesn't work as it should, when I got my progam to start creating track objects it was a great moment, as lots of trials and effort led to it somewhat working.

Also I am a fan of the car movement, the hovering looks pretty cool.
# Proposal submitted earlier can go here:
Games Engines 1 Project Proposal

My project would be a racing game that generates the track ahead of the player.
The track could be created like a hotwheels track with segments of track as objects.
Any models needed won't be overly complex.
AI Drivers could be added with pathfinding.

# CS98 cs98HackAThing2 (Winter 2019)
> Andrew Alini, Abby Starr

### Pet Rock Simulator

Pet Rock Simulator is a game where you can choose a rock size, accessorize it, and then have it roll around in a open field. This
game uses unity and c# scripts to create various scenes and produce the overall game. Abby Starr built the rock size scene and
the choose accessory scene while Andrew Alini built the main menu and the simulator scene. Both Abby and Alini worked on hooking
up the various scenes with each other.

#### Get Started

Before building the program, certain scripts must be connected to certain objects in unity
Make sure cameras and appropriate scripts are connected.

#### Usage


To run the game, run the build program with a screen resolution of 2048 by 1280.
Control Rock in simulator using AWSD keys.
To name rock, click top of name box.

### Assumptions

User doesnt direct rock to go off of edge of grass field. 



### What we learned

We learned the basics of Unity and C#. Learned how to do various things such as instantiating gameobjects, working with the camera, and creating the environment for the game. We also learned how to take rock designs in Maya and introduce them as prefabs in Unity. Finally, we also learned how to link scenes together with accessorizing the rocks and then introducing them in the main simulator If we end up doing a game in Unity for our cs98 project, we would have learned the basics and could apply them to ourfinal project. 


### What didn't work
* We tried to make an animated terrain with simulated grass but was unable to get that to work. Therefore, we reverted to a base
plane with grass pictures as tiles. The main menu picture was also very basic after struggling to create terrains there too.
* We also tried to have name of rock appear as label on top of rock but was unable to get it to work.
* Was unable to save accessories to rock so they dont appear in simulator. 
* Buttons in accessories scene are clickable but they don't do anything
* The accessories in the accessories scene aren't clickable
* Selecting the small rock and pressing "next" results in an error and the user is unable to mvoe to the next scene.
* Selecting the large rock and simulating results in a camera that doesn't zoom in on the rock correctly. 

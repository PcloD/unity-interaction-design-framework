# Unity Interaction Design Framework
*A robust, extensible, generic, and versatile interaction design framework for building complex puzzle systems.*

**Status:** In active development

**Version:** 0.0.1

## Introducing UnityEngine.Interaction for content creators and level designers!
UnityEngine.Interaction offers a whole new suite of tools for designing systems of interaction that allow content creators and level designs to easily and quickly build complex challenges and puzzles for their games. The framework can be applied to any game genre and customized to cater to the unique design needs of any game.

## Overview
The technical design of this framework draws inspiration from computer organization and digital logic. The framework uses [directed graphs](https://en.wikipedia.org/wiki/Directed_graph) to represent puzzles (hereinafter referred to as interaction systems). The nodes that make up these graphs refer to the puzzle pieces (hereinafter reffered to as interaction components) of that interaction system. So puzzle piece is to puzzle as interaction component is to interaction system.

## Update 9/26/2016
I completed the first draft of the list of components I believe v1.0 should contain. Please feel free to provide any feedback regarding the organization, naming, and/or grouping of these components. I welcome any ideas for adding, removing, and/or modifying any components. I provide an overview the current rudimentary design for the framework. I welcome any feedback regarding that as well. On a quick side note, I hope to eventually integrate this with the open source [Baste-Rain Games' Node Editor](https://github.com/Baste-RainGames/Node_Editor) project down the road in order to make this tool more usable for content creators and game designers.

## Want to know more?
I encourage you to view this brief **[5-minute YouTube video](https://www.youtube.com/channel/UCkxtr--pUXOrsC4jbMNa3QA)**. In the video, I explain the project's objectives, the current rudimentary design, the implementation plans, and each component listed below.

## Terminology
* **Interaction Object:** A simple building block to build more complex building blocks.
* **Interaction Subsystem:** A complex building block comprised of other building blocks.
* **Interaction System:** A product of simple and complex building blocks put together.
* **Interaction Component:** A general term to reference a simple or complex building block.
* **Interaction Reaction:** A Unity Event that invokes in response to an interaction.
* **Interaction Node:** A graph node represenation of a component.
* **Interaction Graph:** A graph representation of a system or subsystem.

## Components
Definitions contain rules for outputing 1. Any input that doesn't meet these can be assumed to output 0.

### Logic Gates

* **And Gate:** Outputs 1 if all inputs contain a value of 1.
* **Nand Gate:** Outputs 1 if not every input contains a value of 1.
* **Or Gate:** Outputs 1 if at least one input contains a value of 1.
* **Nor Gate:** Outputs 1 if no inputs contain a value of 1.
* **Xor Gate:** Outputs 1 if exactly one input contains a value of 1.
* **Xnor Gate:** Outputs 1 if all inputs contain the same value.
* **Inverter:** Outputs 1 if the input contains a value of 0.

### Buttons
* **Click Button:** Outputs 1 when player clicks on the trigger zone using the mouse.
* **Hold Button:** Outputs 1 when player holds \<key code> for \<duration> while in the button zone.
* **Mash Button:** Outputs 1 when player maintains \<clicks per seconds> and for \<duration> while in the button zone.
* **Push Button:** Outputs 1 when player presses \<key code> while in the button zone.

### Switches
* **Click Switch:** test
* **Hold Switch:** test
* **Mash Switch:** test
* **Flick Switch:** test
* **Sensor Switch:** test

### Sensors
* **Stateless Sensor:** test
* **Stateful Sensor:** test

### Selectors
* **Selector:** test
* **Weighted Selector:** test
* **Bistate Selector:** test
* **Quadstate Selector:** test
* **Octostate Selector:** test

### Sequencer
* **Sequencer:** test
* **Chance Sequencer:** test
* **Random Sequencer:** test

### Misc
* **Distance Checker:** test:
* **Counter:** test
* **Timer:** test
* **Metronome:** test

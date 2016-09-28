# Unity Interaction Design Framework
*A robust, extensible, generic, and versatile interaction design framework for building complex puzzle systems.*

**Status:** Planning

**Version:** 0.0.1

## Quick Introductory Video
I encourage you to view this brief **[5-minute YouTube video](https://www.youtube.com/channel/UCkxtr--pUXOrsC4jbMNa3QA)**. In the video, I explain the project's objectives, the current rudimentary design, the implementation plans, and each component listed below.

## Update 9/26/2016
I completed the first draft of the list of components I believe v1.0 should contain. Please feel free to provide any feedback regarding the organization, naming, and/or grouping of these components. I welcome any ideas for adding, removing, and/or modifying any components. I provide an overview the current rudimentary design for the framework. I welcome any feedback regarding that as well. On a quick side note, I hope to eventually integrate this with the open source [Baste-Rain Games' Node Editor](https://github.com/Baste-RainGames/Node_Editor) project down the road in order to make this tool more usable for content creators and game designers.

## Introducing UnityEngine.Interaction for content creators and level designers!
UnityEngine.Interaction offers a whole new suite of tools for designing systems of interaction that allow content creators and level designers to easily and quickly build complex challenges and puzzles for their games. The framework can be applied to any game genre and customized to cater to the unique design goals of any game.

## Overview
The technical design of this framework draws inspiration from computer organization and digital logic. The framework uses [directed graphs](https://en.wikipedia.org/wiki/Directed_graph) to represent puzzles (hereinafter referred to as interaction systems). The nodes that make up these graphs refer to the puzzle pieces (hereinafter reffered to as interaction components) of that interaction system. So puzzle piece is to puzzle as interaction component is to interaction system.

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
* **Hold Button:** Outputs 1 when player holds **`<key code>`** for **`<duration>`** while in trigger zone.
* **Mash Button:** Outputs 1 when player mashes **`<clicks/sec>`** and for **`<duration>`** while in trigger zone.
* **Push Button:** Outputs 1 when player presses **`<key code>`** while in trigger zone.

### Switches
* **Click Switch:** Changes/outputs state when player clicks on the trigger zone using the mouse.
* **Hold Switch:** Changes/outputs state when player **`<key code>`** for **`<duration>`** while in trigger zone. 
* **Mash Switch:** Changes/outputs state when player mashes **`<clicks/sec>`** and for **`<duration>`** while in trigger zone.
* **Flick Switch:** Changes/outputs state when player presses **`<key code>`** while in the trigger zone.
* **Sensor Switch:** Changes/outputs state when **`<target>`** enters the trigger zone.

### Sensors
* **Stateless Sensor:** Outputs 1 when **`<target>`** enters the switch zone.
* **Stateful Sensor:** Outputs 1 when **`<target>`** enters the switch zone and 0 when it exits.

### Selectors
* **Selector:** Outputs 1 to **`<amount to select>`** randomly selected outputs when receives a 1 input.
* **Weighted Selector:** Outputs 1 to **`<amount to select>`** weight selected outputs when receives a 1 input.
* **Bistate Selector:** Outputs 1 to 1 of 2 outputs based off of 1 input and the decimal equivalent of the input.
* **Quadstate Selector:** Outputs 1 to 1 of 4 outputs based off of 2 inputs and the decimal equivalent of the inputs.
* **Octostate Selector:** Outputs 1 to 1 of 8 outputs based off of 3 inputs and the decimal equivalent of the inputs.

### Sequencer
* **Sequencer:** Outputs 1 for a sequentially selected output for each input 1 received.
* **Chance Sequencer:** Has a chance to output 1 for a sequentially selected output for each input 1 received.
* **Random Sequencer:** Outputs 1 for a randomly selected, but non-re-selectable output for each input 1 received.

### Misc
* **Distance Checker:** Outputs 1 if **`<target>`** is **`<comparison>`** **`<distance>`** from **`<other target>`** when receives a 1 input.
* **Counter:** Outputs 1 if **`<count>`** equals **`<target count>`**. Receiving a 1 input increments **`<count>`** while a 0 resets it to 0.
* **Timer:** Outputs 1 after **`<duration>`** has passed after receiving a 1 input. Stops and resets upon receiving a 0 input.
* **Metronome:** Outputs 1 every **`<interval duration>`** after receiving a 1 input. Stops when receiving a 0 input.

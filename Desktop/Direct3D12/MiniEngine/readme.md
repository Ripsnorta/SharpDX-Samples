# MiniEngine by Team Minigraph at Microsoft
## Ported to C#/SharpDX by John Judd

This is a port of the Microsoft DirectX Graphics Samples MiniEngine project (for DirectX 12) originally developed using C++ to C# and the SharpDX DirectX API.

It includes three projects: Core, Model, and ModelViewer. It does not include the ModelConverter or SDFFontCreator projects at this time. Core, Model, and ModelViewer are sufficient to demonstrate the operation of the engine.

There are some differences:
* A top level namespace MiniEngine has been added.
* Because C# does not allow non-member functions, in MiniEngine# all methods belong to a class. Where MiniEngine has many non-member functions under a namespace or not, these are now incorporated in a class that either reflects the namespace or a new class invented to implement these functions. 
* Some classes and structures in the original MiniEngine are included two or more to a single source file pair (.cpp/.h) which makes the source overall harder to read. These shall be extracted to their own C# class files.


## Getting started:
* Open ModelViewer/ModelViewer_VS14.sln
* Select configuration: Debug (full validation), Profile (instrumented), Release
* Select platform
* Build and run

## Controls:
* forward/backward/strafe: left thumbstick or WASD (FPS controls)
* up/down: triggers or E/Q
* yaw/pitch: right thumbstick or mouse
* toggle slow movement: click left thumbstick or lshift
* open debug menu: back button or backspace
* navigate debug menu: dpad or arrow keys
* toggle debug menu item: A button or return
* adjust debug menu value: dpad left/right or left/right arrow keys

## MiniEngine Project Structure

### Core

### Model

### ModelViewer
# Cursed Depths Core

**Cursed Depths Core** is a Unity package containing shared gameplay systems for the Cursed Depths game. This package is designed to hold reusable C# scripts that can be used by the main Unity game project, including health, coordinates, settings data, event arguments, and global game events.

This repository is separate from the main Unity project so the core systems can be organized, versioned, and reused more cleanly.

## Package Information

* **Package name:** `com.mineking702.curseddepths.core`
* **Display name:** Cursed Depths Core
* **Version:** 1.0.25
* **Unity version:** 6000.0 or newer
* **Authors:** Andrew Gountis and Daniel Kaminski

## Project Overview

This package provides the core code layer for Cursed Depths. It includes shared systems that other scripts can reference, such as player settings, health, entity death events, settings events, and startup events.

The goal of this package is to separate reusable backend-style gameplay logic from scene-specific scripts in the main Unity project.

## How to Use This Package

### Option 1: Add Through Unity Package Manager

1. Open the main Cursed Depths Unity project.
2. Open **Window > Package Manager**.
3. Click the **+** button.
4. Choose **Add package from git URL**.
5. Enter the repository URL for this package.
6. Allow Unity to import the package.

### Option 2: Add Locally

1. Download or clone this repository.
2. Open the main Cursed Depths Unity project.
3. In Unity Package Manager, choose **Add package from disk**.
4. Select this package’s `package.json` file.
5. Unity will import the package as `Cursed Depths Core`.

## Main Systems

### Health System

The `Health` component tracks an entity’s current health and maximum health. It supports:

* Adding health
* Taking damage
* Preventing health from going below zero
* Triggering an entity death event when health reaches zero
* Identifying whether the dead entity is the player or an enemy

This allows both player and enemy objects to use a shared health-related structure.

### Coordinate Data

The `Coordinate` class stores basic position-related data, including:

* Rotation
* Position
* Section ID

This can be used to track where an entity is or what section of the level it belongs to.

### Player Settings

The `PlayerSettings` class stores player configuration data, including:

* Master volume
* Music volume
* Sound effects volume
* Walk left keybind
* Walk right keybind
* Jump keybind
* Attack keybind

The main Unity project uses these settings for the home menu, audio manager, and key rebinding system.

### Game Events

The `GameEvents` static class provides a central event system for important gameplay and UI actions.

It includes events for:

* Game startup requested
* Game startup finished
* Opening the settings menu
* Closing the settings menu
* Settings loaded
* Settings saved
* Entity death

Using events helps separate systems from each other. For example, the UI can request settings changes, while the settings manager and audio manager can respond without every script needing direct references to each other.

### Event Argument Classes

The package includes event argument classes used by the event system:

* `ClosedSettingsMenuEventArgs`
* `SettingsLoadedEventArgs`
* `SettingsSavedEventArgs`
* `EntityDiedEventArgs`

These classes allow event calls to pass useful data, such as player settings or information about what type of entity died.

## Technologies Used

* C#
* Unity 6
* Unity Package Manager
* Assembly Definition Files
* Event-driven programming
* Unity `MonoBehaviour`
* Unity `KeyCode`
* Unity `Vector2`

## Repository Structure

```text
Runtime/
```

Contains all runtime scripts used by the package.

```text
Runtime/EntityStats/
```

Contains entity-related data and health logic.

```text
Runtime/EventArgs/
```

Contains event argument classes used by game events.

```text
Runtime/Events/
```

Contains the central `GameEvents` class.

```text
Runtime/Settings/
```

Contains the `PlayerSettings` class.

```text
Runtime/Core.asmdef
```

Defines the `CursedDepths.Core` assembly.

```text
package.json
```

Defines the Unity package name, version, description, Unity version, and authors.

## Team Contributions

### Andrew Gountis

* Helped design the core gameplay package structure
* Worked on shared gameplay systems used by the main Cursed Depths project
* Helped connect settings, health, and event systems to the main game
* Used AI tools for planning, code support, and documentation help

### Daniel Kaminski

* Helped build and organize the reusable Unity package
* Contributed to core gameplay logic and testing
* Helped with project structure, debugging, and documentation
* Supported integration between the core package and the main game project

## Use of AI Tools

AI tools were used responsibly as support during development.

The team used:

* **Suno Music** for music/audio support in the overall Cursed Depths project.
* **ChatGPT / Codex** for project planning, technical explanations, game concept support, art/spec ideas, and documentation.
* **Codex programming assistance** for C# scripting help, debugging suggestions, and code organization ideas.
* **Ludo animations** for animation workflow support in the broader game project.

The team reviewed and modified AI-assisted work before including it. The final submitted code and package structure were tested and understood by the team.

## Known Issues and Limitations

* This package contains shared systems only; it is not a full playable game by itself.
* The main Unity project is required to see these systems working in context.
* Additional XML documentation could be expanded for every public class, method, property, and enum.
* The settings system stores data objects, but full persistence behavior is handled mostly by scripts in the main Unity project.
* More core systems, such as inventory, checkpoints, save data, or ability data, could be moved into this package in the future.

## Future Improvements

Future versions could include:

* More complete XML documentation
* Unit tests for settings and event behavior
* Save/load data structures
* Shared ability interfaces
* Shared inventory or checkpoint systems
* Better namespace consistency across all classes
* More reusable player and enemy stat systems

## Final Project Summary

Cursed Depths Core is the reusable foundation package for the Cursed Depths Unity project. It organizes shared C# systems such as health, settings, coordinates, and game events into a separate Unity package so the main game project can stay cleaner and easier to maintain.

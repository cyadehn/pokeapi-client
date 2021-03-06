# Pokemon CLI Game Engine (incl. demo game loop)
> .NET Command-line Pokemon Adventure / PokeAPI.co REST Client

## Table of Contents
<p align="center">
  <a href="#requirements">Requirements</a> •
  <a href="#quick-start">Quick Start</a> •
  <a href="#general-info">General Info</a> •
  <a href="#screenshots">Screenshots</a> •
  <a href="#codelou-fall20-included-features">CodeLou Fall'20 Included Features</a> •
  <a href="#completed-features">Completed Features</a> •
  <a href="#credits">Credits</a> •
  <a href="#status">Status</a> •
  <a href="#contact">Contact</a>
</p>

### Requirements
* .NET SDK v3.1 [(link)](https://dotnet.microsoft.com/download/dotnet-core/3.1)

### Quick Start
1. Clone repository
2. Change into main PokemonCLI directory
3. `dotnet run`
```
git clone https://github.com/cyadehn/PokemonCLI.git
cd pokemon-cli/PokemonCLI/PokemonCLI
dotnet run
```

### General Info
This project lays the groundwork for a console-based Pokemon adventure game. The game will include separate game states for character creation, Pokemon trainer battles, exploring to find items and catch Pokemon (including the option to auto-battle Pokemon and gain experience faster), and item/Pokemon inventory display.

### Completed Features
| Feature | Status |
| -- | -- |
| Cutscene engine | In progress |
| PC Pokemon storage/display | Not started |
| Battle system | Not started |
| Map exploration | Not started |
| Item discovery/battle use | Not started |

### CodeLou Fall'20 Included Features
1. PokeAPIClient - Manages use of RestClient package to access [PokeAPI](https://pokeapi.co/) for Pokemon game information (*Accessing external API*)
2. BasicGUI - Handles display of game text and arrangement of separate content windows (*none*)
3. PokemonCLI
* Main game loop handles game states by passing control between a mediator class (Game) and GameState classes - (*Master loop console app*)
* CutsceneMap class handles reading scene/dialogue information from embedded binary resources, parsing cutscene "command" lines, and passing the commands as keys to a Dictionary of Func<T> delegates to retrieve scene actions (*Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program; Read data from an external file, such as text, JSON, CSV, etc and use that data in your application*)
* PlayerCharacter class inherits from a base Character class to provide separate new character prompt/setup options (*Create an additional class which inherits one or more properties from its parent*)


### Status
### Contact

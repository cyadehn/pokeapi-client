using System;
using PokeAPIClient;
using System.Collections.Generic;

namespace PokemonCLI
{
    public class Character
    {
        public string Name { get; protected set; }
        public List<PokemonSpecies> Pokemon { get; private set; }
        //public List<Item> Items { get; private set; }
        public Character(IUserInput userInput)
        {
            SetCharacterName(userInput);
            
        }
        public virtual void SetCharacterName(IUserInput userInput)
        {
            string inputName = userInput.GetUserInput("Enter character name:");
            if ( !string.IsNullOrWhiteSpace(inputName) )
            {
                Name = inputName;
            }
            else
            {
                Tools.Typewriter.WriteDialogue("Hm. Well, how about we call them person for now?");
                Name = "Person";
            }
        }
    }
    public class PlayerCharacter : Character
    {
        //public PokemonBox Box { get; private set; }
        //public PlayerStats Stats { get; private set; }
        public PlayerSettings Settings { get; private set; }
        public PlayerCharacter(IUserInput userInput) : base(userInput)
        {

        }
        public override void SetCharacterName(IUserInput userInput)
        {
            string inputName = userInput.GetUserInput("Remind me... what is your name again?");
            if ( !string.IsNullOrWhiteSpace(inputName) )
            {
                Name = inputName;
            }
            else
            {
                Tools.Typewriter.WriteDialogue("Shy, huh? Well, how about we just call you Kid for now?");
                Name = "Kid";
            }
        }
    }
    public class PlayerSettings
    {

    }
    public class NPC : Character
    {
        public NPC(IUserInput userInput) : base(userInput)
        {

        }
    }
}

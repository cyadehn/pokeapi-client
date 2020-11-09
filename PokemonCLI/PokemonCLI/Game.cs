using System.Collections.Generic;
using PokeAPIClient;

namespace PokemonCLI
{
    public class Game : IGame
    {
        private PokeRepository _pokeRepository = new PokeRepository();
        public IState GameState { get; private set; }
        public List<PlayerCharacter> Players { get; set; }
        public List<NPC> NonPlayerCharacters { get; set; }
        public PlayerData LoadedData { get; private set; }

        public Game(PlayerData loadedData)
        {
            LoadedData = loadedData;
            if ( LoadedData.Continue == true )
            {
                this.GameState = new ContinueState();
            }
            else 
            {
                Players = new List<PlayerCharacter>();
                this.GameState = new NewGameState();
            }
            this.GameState.SetContext(this);
        }
        public void Start()
        {
            GameState.Start();
        }
        public void TransitionTo(IState state)
        {
            this.GameState = state;
            this.GameState.SetContext(this);
            GameState.Start();
        }
        public void TransitionTo(IState state, PlayerCharacter player)
        {
            Players.Add(player);
            GameState = state;
            GameState.Start();
        }
        public void Quit()
        {
            //serialize playerdata into save file
        }
    }
    public interface IGame
    {
        IState GameState { get; }
        void Start();
        void TransitionTo(IState state);
        void TransitionTo(IState state, PlayerCharacter player);
        void Quit();
    }
}

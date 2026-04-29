using UnityEngine;

namespace CursedDepths.Core.Settings
{
    public class PlayerSettings
    {
        // Volume Settings
        public float MasterVolume { get; set; } 
        public float MusicVolume { get; set; } 
        public float SoundEffects { get; set; } 

        // Keybind Settings
        public KeyCode WalkLeft { get; set; }
        public KeyCode WalkRight { get; set; }
        public KeyCode Jump { get; set; }
        public KeyCode Attack { get; set; }
    }
}

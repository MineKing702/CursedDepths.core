namespace CursedDepths.Core.Settings
{
    public class PlayerSettings
    {
        // Volume Settings
        public float MasterVolume { get; set; } 
        public float MusicVolume { get; set; } 
        public float SoundEffects { get; set; } 

        // Keybind Settings
        public Keycode WalkLeft { get; set; }
        public Keycode WalkRight { get; set; }
        public Keycode Jump { get; set; }
        public Keycode Attack { get; set; }
    }
}

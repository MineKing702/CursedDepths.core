using System;
using CursedDepths.Core.Settings;

namespace CursedDepths.Core.Events
{
    public static class GameEvents
    {
        public static event Action GameStartupRequested;
        public static event Action GameStartupFinished;
        public static event Action OpenSettingsMenu;
        public static event Action CloseSettingsMenu;

        public static event Action<PlayerSettings> PlayerSettingsLoaded;

        public static void RequestGameStartup()
        {
            GameStartupRequested?.Invoke();
        }

        public static void FinishGameStartup()
        {
            GameStartupFinished?.Invoke();
        }

        public static void LoadPlayerSettings(PlayerSettings settings)
        {
            PlayerSettingsLoaded?.Invoke(settings);
        }
    }
}

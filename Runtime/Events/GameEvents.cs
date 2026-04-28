using System;
using CursedDepths.Core.Settings;

namespace CursedDepths.Core.Events
{
    public static class GameEvents
    {
        public static event Action GameStartupRequested;
        public static event Action GameStartupFinished;
        public static event Action OpenSettingsMenu;
        public static event Action<PlayerSettings> CloseSettingsMenu;

        public static void RequestGameStartup()
        {
            GameStartupRequested?.Invoke();
        }

        public static void FinishGameStartup()
        {
            GameStartupFinished?.Invoke();
        }

        public static void OpenSettings()
        {
            OpenSettingsMenu?.Invoke();
        }

        public static void CloseSettings()
        {
            CloseSettingsMenu?.Invoke();
        }
    }
}

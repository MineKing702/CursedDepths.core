using CursedDepths.Core.Settings;

public class SettingsLoadedEventArgs
{
    public PlayerSettings playerSettings;

    public SettingsLoadedEventArgs(PlayerSettings playerSettings)
    {
        this.playerSettings = playerSettings;
    }
}

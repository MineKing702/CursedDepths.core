using CursedDepths.Core.Settings;

public class SettingsSavedEventArgs
{
    public PlayerSettings playerSettings;

    public SettingSavedEventArgs(PlayerSettings playerSettings)
    {
        this.playerSettings = playerSettings;
    }
}

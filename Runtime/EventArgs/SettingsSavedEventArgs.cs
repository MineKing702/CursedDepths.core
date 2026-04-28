using CursedDepths.Core.Settings;

public class SettingsSavedEventArgs
{
    public PlayerSettings playerSettings;

    public SettingsSavedEventArgs(PlayerSettings playerSettings)
    {
        this.playerSettings = playerSettings;
    }
}

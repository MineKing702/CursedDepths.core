using CursedDepths.Core.Settings;

public class ClosedSettingsMenuEventArgs
{ 
    public PlayerSettings playerSettings;

    public ClosedSettingsMenuEventArgs(PlayerSettings playerSettings)
    {
        this.playerSettings = playerSettings;
    }
}

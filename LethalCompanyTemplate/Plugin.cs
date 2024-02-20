using BepInEx;

namespace LethalCompanyTemplate
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string modGUID = "VNicoceli.TestMod";
        private const string modName = "To Be Created";
        private const string modVersion = "1.0.0";

        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {modGUID} is loaded!");
        }
    }
}
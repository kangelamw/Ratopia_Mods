using BepInEx;
using HarmonyLib;
using System.Linq;

namespace Ratopia_ResearchUnlocked;

[BepInPlugin("com.angela.ratopia.researchunlocked",
             "Ratopia_ResearchUnlocked",
             "1.0.0")]
public class Plugin : BaseUnityPlugin
{
    private void Awake()
    {
        var harmony = new Harmony("com.angela.ratopia.researchunlocked");
        harmony.PatchAll();                                // apply everything in this DLL
        Logger.LogInfo($"[Ratopia] Patched {harmony.GetPatchedMethods().Count()} methods.");
    }
}
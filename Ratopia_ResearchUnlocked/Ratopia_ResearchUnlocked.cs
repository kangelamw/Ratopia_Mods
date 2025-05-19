using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace Ratopia_ResearchUnlocked;

[HarmonyPatch(typeof(CheatMgr), "Start")]
static class CheatMgr_Start_Patch
{
    static void Postfix(CheatMgr __instance)
    {
        __instance.Unlock_All_ResearchBtn();
        UnityEngine.Debug.Log("[Ratopia] All research unlocked (CheatMgr.Start).");
    }
}
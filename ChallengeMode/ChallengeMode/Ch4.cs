using System;
using HarmonyLib;
using UnityEngine;

namespace ChallengeMode
{
    [HarmonyPatch(typeof(MenuController))]
    [HarmonyPatch("LoadChapter4NowFromStart")]
    class Ch4
    {
        static bool Prefix()
        {
            FractalSave.SaveKey("Current_Ammo", 1);
            FractalSave.SaveLevelKey("Current_Ammo", 1);
            return true;
        }
    }
}

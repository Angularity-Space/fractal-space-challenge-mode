using System;
using HarmonyLib;
using UnityEngine;

namespace ChallengeMode
{
    [HarmonyPatch(typeof(MenuController))]
    [HarmonyPatch("LoadChapter3NowFromStart")]
    class Ch3
    {
        static bool Prefix()
        {
            FractalSave.SaveKey("Current_Ammo", 1);
            FractalSave.SaveLevelKey("Current_Ammo", 1);
            return true;
        }
    }
}

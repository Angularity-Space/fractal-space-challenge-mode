using System;
using HarmonyLib;
using UnityEngine;

namespace ChallengeMode
{
    [HarmonyPatch(typeof(MenuController))]
    [HarmonyPatch("LoadChapter1NowFromStart")]
    class LimitChaptersLoadOut
    {
        static bool Prefix()
        {
            FractalSave.SaveKey("Current_MaxAmmo", 1);
            FractalSave.SaveLevelKey("Current_MaxAmmo", 1);
            return true;
        }
    }
}

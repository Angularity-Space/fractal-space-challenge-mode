using System;
using UnityEngine;
using HarmonyLib;

namespace ChallengeMode
{
    [HarmonyPatch(typeof(FractalSave))]
    [HarmonyPatch("CanRequestQuickLoadLastCheckpoint")]
    class CheckPointLockOne
    {
        static bool Prefix()
        {
            return false;
        }
    }
}

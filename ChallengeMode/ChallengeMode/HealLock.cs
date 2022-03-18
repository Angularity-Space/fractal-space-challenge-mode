using System;
using HarmonyLib;
using UnityEngine;

namespace ChallengeMode
{
    [HarmonyPatch(typeof(Controls))]
    [HarmonyPatch("HealRequested")]
    class HealLock
    {
        static bool Prefix()
        {
            return false;
        }
    }
}

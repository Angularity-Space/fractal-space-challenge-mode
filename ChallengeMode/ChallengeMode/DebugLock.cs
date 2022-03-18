using System;
using HarmonyLib;
using UnityEngine;

namespace ChallengeMode
{
    [HarmonyPatch(typeof(Controls))]
    [HarmonyPatch("ToggleDevMode")]
    class DebugLock
    {
        static bool Prefix()
        {
            return false;
        }
    }
}

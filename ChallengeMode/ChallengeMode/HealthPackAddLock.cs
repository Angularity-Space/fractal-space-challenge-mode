using UnityEngine;
using HarmonyLib;
using System;

namespace ChallengeMode
{
    [HarmonyPatch(typeof(Controls))]
    [HarmonyPatch("AddHealthPackToInventory")]
    class HealthPackAddLock
    {
        static bool Prefix()
        {
            return false;
        }
    }
}

using System;
using UnityEngine;
using HarmonyLib;

namespace ChallengeMode
{
    [HarmonyPatch(typeof(Controls))]
    [HarmonyPatch("GetDefaultFOV")]
    class GravityBN
    {
        static AccessTools.FieldRef<Controls, float> gravityRef = AccessTools.FieldRefAccess<Controls, float>("worldGravity");
        static bool Prefix(Controls __instance)
        {
            gravityRef(__instance) = -16.81f;
            return true;
        }
    }
}

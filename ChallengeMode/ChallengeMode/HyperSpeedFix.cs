using System;
using HarmonyLib;
using UnityEngine;

namespace ChallengeMode
{
    [HarmonyPatch(typeof(TimeManipulator))]
    [HarmonyPatch("IsCurrentlyActive")]
    class HyperSpeedFix
    {
        static AccessTools.FieldRef<TimeManipulator, float> healthconsRef = AccessTools.FieldRefAccess<TimeManipulator, float>("healthConsumption");
        static AccessTools.FieldRef<TimeManipulator, float> requiredhelRef = AccessTools.FieldRefAccess<TimeManipulator, float>("m_minimumHealthToEnable");
        static bool Prefix(TimeManipulator __instance, ref bool ___m_isActive)
        {
            healthconsRef(__instance) = 0.05f;
            requiredhelRef(__instance) = 0.10f;
            return ___m_isActive;

        }
    }
}

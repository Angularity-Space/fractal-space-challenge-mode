using System;
using HarmonyLib;
using UnityEngine;

namespace ChallengeMode
{
    [HarmonyPatch(typeof(Controls))]
    [HarmonyPatch("HealCharacter")]
    class HealCharacter
    {
        static bool Prefix()
        {
            return false;
        }
    }
}

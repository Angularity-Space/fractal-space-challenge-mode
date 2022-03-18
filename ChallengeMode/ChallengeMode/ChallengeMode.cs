using UnityEngine;
using BepInEx;
using HarmonyLib;
using FractalSpace;
using System;
using UnityEngine.Networking;

namespace ChallengeMode
{
    [BepInPlugin("wilburgray.challengemode", "Challenge Mode", "1.0.0.0")]
    [BepInProcess("Fractal_Space.exe")]
    public class ChallengeMode : BaseUnityPlugin
    {
        private readonly Harmony harmony = new Harmony("wilburgray.challengemode");
        void Awake()
        {
            harmony.PatchAll();
        }
    }
}

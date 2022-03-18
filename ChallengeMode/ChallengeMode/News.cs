//using System;
//using HarmonyLib;
//using UnityEngine;

//namespace ChallengeMode
//{
//    [HarmonyPatch(typeof(MenuController))]
//    [HarmonyPatch("GetLatestNewsText")]
//    class News
//    {
//        static bool Prefix(ref UILabel ___latestNewsLabel)
//        {
//            ___latestNewsLabel.text = "Welcome to [FC3503]Hell itself[-]\nFractal Space Challenge Mode is a community mod, which drops you into a challenge, in which:\n[6BFC03]-[-] Healthpacks Backpack is [FC3503]not working![-];\n[6BFC03]-[-] Healthpacks themself are [FC3503]not working![-];\n[6BFC03]-[-] Terminals are [FC3503]not working![-];\n[6BFC03]-[-] Debug is [FC3503]not working![-]\nSo, sit back, and experience the hell.\n[6BFC03]-WilburGray from Angularity Space team.[-]";
//            return false;

//        }
//    }
//}

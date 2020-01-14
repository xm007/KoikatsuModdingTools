﻿using System.Collections.Generic;

namespace IllusionMods.KoikatuModdingTools
{
    internal static class Constants
    {
        internal const string ModsPath = @"Assets\Mods";
        internal const string ExamplesPath = @"Assets\Examples";
        internal const string SB3UtilityScriptPath = @"Tools\SB3UGS\SB3UtilityScript.exe";

        internal static readonly Dictionary<string, string> ShaderABs = new Dictionary<string, string>() { { "Shader Forge/main_item", @"chara\ao_arm_00.unity3d" } };
        internal static readonly HashSet<string> GameNameList = new HashSet<string>() { "koikatsu", "koikatu", "コイカツ" };
    }
}
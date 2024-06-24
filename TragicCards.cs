using BepInEx;
using RarityLib.Utils;
using Tragic.cards;
using UnboundLib;
using UnboundLib.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using RarityLib.Utils;
using System;

namespace Tragic
{
    [BepInDependency("root.rarity.lib", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch",
BepInDependency.DependencyFlags.HardDependency)]

    [BepInPlugin("TRGC", "Tragc", "1.0.0")]

    [BepInProcess("Rounds.exe")]
    public class Tragic : BaseUnityPlugin
    {
        private const string ModId = "Tragic";
        private const string ModName = "TragicCards";
        public const string Version = "1.0.0";
        public const string ModInitials = "TRGC";
        public static Tragic ins { get; private set; }
        void Awake()
        {

            var harmony = new Harmony(ModId);
            harmony.PatchAll();

        }

        void Start()
        {
            CustomCard.BuildCard<BarfRounds>();
            CustomCard.BuildCard<TheLord>();
            CustomCard.BuildCard<BarrageCloud>();
            CustomCard.BuildCard<BlownAway>();
            CustomCard.BuildCard<BlockTrouble>();
            CustomCard.BuildCard<Combat_Medic>();
            CustomCard.BuildCard<Corodeable>();
            CustomCard.BuildCard<DoubleRisk>();
            CustomCard.BuildCard<HealthPack>();
            CustomCard.BuildCard<Hoppy_Health>();
            CustomCard.BuildCard<Hostest>();
            CustomCard.BuildCard<Regen_God>();
            CustomCard.BuildCard<Smash>();
            CustomCard.BuildCard<Sniper>();
            CustomCard.BuildCard<Snuff>();
            CustomCard.BuildCard<SpeedDrink>();
            CustomCard.BuildCard<SpeedReload>();
            CustomCard.BuildCard<TheRock>();
            CustomCard.BuildCard<TheWheelOfLuck>();
            CustomCard.BuildCard<UltimatePowerCard>();
            CustomCard.BuildCard<Vamp>();
            CustomCard.BuildCard<TripleDamage>();
            CustomCard.BuildCard<DoubleDamage>();
            CustomCard.BuildCard<LifeGain>();
            CustomCard.BuildCard<FullReset>();
            ///CustomCard.BuildCard<>();
            ins = this;
        }
    }

}
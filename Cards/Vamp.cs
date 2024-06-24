using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using RarityLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;

namespace Tragic.cards
{
    class Vamp : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            statModifiers.health = 0.5f;
            statModifiers.movementSpeed = 1.25f;
            statModifiers.lifeSteal = 20f;



            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {

            List<ObjectsToSpawn> list = gun.objectsToSpawn.ToList();
            ObjectsToSpawn item = ((GameObject)Resources.Load("0 cards/Parasite")).GetComponent<Gun>().objectsToSpawn[0];
            list.Add(item);
            gun.objectsToSpawn = list.ToArray();
            gun.projectileColor = Color.blue;
            
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
        }

        protected override string GetTitle()
        {
            return " Vamp";
        }
        protected override string GetDescription()
        {
            return "Im your fear!";
        }
        protected override GameObject GetCardArt()
        {
            return null;
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return RarityUtils.GetRarity("Rare");
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = " Life Steal ",
                    amount = ""
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "  Health  ",
                    amount = "-50%"
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = " Movement Speed  ",
                    amount = "+25%"
                },



            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.EvilPurple;
        }
        public override string GetModName()
        {
            return Tragic.ModInitials;
        }
    }
}
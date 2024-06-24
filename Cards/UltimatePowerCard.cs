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
    class UltimatePowerCard : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            cardInfo.cardName = "Ultimate Power Card";
            cardInfo.cardDestription = "Grants ultimate power to the player.";
            cardInfo.categories = new CardCategory[1] { CustomCardCategories.instance.CardCategory("Power") };

            gun.damage = 1.5f;
            gun.reloadTime = 0.1f;
            
            

            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {

            //Edits values on player when card is selected
            data.health = 1000f;
            data.maxHealth = 1000f;
            gun.projectileColor = Color.red;
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
        }

        protected override string GetTitle()
        {
            return " Ultimate Power Play";
        }
        protected override string GetDescription()
        {
            return "Grants ultimate power to the player";
        }
        protected override GameObject GetCardArt()
        {
            return null;
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return RarityUtils.GetRarity("Legendary");
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = " DMG ",
                    amount = "+100%"
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = " Reload Time ",
                    amount = "+10%"
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = " Health ",
                    amount = "1000"
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
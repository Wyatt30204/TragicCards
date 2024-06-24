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
    class Sniper : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            gun.damage += 1f;
            gun.attackSpeed = 1.75f;
            gun.ammo -= 2;
            gun.reloadTime = 1.75f;


            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {

            //Edits values on player when card is selected
            gun.projectileColor = Color.white;
            gun.projectileSpeed = 5f;
            List<ObjectsToSpawn> list = gun.objectsToSpawn.ToList();
            ObjectsToSpawn item = ((GameObject)Resources.Load("0 cards/Explosive bullet")).GetComponent<Gun>().objectsToSpawn[0];
            list.Add(item);
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
        }

        protected override string GetTitle()
        {
            return " Sniper";
        }
        protected override string GetDescription()
        {
            return "o fast 1 Bullet all I need!";
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
                    stat = "DMG ",
                    amount = "+100%"
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Reload Time  ",
                    amount = "-75%"
                },
                 new CardInfoStat()
                {
                    positive = true,
                    stat = "Attack Speed ",
                    amount = "-75%"
                },



            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.DestructiveRed;
        }
        public override string GetModName()
        {
            return Tragic.ModInitials;
        }
    }
}
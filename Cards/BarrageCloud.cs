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
    class BarrageCloud : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            gun.attackSpeed -= 0.8f;
            gun.damage = -0.6f;
            gun.ammo = 4;
            gun.spread = 0.2f;
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            List<ObjectsToSpawn> list = gun.objectsToSpawn.ToList();
            ObjectsToSpawn item = ((GameObject)Resources.Load("0 cards/Toxic cloud")).GetComponent<Gun>().objectsToSpawn[0];
            list.Add(item);
            gun.objectsToSpawn = list.ToArray();
            gun.projectileColor = Color.black;
            //Edits values on player when card is selected
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
        }

        protected override string GetTitle()
        {
            return "Barrage Cloud";
        }
        protected override string GetDescription()
        {
            return "Hmmmm Barrage of shits";
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
                    stat = "DMG",
                    amount = "-60%",
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Clouds",
                    amount = "1",
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = " Ammo",
                    amount = "+4",
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Attack Speed ",
                    amount = "+80%"
                },
                new CardInfoStat()
               
                
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.TechWhite;
        }
        public override string GetModName()
        {
            return Tragic.ModInitials;
        }
    }
}                                                   
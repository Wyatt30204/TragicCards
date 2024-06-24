using ModdingUtils.Utils;
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
    class TheLord : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            gun.attackSpeed = 0.04f;
            gun.ammoReg = 0.09f;
            gun.spread = 0.2f;
            gun.damage = 0.25f;
            gun.reloadTime = 2f;
            block.additionalBlocks = 2;
            block.autoBlock = true;
            block.cooldown = 0.4f;
            gun.ammo = 10;


            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Edits values on player when card is selected
            Cards.instance.AddCardToPlayer(player, Cards.instance.GetCardWithObjectName("Silence"), reassign: true, "SL", 0f, 0f, addToCardBar: false);
            Cards.instance.AddCardToPlayer(player, Cards.instance.GetCardWithObjectName("Shield Charge"), reassign: true, "SC", 0f, 0f, addToCardBar: false);
            List<ObjectsToSpawn> list = gun.objectsToSpawn.ToList();
            ObjectsToSpawn item = ((GameObject)Resources.Load("0 cards/Radiance")).GetComponent<Gun>().objectsToSpawn[0];
            list.Add(item);
            gun.objectsToSpawn = list.ToArray();
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
        }
        protected override string GetTitle()
        {
            return "TheLord";
        }
        protected override string GetDescription()
        {
            return "All Hail The Lord";
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
                    stat = "Chaos",
                    amount = "OP or Weak",
                },
               
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.MagicPink;
        }
        public override string GetModName()
        {
            return Tragic.ModInitials;
        }
    }
}
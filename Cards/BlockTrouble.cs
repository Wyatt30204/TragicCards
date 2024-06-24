﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;

namespace Tragic.cards
{
    class BlockTrouble : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {

             statModifiers.movementSpeed = 1.3f;
            statModifiers.health = 1.4f;

            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            
            block.additionalBlocks = 1;
            block.cooldown = 1.05f;

            List<ObjectsToSpawn> list = gun.objectsToSpawn.ToList();
            ObjectsToSpawn item = ((GameObject)Resources.Load("0 cards/Healing field")).GetComponent<Gun>().objectsToSpawn[0];
            list.Add(item);
            gun.objectsToSpawn = list.ToArray();
            //Edits values on player when card is selected
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player


        }

        protected override string GetTitle()
        {
            return "BlockTrouble";
        }
        protected override string GetDescription()
        {
            return "The Block Demi-god";
        }
        protected override GameObject GetCardArt()
        {
            return null;
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Rare;
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Movement Speed",
                    amount = "+30%",
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
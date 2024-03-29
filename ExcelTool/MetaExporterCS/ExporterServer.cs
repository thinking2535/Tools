﻿using rso.excel;
using System;
using System.Collections.Generic;
using bb;

namespace MetaExporterCS
{
    public static class ExporterServer
    {
        public static List<Enum> Enums = new List<Enum>();

        public static void Export()
        {
            Enums.Add(default(ECashItemType));
            Enums.Add(default(EResource));
            Enums.Add(default(EGrade));
            Enums.Add(default(ERank));
            Enums.Add(default(EQuestType));
            Enums.Add(default(EArrowDodgeItemType));
            Enums.Add(default(EFlyAwayItemType));

            using (var MetaFile = new CExcel(Enums, "bin", 0))
            {
                String DataPath = "../../../Server/Bin/GameServer/MetaData";

                // Server Meta Datas ////////////////////////////////////////////////////////////////////////////////////////////////////
                Console.WriteLine("Exporting Server Meta Data");

                MetaFile.Open("MetaDataXLS/Config.xlsx");
                MetaFile.Export<SConfigMeta>("Config", DataPath);

                MetaFile.Open("MetaDataXLS/ForbiddenWord.xlsx");
                MetaFile.Export<SForbiddenWordMeta>("ForbiddenWord", DataPath);

                MetaFile.Open("MetaDataXLS/Char.xlsx");
                MetaFile.Export<SCharacterServerMeta>("Character", DataPath);
                MetaFile.Export<SCharacterGradeMeta>("CharacterGrade", DataPath);

                MetaFile.Open("MetaDataXLS/Reward.xlsx");
                MetaFile.Export<SCodeRewardItemMeta>("RewardItem", DataPath);

                MetaFile.Open("MetaDataXLS/Shop.xlsx");
                MetaFile.Export<SShopConfigServerMeta>("ShopConfig", DataPath);
                MetaFile.Export<SShopMeta>("Shop", DataPath);
                MetaFile.Export<SShopPackageServerMeta>("ShopPackage", DataPath);
                MetaFile.Export<SShopDailyRewardServerMeta>("ShopDailyReward", DataPath);
                MetaFile.Export<ShopExchangeMeta>("ShopExchange", DataPath);

                MetaFile.Open("MetaDataXLS/Rank.xlsx");
                MetaFile.Export<SRankMeta>("Rank", DataPath);
                MetaFile.Export<SRankTierMeta>("RankTier", DataPath);
                MetaFile.Export<SRankRewardMeta>("RankReward", DataPath);

                MetaFile.Open("MetaDataXLS/Gacha.xlsx");
                MetaFile.Export<SGachaMeta>("Gacha", DataPath);
                MetaFile.Export<SGachaGradeMeta>("GachaGrade", DataPath);
                MetaFile.Export<SGachaRewardMeta>("GachaReward", DataPath);

                MetaFile.Open("MetaDataXLS/Quest.xlsx");
                MetaFile.Export<SQuestMeta>("Quest", DataPath);
                MetaFile.Export<SQuestDailyCompleteMeta>("QuestDailyComplete", DataPath);

                MetaFile.Open("MetaDataXLS/Battle.xlsx");
                MetaFile.Export<SBattleRewardMeta>("BattleReward", DataPath);
                MetaFile.Export<SMultiMeta>("Multi", DataPath);
                MetaFile.Export<SMultiMatchDeniedDurationMeta>("MultiMatchDeniedDuration", DataPath);
                MetaFile.Export<SArrowDodgeMeta>("ArrowDodge", DataPath);
                MetaFile.Export<SArrowDodgeItemMeta>("ArrowDodgeItem", DataPath);
                MetaFile.Export<SFlyAwayMeta>("FlyAway", DataPath);
                MetaFile.Export<SFlyAwayItemMeta>("FlyAwayItem", DataPath);

                MetaFile.Open("MetaDataXLS/Coupon.xlsx");
                MetaFile.Export<SCouponMeta>("Coupon", DataPath);
                MetaFile.Export<SCouponKeyMeta>("CouponKey", DataPath);

                MetaFile.Open("MetaDataXLS/Ranking.xlsx");
                MetaFile.Export<SRankingConfigMeta>("RankingConfig", DataPath);
                MetaFile.Export<SRankingRewardMeta>("RankingReward", DataPath);
            }
        }
    }
}

using rso.excel;
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
            Enums.Add(default(ERewardType));
            Enums.Add(default(ERank));
            Enums.Add(default(EQuestType));
            Enums.Add(default(EGameMode));

            using (var MetaFile = new CExcel(Enums, "bin", 0))
            {
                // Server Meta Datas ////////////////////////////////////////////////////////////////////////////////////////////////////
                Console.WriteLine("Exporting Server Meta Data");

                MetaFile.Open("MetaDataXLS/Config.xlsx");
                MetaFile.Export<SConfigMeta>("Config", "../../../Server/Bin/GameServer/MetaData");

                MetaFile.Open("MetaDataXLS/Single.xlsx");
                MetaFile.Export<SSingleMeta>("Single", "../../../Server/Bin/GameServer/MetaData");
                MetaFile.Export<SIslandMeta>("Island", "../../../Server/Bin/GameServer/MetaData");

                MetaFile.Open("MetaDataXLS/ForbiddenWord.xlsx");
                MetaFile.Export<SForbiddenWordMeta>("ForbiddenWord", "../../../Server/Bin/GameServer/MetaData");

                MetaFile.Open("MetaDataXLS/Char.xlsx");
                MetaFile.Export<SCharacterServerMeta>("Character", "../../../Server/Bin/GameServer/MetaData");
                MetaFile.Export<SCharacterGradeMeta>("CharacterGrade", "../../../Server/Bin/GameServer/MetaData");

                MetaFile.Open("MetaDataXLS/Reward.xlsx");
                MetaFile.Export<SKeyRewardMeta>("Reward", "../../../Server/Bin/GameServer/MetaData");

                MetaFile.Open("MetaDataXLS/Shop.xlsx");
                MetaFile.Export<SShopConfigServerMeta>("ShopConfig", "../../../Server/Bin/GameServer/MetaData");
                MetaFile.Export<SShopServerMeta>("Shop", "../../../Server/Bin/GameServer/MetaData");
                MetaFile.Export<SShopPackageServerMeta>("ShopPackage", "../../../Server/Bin/GameServer/MetaData");
                MetaFile.Export<SShopDailyRewardServerMeta>("ShopDailyReward", "../../../Server/Bin/GameServer/MetaData");
                MetaFile.Export<SShopCashServerMeta>("ShopCash", "../../../Server/Bin/GameServer/MetaData");

                MetaFile.Open("MetaDataXLS/Rank.xlsx");
                MetaFile.Export<SRankMeta>("Rank", "../../../Server/Bin/GameServer/MetaData");
                MetaFile.Export<SRankTierMeta>("RankTier", "../../../Server/Bin/GameServer/MetaData");
                MetaFile.Export<SRankRewardMeta>("RankReward", "../../../Server/Bin/GameServer/MetaData");

                MetaFile.Open("MetaDataXLS/Gacha.xlsx");
                MetaFile.Export<SGachaMeta>("Gacha", "../../../Server/Bin/GameServer/MetaData");
                MetaFile.Export<SGachaGradeMeta>("GachaGrade", "../../../Server/Bin/GameServer/MetaData");
                MetaFile.Export<SGachaRewardMeta>("GachaReward", "../../../Server/Bin/GameServer/MetaData");

                MetaFile.Open("MetaDataXLS/Quest.xlsx");
                MetaFile.Export<SQuestMeta>("Quest", "../../../Server/Bin/GameServer/MetaData");
                MetaFile.Export<SQuestDailyCompleteMeta>("QuestDailyComplete", "../../../Server/Bin/GameServer/MetaData");

                MetaFile.Open("MetaDataXLS/Battle.xlsx");
                MetaFile.Export<SBattleRewardMeta>("BattleReward", "../../../Server/Bin/GameServer/MetaData");

                MetaFile.Open("MetaDataXLS/Coupon.xlsx");
                MetaFile.Export<SCouponMeta>("Coupon", "../../../Server/Bin/GameServer/MetaData");
                MetaFile.Export<SCouponKeyMeta>("CouponKey", "../../../Server/Bin/GameServer/MetaData");

                MetaFile.Open("MetaDataXLS/Ranking.xlsx");
                MetaFile.Export<SRankingConfigMeta>("RankingConfig", "../../../Server/Bin/GameServer/MetaData");
                MetaFile.Export<SRankingRewardMeta>("RankingReward", "../../../Server/Bin/GameServer/MetaData");
            }
        }
    }
}

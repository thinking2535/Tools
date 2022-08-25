using rso.core;
using rso.excel;
using rso.game;
using System;
using System.Collections.Generic;
using bb;

namespace MetaExporterCS
{
    public static class ExporterClient
    {
		public static List<Enum> Enums = new List<Enum>();

		public static void Export()
        {
            Enums.Add(default(EText));
            Enums.Add(default(EGameRet));
            Enums.Add(default(EGrade));
            Enums.Add(default(EResource));
            Enums.Add(default(EQuestType));
            Enums.Add(default(EArrowDodgeItemType));
            Enums.Add(default(EFlyAwayItemType));
            Enums.Add(default(ERank));
            Enums.Add(default(ETrackingKey));
            Enums.Add(default(EMultiItemType));
            Enums.Add(default(EStatusType));
            Enums.Add(default(ELanguage));

            using (var MetaFile = new CExcel(Enums, "bytes", 0))
            {
                String DataPath = "../../../Client/Assets/Resources/MetaData";
                ulong CheckSum = 0;

                // Client Meta Datas ////////////////////////////////////////////////////////////////////////////////////////////////////
                Console.WriteLine("Exporting Client Meta Data");

                MetaFile.Open("MetaDataXLS/Config.xlsx");
                CheckSum ^= MetaFile.Export<SConfigMeta>("Config", DataPath);

                MetaFile.Open("MetaDataXLS/ForbiddenWord.xlsx");
                CheckSum ^= MetaFile.Export<SForbiddenWordMeta>("ForbiddenWord", DataPath);

                MetaFile.Open("MetaDataXLS/Char.xlsx");
                CheckSum ^= MetaFile.Export<SCharacterClientMeta>("Character", DataPath);
                CheckSum ^= MetaFile.Export<SCharacterGradeClientMeta>("CharacterGrade", DataPath);

                MetaFile.Open("MetaDataXLS/Shop.xlsx");
                CheckSum ^= MetaFile.Export<SShopConfigServerMeta>("ShopConfig", DataPath);
                CheckSum ^= MetaFile.Export<SShopClientMeta>("Shop", DataPath);
                CheckSum ^= MetaFile.Export<SShopPackageClientMeta>("ShopPackage", DataPath);
                CheckSum ^= MetaFile.Export<SShopPackageDateMeta>("ShopPackageDate", DataPath);
                CheckSum ^= MetaFile.Export<ShopExchangeMeta>("ShopExchange", DataPath);

                MetaFile.Open("MetaDataXLS/Quest.xlsx");
                CheckSum ^= MetaFile.Export<QuestTypeKeyValueMeta>("QuestType", DataPath);
                CheckSum ^= MetaFile.Export<SQuestMeta>("Quest", DataPath);
                CheckSum ^= MetaFile.Export<SQuestDailyCompleteMeta>("QuestDailyComplete", DataPath);

                MetaFile.Open("MetaDataXLS/Battle.xlsx");
                CheckSum ^= MetaFile.Export<SArrowDodgeMeta>("ArrowDodge", DataPath);
                CheckSum ^= MetaFile.Export<SArrowDodgeItemMeta>("ArrowDodgeItem", DataPath);
                CheckSum ^= MetaFile.Export<SFlyAwayMeta>("FlyAway", DataPath);
                CheckSum ^= MetaFile.Export<SFlyAwayItemMeta>("FlyAwayItem", DataPath);

                MetaFile.Open("MetaDataXLS/Rank.xlsx");
                CheckSum ^= MetaFile.Export<SRankTierClientMeta>("RankTier", DataPath);
                CheckSum ^= MetaFile.Export<SRankRewardMeta>("RankReward", DataPath);

                MetaFile.Open("MetaDataXLS/Reward.xlsx");
                CheckSum ^= MetaFile.Export<SCodeRewardClientMeta>("Reward", DataPath);
                CheckSum ^= MetaFile.Export<SCodeRewardItemMeta>("RewardItem", DataPath);

                MetaFile.Open("MetaDataXLS/Gacha.xlsx");
                CheckSum ^= MetaFile.Export<SGachaClientMeta>("Gacha", DataPath);
                CheckSum ^= MetaFile.Export<SGachaRewardClientMeta>("GachaReward", DataPath);
                CheckSum ^= MetaFile.Export<SGachaGradeMeta>("GachaGrade", DataPath);

                MetaFile.Open("MetaDataXLS/Tracking.xlsx");
                CheckSum ^= MetaFile.Export<STrackingMeta>("Tracking", DataPath);

                MetaFile.Open("MetaDataXLS/Ranking.xlsx");
                CheckSum ^= MetaFile.Export<SRankingRewardMeta>("RankingReward", DataPath);

                string[] language = new string[Enum.GetValues(typeof(ELanguage)).Length];
                foreach (ELanguage enumItem in Enum.GetValues(typeof(ELanguage)))
                {
                    if (enumItem == ELanguage.Max) continue;
                    language[(int)enumItem + 1] = enumItem.ToString();
                }

                MetaFile.Open("MetaDataXLS/Text.xlsx");
                language[0] = "TextName";
                CheckSum ^= MetaFile.Export<STextMeta>("Text", DataPath, language);
                language[0] = "GameRetName";
                CheckSum ^= MetaFile.Export<SLanguageTextMeta>("LanguageText", DataPath);
                CheckSum ^= MetaFile.Export<SGameRetMeta>("GameRet", DataPath, language);
                CheckSum ^= MetaFile.Export<SServerAlarmMeta>("ServerAlarm", DataPath);


                var Stream = new CStream();
                Stream.Push(CheckSum);
                Stream.SaveFile("../../../Server/Bin/GameServer/MetaData/Checksum.bin");
                Stream.SaveFile(DataPath + "/Checksum.bytes");

                Console.WriteLine("Checksum : " + CheckSum.ToString());


                Console.WriteLine("Exporting Done !!!");
                Console.WriteLine("Press Any Key To Close.");
                Console.ReadKey();
            }
        }
    }
}

using TSize = System.Int32;
using TCheckSum = System.UInt64;
using TUID = System.Int64;
using TPeerCnt = System.UInt32;
using TLongIP = System.UInt32;
using TPort = System.UInt16;
using TPacketSeq = System.UInt64;
using TSessionCode = System.Int64;
using SRangeUID = rso.net.SRangeKey<System.Int64>;
using TVer = System.SByte;
using TID = System.String;
using TNick = System.String;
using TMessage = System.String;
using TState = System.Byte;
using TServerNets = System.Collections.Generic.HashSet<rso.game.SServerNet>;
using TMasterNets = System.Collections.Generic.List<rso.game.SMasterNet>;
using TFriendDBs = System.Collections.Generic.Dictionary<System.Int64,rso.game.SFriendDB>;
using TFriends = System.Collections.Generic.Dictionary<System.Int64,rso.game.SFriend>;
using TUIDFriendInfos = System.Collections.Generic.List<rso.game.SUIDFriendInfo>;
using TFriendInfos = System.Collections.Generic.Dictionary<System.Int64,rso.game.SFriendInfo>;
using TCode = System.Int32;
using TIndex = System.Int64;
using TLevel = System.Int32;
using THP = System.Int32;
using TSlotNo = System.SByte;
using TExp = System.Int32;
using TRank = System.Int32;
using TTeamCnt = System.SByte;
using TQuestSlotIndex = System.Byte;
using TRankingUsers = System.Collections.Generic.List<bb.SRankingUser>;
using TRankingRewards = System.Collections.Generic.Dictionary<System.Int64,System.Int32>;
using TResource = System.Int32;
using TDoneQuests = System.Collections.Generic.List<bb.SQuestSlotIndexCount>;
using TChars = System.Collections.Generic.HashSet<System.Int32>;
using TQuestDBs = System.Collections.Generic.Dictionary<System.Byte,bb.SQuestBase>;
using TPackages = System.Collections.Generic.HashSet<System.Int32>;
using TTeamIndexGroup = System.Collections.Generic.List<System.SByte>;
using TQuestSlotIndexCodes = System.Collections.Generic.List<bb.SQuestSlotIndexCode>;
using TPoses = System.Collections.Generic.List<rso.physics.SPoint>;
using System;
using System.Collections.Generic;
using rso.core;


namespace bb
{
	using rso.net;
	using rso.game;
	using rso.physics;
	public enum ETrackingKey
	{
		apple_login,
		facebook_login,
		google_login,
		guest_login,
		guest_to_apple,
		guest_to_facebook,
		guest_to_google,
		ads_dailyquest_result,
		ads_quest,
		ads_result_dodge,
		ads_result_island,
		ads_shop_free,
		ads_shop_free_1,
		ads_shop_free_10,
		ads_shop_free_3,
		ads_shop_free_5,
		unblock_character,
		dailyquest_ad_view,
		quest_reward_complete_1,
		quest_reward_complete_3,
		quest_reward_complete_5,
		quest_reward_complete_7,
		quest_reward_complete_daily,
		earn_keycoin,
		earn_ruby_reward,
		cancel_multiplay,
		cancel_multiplay_startsingle,
		oneone_select,
		oneone_select_r2,
		oneone_select_total,
		singleplay_select_arrow,
		singleplay_select_arrow_r2,
		singleplay_select_arrow_total,
		singleplay_select_arrowM,
		singleplay_select_arrowM_r2,
		singleplay_select_arrowM_total,
		singleplay_select_island,
		singleplay_select_island_r2,
		singleplay_select_island_total,
		singleplay_select_islandM,
		singleplay_select_islandM_r2,
		singleplay_select_islandM_total,
		survival3pplay_select,
		survival3pplay_select_r2,
		survival3pplay_select_total,
		survivalplay_select,
		survivalplay_select_r2,
		survivalplay_select_total,
		teamplay_select_team2,
		teamplay_select_team2_r2,
		teamplay_select_team2_total,
		teamplay_select_teamB,
		teamplay_select_teamB_r2,
		teamplay_select_teamB_total,
		bronze_rank_1,
		bronze_rank_2,
		bronze_rank_3,
		bronze_rank_4,
		bronze_rank_5,
		champion_rank_1,
		champion_rank_2,
		champion_rank_3,
		champion_rank_4,
		champion_rank_5,
		dia_rank_1,
		dia_rank_2,
		dia_rank_3,
		dia_rank_4,
		dia_rank_5,
		gold_rank_1,
		gold_rank_2,
		gold_rank_3,
		gold_rank_4,
		gold_rank_5,
		silver_rank_1,
		silver_rank_2,
		silver_rank_3,
		silver_rank_4,
		silver_rank_5,
		unrank_1,
		unrank_2,
		unrank_3,
		unrank_4,
		unrank_5,
		weekly_ranking_reward,
		buy_gacha,
		gold_1050,
		gold_2900,
		gold_380,
		gold_6780,
		pay_characterbox,
		pay_package,
		spend_gold_gacha,
		spend_gold_singlecharge,
		spend_keycoin,
		spend_ruby_shop,
		title_end,
		tutorial_1,
		tutorial_2,
		tutorial_3,
		tutorial_4,
		Max,
		Null,
	}
	public enum EText
	{
		VsThree,
		LoginScene_MakeNickName,
		Global_Input_PlaceHolder,
		Global_Button_Make,
		Global_Button_Ok,
		Global_Button_Cancel,
		Global_Button_Confirm,
		Global_Popup_GameExit,
		Global_Grade_Normal,
		Global_Grade_Rare,
		Global_Grade_Epic,
		Global_Text_Ranking,
		Global_Text_Rank,
		LobbyScene_BonusStage,
		LobbyScene_Survival_Normal,
		LobbyScene_Team,
		LobbyScene_Play,
		CharacterSelectScene_Select,
		Character_Name_Kiwibird,
		Character_Name_Chick,
		Character_Name_Duckling,
		Character_Name_ShibaInu,
		Character_Name_Poodle,
		Character_Name_Turtle,
		Character_Name_Panda,
		Character_Name_Polarbear,
		Character_Name_Brownbear,
		Character_Name_Gorilla,
		Character_Name_YeTigorilla,
		Character_Name_Greenfrog,
		Character_Name_Hen,
		Character_Name_Rooster,
		Character_Name_Crowtit,
		Character_Name_Hummingbird,
		Character_Name_Gull,
		Character_Name_Macaw,
		Character_Name_Woodpecker,
		Character_Name_BigbilledBird,
		Character_Name_Eagle,
		Character_Name_Owl,
		Character_Name_Chimmy,
		Character_Name_Tata,
		Character_Name_Brown,
		Character_Name_Cony,
		ResultScene_Text_Win,
		ResultScene_Text_Lose,
		ResultScene_Text_Result,
		Character_Requirement_Kiwibird,
		CharacterSelectScene_Select_NotHave,
		MyInfoScene_MaxWinPoint,
		MyInfoScene_BestPlay,
		MyInfoScene_PersonalWin,
		MyInfoScene_TeamWin,
		LobbyScene_UserID,
		Global_Button_On,
		Global_Button_Off,
		OptionScene_Music,
		OptionScene_EffectSound,
		OptionScene_Invite_title,
		OptionScene_Facebook,
		OptionScene_Line,
		OptionScene_Kakao,
		OptionScene_Terms,
		OptionScene_Privacy,
		OptionScene_Language,
		OptionScene_Help,
		OptionScene_Setting,
		OptionScene_Vibe,
		OptionScene_LanguageText,
		Global_Popup_LanguageChanage,
		Quest_Team_Play,
		Quest_Team_Victory,
		Quest_Survival_Play,
		Quest_Survival_Victory,
		Quest_Single_Play,
		Quest_Ingame_ConsecutiveKill,
		Quest_Ingame_BalloonPopping,
		Quest_Ingame_Kill,
		Quest_Ingame_BestPlayer,
		Quest_Character_Gacha,
		Quest_Gacha_Common,
		Quest_Gacha_Ruby,
		QuestScene_Title,
		QuestScene_Refresh,
		QuestScene_Next,
		OptionScene_Language_English,
		OptionScene_Language_Korean,
		OptionScene_Language_France,
		OptionScene_Language_Germany,
		OptionScene_Language_Spain,
		OptionScene_Language_Italia,
		OptionScene_Language_ChinaCH,
		OptionScene_Language_ChinaTW,
		OptionScene_Language_Japan,
		OptionScene_Language_Portugal,
		OptionScene_Language_Russia,
		OptionScene_Language_Nederland,
		OptionScene_Language_Turkey,
		OptionScene_Language_Finland,
		OptionScene_Language_Malaysia,
		OptionScene_Language_Thailand,
		OptionScene_Language_Indonesia,
		OptionScene_Language_Vietnam,
		RankingRewardScene_Title,
		RankingRewardScene_Description,
		ShopScene_GachaText,
		ShopScene_GachaFailedText,
		Global_Text_Ticket,
		Global_Text_Gold,
		Global_Text_Dia,
		Global_Popup_ResourceNotEnough,
		Ranke_Unranked_5,
		Ranke_Unranked_4,
		Ranke_Unranked_3,
		Ranke_Unranked_2,
		Ranke_Unranked_1,
		Ranke_Bronze_5,
		Ranke_Bronze_4,
		Ranke_Bronze_3,
		Ranke_Bronze_2,
		Ranke_Bronze_1,
		Ranke_Silver_5,
		Ranke_Silver_4,
		Ranke_Silver_3,
		Ranke_Silver_2,
		Ranke_Silver_1,
		Ranke_Gold_5,
		Ranke_Gold_4,
		Ranke_Gold_3,
		Ranke_Gold_2,
		Ranke_Gold_1,
		Ranke_Diamond_5,
		Ranke_Diamond_4,
		Ranke_Diamond_3,
		Ranke_Diamond_2,
		Ranke_Diamond_1,
		Ranke_Champion_5,
		Ranke_Champion_4,
		Ranke_Champion_3,
		Ranke_Champion_2,
		Ranke_Champion_1,
		Global_Popup_AllStarCharacter,
		QuestScene_Shipping,
		QuestScene_ShippingComplete,
		LobbyScene_Survival,
		Global_Button_Receive,
		RankingRewardScene_Box,
		Character_Name_Trex,
		Character_Name_Crocodile,
		Character_Name_Tamerabbit,
		Character_Name_Hare,
		Character_Name_Deer,
		Character_Name_Reindeer,
		Character_Name_Milkcow,
		Character_Name_Bull,
		Character_Name_Horse,
		Character_Name_Zebra,
		Game_DoubleKill,
		Game_TripleKill,
		Game_QuadraKill,
		Game_LegendaryKill,
		Game_TimeOver,
		Tutorial_Title,
		Global_Button_Next,
		Global_Button_End,
		Global_Popup_Notice,
		Global_Popup_Confirm,
		SceneAccount_Term_Title,
		SceneAccount_Term_Description,
		SceneAccount_Term_TermOfUse,
		SceneAccount_Term_PrivacyPolicy,
		Global_Button_Agree,
		SceneAccount_Login_Title,
		Global_Popup_TermsOfUse_NeedAgree,
		Global_Popup_PrivacyPolicy_NeedAgree,
		Global_Popup_Terms_Cancel,
		CharacterScene_HaveCharacter,
		CharacterScene_NotHaveCharacter,
		RankingServer_Error_Connection,
		RankingServer_Error_Unlink,
		SceneMyInfo_Title,
		SceneLobby_BtnText_Character,
		SceneLobby_BtnText_Shop,
		SceneLobby_BtnText_Quest,
		SceneLobby_BtnText_Ranking,
		Character_Description_Kiwibird,
		Character_Description_Chick,
		Character_Description_Duckling,
		Character_Description_ShibaInu,
		Character_Description_Poodle,
		Character_Description_Turtle,
		Character_Description_Panda,
		Character_Description_Polarbear,
		Character_Description_Brownbear,
		Character_Description_Gorilla,
		Character_Description_YeTigorilla,
		Character_Description_Greenfrog,
		Character_Description_Hen,
		Character_Description_Rooster,
		Character_Description_Crowtit,
		Character_Description_Hummingbird,
		Character_Description_Gull,
		Character_Description_Macaw,
		Character_Description_Woodpecker,
		Character_Description_BigbilledBird,
		Character_Description_Eagle,
		Character_Description_Owl,
		Character_Description_Trex,
		Character_Description_Crocodile,
		Character_Description_Tamerabbit,
		Character_Description_Hare,
		Character_Description_Deer,
		Character_Description_Reindeer,
		Character_Description_Milkcow,
		Character_Description_Bull,
		Character_Description_Horse,
		Character_Description_Zebra,
		SceneMyInfo_NickNameChangeFailed,
		SceneAccount_LoginFailed,
		SceneAccount_LoginCancel,
		SceneAccount_ModuelInitFailed,
		GlobalPopup_Network_Unlink,
		GlobalPopup_Network_Error,
		GlobalPopup_Network_LinkFailed,
		SceneMyInfo_NickNameMakeFailed,
		ResultScene_Text_Draw,
		Global_Button_Change,
		SceneAccount_CautionText,
		Global_Button_QuickStart,
		Global_Button_AccountLink,
		SceneAccount_GuestLogin,
		GlobalPopup_InvalidNickLength,
		Game_FirstHit,
		Quest_BlowBalloon,
		Quest_PlayNormal,
		Quest_PlayRare,
		Quest_PlayEpic,
		Have_ForbiddenWord,
		SceneSetting_Notice,
		GlobalPopup_TermOfUse,
		SceneSetting_Push,
		SceneBattleEnd_BestPlayer,
		SceneLobby_SinglePlay,
		SceenSingle_Wave,
		SceenSingle_Time,
		SceenSingle_Bonus,
		SceneMyInfo_Uid_Copy,
		ShopScene_Gacha,
		ShopScene_Gold,
		ShopScene_Dia,
		ShopPopup_Text_Cancel,
		ShopPopup_Text_Error_Duplicate,
		ShopPopup_Text_Error_Code,
		ShopGoods_Gold1,
		ShopGoods_Gold2,
		ShopGoods_Gold3,
		ShopGoods_Gold4,
		ShopGoods_Dia1,
		ShopGoods_Dia2,
		ShopGoods_Dia3,
		ShopGoods_Dia4,
		ShopGoods_Dia5,
		ShopGoods_Dia6,
		Global_Text_CP,
		SceneCharacterList_UnLockRank,
		SceneCharacterList_UnLockGacha,
		SceneCharacterList_UnLockEvent,
		Character_Name_Fox,
		Character_Name_Cat,
		Character_Name_Tiger,
		Character_Name_Pig,
		Character_Name_Elephant,
		Character_Description_Fox,
		Character_Description_Cat,
		Character_Description_Tiger,
		Character_Description_Pig,
		Character_Description_Elephant,
		GlobalPopup_Text_InvalidVersion,
		GlobalPopup_Button_Update,
		GlobalPopup_Text_SingleCharge,
		GlobalPopup_Text_AdFailed,
		QuestScene_Text_AdBonus,
		QuestScene_Text_AdBonusAlarm,
		QuestScene_Text_GetReward,
		QuestScene_Text_Title,
		QuestScene_Text_DailyMission,
		QuestScene_Text_DailyMissionWating,
		QuestScene_Text_DailyMissionTimer,
		SceenSingle_Score,
		ShopPopup_Text_CharacterRate,
		RankingScene_Multi,
		QuestScene_DailyQuest_NotComplete,
		Quest_PlaySingle,
		Quest_RechargingSingle,
		Quest_SingleWave,
		Quest_SingleTime,
		Quest_SinglePlayGoldGet,
		Quest_SinglePlayScoreGet,
		Quest_SurvivalPlayRanking,
		Quest_RankPointGet,
		QuestScene_Text_Ad_Button,
		Character_Name_Werewolf,
		Character_Name_Mummy,
		Character_Name_Ghost,
		Character_Name_Witch,
		Character_Name_Jackol,
		Character_Name_Bat,
		Character_Description_Werewolf,
		Character_Description_Mummy,
		Character_Description_Ghost,
		Character_Description_Witch,
		Character_Description_Jackol,
		Character_Description_Bat,
		GlobalPopup_Text_ServerCheck,
		GlobalPopup_Text_NoneCp_Character,
		RankingScene_Text_RankPoint,
		RankingScene_Text_TOP100,
		RankingScene_Text_Point,
		ShopScene_Upscale_Gold,
		ShopScene_Upscale_Dia,
		NickNameChange_Description,
		RankingScene_Text_MyRanking,
		GlobalPopup_SameNick,
		ShopGacha_Event_Halloween,
		Firebase_Login_Duplicate,
		SceneSetting_Coupon_Title,
		SceneSetting_Coupon_Button_Send,
		SceneSetting_Coupon_Placeholder,
		SceneSetting_Coupon_Used,
		SceneSetting_Coupon_Not,
		SceneSetting_Coupon_Duplicate,
		SceneMatching_PlayerSearching,
		SceneMatching_ReadyPlayer,
		LobbyScene_Solo,
		Quest_SoloPlay,
		Quest_SoloVictory,
		Character_Status_Sky,
		Character_Status_Land,
		Character_Status_Stamina,
		Character_Status_Pump,
		SceenSingle_ExitPopup,
		SceenSingle_Replay,
		LobbyScene_SelectMode,
		LobbyScene_FlyAway,
		LobbyScene_Dodge,
		ShopScene_Upscale_DailyFree,
		ShopScene_Upscale_LimitedPackage,
		ShopScene_Upscale_Skin,
		ShopScene_Upscale_Balloon,
		ShopScene_Upscale_Hat,
		ShopScene_Popup_CheckBuy,
		ShopScene_Popup_CheckGacha,
		Tutorial_Text_Complete,
		Tutorial_Popup_Skip,
		SceneSetting_Tutorial_Title,
		Skin_Name_Kiwibird,
		Skin_Name_Chick,
		Skin_Name_Duckling,
		Skin_Name_ShibaInu,
		Skin_Name_Poodle,
		Skin_Name_Turtle,
		Skin_Name_Panda,
		Skin_Name_Polarbear,
		Skin_Name_BrownBear,
		Skin_Name_Gorilla,
		Skin_Name_YeTigorilla,
		Skin_Name_Greenfrog,
		Skin_Name_Hen,
		Skin_Name_Rooster,
		Skin_Name_Crowtit,
		Skin_Name_Hummingbird,
		Skin_Name_Gull,
		Skin_Name_Macaw,
		Skin_Name_Woodpecker,
		Skin_Name_BigbilledBird,
		Skin_Name_Eagle,
		Skin_Name_Owl,
		Skin_Name_Trex,
		Skin_Name_Crocodile,
		Skin_Name_Tamerabbit,
		Skin_Name_Hare,
		Skin_Name_Deer,
		Skin_Name_Reindeer,
		Skin_Name_Milkcow,
		Skin_Name_Bull,
		Skin_Name_Horse,
		Skin_Name_Zebra,
		Skin_Name_Fox,
		Skin_Name_Cat,
		Skin_Name_Tiger,
		Skin_Name_Pig,
		Skin_Name_Elephant,
		Skin_Name_Werewolf,
		Skin_Name_Mummy,
		Skin_Name_Ghost,
		Skin_Name_Witch,
		Skin_Name_Jackol,
		Skin_Name_Bat,
		Tutorial_Text_Start,
		OptionScene_Joypad,
		Character_Description_Bluemon,
		Character_Description_Lemon,
		Character_Description_Santa,
		Character_Description_Snowman,
		Character_Name_Santa,
		Character_Name_Snowman,
		Character_Name_Bluemon,
		Character_Name_Lemon,
		ShopScene_Popup_CheckFreeGacha,
		ShopScene_Popup_CheckAdGacha,
		SceneCharacterList_UnLockShop,
		ShopGoods_Package_Santa,
		ShopGoods_Package_Polarbear,
		ShopGoods_Package_Yetigorilla,
		ShopGoods_Package_Owl,
		ShopGoods_Package_Reindeer,
		ShopGoods_Package_Witch,
		Skin_Name_Santa,
		Skin_Name_Snowman,
		SceneShop_DayTimeText,
		SceneShop_TimeText,
		SceneShop_DailyOpen,
		SceneShop_DailyWait,
		SceneShop_Popup_DailyCountNot,
		MyInfoScene_SoloWin,
		MyInfoScene_DodgeScore,
		MyInfoScene_DodgeTime,
		MyInfoScene_FlyawayScore,
		MyInfoScene_FlyawayCount,
		MyInfoScene_IngameKill,
		MyInfoScene_ConsecutiveKill,
		MyInfoScene_BlowBalloon,
		Quest_IslandCount,
		Quest_PlayIsland,
		Quest_PlayIslandGoldGet,
		Quest_PlayIslandScoreGet,
		Popup_IslandAdReward,
		Popup_DodgeAdReward,
		Popup_DailyMissionAdReward,
		Popup_FreeBoxAdReward,
		Popup_QuestAdChange,
		RankingScene_Popup_Point,
		RankingScene_Popup_EqualPoint,
		RankingScene_Popup_Rate,
		RankingScene_Popup_Ranking,
		RankingScene_Popup_RankingPoint,
		RankingScene_Text_WeeklyRanking,
		RankingScene_Text_NoRecord,
		RankingScene_Popup_RewardMulti,
		RankingScene_Popup_RewardIsland,
		RankingScene_Popup_RewardDodge,
		RankingScene_Popup_RewardPopup,
		SceneSetting_NoticeText,
		GameTip_Island_Step01,
		GameTip_Island_Step02,
		GameTip_Island_Step03,
		GameTip_Island_Step04,
		GameTip_Island_Step05,
		GameTip_Island_Step06,
		GameTip_Island_Step07,
		Quest_CharacterName,
		MainLobby_MainInfoTip,
		MainLobby_MoneyTip,
		MainLobby_ModeTip,
		MainLobby_TrophyTip,
		Character_StatTip,
		Character_SkinTip,
		Mondey_KeyCoinTip,
		Character_KeyCoinBuy,
		Character_ListTip,
		Quest_ListTip,
		Quest_DailyMissionTip,
		RankReward_Tip,
		WeeklyRanking_Tip,
		Shop_PackageTip,
		PopupTitle_Tip,
		GameTip_Island_TipOff,
		Global_Popup_AllStarCharacterBuy,
		Global_Popup_GuestBuy,
		OptionScene_Language_India,
		SceneAccount_Term_View,
		RankingScene_Popup_TimeLine,
		RankingReward_Popup_Failed,
		Global_Button_Buy,
		SystemNotice_ServerHolding,
		SystemNotice_ServerUndergoing,
		SystemAlarm_ServerCheck,
		SystemAlarm_ServerTask,
		SystemAlarm_ServerEmergency,
		SystemAlarm_ServerMaintenance,
		SystemNotice_ServerEmergency,
		SystemNotice_ServerMaintenance,
		LobbyScene_3PSurvival,
		Quest_Survival3PPlay,
		Quest_Survival3PVictory,
		Global_Popup_News,
		Global_Popup_NewsText,
		Skin_Name_Raccoon,
		Skin_Name_Penguin,
		Skin_Name_Mouse,
		Skin_Name_Squirrel,
		Skin_Name_Hippo,
		Skin_Name_Walrus,
		Character_Name_Raccoon,
		Character_Name_Penguin,
		Character_Name_Mouse,
		Character_Name_Squirrel,
		Character_Name_Hippo,
		Character_Name_Walrus,
		Character_Description_Raccoon,
		Character_Description_Penguin,
		Character_Description_Mouse,
		Character_Description_Squirrel,
		Character_Description_Hippo,
		Character_Description_Walrus,
		LobbyScene_TeamSmall,
		Character_Name_Killerbee,
		Character_Name_Bee,
		Character_Name_Beetle,
		Character_Name_Mantis,
		Character_Name_Ladybugs,
		Character_Name_Stagbeetle,
		Character_Description_Killerbee,
		Character_Description_Bee,
		Character_Description_Beetle,
		Character_Description_Mantis,
		Character_Description_Ladybugs,
		Character_Description_Stagbeetle,
		Skin_Name_Killerbee,
		Skin_Name_Bee,
		Skin_Name_Beetle,
		Skin_Name_Mantis,
		Skin_Name_Ladybugs,
		Skin_Name_Stagbeetle,
		LobbyScene_FlyAwayRace,
		LobbyScene_DodgeArrowRace,
		Quest_MultiSinglePlay,
		Quest_MultiIslandPlay,
		ShopGoods_Package_Killerbee,
		ShopGoods_Package_Bee,
		ShopGoods_Package_Beetle,
		ShopGoods_Package_Mantis,
		ShopGoods_Package_Ladybugs,
		ShopGoods_Package_Stagbeetle,
		MuiltiItem_Name_Ink,
		MuiltiItem_Name_Scale,
		MuiltiItem_Name_Slow,
		LobbyScene_Event,
		LobbyScene_Event_Survival,
		LobbyScene_Event_Team,
		OptionScene_UpdatingInfo,
		ShopGoods_Dia7,
		Global_Button_Exit,
		LobbyScene_MultiPlay,
		MultiScene_Owner,
		MultiScene_Enter,
		MultiScene_Create,
		MultiScene_QuickEnter,
		MultiScene_Private,
		MultiScene_Individual,
		MultiScene_Team,
		MultiScene_Solo,
		MultiScene_Promote,
		MultiScene_Text_GameStart,
		MultiScne_Popup_SelectPublic,
		MultiScne_Popup_Public,
		MultiScne_Popup_Private,
		MultiScne_Popup_Password,
		MultiScne_Popup_Text_Password,
		MultiScne_Popup_SelectMode,
		MultiScne_Popup_SelectPlayMode,
		Character_Name_Uni_Kiwibird,
		Character_Name_Uni_Chick,
		Character_Name_Uni_Duckling,
		Character_Name_Uni_Poodle,
		Character_Name_Uni_Greenfrog,
		Character_Name_Uni_Crowtit,
		Character_Name_Uni_Hummingbird,
		Character_Name_Uni_Macaw,
		Character_Name_Uni_Tamerabbit,
		Character_Description_Uni_Kiwibird,
		Character_Description_Uni_Chick,
		Character_Description_Uni_Duckling,
		Character_Description_Uni_Poodle,
		Character_Description_Uni_Greenfrog,
		Character_Description_Uni_Crowtit,
		Character_Description_Uni_Hummingbird,
		Character_Description_Uni_Macaw,
		Character_Description_Uni_Tamerabbit,
		Character_Requirement_Uni_Kiwibird,
		Character_Requirement_Uni_Chick,
		Character_Requirement_Uni_Duckling,
		Character_Requirement_Uni_Poodle,
		Character_Requirement_Uni_Greenfrog,
		Character_Requirement_Uni_Crowtit,
		Character_Requirement_Uni_Hummingbird,
		Character_Requirement_Uni_Macaw,
		Character_Requirement_Uni_Tamerabbit,
		MultiScne_Popup_Info,
		MultiScene_All,
		MultiScene_Send,
		MultiScene_Chat,
		MultiScene_Popup_PwFailed,
		MultiScene_Popup_RoomFailed,
		MultiScene_Popup_Start,
		Global_Grade_Unique,
		MultiScene_Popup_ErrorQuickEnter,
		System_Chat_GameStart,
		MultiScene_Text_NoRoom,
		Global_Button_Back,
		Global_Text_CharacterInfo,
		CharacterSelectScene_Text_Tip,
		Ranking_Popup_TimeLine,
		Ranking_Popup_RewardInfo,
		CharacterSelectScene_Text_Tip2,
		ResultScene_Text_AutoExit,
		LobbyScene_Text_StartRooom,
		ShopScene_DailyFreeBox,
		ShopScene_DailyFreeBoxText,
		Global_Popup_CpNotEnough,
		ShopScene_GachaOverlapText,
		Account_LogIn_Apple,
		Account_LogIn_Google,
		Account_LogIn_FaceBook,
		Account_LogInCompleted_Apple,
		Account_LogInCompleted_Google,
		Account_LogInCompleted_FaceBook,
		Account_LogOut,
		Account_LogInCompleted,
		Account_LogOut_PopUp_Text,
		Account_SignIn_PopUp_Text,
		Character_Name_Fairy,
		Character_Name_Knight,
		Character_Name_Wizard,
		Character_Name_Princess,
		Character_Name_Dragon,
		Character_Description_Fairy,
		Character_Description_Knight,
		Character_Description_Wizard,
		Character_Description_Princess,
		Character_Description_Dragon,
		ShopGoods_Package_Fairy,
		ShopGoods_Package_Knight,
		ShopGoods_Package_Wizard,
		ShopGoods_Package_Princess,
		ShopGoods_Package_Dragon,
		Skin_Name_Fairy,
		Skin_Name_Knight,
		Skin_Name_Wizard,
		Skin_Name_Princess,
		Skin_Name_Dragon,
		Global_Popup_CloseService,
		NickNameAlreadyExists,
		OtherPlayerDisconnected,
		InvalidGame,
		InvalidDisconnectNotice,
		TimeLeft,
		Global_Text_Dia00,
		Global_Text_Dia01,
		Global_Text_Dia02,
		Global_Text_Dia03,
		Global_Popup_PlayCountNotEnough,
		Global_Popup_MultiPlayCountNotEnough,
		Global_Popup_MultiPlayCountMax,
		Global_Popup_GoldNotEnough,
		SceneCharacterList_UnLockNFT,
		Global_Grade_Rare_T1,
		Global_Grade_Rare_T2,
		Global_Grade_Rare_T3,
		Global_Grade_Epic_T1,
		Global_Grade_Epic_T2,
		Global_Grade_Epic_T3,
		Global_Grade_Unique_T1,
		Global_Grade_Unique_T2,
		Global_Grade_Unique_T3,
		Character_Name_Kiwibird01,
		Character_Name_Kiwibird02,
		Character_Name_Kiwibird03,
		Character_Name_Kiwibird04,
		Character_Name_Chick01,
		Character_Name_Chick02,
		Character_Name_Chick03,
		Character_Name_Chick04,
		Character_Name_Duckling01,
		Character_Name_Duckling02,
		Character_Name_Duckling03,
		Character_Name_Duckling04,
		Character_Name_ShibaInu01,
		Character_Name_ShibaInu02,
		Character_Name_ShibaInu03,
		Character_Name_ShibaInu04,
		Character_Name_Poodle01,
		Character_Name_Poodle02,
		Character_Name_Poodle03,
		Character_Name_Poodle04,
		Character_Name_Turtle01,
		Character_Name_Turtle02,
		Character_Name_Turtle03,
		Character_Name_Turtle04,
		Character_Name_Panda01,
		Character_Name_Panda02,
		Character_Name_Panda03,
		Character_Name_Panda04,
		Character_Name_Polarbear01,
		Character_Name_Polarbear02,
		Character_Name_Polarbear03,
		Character_Name_Polarbear04,
		Character_Name_Brownbear01,
		Character_Name_Brownbear02,
		Character_Name_Brownbear03,
		Character_Name_Brownbear04,
		Character_Name_Gorilla01,
		Character_Name_Gorilla02,
		Character_Name_Gorilla03,
		Character_Name_Gorilla04,
		Character_Name_YeTigorilla01,
		Character_Name_YeTigorilla02,
		Character_Name_YeTigorilla03,
		Character_Name_YeTigorilla04,
		Character_Name_Greenfrog01,
		Character_Name_Greenfrog02,
		Character_Name_Greenfrog03,
		Character_Name_Greenfrog04,
		Character_Name_Hen01,
		Character_Name_Hen02,
		Character_Name_Hen03,
		Character_Name_Hen04,
		Character_Name_Rooster01,
		Character_Name_Rooster02,
		Character_Name_Rooster03,
		Character_Name_Rooster04,
		Character_Name_Crowtit01,
		Character_Name_Crowtit02,
		Character_Name_Crowtit03,
		Character_Name_Crowtit04,
		Character_Name_Hummingbird01,
		Character_Name_Hummingbird02,
		Character_Name_Hummingbird03,
		Character_Name_Hummingbird04,
		Character_Name_Gull01,
		Character_Name_Gull02,
		Character_Name_Gull03,
		Character_Name_Gull04,
		Character_Name_Macaw01,
		Character_Name_Macaw02,
		Character_Name_Macaw03,
		Character_Name_Macaw04,
		Character_Name_Woodpecker01,
		Character_Name_Woodpecker02,
		Character_Name_Woodpecker03,
		Character_Name_Woodpecker04,
		Character_Name_BigbilledBird01,
		Character_Name_BigbilledBird02,
		Character_Name_BigbilledBird03,
		Character_Name_BigbilledBird04,
		Character_Name_Eagle01,
		Character_Name_Eagle02,
		Character_Name_Eagle03,
		Character_Name_Eagle04,
		Character_Name_Owl01,
		Character_Name_Owl02,
		Character_Name_Owl03,
		Character_Name_Owl04,
		Character_Name_Trex01,
		Character_Name_Trex02,
		Character_Name_Trex03,
		Character_Name_Trex04,
		Character_Name_Crocodile01,
		Character_Name_Crocodile02,
		Character_Name_Crocodile03,
		Character_Name_Crocodile04,
		Character_Name_Tamerabbit01,
		Character_Name_Tamerabbit02,
		Character_Name_Tamerabbit03,
		Character_Name_Tamerabbit04,
		Character_Name_Hare01,
		Character_Name_Hare02,
		Character_Name_Hare03,
		Character_Name_Hare04,
		Character_Name_Deer01,
		Character_Name_Deer02,
		Character_Name_Deer03,
		Character_Name_Deer04,
		Character_Name_Reindeer01,
		Character_Name_Reindeer02,
		Character_Name_Reindeer03,
		Character_Name_Reindeer04,
		Character_Name_Milkcow01,
		Character_Name_Milkcow02,
		Character_Name_Milkcow03,
		Character_Name_Milkcow04,
		Character_Name_Bull01,
		Character_Name_Bull02,
		Character_Name_Bull03,
		Character_Name_Bull04,
		Character_Name_Horse01,
		Character_Name_Horse02,
		Character_Name_Horse03,
		Character_Name_Horse04,
		Character_Name_Zebra01,
		Character_Name_Zebra02,
		Character_Name_Zebra03,
		Character_Name_Zebra04,
		Character_Name_Fox01,
		Character_Name_Fox02,
		Character_Name_Fox03,
		Character_Name_Fox04,
		Character_Name_Cat01,
		Character_Name_Cat02,
		Character_Name_Cat03,
		Character_Name_Cat04,
		Character_Name_Tiger01,
		Character_Name_Tiger02,
		Character_Name_Tiger03,
		Character_Name_Tiger04,
		Character_Name_Pig01,
		Character_Name_Pig02,
		Character_Name_Pig03,
		Character_Name_Pig04,
		Character_Name_Elephant01,
		Character_Name_Elephant02,
		Character_Name_Elephant03,
		Character_Name_Elephant04,
		Character_Name_Werewolf01,
		Character_Name_Werewolf02,
		Character_Name_Werewolf03,
		Character_Name_Werewolf04,
		Character_Name_Mummy01,
		Character_Name_Mummy02,
		Character_Name_Mummy03,
		Character_Name_Mummy04,
		Character_Name_Ghost01,
		Character_Name_Ghost02,
		Character_Name_Ghost03,
		Character_Name_Ghost04,
		Character_Name_Witch01,
		Character_Name_Witch02,
		Character_Name_Witch03,
		Character_Name_Witch04,
		Character_Name_Jackol01,
		Character_Name_Jackol02,
		Character_Name_Jackol03,
		Character_Name_Jackol04,
		Character_Name_Bat01,
		Character_Name_Bat02,
		Character_Name_Bat03,
		Character_Name_Bat04,
		Character_Name_Santa01,
		Character_Name_Santa02,
		Character_Name_Santa03,
		Character_Name_Santa04,
		Character_Name_Snowman01,
		Character_Name_Snowman02,
		Character_Name_Snowman03,
		Character_Name_Snowman04,
		Character_Name_Raccoon01,
		Character_Name_Raccoon02,
		Character_Name_Raccoon03,
		Character_Name_Raccoon04,
		Character_Name_Penguin01,
		Character_Name_Penguin02,
		Character_Name_Penguin03,
		Character_Name_Penguin04,
		Character_Name_Mouse01,
		Character_Name_Mouse02,
		Character_Name_Mouse03,
		Character_Name_Mouse04,
		Character_Name_Squirrel01,
		Character_Name_Squirrel02,
		Character_Name_Squirrel03,
		Character_Name_Squirrel04,
		Character_Name_Hippo01,
		Character_Name_Hippo02,
		Character_Name_Hippo03,
		Character_Name_Hippo04,
		Character_Name_Walrus01,
		Character_Name_Walrus02,
		Character_Name_Walrus03,
		Character_Name_Walrus04,
		Character_Name_Killerbee01,
		Character_Name_Killerbee02,
		Character_Name_Killerbee03,
		Character_Name_Killerbee04,
		Character_Name_Bee01,
		Character_Name_Bee02,
		Character_Name_Bee03,
		Character_Name_Bee04,
		Character_Name_Beetle01,
		Character_Name_Beetle02,
		Character_Name_Beetle03,
		Character_Name_Beetle04,
		Character_Name_Mantis01,
		Character_Name_Mantis02,
		Character_Name_Mantis03,
		Character_Name_Mantis04,
		Character_Name_Ladybugs01,
		Character_Name_Ladybugs02,
		Character_Name_Ladybugs03,
		Character_Name_Ladybugs04,
		Character_Name_Stagbeetle01,
		Character_Name_Stagbeetle02,
		Character_Name_Stagbeetle03,
		Character_Name_Stagbeetle04,
		Character_Name_Fairy01,
		Character_Name_Fairy02,
		Character_Name_Fairy03,
		Character_Name_Fairy04,
		Character_Name_Knight01,
		Character_Name_Knight02,
		Character_Name_Knight03,
		Character_Name_Knight04,
		Character_Name_Wizard01,
		Character_Name_Wizard02,
		Character_Name_Wizard03,
		Character_Name_Wizard04,
		Character_Name_Princess01,
		Character_Name_Princess02,
		Character_Name_Princess03,
		Character_Name_Princess04,
		Character_Name_Dragon01,
		Character_Name_Dragon02,
		Character_Name_Dragon03,
		Character_Name_Dragon04,
		ReachedMaximumLimit,
		Max,
		Null=-1,
	}
	public enum EMultiItemType
	{
		Null,
		Ink,
		Scale,
		Slow,
		Max,
	}
	public enum EStatusType
	{
		Null,
		Sky,
		Land,
		Stamina,
		Pump,
		Max,
	}
	public class STextSet : SProto
	{
		public String[] Texts = new String[19];
		public STextSet()
		{
			for (int iTexts = 0; iTexts < Texts.Length; ++iTexts)
				Texts[iTexts] = string.Empty;
		}
		public STextSet(STextSet Obj_)
		{
			Texts = Obj_.Texts;
		}
		public STextSet(String[] Texts_)
		{
			Texts = Texts_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Texts);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Texts", ref Texts);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Texts);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Texts", Texts);
		}
		public void Set(STextSet Obj_)
		{
			Texts = Obj_.Texts;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Texts);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Texts, "Texts");
		}
	}
	public class STextMeta : SProto
	{
		public EText TextName = default(EText);
		public String[] Texts = new String[19];
		public STextMeta()
		{
			for (int iTexts = 0; iTexts < Texts.Length; ++iTexts)
				Texts[iTexts] = string.Empty;
		}
		public STextMeta(STextMeta Obj_)
		{
			TextName = Obj_.TextName;
			Texts = Obj_.Texts;
		}
		public STextMeta(EText TextName_, String[] Texts_)
		{
			TextName = TextName_;
			Texts = Texts_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref TextName);
			Stream_.Pop(ref Texts);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("TextName", ref TextName);
			Value_.Pop("Texts", ref Texts);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(TextName);
			Stream_.Push(Texts);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("TextName", TextName);
			Value_.Push("Texts", Texts);
		}
		public void Set(STextMeta Obj_)
		{
			TextName = Obj_.TextName;
			Texts = Obj_.Texts;
		}
		public override string StdName()
		{
			return 
				"bb.EText" + "," + 
				SEnumChecker.GetStdName(Texts);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(TextName, "TextName") + "," + 
				SEnumChecker.GetMemberName(Texts, "Texts");
		}
	}
	public class SLanguageTextMeta : SProto
	{
		public ELanguage Language = default(ELanguage);
		public String Text = string.Empty;
		public SLanguageTextMeta()
		{
		}
		public SLanguageTextMeta(SLanguageTextMeta Obj_)
		{
			Language = Obj_.Language;
			Text = Obj_.Text;
		}
		public SLanguageTextMeta(ELanguage Language_, String Text_)
		{
			Language = Language_;
			Text = Text_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Language);
			Stream_.Pop(ref Text);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Language", ref Language);
			Value_.Pop("Text", ref Text);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Language);
			Stream_.Push(Text);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Language", Language);
			Value_.Push("Text", Text);
		}
		public void Set(SLanguageTextMeta Obj_)
		{
			Language = Obj_.Language;
			Text = Obj_.Text;
		}
		public override string StdName()
		{
			return 
				"bb.ELanguage" + "," + 
				SEnumChecker.GetStdName(Text);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Language, "Language") + "," + 
				SEnumChecker.GetMemberName(Text, "Text");
		}
	}
	public class SGameRetMeta : SProto
	{
		public EGameRet GameRetName = default(EGameRet);
		public String[] Texts = new String[19];
		public SGameRetMeta()
		{
			for (int iTexts = 0; iTexts < Texts.Length; ++iTexts)
				Texts[iTexts] = string.Empty;
		}
		public SGameRetMeta(SGameRetMeta Obj_)
		{
			GameRetName = Obj_.GameRetName;
			Texts = Obj_.Texts;
		}
		public SGameRetMeta(EGameRet GameRetName_, String[] Texts_)
		{
			GameRetName = GameRetName_;
			Texts = Texts_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref GameRetName);
			Stream_.Pop(ref Texts);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("GameRetName", ref GameRetName);
			Value_.Pop("Texts", ref Texts);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(GameRetName);
			Stream_.Push(Texts);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("GameRetName", GameRetName);
			Value_.Push("Texts", Texts);
		}
		public void Set(SGameRetMeta Obj_)
		{
			GameRetName = Obj_.GameRetName;
			Texts = Obj_.Texts;
		}
		public override string StdName()
		{
			return 
				"rso.game.EGameRet" + "," + 
				SEnumChecker.GetStdName(Texts);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(GameRetName, "GameRetName") + "," + 
				SEnumChecker.GetMemberName(Texts, "Texts");
		}
	}
	public class SCharacterClientMeta : SCharacterMeta
	{
		public EText ETextName = default(EText);
		public EText ETextDescription = default(EText);
		public EText ETextRequirement = default(EText);
		public String PrefabName = string.Empty;
		public String DescriptionIcon = string.Empty;
		public String IconName = string.Empty;
		public EStatusType Post_Status = default(EStatusType);
		public Int32 SkyStatus = default(Int32);
		public Int32 LandStatus = default(Int32);
		public Int32 StaminaStatus = default(Int32);
		public Int32 PumpStatus = default(Int32);
		public SCharacterClientMeta()
		{
		}
		public SCharacterClientMeta(SCharacterClientMeta Obj_) : base(Obj_)
		{
			ETextName = Obj_.ETextName;
			ETextDescription = Obj_.ETextDescription;
			ETextRequirement = Obj_.ETextRequirement;
			PrefabName = Obj_.PrefabName;
			DescriptionIcon = Obj_.DescriptionIcon;
			IconName = Obj_.IconName;
			Post_Status = Obj_.Post_Status;
			SkyStatus = Obj_.SkyStatus;
			LandStatus = Obj_.LandStatus;
			StaminaStatus = Obj_.StaminaStatus;
			PumpStatus = Obj_.PumpStatus;
		}
		public SCharacterClientMeta(SCharacterMeta Super_, EText ETextName_, EText ETextDescription_, EText ETextRequirement_, String PrefabName_, String DescriptionIcon_, String IconName_, EStatusType Post_Status_, Int32 SkyStatus_, Int32 LandStatus_, Int32 StaminaStatus_, Int32 PumpStatus_) : base(Super_)
		{
			ETextName = ETextName_;
			ETextDescription = ETextDescription_;
			ETextRequirement = ETextRequirement_;
			PrefabName = PrefabName_;
			DescriptionIcon = DescriptionIcon_;
			IconName = IconName_;
			Post_Status = Post_Status_;
			SkyStatus = SkyStatus_;
			LandStatus = LandStatus_;
			StaminaStatus = StaminaStatus_;
			PumpStatus = PumpStatus_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref ETextName);
			Stream_.Pop(ref ETextDescription);
			Stream_.Pop(ref ETextRequirement);
			Stream_.Pop(ref PrefabName);
			Stream_.Pop(ref DescriptionIcon);
			Stream_.Pop(ref IconName);
			Stream_.Pop(ref Post_Status);
			Stream_.Pop(ref SkyStatus);
			Stream_.Pop(ref LandStatus);
			Stream_.Pop(ref StaminaStatus);
			Stream_.Pop(ref PumpStatus);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("ETextName", ref ETextName);
			Value_.Pop("ETextDescription", ref ETextDescription);
			Value_.Pop("ETextRequirement", ref ETextRequirement);
			Value_.Pop("PrefabName", ref PrefabName);
			Value_.Pop("DescriptionIcon", ref DescriptionIcon);
			Value_.Pop("IconName", ref IconName);
			Value_.Pop("Post_Status", ref Post_Status);
			Value_.Pop("SkyStatus", ref SkyStatus);
			Value_.Pop("LandStatus", ref LandStatus);
			Value_.Pop("StaminaStatus", ref StaminaStatus);
			Value_.Pop("PumpStatus", ref PumpStatus);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(ETextName);
			Stream_.Push(ETextDescription);
			Stream_.Push(ETextRequirement);
			Stream_.Push(PrefabName);
			Stream_.Push(DescriptionIcon);
			Stream_.Push(IconName);
			Stream_.Push(Post_Status);
			Stream_.Push(SkyStatus);
			Stream_.Push(LandStatus);
			Stream_.Push(StaminaStatus);
			Stream_.Push(PumpStatus);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("ETextName", ETextName);
			Value_.Push("ETextDescription", ETextDescription);
			Value_.Push("ETextRequirement", ETextRequirement);
			Value_.Push("PrefabName", PrefabName);
			Value_.Push("DescriptionIcon", DescriptionIcon);
			Value_.Push("IconName", IconName);
			Value_.Push("Post_Status", Post_Status);
			Value_.Push("SkyStatus", SkyStatus);
			Value_.Push("LandStatus", LandStatus);
			Value_.Push("StaminaStatus", StaminaStatus);
			Value_.Push("PumpStatus", PumpStatus);
		}
		public void Set(SCharacterClientMeta Obj_)
		{
			base.Set(Obj_);
			ETextName = Obj_.ETextName;
			ETextDescription = Obj_.ETextDescription;
			ETextRequirement = Obj_.ETextRequirement;
			PrefabName = Obj_.PrefabName;
			DescriptionIcon = Obj_.DescriptionIcon;
			IconName = Obj_.IconName;
			Post_Status = Obj_.Post_Status;
			SkyStatus = Obj_.SkyStatus;
			LandStatus = Obj_.LandStatus;
			StaminaStatus = Obj_.StaminaStatus;
			PumpStatus = Obj_.PumpStatus;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				"bb.EText" + "," + 
				"bb.EText" + "," + 
				"bb.EText" + "," + 
				SEnumChecker.GetStdName(PrefabName) + "," + 
				SEnumChecker.GetStdName(DescriptionIcon) + "," + 
				SEnumChecker.GetStdName(IconName) + "," + 
				"bb.EStatusType" + "," + 
				SEnumChecker.GetStdName(SkyStatus) + "," + 
				SEnumChecker.GetStdName(LandStatus) + "," + 
				SEnumChecker.GetStdName(StaminaStatus) + "," + 
				SEnumChecker.GetStdName(PumpStatus);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(ETextName, "ETextName") + "," + 
				SEnumChecker.GetMemberName(ETextDescription, "ETextDescription") + "," + 
				SEnumChecker.GetMemberName(ETextRequirement, "ETextRequirement") + "," + 
				SEnumChecker.GetMemberName(PrefabName, "PrefabName") + "," + 
				SEnumChecker.GetMemberName(DescriptionIcon, "DescriptionIcon") + "," + 
				SEnumChecker.GetMemberName(IconName, "IconName") + "," + 
				SEnumChecker.GetMemberName(Post_Status, "Post_Status") + "," + 
				SEnumChecker.GetMemberName(SkyStatus, "SkyStatus") + "," + 
				SEnumChecker.GetMemberName(LandStatus, "LandStatus") + "," + 
				SEnumChecker.GetMemberName(StaminaStatus, "StaminaStatus") + "," + 
				SEnumChecker.GetMemberName(PumpStatus, "PumpStatus");
		}
	}
	public class SCharacterGradeClientMeta : SCharacterGradeMeta
	{
		public EText ETextGradeName = default(EText);
		public Int32 ColorR = default(Int32);
		public Int32 ColorG = default(Int32);
		public Int32 ColorB = default(Int32);
		public SCharacterGradeClientMeta()
		{
		}
		public SCharacterGradeClientMeta(SCharacterGradeClientMeta Obj_) : base(Obj_)
		{
			ETextGradeName = Obj_.ETextGradeName;
			ColorR = Obj_.ColorR;
			ColorG = Obj_.ColorG;
			ColorB = Obj_.ColorB;
		}
		public SCharacterGradeClientMeta(SCharacterGradeMeta Super_, EText ETextGradeName_, Int32 ColorR_, Int32 ColorG_, Int32 ColorB_) : base(Super_)
		{
			ETextGradeName = ETextGradeName_;
			ColorR = ColorR_;
			ColorG = ColorG_;
			ColorB = ColorB_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref ETextGradeName);
			Stream_.Pop(ref ColorR);
			Stream_.Pop(ref ColorG);
			Stream_.Pop(ref ColorB);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("ETextGradeName", ref ETextGradeName);
			Value_.Pop("ColorR", ref ColorR);
			Value_.Pop("ColorG", ref ColorG);
			Value_.Pop("ColorB", ref ColorB);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(ETextGradeName);
			Stream_.Push(ColorR);
			Stream_.Push(ColorG);
			Stream_.Push(ColorB);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("ETextGradeName", ETextGradeName);
			Value_.Push("ColorR", ColorR);
			Value_.Push("ColorG", ColorG);
			Value_.Push("ColorB", ColorB);
		}
		public void Set(SCharacterGradeClientMeta Obj_)
		{
			base.Set(Obj_);
			ETextGradeName = Obj_.ETextGradeName;
			ColorR = Obj_.ColorR;
			ColorG = Obj_.ColorG;
			ColorB = Obj_.ColorB;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				"bb.EText" + "," + 
				SEnumChecker.GetStdName(ColorR) + "," + 
				SEnumChecker.GetStdName(ColorG) + "," + 
				SEnumChecker.GetStdName(ColorB);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(ETextGradeName, "ETextGradeName") + "," + 
				SEnumChecker.GetMemberName(ColorR, "ColorR") + "," + 
				SEnumChecker.GetMemberName(ColorG, "ColorG") + "," + 
				SEnumChecker.GetMemberName(ColorB, "ColorB");
		}
	}
	public class SGameOption : SProto
	{
		public Boolean IsVibe = default(Boolean);
		public Boolean IsMusic = default(Boolean);
		public Boolean IsSound = default(Boolean);
		public Boolean IsPush = default(Boolean);
		public Boolean IsPad = default(Boolean);
		public Boolean IsTutorial = default(Boolean);
		public ELanguage Language = default(ELanguage);
		public SGameOption()
		{
		}
		public SGameOption(SGameOption Obj_)
		{
			IsVibe = Obj_.IsVibe;
			IsMusic = Obj_.IsMusic;
			IsSound = Obj_.IsSound;
			IsPush = Obj_.IsPush;
			IsPad = Obj_.IsPad;
			IsTutorial = Obj_.IsTutorial;
			Language = Obj_.Language;
		}
		public SGameOption(Boolean IsVibe_, Boolean IsMusic_, Boolean IsSound_, Boolean IsPush_, Boolean IsPad_, Boolean IsTutorial_, ELanguage Language_)
		{
			IsVibe = IsVibe_;
			IsMusic = IsMusic_;
			IsSound = IsSound_;
			IsPush = IsPush_;
			IsPad = IsPad_;
			IsTutorial = IsTutorial_;
			Language = Language_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref IsVibe);
			Stream_.Pop(ref IsMusic);
			Stream_.Pop(ref IsSound);
			Stream_.Pop(ref IsPush);
			Stream_.Pop(ref IsPad);
			Stream_.Pop(ref IsTutorial);
			Stream_.Pop(ref Language);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("IsVibe", ref IsVibe);
			Value_.Pop("IsMusic", ref IsMusic);
			Value_.Pop("IsSound", ref IsSound);
			Value_.Pop("IsPush", ref IsPush);
			Value_.Pop("IsPad", ref IsPad);
			Value_.Pop("IsTutorial", ref IsTutorial);
			Value_.Pop("Language", ref Language);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(IsVibe);
			Stream_.Push(IsMusic);
			Stream_.Push(IsSound);
			Stream_.Push(IsPush);
			Stream_.Push(IsPad);
			Stream_.Push(IsTutorial);
			Stream_.Push(Language);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("IsVibe", IsVibe);
			Value_.Push("IsMusic", IsMusic);
			Value_.Push("IsSound", IsSound);
			Value_.Push("IsPush", IsPush);
			Value_.Push("IsPad", IsPad);
			Value_.Push("IsTutorial", IsTutorial);
			Value_.Push("Language", Language);
		}
		public void Set(SGameOption Obj_)
		{
			IsVibe = Obj_.IsVibe;
			IsMusic = Obj_.IsMusic;
			IsSound = Obj_.IsSound;
			IsPush = Obj_.IsPush;
			IsPad = Obj_.IsPad;
			IsTutorial = Obj_.IsTutorial;
			Language = Obj_.Language;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(IsVibe) + "," + 
				SEnumChecker.GetStdName(IsMusic) + "," + 
				SEnumChecker.GetStdName(IsSound) + "," + 
				SEnumChecker.GetStdName(IsPush) + "," + 
				SEnumChecker.GetStdName(IsPad) + "," + 
				SEnumChecker.GetStdName(IsTutorial) + "," + 
				"bb.ELanguage";
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(IsVibe, "IsVibe") + "," + 
				SEnumChecker.GetMemberName(IsMusic, "IsMusic") + "," + 
				SEnumChecker.GetMemberName(IsSound, "IsSound") + "," + 
				SEnumChecker.GetMemberName(IsPush, "IsPush") + "," + 
				SEnumChecker.GetMemberName(IsPad, "IsPad") + "," + 
				SEnumChecker.GetMemberName(IsTutorial, "IsTutorial") + "," + 
				SEnumChecker.GetMemberName(Language, "Language");
		}
	}
	public class SShopClientMeta : SShopMeta
	{
		public EText ETextName = default(EText);
		public String TextureName = string.Empty;
		public ETrackingKey AnalyticsKey = default(ETrackingKey);
		public SShopClientMeta()
		{
		}
		public SShopClientMeta(SShopClientMeta Obj_) : base(Obj_)
		{
			ETextName = Obj_.ETextName;
			TextureName = Obj_.TextureName;
			AnalyticsKey = Obj_.AnalyticsKey;
		}
		public SShopClientMeta(SShopMeta Super_, EText ETextName_, String TextureName_, ETrackingKey AnalyticsKey_) : base(Super_)
		{
			ETextName = ETextName_;
			TextureName = TextureName_;
			AnalyticsKey = AnalyticsKey_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref ETextName);
			Stream_.Pop(ref TextureName);
			Stream_.Pop(ref AnalyticsKey);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("ETextName", ref ETextName);
			Value_.Pop("TextureName", ref TextureName);
			Value_.Pop("AnalyticsKey", ref AnalyticsKey);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(ETextName);
			Stream_.Push(TextureName);
			Stream_.Push(AnalyticsKey);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("ETextName", ETextName);
			Value_.Push("TextureName", TextureName);
			Value_.Push("AnalyticsKey", AnalyticsKey);
		}
		public void Set(SShopClientMeta Obj_)
		{
			base.Set(Obj_);
			ETextName = Obj_.ETextName;
			TextureName = Obj_.TextureName;
			AnalyticsKey = Obj_.AnalyticsKey;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				"bb.EText" + "," + 
				SEnumChecker.GetStdName(TextureName) + "," + 
				"bb.ETrackingKey";
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(ETextName, "ETextName") + "," + 
				SEnumChecker.GetMemberName(TextureName, "TextureName") + "," + 
				SEnumChecker.GetMemberName(AnalyticsKey, "AnalyticsKey");
		}
	}
	public class SGachaClientMeta : SGachaMeta
	{
		public String TextureName = string.Empty;
		public Boolean IsEvent = default(Boolean);
		public EText EventTextName = default(EText);
		public SGachaClientMeta()
		{
		}
		public SGachaClientMeta(SGachaClientMeta Obj_) : base(Obj_)
		{
			TextureName = Obj_.TextureName;
			IsEvent = Obj_.IsEvent;
			EventTextName = Obj_.EventTextName;
		}
		public SGachaClientMeta(SGachaMeta Super_, String TextureName_, Boolean IsEvent_, EText EventTextName_) : base(Super_)
		{
			TextureName = TextureName_;
			IsEvent = IsEvent_;
			EventTextName = EventTextName_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref TextureName);
			Stream_.Pop(ref IsEvent);
			Stream_.Pop(ref EventTextName);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("TextureName", ref TextureName);
			Value_.Pop("IsEvent", ref IsEvent);
			Value_.Pop("EventTextName", ref EventTextName);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(TextureName);
			Stream_.Push(IsEvent);
			Stream_.Push(EventTextName);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("TextureName", TextureName);
			Value_.Push("IsEvent", IsEvent);
			Value_.Push("EventTextName", EventTextName);
		}
		public void Set(SGachaClientMeta Obj_)
		{
			base.Set(Obj_);
			TextureName = Obj_.TextureName;
			IsEvent = Obj_.IsEvent;
			EventTextName = Obj_.EventTextName;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(TextureName) + "," + 
				SEnumChecker.GetStdName(IsEvent) + "," + 
				"bb.EText";
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(TextureName, "TextureName") + "," + 
				SEnumChecker.GetMemberName(IsEvent, "IsEvent") + "," + 
				SEnumChecker.GetMemberName(EventTextName, "EventTextName");
		}
	}
	public class SRankTierClientMeta : SRankTierMeta
	{
		public Int32 Level = default(Int32);
		public EText ETextName = default(EText);
		public String TextureName = string.Empty;
		public Single RankColorR = default(Single);
		public Single RankColorG = default(Single);
		public Single RankColorB = default(Single);
		public SRankTierClientMeta()
		{
		}
		public SRankTierClientMeta(SRankTierClientMeta Obj_) : base(Obj_)
		{
			Level = Obj_.Level;
			ETextName = Obj_.ETextName;
			TextureName = Obj_.TextureName;
			RankColorR = Obj_.RankColorR;
			RankColorG = Obj_.RankColorG;
			RankColorB = Obj_.RankColorB;
		}
		public SRankTierClientMeta(SRankTierMeta Super_, Int32 Level_, EText ETextName_, String TextureName_, Single RankColorR_, Single RankColorG_, Single RankColorB_) : base(Super_)
		{
			Level = Level_;
			ETextName = ETextName_;
			TextureName = TextureName_;
			RankColorR = RankColorR_;
			RankColorG = RankColorG_;
			RankColorB = RankColorB_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref Level);
			Stream_.Pop(ref ETextName);
			Stream_.Pop(ref TextureName);
			Stream_.Pop(ref RankColorR);
			Stream_.Pop(ref RankColorG);
			Stream_.Pop(ref RankColorB);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("Level", ref Level);
			Value_.Pop("ETextName", ref ETextName);
			Value_.Pop("TextureName", ref TextureName);
			Value_.Pop("RankColorR", ref RankColorR);
			Value_.Pop("RankColorG", ref RankColorG);
			Value_.Pop("RankColorB", ref RankColorB);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(Level);
			Stream_.Push(ETextName);
			Stream_.Push(TextureName);
			Stream_.Push(RankColorR);
			Stream_.Push(RankColorG);
			Stream_.Push(RankColorB);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("Level", Level);
			Value_.Push("ETextName", ETextName);
			Value_.Push("TextureName", TextureName);
			Value_.Push("RankColorR", RankColorR);
			Value_.Push("RankColorG", RankColorG);
			Value_.Push("RankColorB", RankColorB);
		}
		public void Set(SRankTierClientMeta Obj_)
		{
			base.Set(Obj_);
			Level = Obj_.Level;
			ETextName = Obj_.ETextName;
			TextureName = Obj_.TextureName;
			RankColorR = Obj_.RankColorR;
			RankColorG = Obj_.RankColorG;
			RankColorB = Obj_.RankColorB;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(Level) + "," + 
				"bb.EText" + "," + 
				SEnumChecker.GetStdName(TextureName) + "," + 
				SEnumChecker.GetStdName(RankColorR) + "," + 
				SEnumChecker.GetStdName(RankColorG) + "," + 
				SEnumChecker.GetStdName(RankColorB);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(Level, "Level") + "," + 
				SEnumChecker.GetMemberName(ETextName, "ETextName") + "," + 
				SEnumChecker.GetMemberName(TextureName, "TextureName") + "," + 
				SEnumChecker.GetMemberName(RankColorR, "RankColorR") + "," + 
				SEnumChecker.GetMemberName(RankColorG, "RankColorG") + "," + 
				SEnumChecker.GetMemberName(RankColorB, "RankColorB");
		}
	}
	public class SRewardClientMeta : SProto
	{
		public String TextureName = string.Empty;
		public EText TextName = default(EText);
		public SRewardClientMeta()
		{
		}
		public SRewardClientMeta(SRewardClientMeta Obj_)
		{
			TextureName = Obj_.TextureName;
			TextName = Obj_.TextName;
		}
		public SRewardClientMeta(String TextureName_, EText TextName_)
		{
			TextureName = TextureName_;
			TextName = TextName_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref TextureName);
			Stream_.Pop(ref TextName);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("TextureName", ref TextureName);
			Value_.Pop("TextName", ref TextName);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(TextureName);
			Stream_.Push(TextName);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("TextureName", TextureName);
			Value_.Push("TextName", TextName);
		}
		public void Set(SRewardClientMeta Obj_)
		{
			TextureName = Obj_.TextureName;
			TextName = Obj_.TextName;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(TextureName) + "," + 
				"bb.EText";
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(TextureName, "TextureName") + "," + 
				SEnumChecker.GetMemberName(TextName, "TextName");
		}
	}
	public class SCodeRewardClientMeta : SProto
	{
		public Int32 Code = default(Int32);
		public SRewardClientMeta RewardClientMeta = new SRewardClientMeta();
		public SCodeRewardClientMeta()
		{
		}
		public SCodeRewardClientMeta(SCodeRewardClientMeta Obj_)
		{
			Code = Obj_.Code;
			RewardClientMeta = Obj_.RewardClientMeta;
		}
		public SCodeRewardClientMeta(Int32 Code_, SRewardClientMeta RewardClientMeta_)
		{
			Code = Code_;
			RewardClientMeta = RewardClientMeta_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Code);
			Stream_.Pop(ref RewardClientMeta);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Code", ref Code);
			Value_.Pop("RewardClientMeta", ref RewardClientMeta);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Code);
			Stream_.Push(RewardClientMeta);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Code", Code);
			Value_.Push("RewardClientMeta", RewardClientMeta);
		}
		public void Set(SCodeRewardClientMeta Obj_)
		{
			Code = Obj_.Code;
			RewardClientMeta.Set(Obj_.RewardClientMeta);
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Code) + "," + 
				SEnumChecker.GetStdName(RewardClientMeta);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Code, "Code") + "," + 
				SEnumChecker.GetMemberName(RewardClientMeta, "RewardClientMeta");
		}
	}
	public class STrackingMetaParam : SProto
	{
		public String ParamKey = string.Empty;
		public Int32 ParamValue = default(Int32);
		public STrackingMetaParam()
		{
		}
		public STrackingMetaParam(STrackingMetaParam Obj_)
		{
			ParamKey = Obj_.ParamKey;
			ParamValue = Obj_.ParamValue;
		}
		public STrackingMetaParam(String ParamKey_, Int32 ParamValue_)
		{
			ParamKey = ParamKey_;
			ParamValue = ParamValue_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref ParamKey);
			Stream_.Pop(ref ParamValue);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("ParamKey", ref ParamKey);
			Value_.Pop("ParamValue", ref ParamValue);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(ParamKey);
			Stream_.Push(ParamValue);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("ParamKey", ParamKey);
			Value_.Push("ParamValue", ParamValue);
		}
		public void Set(STrackingMetaParam Obj_)
		{
			ParamKey = Obj_.ParamKey;
			ParamValue = Obj_.ParamValue;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(ParamKey) + "," + 
				SEnumChecker.GetStdName(ParamValue);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(ParamKey, "ParamKey") + "," + 
				SEnumChecker.GetMemberName(ParamValue, "ParamValue");
		}
	}
	public class STrackingMeta : SProto
	{
		public ETrackingKey ETrackingKey = default(ETrackingKey);
		public String EventKey = string.Empty;
		public STrackingMetaParam Param = new STrackingMetaParam();
		public STrackingMeta()
		{
		}
		public STrackingMeta(STrackingMeta Obj_)
		{
			ETrackingKey = Obj_.ETrackingKey;
			EventKey = Obj_.EventKey;
			Param = Obj_.Param;
		}
		public STrackingMeta(ETrackingKey ETrackingKey_, String EventKey_, STrackingMetaParam Param_)
		{
			ETrackingKey = ETrackingKey_;
			EventKey = EventKey_;
			Param = Param_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref ETrackingKey);
			Stream_.Pop(ref EventKey);
			Stream_.Pop(ref Param);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("ETrackingKey", ref ETrackingKey);
			Value_.Pop("EventKey", ref EventKey);
			Value_.Pop("Param", ref Param);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(ETrackingKey);
			Stream_.Push(EventKey);
			Stream_.Push(Param);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("ETrackingKey", ETrackingKey);
			Value_.Push("EventKey", EventKey);
			Value_.Push("Param", Param);
		}
		public void Set(STrackingMeta Obj_)
		{
			ETrackingKey = Obj_.ETrackingKey;
			EventKey = Obj_.EventKey;
			Param.Set(Obj_.Param);
		}
		public override string StdName()
		{
			return 
				"bb.ETrackingKey" + "," + 
				SEnumChecker.GetStdName(EventKey) + "," + 
				SEnumChecker.GetStdName(Param);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(ETrackingKey, "ETrackingKey") + "," + 
				SEnumChecker.GetMemberName(EventKey, "EventKey") + "," + 
				SEnumChecker.GetMemberName(Param, "Param");
		}
	}
	public class SGachaRewardClientMeta : SGachaRewardMeta
	{
		public Boolean Event = default(Boolean);
		public SGachaRewardClientMeta()
		{
		}
		public SGachaRewardClientMeta(SGachaRewardClientMeta Obj_) : base(Obj_)
		{
			Event = Obj_.Event;
		}
		public SGachaRewardClientMeta(SGachaRewardMeta Super_, Boolean Event_) : base(Super_)
		{
			Event = Event_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref Event);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("Event", ref Event);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(Event);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("Event", Event);
		}
		public void Set(SGachaRewardClientMeta Obj_)
		{
			base.Set(Obj_);
			Event = Obj_.Event;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(Event);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(Event, "Event");
		}
	}
	public class SSingleCharacterMove : SProto
	{
		public SPoint Pos = new SPoint();
		public SPoint Vel = new SPoint();
		public SSingleCharacterMove()
		{
		}
		public SSingleCharacterMove(SSingleCharacterMove Obj_)
		{
			Pos = Obj_.Pos;
			Vel = Obj_.Vel;
		}
		public SSingleCharacterMove(SPoint Pos_, SPoint Vel_)
		{
			Pos = Pos_;
			Vel = Vel_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Pos);
			Stream_.Pop(ref Vel);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Pos", ref Pos);
			Value_.Pop("Vel", ref Vel);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Pos);
			Stream_.Push(Vel);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Pos", Pos);
			Value_.Push("Vel", Vel);
		}
		public void Set(SSingleCharacterMove Obj_)
		{
			Pos.Set(Obj_.Pos);
			Vel.Set(Obj_.Vel);
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Pos) + "," + 
				SEnumChecker.GetStdName(Vel);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Pos, "Pos") + "," + 
				SEnumChecker.GetMemberName(Vel, "Vel");
		}
	}
	public class SSingleCharacter : SProto
	{
		public SSingleCharacterMove Move = new SSingleCharacterMove();
		public Boolean IsGround = default(Boolean);
		public SByte Dir = default(SByte);
		public SByte BalloonCount = default(SByte);
		public SByte PumpCount = default(SByte);
		public Single Stamina = default(Single);
		public SByte Face = default(SByte);
		public SPoint Acc = new SPoint();
		public SSingleCharacter()
		{
		}
		public SSingleCharacter(SSingleCharacter Obj_)
		{
			Move = Obj_.Move;
			IsGround = Obj_.IsGround;
			Dir = Obj_.Dir;
			BalloonCount = Obj_.BalloonCount;
			PumpCount = Obj_.PumpCount;
			Stamina = Obj_.Stamina;
			Face = Obj_.Face;
			Acc = Obj_.Acc;
		}
		public SSingleCharacter(SSingleCharacterMove Move_, Boolean IsGround_, SByte Dir_, SByte BalloonCount_, SByte PumpCount_, Single Stamina_, SByte Face_, SPoint Acc_)
		{
			Move = Move_;
			IsGround = IsGround_;
			Dir = Dir_;
			BalloonCount = BalloonCount_;
			PumpCount = PumpCount_;
			Stamina = Stamina_;
			Face = Face_;
			Acc = Acc_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Move);
			Stream_.Pop(ref IsGround);
			Stream_.Pop(ref Dir);
			Stream_.Pop(ref BalloonCount);
			Stream_.Pop(ref PumpCount);
			Stream_.Pop(ref Stamina);
			Stream_.Pop(ref Face);
			Stream_.Pop(ref Acc);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Move", ref Move);
			Value_.Pop("IsGround", ref IsGround);
			Value_.Pop("Dir", ref Dir);
			Value_.Pop("BalloonCount", ref BalloonCount);
			Value_.Pop("PumpCount", ref PumpCount);
			Value_.Pop("Stamina", ref Stamina);
			Value_.Pop("Face", ref Face);
			Value_.Pop("Acc", ref Acc);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Move);
			Stream_.Push(IsGround);
			Stream_.Push(Dir);
			Stream_.Push(BalloonCount);
			Stream_.Push(PumpCount);
			Stream_.Push(Stamina);
			Stream_.Push(Face);
			Stream_.Push(Acc);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Move", Move);
			Value_.Push("IsGround", IsGround);
			Value_.Push("Dir", Dir);
			Value_.Push("BalloonCount", BalloonCount);
			Value_.Push("PumpCount", PumpCount);
			Value_.Push("Stamina", Stamina);
			Value_.Push("Face", Face);
			Value_.Push("Acc", Acc);
		}
		public void Set(SSingleCharacter Obj_)
		{
			Move.Set(Obj_.Move);
			IsGround = Obj_.IsGround;
			Dir = Obj_.Dir;
			BalloonCount = Obj_.BalloonCount;
			PumpCount = Obj_.PumpCount;
			Stamina = Obj_.Stamina;
			Face = Obj_.Face;
			Acc.Set(Obj_.Acc);
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Move) + "," + 
				SEnumChecker.GetStdName(IsGround) + "," + 
				SEnumChecker.GetStdName(Dir) + "," + 
				SEnumChecker.GetStdName(BalloonCount) + "," + 
				SEnumChecker.GetStdName(PumpCount) + "," + 
				SEnumChecker.GetStdName(Stamina) + "," + 
				SEnumChecker.GetStdName(Face) + "," + 
				SEnumChecker.GetStdName(Acc);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Move, "Move") + "," + 
				SEnumChecker.GetMemberName(IsGround, "IsGround") + "," + 
				SEnumChecker.GetMemberName(Dir, "Dir") + "," + 
				SEnumChecker.GetMemberName(BalloonCount, "BalloonCount") + "," + 
				SEnumChecker.GetMemberName(PumpCount, "PumpCount") + "," + 
				SEnumChecker.GetMemberName(Stamina, "Stamina") + "," + 
				SEnumChecker.GetMemberName(Face, "Face") + "," + 
				SEnumChecker.GetMemberName(Acc, "Acc");
		}
	}
	public class SSinglePlayer : SProto
	{
		public TUID UID = default(TUID);
		public String Nick = string.Empty;
		public String CountryCode = string.Empty;
		public TTeamCnt TeamIndex = default(TTeamCnt);
		public Int32 CharCode = default(Int32);
		public SSingleCharacter Character = new SSingleCharacter();
		public TimePoint InvulnerableEndTime = default(TimePoint);
		public SSinglePlayer()
		{
		}
		public SSinglePlayer(SSinglePlayer Obj_)
		{
			UID = Obj_.UID;
			Nick = Obj_.Nick;
			CountryCode = Obj_.CountryCode;
			TeamIndex = Obj_.TeamIndex;
			CharCode = Obj_.CharCode;
			Character = Obj_.Character;
			InvulnerableEndTime = Obj_.InvulnerableEndTime;
		}
		public SSinglePlayer(TUID UID_, String Nick_, String CountryCode_, TTeamCnt TeamIndex_, Int32 CharCode_, SSingleCharacter Character_, TimePoint InvulnerableEndTime_)
		{
			UID = UID_;
			Nick = Nick_;
			CountryCode = CountryCode_;
			TeamIndex = TeamIndex_;
			CharCode = CharCode_;
			Character = Character_;
			InvulnerableEndTime = InvulnerableEndTime_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref UID);
			Stream_.Pop(ref Nick);
			Stream_.Pop(ref CountryCode);
			Stream_.Pop(ref TeamIndex);
			Stream_.Pop(ref CharCode);
			Stream_.Pop(ref Character);
			Stream_.Pop(ref InvulnerableEndTime);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("UID", ref UID);
			Value_.Pop("Nick", ref Nick);
			Value_.Pop("CountryCode", ref CountryCode);
			Value_.Pop("TeamIndex", ref TeamIndex);
			Value_.Pop("CharCode", ref CharCode);
			Value_.Pop("Character", ref Character);
			Value_.Pop("InvulnerableEndTime", ref InvulnerableEndTime);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(UID);
			Stream_.Push(Nick);
			Stream_.Push(CountryCode);
			Stream_.Push(TeamIndex);
			Stream_.Push(CharCode);
			Stream_.Push(Character);
			Stream_.Push(InvulnerableEndTime);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("UID", UID);
			Value_.Push("Nick", Nick);
			Value_.Push("CountryCode", CountryCode);
			Value_.Push("TeamIndex", TeamIndex);
			Value_.Push("CharCode", CharCode);
			Value_.Push("Character", Character);
			Value_.Push("InvulnerableEndTime", InvulnerableEndTime);
		}
		public void Set(SSinglePlayer Obj_)
		{
			UID = Obj_.UID;
			Nick = Obj_.Nick;
			CountryCode = Obj_.CountryCode;
			TeamIndex = Obj_.TeamIndex;
			CharCode = Obj_.CharCode;
			Character.Set(Obj_.Character);
			InvulnerableEndTime = Obj_.InvulnerableEndTime;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(UID) + "," + 
				SEnumChecker.GetStdName(Nick) + "," + 
				SEnumChecker.GetStdName(CountryCode) + "," + 
				SEnumChecker.GetStdName(TeamIndex) + "," + 
				SEnumChecker.GetStdName(CharCode) + "," + 
				SEnumChecker.GetStdName(Character) + "," + 
				SEnumChecker.GetStdName(InvulnerableEndTime);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(UID, "UID") + "," + 
				SEnumChecker.GetMemberName(Nick, "Nick") + "," + 
				SEnumChecker.GetMemberName(CountryCode, "CountryCode") + "," + 
				SEnumChecker.GetMemberName(TeamIndex, "TeamIndex") + "," + 
				SEnumChecker.GetMemberName(CharCode, "CharCode") + "," + 
				SEnumChecker.GetMemberName(Character, "Character") + "," + 
				SEnumChecker.GetMemberName(InvulnerableEndTime, "InvulnerableEndTime");
		}
	}
	public class SShopPackageClientMeta : SShopPackageServerMeta
	{
		public EText ETextName = default(EText);
		public String TextureName = string.Empty;
		public SShopPackageClientMeta()
		{
		}
		public SShopPackageClientMeta(SShopPackageClientMeta Obj_) : base(Obj_)
		{
			ETextName = Obj_.ETextName;
			TextureName = Obj_.TextureName;
		}
		public SShopPackageClientMeta(SShopPackageServerMeta Super_, EText ETextName_, String TextureName_) : base(Super_)
		{
			ETextName = ETextName_;
			TextureName = TextureName_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref ETextName);
			Stream_.Pop(ref TextureName);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("ETextName", ref ETextName);
			Value_.Pop("TextureName", ref TextureName);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(ETextName);
			Stream_.Push(TextureName);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("ETextName", ETextName);
			Value_.Push("TextureName", TextureName);
		}
		public void Set(SShopPackageClientMeta Obj_)
		{
			base.Set(Obj_);
			ETextName = Obj_.ETextName;
			TextureName = Obj_.TextureName;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				"bb.EText" + "," + 
				SEnumChecker.GetStdName(TextureName);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(ETextName, "ETextName") + "," + 
				SEnumChecker.GetMemberName(TextureName, "TextureName");
		}
	}
	public class SServerAlarmMeta : SProto
	{
		public String Key = string.Empty;
		public EText ETextName = default(EText);
		public SServerAlarmMeta()
		{
		}
		public SServerAlarmMeta(SServerAlarmMeta Obj_)
		{
			Key = Obj_.Key;
			ETextName = Obj_.ETextName;
		}
		public SServerAlarmMeta(String Key_, EText ETextName_)
		{
			Key = Key_;
			ETextName = ETextName_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Key);
			Stream_.Pop(ref ETextName);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Key", ref Key);
			Value_.Pop("ETextName", ref ETextName);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Key);
			Stream_.Push(ETextName);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Key", Key);
			Value_.Push("ETextName", ETextName);
		}
		public void Set(SServerAlarmMeta Obj_)
		{
			Key = Obj_.Key;
			ETextName = Obj_.ETextName;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Key) + "," + 
				"bb.EText";
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Key, "Key") + "," + 
				SEnumChecker.GetMemberName(ETextName, "ETextName");
		}
	}
	public class SShopPackageDateMeta : SProto
	{
		public Int32 DateId = default(Int32);
		public String BeginTime = string.Empty;
		public String EndTime = string.Empty;
		public Int32 PackageCode = default(Int32);
		public SShopPackageDateMeta()
		{
		}
		public SShopPackageDateMeta(SShopPackageDateMeta Obj_)
		{
			DateId = Obj_.DateId;
			BeginTime = Obj_.BeginTime;
			EndTime = Obj_.EndTime;
			PackageCode = Obj_.PackageCode;
		}
		public SShopPackageDateMeta(Int32 DateId_, String BeginTime_, String EndTime_, Int32 PackageCode_)
		{
			DateId = DateId_;
			BeginTime = BeginTime_;
			EndTime = EndTime_;
			PackageCode = PackageCode_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref DateId);
			Stream_.Pop(ref BeginTime);
			Stream_.Pop(ref EndTime);
			Stream_.Pop(ref PackageCode);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("DateId", ref DateId);
			Value_.Pop("BeginTime", ref BeginTime);
			Value_.Pop("EndTime", ref EndTime);
			Value_.Pop("PackageCode", ref PackageCode);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(DateId);
			Stream_.Push(BeginTime);
			Stream_.Push(EndTime);
			Stream_.Push(PackageCode);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("DateId", DateId);
			Value_.Push("BeginTime", BeginTime);
			Value_.Push("EndTime", EndTime);
			Value_.Push("PackageCode", PackageCode);
		}
		public void Set(SShopPackageDateMeta Obj_)
		{
			DateId = Obj_.DateId;
			BeginTime = Obj_.BeginTime;
			EndTime = Obj_.EndTime;
			PackageCode = Obj_.PackageCode;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(DateId) + "," + 
				SEnumChecker.GetStdName(BeginTime) + "," + 
				SEnumChecker.GetStdName(EndTime) + "," + 
				SEnumChecker.GetStdName(PackageCode);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(DateId, "DateId") + "," + 
				SEnumChecker.GetMemberName(BeginTime, "BeginTime") + "," + 
				SEnumChecker.GetMemberName(EndTime, "EndTime") + "," + 
				SEnumChecker.GetMemberName(PackageCode, "PackageCode");
		}
	}
	public class SMultiItem : SProto
	{
		public EMultiItemType ItemType = default(EMultiItemType);
		public EText Description = default(EText);
		public SMultiItem()
		{
		}
		public SMultiItem(SMultiItem Obj_)
		{
			ItemType = Obj_.ItemType;
			Description = Obj_.Description;
		}
		public SMultiItem(EMultiItemType ItemType_, EText Description_)
		{
			ItemType = ItemType_;
			Description = Description_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref ItemType);
			Stream_.Pop(ref Description);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("ItemType", ref ItemType);
			Value_.Pop("Description", ref Description);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(ItemType);
			Stream_.Push(Description);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("ItemType", ItemType);
			Value_.Push("Description", Description);
		}
		public void Set(SMultiItem Obj_)
		{
			ItemType = Obj_.ItemType;
			Description = Obj_.Description;
		}
		public override string StdName()
		{
			return 
				"bb.EMultiItemType" + "," + 
				"bb.EText";
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(ItemType, "ItemType") + "," + 
				SEnumChecker.GetMemberName(Description, "Description");
		}
	}
	public class SMultiItemDodge : SMultiItem
	{
		public Single MultiDodgeTime = default(Single);
		public Single MultiDodgeValue = default(Single);
		public Int32 MultiDodgeRand = default(Int32);
		public SMultiItemDodge()
		{
		}
		public SMultiItemDodge(SMultiItemDodge Obj_) : base(Obj_)
		{
			MultiDodgeTime = Obj_.MultiDodgeTime;
			MultiDodgeValue = Obj_.MultiDodgeValue;
			MultiDodgeRand = Obj_.MultiDodgeRand;
		}
		public SMultiItemDodge(SMultiItem Super_, Single MultiDodgeTime_, Single MultiDodgeValue_, Int32 MultiDodgeRand_) : base(Super_)
		{
			MultiDodgeTime = MultiDodgeTime_;
			MultiDodgeValue = MultiDodgeValue_;
			MultiDodgeRand = MultiDodgeRand_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref MultiDodgeTime);
			Stream_.Pop(ref MultiDodgeValue);
			Stream_.Pop(ref MultiDodgeRand);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("MultiDodgeTime", ref MultiDodgeTime);
			Value_.Pop("MultiDodgeValue", ref MultiDodgeValue);
			Value_.Pop("MultiDodgeRand", ref MultiDodgeRand);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(MultiDodgeTime);
			Stream_.Push(MultiDodgeValue);
			Stream_.Push(MultiDodgeRand);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("MultiDodgeTime", MultiDodgeTime);
			Value_.Push("MultiDodgeValue", MultiDodgeValue);
			Value_.Push("MultiDodgeRand", MultiDodgeRand);
		}
		public void Set(SMultiItemDodge Obj_)
		{
			base.Set(Obj_);
			MultiDodgeTime = Obj_.MultiDodgeTime;
			MultiDodgeValue = Obj_.MultiDodgeValue;
			MultiDodgeRand = Obj_.MultiDodgeRand;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(MultiDodgeTime) + "," + 
				SEnumChecker.GetStdName(MultiDodgeValue) + "," + 
				SEnumChecker.GetStdName(MultiDodgeRand);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(MultiDodgeTime, "MultiDodgeTime") + "," + 
				SEnumChecker.GetMemberName(MultiDodgeValue, "MultiDodgeValue") + "," + 
				SEnumChecker.GetMemberName(MultiDodgeRand, "MultiDodgeRand");
		}
	}
	public class SMultiItemIsland : SMultiItem
	{
		public Single MultiIslandTime = default(Single);
		public Single MultiIslandValue = default(Single);
		public Int32 MultiIslandRand = default(Int32);
		public SMultiItemIsland()
		{
		}
		public SMultiItemIsland(SMultiItemIsland Obj_) : base(Obj_)
		{
			MultiIslandTime = Obj_.MultiIslandTime;
			MultiIslandValue = Obj_.MultiIslandValue;
			MultiIslandRand = Obj_.MultiIslandRand;
		}
		public SMultiItemIsland(SMultiItem Super_, Single MultiIslandTime_, Single MultiIslandValue_, Int32 MultiIslandRand_) : base(Super_)
		{
			MultiIslandTime = MultiIslandTime_;
			MultiIslandValue = MultiIslandValue_;
			MultiIslandRand = MultiIslandRand_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref MultiIslandTime);
			Stream_.Pop(ref MultiIslandValue);
			Stream_.Pop(ref MultiIslandRand);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("MultiIslandTime", ref MultiIslandTime);
			Value_.Pop("MultiIslandValue", ref MultiIslandValue);
			Value_.Pop("MultiIslandRand", ref MultiIslandRand);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(MultiIslandTime);
			Stream_.Push(MultiIslandValue);
			Stream_.Push(MultiIslandRand);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("MultiIslandTime", MultiIslandTime);
			Value_.Push("MultiIslandValue", MultiIslandValue);
			Value_.Push("MultiIslandRand", MultiIslandRand);
		}
		public void Set(SMultiItemIsland Obj_)
		{
			base.Set(Obj_);
			MultiIslandTime = Obj_.MultiIslandTime;
			MultiIslandValue = Obj_.MultiIslandValue;
			MultiIslandRand = Obj_.MultiIslandRand;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(MultiIslandTime) + "," + 
				SEnumChecker.GetStdName(MultiIslandValue) + "," + 
				SEnumChecker.GetStdName(MultiIslandRand);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(MultiIslandTime, "MultiIslandTime") + "," + 
				SEnumChecker.GetMemberName(MultiIslandValue, "MultiIslandValue") + "," + 
				SEnumChecker.GetMemberName(MultiIslandRand, "MultiIslandRand");
		}
	}
	public class QuestTypeValueMeta : SProto
	{
		public EText textName = default(EText);
		public String iconName = string.Empty;
		public QuestTypeValueMeta()
		{
		}
		public QuestTypeValueMeta(QuestTypeValueMeta Obj_)
		{
			textName = Obj_.textName;
			iconName = Obj_.iconName;
		}
		public QuestTypeValueMeta(EText textName_, String iconName_)
		{
			textName = textName_;
			iconName = iconName_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref textName);
			Stream_.Pop(ref iconName);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("textName", ref textName);
			Value_.Pop("iconName", ref iconName);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(textName);
			Stream_.Push(iconName);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("textName", textName);
			Value_.Push("iconName", iconName);
		}
		public void Set(QuestTypeValueMeta Obj_)
		{
			textName = Obj_.textName;
			iconName = Obj_.iconName;
		}
		public override string StdName()
		{
			return 
				"bb.EText" + "," + 
				SEnumChecker.GetStdName(iconName);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(textName, "textName") + "," + 
				SEnumChecker.GetMemberName(iconName, "iconName");
		}
	}
	public class QuestTypeKeyValueMeta : SProto
	{
		public EQuestType questType = default(EQuestType);
		public QuestTypeValueMeta questTypeValueMeta = new QuestTypeValueMeta();
		public QuestTypeKeyValueMeta()
		{
		}
		public QuestTypeKeyValueMeta(QuestTypeKeyValueMeta Obj_)
		{
			questType = Obj_.questType;
			questTypeValueMeta = Obj_.questTypeValueMeta;
		}
		public QuestTypeKeyValueMeta(EQuestType questType_, QuestTypeValueMeta questTypeValueMeta_)
		{
			questType = questType_;
			questTypeValueMeta = questTypeValueMeta_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref questType);
			Stream_.Pop(ref questTypeValueMeta);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("questType", ref questType);
			Value_.Pop("questTypeValueMeta", ref questTypeValueMeta);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(questType);
			Stream_.Push(questTypeValueMeta);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("questType", questType);
			Value_.Push("questTypeValueMeta", questTypeValueMeta);
		}
		public void Set(QuestTypeKeyValueMeta Obj_)
		{
			questType = Obj_.questType;
			questTypeValueMeta.Set(Obj_.questTypeValueMeta);
		}
		public override string StdName()
		{
			return 
				"bb.EQuestType" + "," + 
				SEnumChecker.GetStdName(questTypeValueMeta);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(questType, "questType") + "," + 
				SEnumChecker.GetMemberName(questTypeValueMeta, "questTypeValueMeta");
		}
	}
}

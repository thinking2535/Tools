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
using System;
using System.Collections.Generic;
using rso.core;


namespace bb
{
	using rso.net;
	using rso.game;
	using rso.physics;
	using rso.gameutil;
	public enum EProtoNetCs
	{
		Chat,
		FCMTokenSet,
		FCMTokenUnset,
		FCMCanPushAtNight,
		ChangeLanguage,
		Buy,
		BuyChar,
		BuyPackage,
		DailyReward,
		SelectChar,
		BattleTouch,
		BattlePush,
		MultiBattleJoin,
		MultiBattleOut,
		MultiBattleIcon,
		ArrowDodgeBattleJoin,
		ArrowDodgeBattleEnd,
		FlyAwayBattleJoin,
		FlyAwayBattleEnd,
		Gacha,
		GachaX10,
		RankReward,
		QuestReward,
		QuestNext,
		QuestDailyCompleteReward,
		ChangeNick,
		CouponUse,
		TutorialReward,
		RankingRewardInfo,
		RankingReward,
		Max,
		Null,
	}
	public enum EProtoNetSc
	{
		Ret,
		Msg,
		Login,
		Lobby,
		Chat,
		UserExp,
		Resources,
		SetPoint,
		SetChar,
		UnsetChar,
		Buy,
		BuyChar,
		BuyPackage,
		DailyReward,
		DailyRewardFail,
		BattleSync,
		BattleTouch,
		BattlePush,
		MultiBattleJoin,
		MultiBattleOut,
		MultiBattleBegin,
		MultiBattleStart,
		MultiBattleEnd,
		MultiBattleEndDraw,
		MultiBattleEndInvalid,
		MultiBattleIcon,
		MultiBattleLink,
		MultiBattleUnLink,
		InvalidDisconnectInfo,
		ArrowDodgeBattleJoin,
		ArrowDodgeBattleBegin,
		ArrowDodgeBattleStart,
		ArrowDodgeBattleEnd,
		FlyAwayBattleJoin,
		FlyAwayBattleBegin,
		FlyAwayBattleStart,
		FlyAwayBattleEnd,
		Gacha,
		GachaX10,
		GachaFailed,
		RankReward,
		QuestGot,
		QuestDone,
		QuestReward,
		QuestNext,
		QuestDailyCompleteReward,
		ChangeNick,
		ChangeNickFail,
		CouponUse,
		CouponUseFail,
		RankingRewardInfo,
		RankingReward,
		RankingRewardFail,
		Max,
	}
	public enum ERet
	{
		Ok,
		InvalidTime,
		UserDoesNotExist,
		SameCanNotPushAtNight,
		SameCode,
		InvalidProtocol,
		InvalidLanguage,
		InvalidShopID,
		InvalidGoodsID,
		InvalidCharCode,
		ReceiptCheckFail,
		SPError,
		NotBattleJoining,
		AlreadyBattleJoining,
		AlreadyInBattle,
		AlreadyHave,
		InvalidBattleType,
		MatchInsertFail,
		BattleBeginFail,
		NotEnoughMoney,
		NoMoreNewCharacter,
		NickLengthUnderMin,
		NickLengthOverMax,
		CouponAlreadyUsed,
		CouponInvalid,
		RankingServerOffLine,
		RankingNoReward,
		RankingRewarded,
		RankingRewardFail,
		Max,
		Null,
	}
	public enum ELanguage : Byte
	{
		English,
		Korean,
		France,
		Germany,
		Spain,
		Italia,
		ChinaCH,
		ChinaTW,
		Japan,
		Portugal,
		Russia,
		Nederland,
		Turkey,
		Finland,
		Malaysia,
		Thailand,
		Indonesia,
		Vietnam,
		India,
		Max,
	}
	public enum EGrade : Byte
	{
		Normal,
		Rare,
		Epic,
		Unique,
		Max,
	}
	public class SRankingUser : SProto
	{
		public TUID UID = default(TUID);
		public String Nick = string.Empty;
		public Int32 CharCode = default(Int32);
		public String CountryCode = string.Empty;
		public Int32 Point = default(Int32);
		public SRankingUser()
		{
		}
		public SRankingUser(SRankingUser Obj_)
		{
			UID = Obj_.UID;
			Nick = Obj_.Nick;
			CharCode = Obj_.CharCode;
			CountryCode = Obj_.CountryCode;
			Point = Obj_.Point;
		}
		public SRankingUser(TUID UID_, String Nick_, Int32 CharCode_, String CountryCode_, Int32 Point_)
		{
			UID = UID_;
			Nick = Nick_;
			CharCode = CharCode_;
			CountryCode = CountryCode_;
			Point = Point_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref UID);
			Stream_.Pop(ref Nick);
			Stream_.Pop(ref CharCode);
			Stream_.Pop(ref CountryCode);
			Stream_.Pop(ref Point);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("UID", ref UID);
			Value_.Pop("Nick", ref Nick);
			Value_.Pop("CharCode", ref CharCode);
			Value_.Pop("CountryCode", ref CountryCode);
			Value_.Pop("Point", ref Point);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(UID);
			Stream_.Push(Nick);
			Stream_.Push(CharCode);
			Stream_.Push(CountryCode);
			Stream_.Push(Point);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("UID", UID);
			Value_.Push("Nick", Nick);
			Value_.Push("CharCode", CharCode);
			Value_.Push("CountryCode", CountryCode);
			Value_.Push("Point", Point);
		}
		public void Set(SRankingUser Obj_)
		{
			UID = Obj_.UID;
			Nick = Obj_.Nick;
			CharCode = Obj_.CharCode;
			CountryCode = Obj_.CountryCode;
			Point = Obj_.Point;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(UID) + "," + 
				SEnumChecker.GetStdName(Nick) + "," + 
				SEnumChecker.GetStdName(CharCode) + "," + 
				SEnumChecker.GetStdName(CountryCode) + "," + 
				SEnumChecker.GetStdName(Point);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(UID, "UID") + "," + 
				SEnumChecker.GetMemberName(Nick, "Nick") + "," + 
				SEnumChecker.GetMemberName(CharCode, "CharCode") + "," + 
				SEnumChecker.GetMemberName(CountryCode, "CountryCode") + "," + 
				SEnumChecker.GetMemberName(Point, "Point");
		}
	}
	public class SRankingUsers : SProto
	{
		public TRankingUsers RankingUsers = new TRankingUsers();
		public SRankingUsers()
		{
		}
		public SRankingUsers(SRankingUsers Obj_)
		{
			RankingUsers = Obj_.RankingUsers;
		}
		public SRankingUsers(TRankingUsers RankingUsers_)
		{
			RankingUsers = RankingUsers_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref RankingUsers);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("RankingUsers", ref RankingUsers);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(RankingUsers);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("RankingUsers", RankingUsers);
		}
		public void Set(SRankingUsers Obj_)
		{
			RankingUsers = Obj_.RankingUsers;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(RankingUsers);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(RankingUsers, "RankingUsers");
		}
	}
	public enum ERankingType
	{
		Multi,
		Single,
		Island,
		Max,
		Null,
	}
	public class SUserLoginOption : SProto
	{
		public EOS OS = default(EOS);
		public SUserLoginOption()
		{
		}
		public SUserLoginOption(SUserLoginOption Obj_)
		{
			OS = Obj_.OS;
		}
		public SUserLoginOption(EOS OS_)
		{
			OS = OS_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref OS);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("OS", ref OS);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(OS);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("OS", OS);
		}
		public void Set(SUserLoginOption Obj_)
		{
			OS = Obj_.OS;
		}
		public override string StdName()
		{
			return 
				"rso.gameutil.EOS";
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(OS, "OS");
		}
	}
	public class SUserCreateOption : SProto
	{
		public SUserLoginOption LoginOption = new SUserLoginOption();
		public ELanguage Language = default(ELanguage);
		public SUserCreateOption()
		{
		}
		public SUserCreateOption(SUserCreateOption Obj_)
		{
			LoginOption = Obj_.LoginOption;
			Language = Obj_.Language;
		}
		public SUserCreateOption(SUserLoginOption LoginOption_, ELanguage Language_)
		{
			LoginOption = LoginOption_;
			Language = Language_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref LoginOption);
			Stream_.Pop(ref Language);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("LoginOption", ref LoginOption);
			Value_.Pop("Language", ref Language);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(LoginOption);
			Stream_.Push(Language);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("LoginOption", LoginOption);
			Value_.Push("Language", Language);
		}
		public void Set(SUserCreateOption Obj_)
		{
			LoginOption.Set(Obj_.LoginOption);
			Language = Obj_.Language;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(LoginOption) + "," + 
				"bb.ELanguage";
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(LoginOption, "LoginOption") + "," + 
				SEnumChecker.GetMemberName(Language, "Language");
		}
	}
	public enum EResource
	{
		Ticket,
		Gold,
		Dia00,
		Dia01,
		Dia02,
		Dia03,
		Max,
		Null,
	}
	public enum EQuestType
	{
		IngameBalloonPopping,
		IngameKill,
		BlowBalloon,
		PlayNormal,
		PlayRare,
		PlayEpic,
		PlaySingle,
		SingleTime,
		SinglePlayScoreGet,
		PlayIsland,
		IslandCount,
		IslandScoreGet,
		RankPointGet,
		SoloPlay,
		SoloVictory,
		Max,
		Null=-1,
	}
	public class SQuestSlotIndexCount : SProto
	{
		public TQuestSlotIndex SlotIndex = default(TQuestSlotIndex);
		public Int32 Count = default(Int32);
		public SQuestSlotIndexCount()
		{
		}
		public SQuestSlotIndexCount(SQuestSlotIndexCount Obj_)
		{
			SlotIndex = Obj_.SlotIndex;
			Count = Obj_.Count;
		}
		public SQuestSlotIndexCount(TQuestSlotIndex SlotIndex_, Int32 Count_)
		{
			SlotIndex = SlotIndex_;
			Count = Count_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref SlotIndex);
			Stream_.Pop(ref Count);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("SlotIndex", ref SlotIndex);
			Value_.Pop("Count", ref Count);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(SlotIndex);
			Stream_.Push(Count);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("SlotIndex", SlotIndex);
			Value_.Push("Count", Count);
		}
		public void Set(SQuestSlotIndexCount Obj_)
		{
			SlotIndex = Obj_.SlotIndex;
			Count = Obj_.Count;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(SlotIndex) + "," + 
				SEnumChecker.GetStdName(Count);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(SlotIndex, "SlotIndex") + "," + 
				SEnumChecker.GetMemberName(Count, "Count");
		}
	}
	public class SRetNetSc : SProto
	{
		public ERet Ret = default(ERet);
		public SRetNetSc()
		{
		}
		public SRetNetSc(SRetNetSc Obj_)
		{
			Ret = Obj_.Ret;
		}
		public SRetNetSc(ERet Ret_)
		{
			Ret = Ret_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Ret);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Ret", ref Ret);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Ret);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Ret", Ret);
		}
		public void Set(SRetNetSc Obj_)
		{
			Ret = Obj_.Ret;
		}
		public override string StdName()
		{
			return 
				"bb.ERet";
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Ret, "Ret");
		}
	}
	public class SMsgNetSc : SProto
	{
		public String Msg = string.Empty;
		public SMsgNetSc()
		{
		}
		public SMsgNetSc(SMsgNetSc Obj_)
		{
			Msg = Obj_.Msg;
		}
		public SMsgNetSc(String Msg_)
		{
			Msg = Msg_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Msg);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Msg", ref Msg);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Msg);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Msg", Msg);
		}
		public void Set(SMsgNetSc Obj_)
		{
			Msg = Obj_.Msg;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Msg);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Msg, "Msg");
		}
	}
	public class SResourceTypeData : SProto
	{
		public EResource Type = default(EResource);
		public TResource Data = default(TResource);
		public SResourceTypeData()
		{
		}
		public SResourceTypeData(SResourceTypeData Obj_)
		{
			Type = Obj_.Type;
			Data = Obj_.Data;
		}
		public SResourceTypeData(EResource Type_, TResource Data_)
		{
			Type = Type_;
			Data = Data_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Type);
			Stream_.Pop(ref Data);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Type", ref Type);
			Value_.Pop("Data", ref Data);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Type);
			Stream_.Push(Data);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Type", Type);
			Value_.Push("Data", Data);
		}
		public void Set(SResourceTypeData Obj_)
		{
			Type = Obj_.Type;
			Data = Obj_.Data;
		}
		public override string StdName()
		{
			return 
				"bb.EResource" + "," + 
				SEnumChecker.GetStdName(Data);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Type, "Type") + "," + 
				SEnumChecker.GetMemberName(Data, "Data");
		}
	}
	public class SUserCore : SProto
	{
		public TResource[] Resources = new TResource[6];
		public SByte Debug = default(SByte);
		public Int32 SelectedCharCode = default(Int32);
		public Int32 SinglePlayCount = default(Int32);
		public TimePoint SingleRefreshTime = default(TimePoint);
		public Int32 IslandPlayCount = default(Int32);
		public TimePoint IslandRefreshTime = default(TimePoint);
		public TimePoint QuestDailyCompleteRefreshTime = default(TimePoint);
		public Int32 ChangeNickFreeCount = default(Int32);
		public TimePoint DailyRewardExpiredTime = default(TimePoint);
		public Int32 DailyRewardCountLeft = default(Int32);
		public SUserCore()
		{
			for (int iResources = 0; iResources < Resources.Length; ++iResources)
				Resources[iResources] = default(TResource);
		}
		public SUserCore(SUserCore Obj_)
		{
			Resources = Obj_.Resources;
			Debug = Obj_.Debug;
			SelectedCharCode = Obj_.SelectedCharCode;
			SinglePlayCount = Obj_.SinglePlayCount;
			SingleRefreshTime = Obj_.SingleRefreshTime;
			IslandPlayCount = Obj_.IslandPlayCount;
			IslandRefreshTime = Obj_.IslandRefreshTime;
			QuestDailyCompleteRefreshTime = Obj_.QuestDailyCompleteRefreshTime;
			ChangeNickFreeCount = Obj_.ChangeNickFreeCount;
			DailyRewardExpiredTime = Obj_.DailyRewardExpiredTime;
			DailyRewardCountLeft = Obj_.DailyRewardCountLeft;
		}
		public SUserCore(TResource[] Resources_, SByte Debug_, Int32 SelectedCharCode_, Int32 SinglePlayCount_, TimePoint SingleRefreshTime_, Int32 IslandPlayCount_, TimePoint IslandRefreshTime_, TimePoint QuestDailyCompleteRefreshTime_, Int32 ChangeNickFreeCount_, TimePoint DailyRewardExpiredTime_, Int32 DailyRewardCountLeft_)
		{
			Resources = Resources_;
			Debug = Debug_;
			SelectedCharCode = SelectedCharCode_;
			SinglePlayCount = SinglePlayCount_;
			SingleRefreshTime = SingleRefreshTime_;
			IslandPlayCount = IslandPlayCount_;
			IslandRefreshTime = IslandRefreshTime_;
			QuestDailyCompleteRefreshTime = QuestDailyCompleteRefreshTime_;
			ChangeNickFreeCount = ChangeNickFreeCount_;
			DailyRewardExpiredTime = DailyRewardExpiredTime_;
			DailyRewardCountLeft = DailyRewardCountLeft_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Resources);
			Stream_.Pop(ref Debug);
			Stream_.Pop(ref SelectedCharCode);
			Stream_.Pop(ref SinglePlayCount);
			Stream_.Pop(ref SingleRefreshTime);
			Stream_.Pop(ref IslandPlayCount);
			Stream_.Pop(ref IslandRefreshTime);
			Stream_.Pop(ref QuestDailyCompleteRefreshTime);
			Stream_.Pop(ref ChangeNickFreeCount);
			Stream_.Pop(ref DailyRewardExpiredTime);
			Stream_.Pop(ref DailyRewardCountLeft);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Resources", ref Resources);
			Value_.Pop("Debug", ref Debug);
			Value_.Pop("SelectedCharCode", ref SelectedCharCode);
			Value_.Pop("SinglePlayCount", ref SinglePlayCount);
			Value_.Pop("SingleRefreshTime", ref SingleRefreshTime);
			Value_.Pop("IslandPlayCount", ref IslandPlayCount);
			Value_.Pop("IslandRefreshTime", ref IslandRefreshTime);
			Value_.Pop("QuestDailyCompleteRefreshTime", ref QuestDailyCompleteRefreshTime);
			Value_.Pop("ChangeNickFreeCount", ref ChangeNickFreeCount);
			Value_.Pop("DailyRewardExpiredTime", ref DailyRewardExpiredTime);
			Value_.Pop("DailyRewardCountLeft", ref DailyRewardCountLeft);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Resources);
			Stream_.Push(Debug);
			Stream_.Push(SelectedCharCode);
			Stream_.Push(SinglePlayCount);
			Stream_.Push(SingleRefreshTime);
			Stream_.Push(IslandPlayCount);
			Stream_.Push(IslandRefreshTime);
			Stream_.Push(QuestDailyCompleteRefreshTime);
			Stream_.Push(ChangeNickFreeCount);
			Stream_.Push(DailyRewardExpiredTime);
			Stream_.Push(DailyRewardCountLeft);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Resources", Resources);
			Value_.Push("Debug", Debug);
			Value_.Push("SelectedCharCode", SelectedCharCode);
			Value_.Push("SinglePlayCount", SinglePlayCount);
			Value_.Push("SingleRefreshTime", SingleRefreshTime);
			Value_.Push("IslandPlayCount", IslandPlayCount);
			Value_.Push("IslandRefreshTime", IslandRefreshTime);
			Value_.Push("QuestDailyCompleteRefreshTime", QuestDailyCompleteRefreshTime);
			Value_.Push("ChangeNickFreeCount", ChangeNickFreeCount);
			Value_.Push("DailyRewardExpiredTime", DailyRewardExpiredTime);
			Value_.Push("DailyRewardCountLeft", DailyRewardCountLeft);
		}
		public void Set(SUserCore Obj_)
		{
			Resources = Obj_.Resources;
			Debug = Obj_.Debug;
			SelectedCharCode = Obj_.SelectedCharCode;
			SinglePlayCount = Obj_.SinglePlayCount;
			SingleRefreshTime = Obj_.SingleRefreshTime;
			IslandPlayCount = Obj_.IslandPlayCount;
			IslandRefreshTime = Obj_.IslandRefreshTime;
			QuestDailyCompleteRefreshTime = Obj_.QuestDailyCompleteRefreshTime;
			ChangeNickFreeCount = Obj_.ChangeNickFreeCount;
			DailyRewardExpiredTime = Obj_.DailyRewardExpiredTime;
			DailyRewardCountLeft = Obj_.DailyRewardCountLeft;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Resources) + "," + 
				SEnumChecker.GetStdName(Debug) + "," + 
				SEnumChecker.GetStdName(SelectedCharCode) + "," + 
				SEnumChecker.GetStdName(SinglePlayCount) + "," + 
				SEnumChecker.GetStdName(SingleRefreshTime) + "," + 
				SEnumChecker.GetStdName(IslandPlayCount) + "," + 
				SEnumChecker.GetStdName(IslandRefreshTime) + "," + 
				SEnumChecker.GetStdName(QuestDailyCompleteRefreshTime) + "," + 
				SEnumChecker.GetStdName(ChangeNickFreeCount) + "," + 
				SEnumChecker.GetStdName(DailyRewardExpiredTime) + "," + 
				SEnumChecker.GetStdName(DailyRewardCountLeft);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Resources, "Resources") + "," + 
				SEnumChecker.GetMemberName(Debug, "Debug") + "," + 
				SEnumChecker.GetMemberName(SelectedCharCode, "SelectedCharCode") + "," + 
				SEnumChecker.GetMemberName(SinglePlayCount, "SinglePlayCount") + "," + 
				SEnumChecker.GetMemberName(SingleRefreshTime, "SingleRefreshTime") + "," + 
				SEnumChecker.GetMemberName(IslandPlayCount, "IslandPlayCount") + "," + 
				SEnumChecker.GetMemberName(IslandRefreshTime, "IslandRefreshTime") + "," + 
				SEnumChecker.GetMemberName(QuestDailyCompleteRefreshTime, "QuestDailyCompleteRefreshTime") + "," + 
				SEnumChecker.GetMemberName(ChangeNickFreeCount, "ChangeNickFreeCount") + "," + 
				SEnumChecker.GetMemberName(DailyRewardExpiredTime, "DailyRewardExpiredTime") + "," + 
				SEnumChecker.GetMemberName(DailyRewardCountLeft, "DailyRewardCountLeft");
		}
	}
	public class SInvalidDisconnectInfo : SProto
	{
		public TimePoint EndTime = default(TimePoint);
		public TimePoint MatchBlockEndTime = default(TimePoint);
		public Int32 Count = default(Int32);
		public SInvalidDisconnectInfo()
		{
		}
		public SInvalidDisconnectInfo(SInvalidDisconnectInfo Obj_)
		{
			EndTime = Obj_.EndTime;
			MatchBlockEndTime = Obj_.MatchBlockEndTime;
			Count = Obj_.Count;
		}
		public SInvalidDisconnectInfo(TimePoint EndTime_, TimePoint MatchBlockEndTime_, Int32 Count_)
		{
			EndTime = EndTime_;
			MatchBlockEndTime = MatchBlockEndTime_;
			Count = Count_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref EndTime);
			Stream_.Pop(ref MatchBlockEndTime);
			Stream_.Pop(ref Count);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("EndTime", ref EndTime);
			Value_.Pop("MatchBlockEndTime", ref MatchBlockEndTime);
			Value_.Pop("Count", ref Count);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(EndTime);
			Stream_.Push(MatchBlockEndTime);
			Stream_.Push(Count);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("EndTime", EndTime);
			Value_.Push("MatchBlockEndTime", MatchBlockEndTime);
			Value_.Push("Count", Count);
		}
		public void Set(SInvalidDisconnectInfo Obj_)
		{
			EndTime = Obj_.EndTime;
			MatchBlockEndTime = Obj_.MatchBlockEndTime;
			Count = Obj_.Count;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(EndTime) + "," + 
				SEnumChecker.GetStdName(MatchBlockEndTime) + "," + 
				SEnumChecker.GetStdName(Count);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(EndTime, "EndTime") + "," + 
				SEnumChecker.GetMemberName(MatchBlockEndTime, "MatchBlockEndTime") + "," + 
				SEnumChecker.GetMemberName(Count, "Count");
		}
	}
	public class SUserBase : SUserCore
	{
		public TExp Exp = default(TExp);
		public Boolean CanPushAtNight = default(Boolean);
		public Int32 Point = default(Int32);
		public Int32 PointBest = default(Int32);
		public Int32 LastGotRewardRankIndex = default(Int32);
		public Int32 WinCountSolo = default(Int32);
		public Int32 LoseCountSolo = default(Int32);
		public Int32 WinCountMulti = default(Int32);
		public Int32 LoseCountMulti = default(Int32);
		public Int32 BattlePointBest = default(Int32);
		public Int32 SinglePointBest = default(Int32);
		public Int32 IslandPointBest = default(Int32);
		public Int64 SingleBestTick = default(Int64);
		public Int32 IslandPassedCountBest = default(Int32);
		public Int32 KillTotal = default(Int32);
		public Int32 ChainKillTotal = default(Int32);
		public Int32 BlowBalloonTotal = default(Int32);
		public Int32 QuestDailyCompleteCount = default(Int32);
		public Boolean TutorialReward = default(Boolean);
		public Int64 RankingRewardedCounter = default(Int64);
		public TNick NewNick = string.Empty;
		public SInvalidDisconnectInfo InvalidDisconnectInfo = new SInvalidDisconnectInfo();
		public SUserBase()
		{
		}
		public SUserBase(SUserBase Obj_) : base(Obj_)
		{
			Exp = Obj_.Exp;
			CanPushAtNight = Obj_.CanPushAtNight;
			Point = Obj_.Point;
			PointBest = Obj_.PointBest;
			LastGotRewardRankIndex = Obj_.LastGotRewardRankIndex;
			WinCountSolo = Obj_.WinCountSolo;
			LoseCountSolo = Obj_.LoseCountSolo;
			WinCountMulti = Obj_.WinCountMulti;
			LoseCountMulti = Obj_.LoseCountMulti;
			BattlePointBest = Obj_.BattlePointBest;
			SinglePointBest = Obj_.SinglePointBest;
			IslandPointBest = Obj_.IslandPointBest;
			SingleBestTick = Obj_.SingleBestTick;
			IslandPassedCountBest = Obj_.IslandPassedCountBest;
			KillTotal = Obj_.KillTotal;
			ChainKillTotal = Obj_.ChainKillTotal;
			BlowBalloonTotal = Obj_.BlowBalloonTotal;
			QuestDailyCompleteCount = Obj_.QuestDailyCompleteCount;
			TutorialReward = Obj_.TutorialReward;
			RankingRewardedCounter = Obj_.RankingRewardedCounter;
			NewNick = Obj_.NewNick;
			InvalidDisconnectInfo = Obj_.InvalidDisconnectInfo;
		}
		public SUserBase(SUserCore Super_, TExp Exp_, Boolean CanPushAtNight_, Int32 Point_, Int32 PointBest_, Int32 LastGotRewardRankIndex_, Int32 WinCountSolo_, Int32 LoseCountSolo_, Int32 WinCountMulti_, Int32 LoseCountMulti_, Int32 BattlePointBest_, Int32 SinglePointBest_, Int32 IslandPointBest_, Int64 SingleBestTick_, Int32 IslandPassedCountBest_, Int32 KillTotal_, Int32 ChainKillTotal_, Int32 BlowBalloonTotal_, Int32 QuestDailyCompleteCount_, Boolean TutorialReward_, Int64 RankingRewardedCounter_, TNick NewNick_, SInvalidDisconnectInfo InvalidDisconnectInfo_) : base(Super_)
		{
			Exp = Exp_;
			CanPushAtNight = CanPushAtNight_;
			Point = Point_;
			PointBest = PointBest_;
			LastGotRewardRankIndex = LastGotRewardRankIndex_;
			WinCountSolo = WinCountSolo_;
			LoseCountSolo = LoseCountSolo_;
			WinCountMulti = WinCountMulti_;
			LoseCountMulti = LoseCountMulti_;
			BattlePointBest = BattlePointBest_;
			SinglePointBest = SinglePointBest_;
			IslandPointBest = IslandPointBest_;
			SingleBestTick = SingleBestTick_;
			IslandPassedCountBest = IslandPassedCountBest_;
			KillTotal = KillTotal_;
			ChainKillTotal = ChainKillTotal_;
			BlowBalloonTotal = BlowBalloonTotal_;
			QuestDailyCompleteCount = QuestDailyCompleteCount_;
			TutorialReward = TutorialReward_;
			RankingRewardedCounter = RankingRewardedCounter_;
			NewNick = NewNick_;
			InvalidDisconnectInfo = InvalidDisconnectInfo_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref Exp);
			Stream_.Pop(ref CanPushAtNight);
			Stream_.Pop(ref Point);
			Stream_.Pop(ref PointBest);
			Stream_.Pop(ref LastGotRewardRankIndex);
			Stream_.Pop(ref WinCountSolo);
			Stream_.Pop(ref LoseCountSolo);
			Stream_.Pop(ref WinCountMulti);
			Stream_.Pop(ref LoseCountMulti);
			Stream_.Pop(ref BattlePointBest);
			Stream_.Pop(ref SinglePointBest);
			Stream_.Pop(ref IslandPointBest);
			Stream_.Pop(ref SingleBestTick);
			Stream_.Pop(ref IslandPassedCountBest);
			Stream_.Pop(ref KillTotal);
			Stream_.Pop(ref ChainKillTotal);
			Stream_.Pop(ref BlowBalloonTotal);
			Stream_.Pop(ref QuestDailyCompleteCount);
			Stream_.Pop(ref TutorialReward);
			Stream_.Pop(ref RankingRewardedCounter);
			Stream_.Pop(ref NewNick);
			Stream_.Pop(ref InvalidDisconnectInfo);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("Exp", ref Exp);
			Value_.Pop("CanPushAtNight", ref CanPushAtNight);
			Value_.Pop("Point", ref Point);
			Value_.Pop("PointBest", ref PointBest);
			Value_.Pop("LastGotRewardRankIndex", ref LastGotRewardRankIndex);
			Value_.Pop("WinCountSolo", ref WinCountSolo);
			Value_.Pop("LoseCountSolo", ref LoseCountSolo);
			Value_.Pop("WinCountMulti", ref WinCountMulti);
			Value_.Pop("LoseCountMulti", ref LoseCountMulti);
			Value_.Pop("BattlePointBest", ref BattlePointBest);
			Value_.Pop("SinglePointBest", ref SinglePointBest);
			Value_.Pop("IslandPointBest", ref IslandPointBest);
			Value_.Pop("SingleBestTick", ref SingleBestTick);
			Value_.Pop("IslandPassedCountBest", ref IslandPassedCountBest);
			Value_.Pop("KillTotal", ref KillTotal);
			Value_.Pop("ChainKillTotal", ref ChainKillTotal);
			Value_.Pop("BlowBalloonTotal", ref BlowBalloonTotal);
			Value_.Pop("QuestDailyCompleteCount", ref QuestDailyCompleteCount);
			Value_.Pop("TutorialReward", ref TutorialReward);
			Value_.Pop("RankingRewardedCounter", ref RankingRewardedCounter);
			Value_.Pop("NewNick", ref NewNick);
			Value_.Pop("InvalidDisconnectInfo", ref InvalidDisconnectInfo);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(Exp);
			Stream_.Push(CanPushAtNight);
			Stream_.Push(Point);
			Stream_.Push(PointBest);
			Stream_.Push(LastGotRewardRankIndex);
			Stream_.Push(WinCountSolo);
			Stream_.Push(LoseCountSolo);
			Stream_.Push(WinCountMulti);
			Stream_.Push(LoseCountMulti);
			Stream_.Push(BattlePointBest);
			Stream_.Push(SinglePointBest);
			Stream_.Push(IslandPointBest);
			Stream_.Push(SingleBestTick);
			Stream_.Push(IslandPassedCountBest);
			Stream_.Push(KillTotal);
			Stream_.Push(ChainKillTotal);
			Stream_.Push(BlowBalloonTotal);
			Stream_.Push(QuestDailyCompleteCount);
			Stream_.Push(TutorialReward);
			Stream_.Push(RankingRewardedCounter);
			Stream_.Push(NewNick);
			Stream_.Push(InvalidDisconnectInfo);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("Exp", Exp);
			Value_.Push("CanPushAtNight", CanPushAtNight);
			Value_.Push("Point", Point);
			Value_.Push("PointBest", PointBest);
			Value_.Push("LastGotRewardRankIndex", LastGotRewardRankIndex);
			Value_.Push("WinCountSolo", WinCountSolo);
			Value_.Push("LoseCountSolo", LoseCountSolo);
			Value_.Push("WinCountMulti", WinCountMulti);
			Value_.Push("LoseCountMulti", LoseCountMulti);
			Value_.Push("BattlePointBest", BattlePointBest);
			Value_.Push("SinglePointBest", SinglePointBest);
			Value_.Push("IslandPointBest", IslandPointBest);
			Value_.Push("SingleBestTick", SingleBestTick);
			Value_.Push("IslandPassedCountBest", IslandPassedCountBest);
			Value_.Push("KillTotal", KillTotal);
			Value_.Push("ChainKillTotal", ChainKillTotal);
			Value_.Push("BlowBalloonTotal", BlowBalloonTotal);
			Value_.Push("QuestDailyCompleteCount", QuestDailyCompleteCount);
			Value_.Push("TutorialReward", TutorialReward);
			Value_.Push("RankingRewardedCounter", RankingRewardedCounter);
			Value_.Push("NewNick", NewNick);
			Value_.Push("InvalidDisconnectInfo", InvalidDisconnectInfo);
		}
		public void Set(SUserBase Obj_)
		{
			base.Set(Obj_);
			Exp = Obj_.Exp;
			CanPushAtNight = Obj_.CanPushAtNight;
			Point = Obj_.Point;
			PointBest = Obj_.PointBest;
			LastGotRewardRankIndex = Obj_.LastGotRewardRankIndex;
			WinCountSolo = Obj_.WinCountSolo;
			LoseCountSolo = Obj_.LoseCountSolo;
			WinCountMulti = Obj_.WinCountMulti;
			LoseCountMulti = Obj_.LoseCountMulti;
			BattlePointBest = Obj_.BattlePointBest;
			SinglePointBest = Obj_.SinglePointBest;
			IslandPointBest = Obj_.IslandPointBest;
			SingleBestTick = Obj_.SingleBestTick;
			IslandPassedCountBest = Obj_.IslandPassedCountBest;
			KillTotal = Obj_.KillTotal;
			ChainKillTotal = Obj_.ChainKillTotal;
			BlowBalloonTotal = Obj_.BlowBalloonTotal;
			QuestDailyCompleteCount = Obj_.QuestDailyCompleteCount;
			TutorialReward = Obj_.TutorialReward;
			RankingRewardedCounter = Obj_.RankingRewardedCounter;
			NewNick = Obj_.NewNick;
			InvalidDisconnectInfo.Set(Obj_.InvalidDisconnectInfo);
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(Exp) + "," + 
				SEnumChecker.GetStdName(CanPushAtNight) + "," + 
				SEnumChecker.GetStdName(Point) + "," + 
				SEnumChecker.GetStdName(PointBest) + "," + 
				SEnumChecker.GetStdName(LastGotRewardRankIndex) + "," + 
				SEnumChecker.GetStdName(WinCountSolo) + "," + 
				SEnumChecker.GetStdName(LoseCountSolo) + "," + 
				SEnumChecker.GetStdName(WinCountMulti) + "," + 
				SEnumChecker.GetStdName(LoseCountMulti) + "," + 
				SEnumChecker.GetStdName(BattlePointBest) + "," + 
				SEnumChecker.GetStdName(SinglePointBest) + "," + 
				SEnumChecker.GetStdName(IslandPointBest) + "," + 
				SEnumChecker.GetStdName(SingleBestTick) + "," + 
				SEnumChecker.GetStdName(IslandPassedCountBest) + "," + 
				SEnumChecker.GetStdName(KillTotal) + "," + 
				SEnumChecker.GetStdName(ChainKillTotal) + "," + 
				SEnumChecker.GetStdName(BlowBalloonTotal) + "," + 
				SEnumChecker.GetStdName(QuestDailyCompleteCount) + "," + 
				SEnumChecker.GetStdName(TutorialReward) + "," + 
				SEnumChecker.GetStdName(RankingRewardedCounter) + "," + 
				SEnumChecker.GetStdName(NewNick) + "," + 
				SEnumChecker.GetStdName(InvalidDisconnectInfo);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(Exp, "Exp") + "," + 
				SEnumChecker.GetMemberName(CanPushAtNight, "CanPushAtNight") + "," + 
				SEnumChecker.GetMemberName(Point, "Point") + "," + 
				SEnumChecker.GetMemberName(PointBest, "PointBest") + "," + 
				SEnumChecker.GetMemberName(LastGotRewardRankIndex, "LastGotRewardRankIndex") + "," + 
				SEnumChecker.GetMemberName(WinCountSolo, "WinCountSolo") + "," + 
				SEnumChecker.GetMemberName(LoseCountSolo, "LoseCountSolo") + "," + 
				SEnumChecker.GetMemberName(WinCountMulti, "WinCountMulti") + "," + 
				SEnumChecker.GetMemberName(LoseCountMulti, "LoseCountMulti") + "," + 
				SEnumChecker.GetMemberName(BattlePointBest, "BattlePointBest") + "," + 
				SEnumChecker.GetMemberName(SinglePointBest, "SinglePointBest") + "," + 
				SEnumChecker.GetMemberName(IslandPointBest, "IslandPointBest") + "," + 
				SEnumChecker.GetMemberName(SingleBestTick, "SingleBestTick") + "," + 
				SEnumChecker.GetMemberName(IslandPassedCountBest, "IslandPassedCountBest") + "," + 
				SEnumChecker.GetMemberName(KillTotal, "KillTotal") + "," + 
				SEnumChecker.GetMemberName(ChainKillTotal, "ChainKillTotal") + "," + 
				SEnumChecker.GetMemberName(BlowBalloonTotal, "BlowBalloonTotal") + "," + 
				SEnumChecker.GetMemberName(QuestDailyCompleteCount, "QuestDailyCompleteCount") + "," + 
				SEnumChecker.GetMemberName(TutorialReward, "TutorialReward") + "," + 
				SEnumChecker.GetMemberName(RankingRewardedCounter, "RankingRewardedCounter") + "," + 
				SEnumChecker.GetMemberName(NewNick, "NewNick") + "," + 
				SEnumChecker.GetMemberName(InvalidDisconnectInfo, "InvalidDisconnectInfo");
		}
	}
	public class SUserNet : SUserBase
	{
		public String CountryCode = string.Empty;
		public SUserNet()
		{
		}
		public SUserNet(SUserNet Obj_) : base(Obj_)
		{
			CountryCode = Obj_.CountryCode;
		}
		public SUserNet(SUserBase Super_, String CountryCode_) : base(Super_)
		{
			CountryCode = CountryCode_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref CountryCode);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("CountryCode", ref CountryCode);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(CountryCode);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("CountryCode", CountryCode);
		}
		public void Set(SUserNet Obj_)
		{
			base.Set(Obj_);
			CountryCode = Obj_.CountryCode;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(CountryCode);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(CountryCode, "CountryCode");
		}
	}
	public class SQuestBase : SProto
	{
		public Int32 Code = default(Int32);
		public Int32 Count = default(Int32);
		public TimePoint CoolEndTime = default(TimePoint);
		public SQuestBase()
		{
		}
		public SQuestBase(SQuestBase Obj_)
		{
			Code = Obj_.Code;
			Count = Obj_.Count;
			CoolEndTime = Obj_.CoolEndTime;
		}
		public SQuestBase(Int32 Code_, Int32 Count_, TimePoint CoolEndTime_)
		{
			Code = Code_;
			Count = Count_;
			CoolEndTime = CoolEndTime_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Code);
			Stream_.Pop(ref Count);
			Stream_.Pop(ref CoolEndTime);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Code", ref Code);
			Value_.Pop("Count", ref Count);
			Value_.Pop("CoolEndTime", ref CoolEndTime);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Code);
			Stream_.Push(Count);
			Stream_.Push(CoolEndTime);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Code", Code);
			Value_.Push("Count", Count);
			Value_.Push("CoolEndTime", CoolEndTime);
		}
		public void Set(SQuestBase Obj_)
		{
			Code = Obj_.Code;
			Count = Obj_.Count;
			CoolEndTime = Obj_.CoolEndTime;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Code) + "," + 
				SEnumChecker.GetStdName(Count) + "," + 
				SEnumChecker.GetStdName(CoolEndTime);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Code, "Code") + "," + 
				SEnumChecker.GetMemberName(Count, "Count") + "," + 
				SEnumChecker.GetMemberName(CoolEndTime, "CoolEndTime");
		}
	}
	public class SLoginNetSc : SProto
	{
		public SUserNet User = new SUserNet();
		public TChars Chars = new TChars();
		public TimePoint ServerTime = default(TimePoint);
		public TQuestDBs Quests = new TQuestDBs();
		public TPackages Packages = new TPackages();
		public SLoginNetSc()
		{
		}
		public SLoginNetSc(SLoginNetSc Obj_)
		{
			User = Obj_.User;
			Chars = Obj_.Chars;
			ServerTime = Obj_.ServerTime;
			Quests = Obj_.Quests;
			Packages = Obj_.Packages;
		}
		public SLoginNetSc(SUserNet User_, TChars Chars_, TimePoint ServerTime_, TQuestDBs Quests_, TPackages Packages_)
		{
			User = User_;
			Chars = Chars_;
			ServerTime = ServerTime_;
			Quests = Quests_;
			Packages = Packages_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref User);
			Stream_.Pop(ref Chars);
			Stream_.Pop(ref ServerTime);
			Stream_.Pop(ref Quests);
			Stream_.Pop(ref Packages);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("User", ref User);
			Value_.Pop("Chars", ref Chars);
			Value_.Pop("ServerTime", ref ServerTime);
			Value_.Pop("Quests", ref Quests);
			Value_.Pop("Packages", ref Packages);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(User);
			Stream_.Push(Chars);
			Stream_.Push(ServerTime);
			Stream_.Push(Quests);
			Stream_.Push(Packages);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("User", User);
			Value_.Push("Chars", Chars);
			Value_.Push("ServerTime", ServerTime);
			Value_.Push("Quests", Quests);
			Value_.Push("Packages", Packages);
		}
		public void Set(SLoginNetSc Obj_)
		{
			User.Set(Obj_.User);
			Chars = Obj_.Chars;
			ServerTime = Obj_.ServerTime;
			Quests = Obj_.Quests;
			Packages = Obj_.Packages;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(User) + "," + 
				SEnumChecker.GetStdName(Chars) + "," + 
				SEnumChecker.GetStdName(ServerTime) + "," + 
				SEnumChecker.GetStdName(Quests) + "," + 
				SEnumChecker.GetStdName(Packages);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(User, "User") + "," + 
				SEnumChecker.GetMemberName(Chars, "Chars") + "," + 
				SEnumChecker.GetMemberName(ServerTime, "ServerTime") + "," + 
				SEnumChecker.GetMemberName(Quests, "Quests") + "," + 
				SEnumChecker.GetMemberName(Packages, "Packages");
		}
	}
	public class SLobbyNetSc : SProto
	{
		public override void Push(CStream Stream_)
		{
		}
		public override void Push(JsonDataObject Value_)
		{
		}
		public override void Pop(CStream Stream_)
		{
		}
		public override void Pop(JsonDataObject Value_)
		{
		}
		public override string StdName()
		{
			return "";
		}
		public override string MemberName()
		{
			return "";
		}
	}
	public class SUserExpNetSc : SProto
	{
		public TExp Exp = default(TExp);
		public SUserExpNetSc()
		{
		}
		public SUserExpNetSc(SUserExpNetSc Obj_)
		{
			Exp = Obj_.Exp;
		}
		public SUserExpNetSc(TExp Exp_)
		{
			Exp = Exp_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Exp);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Exp", ref Exp);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Exp);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Exp", Exp);
		}
		public void Set(SUserExpNetSc Obj_)
		{
			Exp = Obj_.Exp;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Exp);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Exp, "Exp");
		}
	}
	public class SResourcesNetSc : SProto
	{
		public TResource[] Resources = new TResource[6];
		public SResourcesNetSc()
		{
			for (int iResources = 0; iResources < Resources.Length; ++iResources)
				Resources[iResources] = default(TResource);
		}
		public SResourcesNetSc(SResourcesNetSc Obj_)
		{
			Resources = Obj_.Resources;
		}
		public SResourcesNetSc(TResource[] Resources_)
		{
			Resources = Resources_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Resources);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Resources", ref Resources);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Resources);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Resources", Resources);
		}
		public void Set(SResourcesNetSc Obj_)
		{
			Resources = Obj_.Resources;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Resources);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Resources, "Resources");
		}
	}
	public class SSetPointNetSc : SProto
	{
		public Int32 Point = default(Int32);
		public SSetPointNetSc()
		{
		}
		public SSetPointNetSc(SSetPointNetSc Obj_)
		{
			Point = Obj_.Point;
		}
		public SSetPointNetSc(Int32 Point_)
		{
			Point = Point_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Point);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Point", ref Point);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Point);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Point", Point);
		}
		public void Set(SSetPointNetSc Obj_)
		{
			Point = Obj_.Point;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Point);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Point, "Point");
		}
	}
	public class SSetCharNetSc : SProto
	{
		public List<Int32> CharCodes = new List<Int32>();
		public SSetCharNetSc()
		{
		}
		public SSetCharNetSc(SSetCharNetSc Obj_)
		{
			CharCodes = Obj_.CharCodes;
		}
		public SSetCharNetSc(List<Int32> CharCodes_)
		{
			CharCodes = CharCodes_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref CharCodes);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("CharCodes", ref CharCodes);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(CharCodes);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("CharCodes", CharCodes);
		}
		public void Set(SSetCharNetSc Obj_)
		{
			CharCodes = Obj_.CharCodes;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(CharCodes);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(CharCodes, "CharCodes");
		}
	}
	public class SUnsetCharNetSc : SProto
	{
		public List<Int32> CharCodes = new List<Int32>();
		public SUnsetCharNetSc()
		{
		}
		public SUnsetCharNetSc(SUnsetCharNetSc Obj_)
		{
			CharCodes = Obj_.CharCodes;
		}
		public SUnsetCharNetSc(List<Int32> CharCodes_)
		{
			CharCodes = CharCodes_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref CharCodes);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("CharCodes", ref CharCodes);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(CharCodes);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("CharCodes", CharCodes);
		}
		public void Set(SUnsetCharNetSc Obj_)
		{
			CharCodes = Obj_.CharCodes;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(CharCodes);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(CharCodes, "CharCodes");
		}
	}
	public class SChatNetCs : SProto
	{
		public String Msg = string.Empty;
		public SChatNetCs()
		{
		}
		public SChatNetCs(SChatNetCs Obj_)
		{
			Msg = Obj_.Msg;
		}
		public SChatNetCs(String Msg_)
		{
			Msg = Msg_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Msg);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Msg", ref Msg);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Msg);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Msg", Msg);
		}
		public void Set(SChatNetCs Obj_)
		{
			Msg = Obj_.Msg;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Msg);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Msg, "Msg");
		}
	}
	public class SChatNetSc : SProto
	{
		public String Msg = string.Empty;
		public SChatNetSc()
		{
		}
		public SChatNetSc(SChatNetSc Obj_)
		{
			Msg = Obj_.Msg;
		}
		public SChatNetSc(String Msg_)
		{
			Msg = Msg_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Msg);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Msg", ref Msg);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Msg);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Msg", Msg);
		}
		public void Set(SChatNetSc Obj_)
		{
			Msg = Obj_.Msg;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Msg);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Msg, "Msg");
		}
	}
	public class SFCMTokenSetNetCs : SProto
	{
		public String Token = string.Empty;
		public SFCMTokenSetNetCs()
		{
		}
		public SFCMTokenSetNetCs(SFCMTokenSetNetCs Obj_)
		{
			Token = Obj_.Token;
		}
		public SFCMTokenSetNetCs(String Token_)
		{
			Token = Token_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Token);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Token", ref Token);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Token);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Token", Token);
		}
		public void Set(SFCMTokenSetNetCs Obj_)
		{
			Token = Obj_.Token;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Token);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Token, "Token");
		}
	}
	public class SFCMTokenUnsetNetCs : SProto
	{
		public override void Push(CStream Stream_)
		{
		}
		public override void Push(JsonDataObject Value_)
		{
		}
		public override void Pop(CStream Stream_)
		{
		}
		public override void Pop(JsonDataObject Value_)
		{
		}
		public override string StdName()
		{
			return "";
		}
		public override string MemberName()
		{
			return "";
		}
	}
	public class SFCMCanPushAtNightNetCs : SProto
	{
		public Boolean CanPush = default(Boolean);
		public SFCMCanPushAtNightNetCs()
		{
		}
		public SFCMCanPushAtNightNetCs(SFCMCanPushAtNightNetCs Obj_)
		{
			CanPush = Obj_.CanPush;
		}
		public SFCMCanPushAtNightNetCs(Boolean CanPush_)
		{
			CanPush = CanPush_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref CanPush);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("CanPush", ref CanPush);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(CanPush);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("CanPush", CanPush);
		}
		public void Set(SFCMCanPushAtNightNetCs Obj_)
		{
			CanPush = Obj_.CanPush;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(CanPush);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(CanPush, "CanPush");
		}
	}
	public class SChangeLanguageNetCs : SProto
	{
		public ELanguage Language = default(ELanguage);
		public SChangeLanguageNetCs()
		{
		}
		public SChangeLanguageNetCs(SChangeLanguageNetCs Obj_)
		{
			Language = Obj_.Language;
		}
		public SChangeLanguageNetCs(ELanguage Language_)
		{
			Language = Language_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Language);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Language", ref Language);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Language);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Language", Language);
		}
		public void Set(SChangeLanguageNetCs Obj_)
		{
			Language = Obj_.Language;
		}
		public override string StdName()
		{
			return 
				"bb.ELanguage";
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Language, "Language");
		}
	}
	public class SBuyNetCs : SProto
	{
		public Int32 Code = default(Int32);
		public SBuyNetCs()
		{
		}
		public SBuyNetCs(SBuyNetCs Obj_)
		{
			Code = Obj_.Code;
		}
		public SBuyNetCs(Int32 Code_)
		{
			Code = Code_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Code);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Code", ref Code);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Code);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Code", Code);
		}
		public void Set(SBuyNetCs Obj_)
		{
			Code = Obj_.Code;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Code);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Code, "Code");
		}
	}
	public class SRewardDB : SProto
	{
		public TUID UID = default(TUID);
		public TResource[] ResourcesLeft = new TResource[6];
		public List<Int32> CharsAdded = new List<Int32>();
		public SRewardDB()
		{
			for (int iResourcesLeft = 0; iResourcesLeft < ResourcesLeft.Length; ++iResourcesLeft)
				ResourcesLeft[iResourcesLeft] = default(TResource);
		}
		public SRewardDB(SRewardDB Obj_)
		{
			UID = Obj_.UID;
			ResourcesLeft = Obj_.ResourcesLeft;
			CharsAdded = Obj_.CharsAdded;
		}
		public SRewardDB(TUID UID_, TResource[] ResourcesLeft_, List<Int32> CharsAdded_)
		{
			UID = UID_;
			ResourcesLeft = ResourcesLeft_;
			CharsAdded = CharsAdded_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref UID);
			Stream_.Pop(ref ResourcesLeft);
			Stream_.Pop(ref CharsAdded);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("UID", ref UID);
			Value_.Pop("ResourcesLeft", ref ResourcesLeft);
			Value_.Pop("CharsAdded", ref CharsAdded);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(UID);
			Stream_.Push(ResourcesLeft);
			Stream_.Push(CharsAdded);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("UID", UID);
			Value_.Push("ResourcesLeft", ResourcesLeft);
			Value_.Push("CharsAdded", CharsAdded);
		}
		public void Set(SRewardDB Obj_)
		{
			UID = Obj_.UID;
			ResourcesLeft = Obj_.ResourcesLeft;
			CharsAdded = Obj_.CharsAdded;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(UID) + "," + 
				SEnumChecker.GetStdName(ResourcesLeft) + "," + 
				SEnumChecker.GetStdName(CharsAdded);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(UID, "UID") + "," + 
				SEnumChecker.GetMemberName(ResourcesLeft, "ResourcesLeft") + "," + 
				SEnumChecker.GetMemberName(CharsAdded, "CharsAdded");
		}
	}
	public class SBuyNetSc : SRewardDB
	{
		public Int32 Code = default(Int32);
		public SBuyNetSc()
		{
		}
		public SBuyNetSc(SBuyNetSc Obj_) : base(Obj_)
		{
			Code = Obj_.Code;
		}
		public SBuyNetSc(SRewardDB Super_, Int32 Code_) : base(Super_)
		{
			Code = Code_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref Code);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("Code", ref Code);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(Code);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("Code", Code);
		}
		public void Set(SBuyNetSc Obj_)
		{
			base.Set(Obj_);
			Code = Obj_.Code;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(Code);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(Code, "Code");
		}
	}
	public class SBuyCharNetCs : SProto
	{
		public Int32 Code = default(Int32);
		public SBuyCharNetCs()
		{
		}
		public SBuyCharNetCs(SBuyCharNetCs Obj_)
		{
			Code = Obj_.Code;
		}
		public SBuyCharNetCs(Int32 Code_)
		{
			Code = Code_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Code);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Code", ref Code);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Code);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Code", Code);
		}
		public void Set(SBuyCharNetCs Obj_)
		{
			Code = Obj_.Code;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Code);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Code, "Code");
		}
	}
	public class SBuyCharNetSc : SProto
	{
		public Int32 Code = default(Int32);
		public SBuyCharNetSc()
		{
		}
		public SBuyCharNetSc(SBuyCharNetSc Obj_)
		{
			Code = Obj_.Code;
		}
		public SBuyCharNetSc(Int32 Code_)
		{
			Code = Code_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Code);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Code", ref Code);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Code);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Code", Code);
		}
		public void Set(SBuyCharNetSc Obj_)
		{
			Code = Obj_.Code;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Code);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Code, "Code");
		}
	}
	public class SBuyPackageNetCs : SProto
	{
		public Int32 Code = default(Int32);
		public SBuyPackageNetCs()
		{
		}
		public SBuyPackageNetCs(SBuyPackageNetCs Obj_)
		{
			Code = Obj_.Code;
		}
		public SBuyPackageNetCs(Int32 Code_)
		{
			Code = Code_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Code);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Code", ref Code);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Code);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Code", Code);
		}
		public void Set(SBuyPackageNetCs Obj_)
		{
			Code = Obj_.Code;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Code);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Code, "Code");
		}
	}
	public class SBuyPackageNetSc : SRewardDB
	{
		public Int32 Code = default(Int32);
		public SBuyPackageNetSc()
		{
		}
		public SBuyPackageNetSc(SBuyPackageNetSc Obj_) : base(Obj_)
		{
			Code = Obj_.Code;
		}
		public SBuyPackageNetSc(SRewardDB Super_, Int32 Code_) : base(Super_)
		{
			Code = Code_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref Code);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("Code", ref Code);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(Code);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("Code", Code);
		}
		public void Set(SBuyPackageNetSc Obj_)
		{
			base.Set(Obj_);
			Code = Obj_.Code;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(Code);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(Code, "Code");
		}
	}
	public class SDailyRewardNetCs : SProto
	{
		public Boolean IsWatchedAd = default(Boolean);
		public SDailyRewardNetCs()
		{
		}
		public SDailyRewardNetCs(SDailyRewardNetCs Obj_)
		{
			IsWatchedAd = Obj_.IsWatchedAd;
		}
		public SDailyRewardNetCs(Boolean IsWatchedAd_)
		{
			IsWatchedAd = IsWatchedAd_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref IsWatchedAd);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("IsWatchedAd", ref IsWatchedAd);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(IsWatchedAd);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("IsWatchedAd", IsWatchedAd);
		}
		public void Set(SDailyRewardNetCs Obj_)
		{
			IsWatchedAd = Obj_.IsWatchedAd;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(IsWatchedAd);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(IsWatchedAd, "IsWatchedAd");
		}
	}
	public class SDailyRewardNetSc : SProto
	{
		public SResourceTypeData Reward = new SResourceTypeData();
		public TimePoint ExpiredTime = default(TimePoint);
		public Int32 CountLeft = default(Int32);
		public SDailyRewardNetSc()
		{
		}
		public SDailyRewardNetSc(SDailyRewardNetSc Obj_)
		{
			Reward = Obj_.Reward;
			ExpiredTime = Obj_.ExpiredTime;
			CountLeft = Obj_.CountLeft;
		}
		public SDailyRewardNetSc(SResourceTypeData Reward_, TimePoint ExpiredTime_, Int32 CountLeft_)
		{
			Reward = Reward_;
			ExpiredTime = ExpiredTime_;
			CountLeft = CountLeft_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Reward);
			Stream_.Pop(ref ExpiredTime);
			Stream_.Pop(ref CountLeft);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Reward", ref Reward);
			Value_.Pop("ExpiredTime", ref ExpiredTime);
			Value_.Pop("CountLeft", ref CountLeft);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Reward);
			Stream_.Push(ExpiredTime);
			Stream_.Push(CountLeft);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Reward", Reward);
			Value_.Push("ExpiredTime", ExpiredTime);
			Value_.Push("CountLeft", CountLeft);
		}
		public void Set(SDailyRewardNetSc Obj_)
		{
			Reward.Set(Obj_.Reward);
			ExpiredTime = Obj_.ExpiredTime;
			CountLeft = Obj_.CountLeft;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Reward) + "," + 
				SEnumChecker.GetStdName(ExpiredTime) + "," + 
				SEnumChecker.GetStdName(CountLeft);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Reward, "Reward") + "," + 
				SEnumChecker.GetMemberName(ExpiredTime, "ExpiredTime") + "," + 
				SEnumChecker.GetMemberName(CountLeft, "CountLeft");
		}
	}
	public class SDailyRewardFailNetSc : SProto
	{
		public override void Push(CStream Stream_)
		{
		}
		public override void Push(JsonDataObject Value_)
		{
		}
		public override void Pop(CStream Stream_)
		{
		}
		public override void Pop(JsonDataObject Value_)
		{
		}
		public override string StdName()
		{
			return "";
		}
		public override string MemberName()
		{
			return "";
		}
	}
	public class SSelectCharNetCs : SProto
	{
		public Int32 Code = default(Int32);
		public SSelectCharNetCs()
		{
		}
		public SSelectCharNetCs(SSelectCharNetCs Obj_)
		{
			Code = Obj_.Code;
		}
		public SSelectCharNetCs(Int32 Code_)
		{
			Code = Code_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Code);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Code", ref Code);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Code);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Code", Code);
		}
		public void Set(SSelectCharNetCs Obj_)
		{
			Code = Obj_.Code;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Code);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Code, "Code");
		}
	}
	public class SBattleType : SProto
	{
		public TTeamCnt TeamCount = default(TTeamCnt);
		public SByte TeamMemberCount = default(SByte);
		public SBattleType()
		{
		}
		public SBattleType(SBattleType Obj_)
		{
			TeamCount = Obj_.TeamCount;
			TeamMemberCount = Obj_.TeamMemberCount;
		}
		public SBattleType(TTeamCnt TeamCount_, SByte TeamMemberCount_)
		{
			TeamCount = TeamCount_;
			TeamMemberCount = TeamMemberCount_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref TeamCount);
			Stream_.Pop(ref TeamMemberCount);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("TeamCount", ref TeamCount);
			Value_.Pop("TeamMemberCount", ref TeamMemberCount);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(TeamCount);
			Stream_.Push(TeamMemberCount);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("TeamCount", TeamCount);
			Value_.Push("TeamMemberCount", TeamMemberCount);
		}
		public void Set(SBattleType Obj_)
		{
			TeamCount = Obj_.TeamCount;
			TeamMemberCount = Obj_.TeamMemberCount;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(TeamCount) + "," + 
				SEnumChecker.GetStdName(TeamMemberCount);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(TeamCount, "TeamCount") + "," + 
				SEnumChecker.GetMemberName(TeamMemberCount, "TeamMemberCount");
		}
	}
	public class SBattleSyncNetSc : SProto
	{
		public Int64 Tick = default(Int64);
		public SBattleSyncNetSc()
		{
		}
		public SBattleSyncNetSc(SBattleSyncNetSc Obj_)
		{
			Tick = Obj_.Tick;
		}
		public SBattleSyncNetSc(Int64 Tick_)
		{
			Tick = Tick_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Tick);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Tick", ref Tick);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Tick);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Tick", Tick);
		}
		public void Set(SBattleSyncNetSc Obj_)
		{
			Tick = Obj_.Tick;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Tick);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Tick, "Tick");
		}
	}
	public class SBattleTouchNetCs : SProto
	{
		public SByte Dir = default(SByte);
		public SBattleTouchNetCs()
		{
		}
		public SBattleTouchNetCs(SBattleTouchNetCs Obj_)
		{
			Dir = Obj_.Dir;
		}
		public SBattleTouchNetCs(SByte Dir_)
		{
			Dir = Dir_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Dir);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Dir", ref Dir);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Dir);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Dir", Dir);
		}
		public void Set(SBattleTouchNetCs Obj_)
		{
			Dir = Obj_.Dir;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Dir);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Dir, "Dir");
		}
	}
	public class SBattleTouchNetSc : SProto
	{
		public Int64 Tick = default(Int64);
		public Int32 PlayerIndex = default(Int32);
		public SByte Dir = default(SByte);
		public SBattleTouchNetSc()
		{
		}
		public SBattleTouchNetSc(SBattleTouchNetSc Obj_)
		{
			Tick = Obj_.Tick;
			PlayerIndex = Obj_.PlayerIndex;
			Dir = Obj_.Dir;
		}
		public SBattleTouchNetSc(Int64 Tick_, Int32 PlayerIndex_, SByte Dir_)
		{
			Tick = Tick_;
			PlayerIndex = PlayerIndex_;
			Dir = Dir_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Tick);
			Stream_.Pop(ref PlayerIndex);
			Stream_.Pop(ref Dir);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Tick", ref Tick);
			Value_.Pop("PlayerIndex", ref PlayerIndex);
			Value_.Pop("Dir", ref Dir);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Tick);
			Stream_.Push(PlayerIndex);
			Stream_.Push(Dir);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Tick", Tick);
			Value_.Push("PlayerIndex", PlayerIndex);
			Value_.Push("Dir", Dir);
		}
		public void Set(SBattleTouchNetSc Obj_)
		{
			Tick = Obj_.Tick;
			PlayerIndex = Obj_.PlayerIndex;
			Dir = Obj_.Dir;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Tick) + "," + 
				SEnumChecker.GetStdName(PlayerIndex) + "," + 
				SEnumChecker.GetStdName(Dir);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Tick, "Tick") + "," + 
				SEnumChecker.GetMemberName(PlayerIndex, "PlayerIndex") + "," + 
				SEnumChecker.GetMemberName(Dir, "Dir");
		}
	}
	public class SBattlePushNetCs : SProto
	{
		public override void Push(CStream Stream_)
		{
		}
		public override void Push(JsonDataObject Value_)
		{
		}
		public override void Pop(CStream Stream_)
		{
		}
		public override void Pop(JsonDataObject Value_)
		{
		}
		public override string StdName()
		{
			return "";
		}
		public override string MemberName()
		{
			return "";
		}
	}
	public class SBattlePushNetSc : SProto
	{
		public Int64 Tick = default(Int64);
		public Int32 PlayerIndex = default(Int32);
		public SBattlePushNetSc()
		{
		}
		public SBattlePushNetSc(SBattlePushNetSc Obj_)
		{
			Tick = Obj_.Tick;
			PlayerIndex = Obj_.PlayerIndex;
		}
		public SBattlePushNetSc(Int64 Tick_, Int32 PlayerIndex_)
		{
			Tick = Tick_;
			PlayerIndex = PlayerIndex_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Tick);
			Stream_.Pop(ref PlayerIndex);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Tick", ref Tick);
			Value_.Pop("PlayerIndex", ref PlayerIndex);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Tick);
			Stream_.Push(PlayerIndex);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Tick", Tick);
			Value_.Push("PlayerIndex", PlayerIndex);
		}
		public void Set(SBattlePushNetSc Obj_)
		{
			Tick = Obj_.Tick;
			PlayerIndex = Obj_.PlayerIndex;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Tick) + "," + 
				SEnumChecker.GetStdName(PlayerIndex);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Tick, "Tick") + "," + 
				SEnumChecker.GetMemberName(PlayerIndex, "PlayerIndex");
		}
	}
	public class SMultiBattleJoinNetCs : SProto
	{
		public SBattleType BattleType = new SBattleType();
		public SMultiBattleJoinNetCs()
		{
		}
		public SMultiBattleJoinNetCs(SMultiBattleJoinNetCs Obj_)
		{
			BattleType = Obj_.BattleType;
		}
		public SMultiBattleJoinNetCs(SBattleType BattleType_)
		{
			BattleType = BattleType_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref BattleType);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("BattleType", ref BattleType);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(BattleType);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("BattleType", BattleType);
		}
		public void Set(SMultiBattleJoinNetCs Obj_)
		{
			BattleType.Set(Obj_.BattleType);
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(BattleType);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(BattleType, "BattleType");
		}
	}
	public class SMultiBattleJoinNetSc : SProto
	{
		public override void Push(CStream Stream_)
		{
		}
		public override void Push(JsonDataObject Value_)
		{
		}
		public override void Pop(CStream Stream_)
		{
		}
		public override void Pop(JsonDataObject Value_)
		{
		}
		public override string StdName()
		{
			return "";
		}
		public override string MemberName()
		{
			return "";
		}
	}
	public class SMultiBattleOutNetCs : SProto
	{
		public override void Push(CStream Stream_)
		{
		}
		public override void Push(JsonDataObject Value_)
		{
		}
		public override void Pop(CStream Stream_)
		{
		}
		public override void Pop(JsonDataObject Value_)
		{
		}
		public override string StdName()
		{
			return "";
		}
		public override string MemberName()
		{
			return "";
		}
	}
	public class SMultiBattleOutNetSc : SProto
	{
		public override void Push(CStream Stream_)
		{
		}
		public override void Push(JsonDataObject Value_)
		{
		}
		public override void Pop(CStream Stream_)
		{
		}
		public override void Pop(JsonDataObject Value_)
		{
		}
		public override string StdName()
		{
			return "";
		}
		public override string MemberName()
		{
			return "";
		}
	}
	public class SPumpInfo : SProto
	{
		public SByte Count = default(SByte);
		public SByte CountTo = default(SByte);
		public Single Scale = default(Single);
		public SPumpInfo()
		{
		}
		public SPumpInfo(SPumpInfo Obj_)
		{
			Count = Obj_.Count;
			CountTo = Obj_.CountTo;
			Scale = Obj_.Scale;
		}
		public SPumpInfo(SByte Count_, SByte CountTo_, Single Scale_)
		{
			Count = Count_;
			CountTo = CountTo_;
			Scale = Scale_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Count);
			Stream_.Pop(ref CountTo);
			Stream_.Pop(ref Scale);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Count", ref Count);
			Value_.Pop("CountTo", ref CountTo);
			Value_.Pop("Scale", ref Scale);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Count);
			Stream_.Push(CountTo);
			Stream_.Push(Scale);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Count", Count);
			Value_.Push("CountTo", CountTo);
			Value_.Push("Scale", Scale);
		}
		public void Set(SPumpInfo Obj_)
		{
			Count = Obj_.Count;
			CountTo = Obj_.CountTo;
			Scale = Obj_.Scale;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Count) + "," + 
				SEnumChecker.GetStdName(CountTo) + "," + 
				SEnumChecker.GetStdName(Scale);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Count, "Count") + "," + 
				SEnumChecker.GetMemberName(CountTo, "CountTo") + "," + 
				SEnumChecker.GetMemberName(Scale, "Scale");
		}
	}
	public class SParachuteInfo : SProto
	{
		public Single Scale = default(Single);
		public Single Velocity = default(Single);
		public SParachuteInfo()
		{
		}
		public SParachuteInfo(SParachuteInfo Obj_)
		{
			Scale = Obj_.Scale;
			Velocity = Obj_.Velocity;
		}
		public SParachuteInfo(Single Scale_, Single Velocity_)
		{
			Scale = Scale_;
			Velocity = Velocity_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Scale);
			Stream_.Pop(ref Velocity);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Scale", ref Scale);
			Value_.Pop("Velocity", ref Velocity);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Scale);
			Stream_.Push(Velocity);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Scale", Scale);
			Value_.Push("Velocity", Velocity);
		}
		public void Set(SParachuteInfo Obj_)
		{
			Scale = Obj_.Scale;
			Velocity = Obj_.Velocity;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Scale) + "," + 
				SEnumChecker.GetStdName(Velocity);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Scale, "Scale") + "," + 
				SEnumChecker.GetMemberName(Velocity, "Velocity");
		}
	}
	public class SStaminaInfo : SProto
	{
		public Int64 LastUsedTick = default(Int64);
		public Single Stamina = default(Single);
		public SStaminaInfo()
		{
		}
		public SStaminaInfo(SStaminaInfo Obj_)
		{
			LastUsedTick = Obj_.LastUsedTick;
			Stamina = Obj_.Stamina;
		}
		public SStaminaInfo(Int64 LastUsedTick_, Single Stamina_)
		{
			LastUsedTick = LastUsedTick_;
			Stamina = Stamina_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref LastUsedTick);
			Stream_.Pop(ref Stamina);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("LastUsedTick", ref LastUsedTick);
			Value_.Pop("Stamina", ref Stamina);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(LastUsedTick);
			Stream_.Push(Stamina);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("LastUsedTick", LastUsedTick);
			Value_.Push("Stamina", Stamina);
		}
		public void Set(SStaminaInfo Obj_)
		{
			LastUsedTick = Obj_.LastUsedTick;
			Stamina = Obj_.Stamina;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(LastUsedTick) + "," + 
				SEnumChecker.GetStdName(Stamina);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(LastUsedTick, "LastUsedTick") + "," + 
				SEnumChecker.GetMemberName(Stamina, "Stamina");
		}
	}
	public class SBattlePlayer : SProto
	{
		public TUID UID = default(TUID);
		public String Nick = string.Empty;
		public String CountryCode = string.Empty;
		public TTeamCnt TeamIndex = default(TTeamCnt);
		public Int32 CharCode = default(Int32);
		public SBattlePlayer()
		{
		}
		public SBattlePlayer(SBattlePlayer Obj_)
		{
			UID = Obj_.UID;
			Nick = Obj_.Nick;
			CountryCode = Obj_.CountryCode;
			TeamIndex = Obj_.TeamIndex;
			CharCode = Obj_.CharCode;
		}
		public SBattlePlayer(TUID UID_, String Nick_, String CountryCode_, TTeamCnt TeamIndex_, Int32 CharCode_)
		{
			UID = UID_;
			Nick = Nick_;
			CountryCode = CountryCode_;
			TeamIndex = TeamIndex_;
			CharCode = CharCode_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref UID);
			Stream_.Pop(ref Nick);
			Stream_.Pop(ref CountryCode);
			Stream_.Pop(ref TeamIndex);
			Stream_.Pop(ref CharCode);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("UID", ref UID);
			Value_.Pop("Nick", ref Nick);
			Value_.Pop("CountryCode", ref CountryCode);
			Value_.Pop("TeamIndex", ref TeamIndex);
			Value_.Pop("CharCode", ref CharCode);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(UID);
			Stream_.Push(Nick);
			Stream_.Push(CountryCode);
			Stream_.Push(TeamIndex);
			Stream_.Push(CharCode);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("UID", UID);
			Value_.Push("Nick", Nick);
			Value_.Push("CountryCode", CountryCode);
			Value_.Push("TeamIndex", TeamIndex);
			Value_.Push("CharCode", CharCode);
		}
		public void Set(SBattlePlayer Obj_)
		{
			UID = Obj_.UID;
			Nick = Obj_.Nick;
			CountryCode = Obj_.CountryCode;
			TeamIndex = Obj_.TeamIndex;
			CharCode = Obj_.CharCode;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(UID) + "," + 
				SEnumChecker.GetStdName(Nick) + "," + 
				SEnumChecker.GetStdName(CountryCode) + "," + 
				SEnumChecker.GetStdName(TeamIndex) + "," + 
				SEnumChecker.GetStdName(CharCode);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(UID, "UID") + "," + 
				SEnumChecker.GetMemberName(Nick, "Nick") + "," + 
				SEnumChecker.GetMemberName(CountryCode, "CountryCode") + "," + 
				SEnumChecker.GetMemberName(TeamIndex, "TeamIndex") + "," + 
				SEnumChecker.GetMemberName(CharCode, "CharCode");
		}
	}
	public class SCharacter : SProto
	{
		public Boolean IsGround = default(Boolean);
		public SByte Dir = default(SByte);
		public SByte BalloonCount = default(SByte);
		public SPumpInfo PumpInfo = new SPumpInfo();
		public SParachuteInfo ParachuteInfo = new SParachuteInfo();
		public SStaminaInfo StaminaInfo = new SStaminaInfo();
		public SByte Face = default(SByte);
		public SPoint Acc = new SPoint();
		public Int64 InvulnerableEndTick = default(Int64);
		public Int32 ChainKillCount = default(Int32);
		public Int64 LastKillTick = default(Int64);
		public Int64 RegenTick = default(Int64);
		public SCharacter()
		{
		}
		public SCharacter(SCharacter Obj_)
		{
			IsGround = Obj_.IsGround;
			Dir = Obj_.Dir;
			BalloonCount = Obj_.BalloonCount;
			PumpInfo = Obj_.PumpInfo;
			ParachuteInfo = Obj_.ParachuteInfo;
			StaminaInfo = Obj_.StaminaInfo;
			Face = Obj_.Face;
			Acc = Obj_.Acc;
			InvulnerableEndTick = Obj_.InvulnerableEndTick;
			ChainKillCount = Obj_.ChainKillCount;
			LastKillTick = Obj_.LastKillTick;
			RegenTick = Obj_.RegenTick;
		}
		public SCharacter(Boolean IsGround_, SByte Dir_, SByte BalloonCount_, SPumpInfo PumpInfo_, SParachuteInfo ParachuteInfo_, SStaminaInfo StaminaInfo_, SByte Face_, SPoint Acc_, Int64 InvulnerableEndTick_, Int32 ChainKillCount_, Int64 LastKillTick_, Int64 RegenTick_)
		{
			IsGround = IsGround_;
			Dir = Dir_;
			BalloonCount = BalloonCount_;
			PumpInfo = PumpInfo_;
			ParachuteInfo = ParachuteInfo_;
			StaminaInfo = StaminaInfo_;
			Face = Face_;
			Acc = Acc_;
			InvulnerableEndTick = InvulnerableEndTick_;
			ChainKillCount = ChainKillCount_;
			LastKillTick = LastKillTick_;
			RegenTick = RegenTick_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref IsGround);
			Stream_.Pop(ref Dir);
			Stream_.Pop(ref BalloonCount);
			Stream_.Pop(ref PumpInfo);
			Stream_.Pop(ref ParachuteInfo);
			Stream_.Pop(ref StaminaInfo);
			Stream_.Pop(ref Face);
			Stream_.Pop(ref Acc);
			Stream_.Pop(ref InvulnerableEndTick);
			Stream_.Pop(ref ChainKillCount);
			Stream_.Pop(ref LastKillTick);
			Stream_.Pop(ref RegenTick);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("IsGround", ref IsGround);
			Value_.Pop("Dir", ref Dir);
			Value_.Pop("BalloonCount", ref BalloonCount);
			Value_.Pop("PumpInfo", ref PumpInfo);
			Value_.Pop("ParachuteInfo", ref ParachuteInfo);
			Value_.Pop("StaminaInfo", ref StaminaInfo);
			Value_.Pop("Face", ref Face);
			Value_.Pop("Acc", ref Acc);
			Value_.Pop("InvulnerableEndTick", ref InvulnerableEndTick);
			Value_.Pop("ChainKillCount", ref ChainKillCount);
			Value_.Pop("LastKillTick", ref LastKillTick);
			Value_.Pop("RegenTick", ref RegenTick);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(IsGround);
			Stream_.Push(Dir);
			Stream_.Push(BalloonCount);
			Stream_.Push(PumpInfo);
			Stream_.Push(ParachuteInfo);
			Stream_.Push(StaminaInfo);
			Stream_.Push(Face);
			Stream_.Push(Acc);
			Stream_.Push(InvulnerableEndTick);
			Stream_.Push(ChainKillCount);
			Stream_.Push(LastKillTick);
			Stream_.Push(RegenTick);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("IsGround", IsGround);
			Value_.Push("Dir", Dir);
			Value_.Push("BalloonCount", BalloonCount);
			Value_.Push("PumpInfo", PumpInfo);
			Value_.Push("ParachuteInfo", ParachuteInfo);
			Value_.Push("StaminaInfo", StaminaInfo);
			Value_.Push("Face", Face);
			Value_.Push("Acc", Acc);
			Value_.Push("InvulnerableEndTick", InvulnerableEndTick);
			Value_.Push("ChainKillCount", ChainKillCount);
			Value_.Push("LastKillTick", LastKillTick);
			Value_.Push("RegenTick", RegenTick);
		}
		public void Set(SCharacter Obj_)
		{
			IsGround = Obj_.IsGround;
			Dir = Obj_.Dir;
			BalloonCount = Obj_.BalloonCount;
			PumpInfo.Set(Obj_.PumpInfo);
			ParachuteInfo.Set(Obj_.ParachuteInfo);
			StaminaInfo.Set(Obj_.StaminaInfo);
			Face = Obj_.Face;
			Acc.Set(Obj_.Acc);
			InvulnerableEndTick = Obj_.InvulnerableEndTick;
			ChainKillCount = Obj_.ChainKillCount;
			LastKillTick = Obj_.LastKillTick;
			RegenTick = Obj_.RegenTick;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(IsGround) + "," + 
				SEnumChecker.GetStdName(Dir) + "," + 
				SEnumChecker.GetStdName(BalloonCount) + "," + 
				SEnumChecker.GetStdName(PumpInfo) + "," + 
				SEnumChecker.GetStdName(ParachuteInfo) + "," + 
				SEnumChecker.GetStdName(StaminaInfo) + "," + 
				SEnumChecker.GetStdName(Face) + "," + 
				SEnumChecker.GetStdName(Acc) + "," + 
				SEnumChecker.GetStdName(InvulnerableEndTick) + "," + 
				SEnumChecker.GetStdName(ChainKillCount) + "," + 
				SEnumChecker.GetStdName(LastKillTick) + "," + 
				SEnumChecker.GetStdName(RegenTick);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(IsGround, "IsGround") + "," + 
				SEnumChecker.GetMemberName(Dir, "Dir") + "," + 
				SEnumChecker.GetMemberName(BalloonCount, "BalloonCount") + "," + 
				SEnumChecker.GetMemberName(PumpInfo, "PumpInfo") + "," + 
				SEnumChecker.GetMemberName(ParachuteInfo, "ParachuteInfo") + "," + 
				SEnumChecker.GetMemberName(StaminaInfo, "StaminaInfo") + "," + 
				SEnumChecker.GetMemberName(Face, "Face") + "," + 
				SEnumChecker.GetMemberName(Acc, "Acc") + "," + 
				SEnumChecker.GetMemberName(InvulnerableEndTick, "InvulnerableEndTick") + "," + 
				SEnumChecker.GetMemberName(ChainKillCount, "ChainKillCount") + "," + 
				SEnumChecker.GetMemberName(LastKillTick, "LastKillTick") + "," + 
				SEnumChecker.GetMemberName(RegenTick, "RegenTick");
		}
	}
	public class SCharacterNet : SCharacter
	{
		public SPoint Pos = new SPoint();
		public SPoint Vel = new SPoint();
		public SCharacterNet()
		{
		}
		public SCharacterNet(SCharacterNet Obj_) : base(Obj_)
		{
			Pos = Obj_.Pos;
			Vel = Obj_.Vel;
		}
		public SCharacterNet(SCharacter Super_, SPoint Pos_, SPoint Vel_) : base(Super_)
		{
			Pos = Pos_;
			Vel = Vel_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref Pos);
			Stream_.Pop(ref Vel);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("Pos", ref Pos);
			Value_.Pop("Vel", ref Vel);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(Pos);
			Stream_.Push(Vel);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("Pos", Pos);
			Value_.Push("Vel", Vel);
		}
		public void Set(SCharacterNet Obj_)
		{
			base.Set(Obj_);
			Pos.Set(Obj_.Pos);
			Vel.Set(Obj_.Vel);
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(Pos) + "," + 
				SEnumChecker.GetStdName(Vel);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(Pos, "Pos") + "," + 
				SEnumChecker.GetMemberName(Vel, "Vel");
		}
	}
	public class SBattle : SProto
	{
		public SBattleType BattleType = new SBattleType();
		public Int32 MapIndex = default(Int32);
		public SBattle()
		{
		}
		public SBattle(SBattle Obj_)
		{
			BattleType = Obj_.BattleType;
			MapIndex = Obj_.MapIndex;
		}
		public SBattle(SBattleType BattleType_, Int32 MapIndex_)
		{
			BattleType = BattleType_;
			MapIndex = MapIndex_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref BattleType);
			Stream_.Pop(ref MapIndex);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("BattleType", ref BattleType);
			Value_.Pop("MapIndex", ref MapIndex);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(BattleType);
			Stream_.Push(MapIndex);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("BattleType", BattleType);
			Value_.Push("MapIndex", MapIndex);
		}
		public void Set(SBattle Obj_)
		{
			BattleType.Set(Obj_.BattleType);
			MapIndex = Obj_.MapIndex;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(BattleType) + "," + 
				SEnumChecker.GetStdName(MapIndex);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(BattleType, "BattleType") + "," + 
				SEnumChecker.GetMemberName(MapIndex, "MapIndex");
		}
	}
	public class SBattleRecord : SProto
	{
		public Int32 TotalKillCount = default(Int32);
		public Int32 TotalBalloonHitCount = default(Int32);
		public SBattleRecord()
		{
		}
		public SBattleRecord(SBattleRecord Obj_)
		{
			TotalKillCount = Obj_.TotalKillCount;
			TotalBalloonHitCount = Obj_.TotalBalloonHitCount;
		}
		public SBattleRecord(Int32 TotalKillCount_, Int32 TotalBalloonHitCount_)
		{
			TotalKillCount = TotalKillCount_;
			TotalBalloonHitCount = TotalBalloonHitCount_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref TotalKillCount);
			Stream_.Pop(ref TotalBalloonHitCount);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("TotalKillCount", ref TotalKillCount);
			Value_.Pop("TotalBalloonHitCount", ref TotalBalloonHitCount);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(TotalKillCount);
			Stream_.Push(TotalBalloonHitCount);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("TotalKillCount", TotalKillCount);
			Value_.Push("TotalBalloonHitCount", TotalBalloonHitCount);
		}
		public void Set(SBattleRecord Obj_)
		{
			TotalKillCount = Obj_.TotalKillCount;
			TotalBalloonHitCount = Obj_.TotalBalloonHitCount;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(TotalKillCount) + "," + 
				SEnumChecker.GetStdName(TotalBalloonHitCount);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(TotalKillCount, "TotalKillCount") + "," + 
				SEnumChecker.GetMemberName(TotalBalloonHitCount, "TotalBalloonHitCount");
		}
	}
	public class SMultiBattleInfo : SProto
	{
		public Int32 Point = default(Int32);
		public SMultiBattleInfo()
		{
		}
		public SMultiBattleInfo(SMultiBattleInfo Obj_)
		{
			Point = Obj_.Point;
		}
		public SMultiBattleInfo(Int32 Point_)
		{
			Point = Point_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Point);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Point", ref Point);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Point);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Point", Point);
		}
		public void Set(SMultiBattleInfo Obj_)
		{
			Point = Obj_.Point;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Point);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Point, "Point");
		}
	}
	public class SMultiBattleBeginNetSc : SBattle
	{
		public List<SBattlePlayer> Players = new List<SBattlePlayer>();
		public Dictionary<Int32,TimePoint> DisconnectEndTimes = new Dictionary<Int32,TimePoint>();
		public List<SMultiBattleInfo> BattleInfos = new List<SMultiBattleInfo>();
		public SBattleRecord Record = new SBattleRecord();
		public List<SCharacterNet> Characters = new List<SCharacterNet>();
		public Int64 EndTick = default(Int64);
		public Int64 Tick = default(Int64);
		public List<SStructMovePosition> StructMovePositions = new List<SStructMovePosition>();
		public SMultiBattleBeginNetSc()
		{
		}
		public SMultiBattleBeginNetSc(SMultiBattleBeginNetSc Obj_) : base(Obj_)
		{
			Players = Obj_.Players;
			DisconnectEndTimes = Obj_.DisconnectEndTimes;
			BattleInfos = Obj_.BattleInfos;
			Record = Obj_.Record;
			Characters = Obj_.Characters;
			EndTick = Obj_.EndTick;
			Tick = Obj_.Tick;
			StructMovePositions = Obj_.StructMovePositions;
		}
		public SMultiBattleBeginNetSc(SBattle Super_, List<SBattlePlayer> Players_, Dictionary<Int32,TimePoint> DisconnectEndTimes_, List<SMultiBattleInfo> BattleInfos_, SBattleRecord Record_, List<SCharacterNet> Characters_, Int64 EndTick_, Int64 Tick_, List<SStructMovePosition> StructMovePositions_) : base(Super_)
		{
			Players = Players_;
			DisconnectEndTimes = DisconnectEndTimes_;
			BattleInfos = BattleInfos_;
			Record = Record_;
			Characters = Characters_;
			EndTick = EndTick_;
			Tick = Tick_;
			StructMovePositions = StructMovePositions_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref Players);
			Stream_.Pop(ref DisconnectEndTimes);
			Stream_.Pop(ref BattleInfos);
			Stream_.Pop(ref Record);
			Stream_.Pop(ref Characters);
			Stream_.Pop(ref EndTick);
			Stream_.Pop(ref Tick);
			Stream_.Pop(ref StructMovePositions);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("Players", ref Players);
			Value_.Pop("DisconnectEndTimes", ref DisconnectEndTimes);
			Value_.Pop("BattleInfos", ref BattleInfos);
			Value_.Pop("Record", ref Record);
			Value_.Pop("Characters", ref Characters);
			Value_.Pop("EndTick", ref EndTick);
			Value_.Pop("Tick", ref Tick);
			Value_.Pop("StructMovePositions", ref StructMovePositions);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(Players);
			Stream_.Push(DisconnectEndTimes);
			Stream_.Push(BattleInfos);
			Stream_.Push(Record);
			Stream_.Push(Characters);
			Stream_.Push(EndTick);
			Stream_.Push(Tick);
			Stream_.Push(StructMovePositions);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("Players", Players);
			Value_.Push("DisconnectEndTimes", DisconnectEndTimes);
			Value_.Push("BattleInfos", BattleInfos);
			Value_.Push("Record", Record);
			Value_.Push("Characters", Characters);
			Value_.Push("EndTick", EndTick);
			Value_.Push("Tick", Tick);
			Value_.Push("StructMovePositions", StructMovePositions);
		}
		public void Set(SMultiBattleBeginNetSc Obj_)
		{
			base.Set(Obj_);
			Players = Obj_.Players;
			DisconnectEndTimes = Obj_.DisconnectEndTimes;
			BattleInfos = Obj_.BattleInfos;
			Record.Set(Obj_.Record);
			Characters = Obj_.Characters;
			EndTick = Obj_.EndTick;
			Tick = Obj_.Tick;
			StructMovePositions = Obj_.StructMovePositions;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(Players) + "," + 
				SEnumChecker.GetStdName(DisconnectEndTimes) + "," + 
				SEnumChecker.GetStdName(BattleInfos) + "," + 
				SEnumChecker.GetStdName(Record) + "," + 
				SEnumChecker.GetStdName(Characters) + "," + 
				SEnumChecker.GetStdName(EndTick) + "," + 
				SEnumChecker.GetStdName(Tick) + "," + 
				SEnumChecker.GetStdName(StructMovePositions);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(Players, "Players") + "," + 
				SEnumChecker.GetMemberName(DisconnectEndTimes, "DisconnectEndTimes") + "," + 
				SEnumChecker.GetMemberName(BattleInfos, "BattleInfos") + "," + 
				SEnumChecker.GetMemberName(Record, "Record") + "," + 
				SEnumChecker.GetMemberName(Characters, "Characters") + "," + 
				SEnumChecker.GetMemberName(EndTick, "EndTick") + "," + 
				SEnumChecker.GetMemberName(Tick, "Tick") + "," + 
				SEnumChecker.GetMemberName(StructMovePositions, "StructMovePositions");
		}
	}
	public class SMultiBattleStartNetSc : SProto
	{
		public Int64 EndTick = default(Int64);
		public SMultiBattleStartNetSc()
		{
		}
		public SMultiBattleStartNetSc(SMultiBattleStartNetSc Obj_)
		{
			EndTick = Obj_.EndTick;
		}
		public SMultiBattleStartNetSc(Int64 EndTick_)
		{
			EndTick = EndTick_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref EndTick);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("EndTick", ref EndTick);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(EndTick);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("EndTick", EndTick);
		}
		public void Set(SMultiBattleStartNetSc Obj_)
		{
			EndTick = Obj_.EndTick;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(EndTick);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(EndTick, "EndTick");
		}
	}
	public class SBattleEndPlayer : SProto
	{
		public Int32 AddedPoint = default(Int32);
		public Int32 AddedGold = default(Int32);
		public Int32 BattlePoint = default(Int32);
		public SBattleEndPlayer()
		{
		}
		public SBattleEndPlayer(SBattleEndPlayer Obj_)
		{
			AddedPoint = Obj_.AddedPoint;
			AddedGold = Obj_.AddedGold;
			BattlePoint = Obj_.BattlePoint;
		}
		public SBattleEndPlayer(Int32 AddedPoint_, Int32 AddedGold_, Int32 BattlePoint_)
		{
			AddedPoint = AddedPoint_;
			AddedGold = AddedGold_;
			BattlePoint = BattlePoint_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref AddedPoint);
			Stream_.Pop(ref AddedGold);
			Stream_.Pop(ref BattlePoint);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("AddedPoint", ref AddedPoint);
			Value_.Pop("AddedGold", ref AddedGold);
			Value_.Pop("BattlePoint", ref BattlePoint);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(AddedPoint);
			Stream_.Push(AddedGold);
			Stream_.Push(BattlePoint);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("AddedPoint", AddedPoint);
			Value_.Push("AddedGold", AddedGold);
			Value_.Push("BattlePoint", BattlePoint);
		}
		public void Set(SBattleEndPlayer Obj_)
		{
			AddedPoint = Obj_.AddedPoint;
			AddedGold = Obj_.AddedGold;
			BattlePoint = Obj_.BattlePoint;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(AddedPoint) + "," + 
				SEnumChecker.GetStdName(AddedGold) + "," + 
				SEnumChecker.GetStdName(BattlePoint);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(AddedPoint, "AddedPoint") + "," + 
				SEnumChecker.GetMemberName(AddedGold, "AddedGold") + "," + 
				SEnumChecker.GetMemberName(BattlePoint, "BattlePoint");
		}
	}
	public class STeamBattleInfo : SProto
	{
		public Int32 Ranking = default(Int32);
		public Int32 Point = default(Int32);
		public STeamBattleInfo()
		{
		}
		public STeamBattleInfo(STeamBattleInfo Obj_)
		{
			Ranking = Obj_.Ranking;
			Point = Obj_.Point;
		}
		public STeamBattleInfo(Int32 Ranking_, Int32 Point_)
		{
			Ranking = Ranking_;
			Point = Point_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Ranking);
			Stream_.Pop(ref Point);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Ranking", ref Ranking);
			Value_.Pop("Point", ref Point);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Ranking);
			Stream_.Push(Point);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Ranking", Ranking);
			Value_.Push("Point", Point);
		}
		public void Set(STeamBattleInfo Obj_)
		{
			Ranking = Obj_.Ranking;
			Point = Obj_.Point;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Ranking) + "," + 
				SEnumChecker.GetStdName(Point);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Ranking, "Ranking") + "," + 
				SEnumChecker.GetMemberName(Point, "Point");
		}
	}
	public class STeamRanking : STeamBattleInfo
	{
		public TTeamIndexGroup TeamIndexGroup = new TTeamIndexGroup();
		public STeamRanking()
		{
		}
		public STeamRanking(STeamRanking Obj_) : base(Obj_)
		{
			TeamIndexGroup = Obj_.TeamIndexGroup;
		}
		public STeamRanking(STeamBattleInfo Super_, TTeamIndexGroup TeamIndexGroup_) : base(Super_)
		{
			TeamIndexGroup = TeamIndexGroup_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref TeamIndexGroup);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("TeamIndexGroup", ref TeamIndexGroup);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(TeamIndexGroup);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("TeamIndexGroup", TeamIndexGroup);
		}
		public void Set(STeamRanking Obj_)
		{
			base.Set(Obj_);
			TeamIndexGroup = Obj_.TeamIndexGroup;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(TeamIndexGroup);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(TeamIndexGroup, "TeamIndexGroup");
		}
	}
	public class SMultiBattleEndNet : SProto
	{
		public SInvalidDisconnectInfo InvalidDisconnectInfo = new SInvalidDisconnectInfo();
		public SMultiBattleEndNet()
		{
		}
		public SMultiBattleEndNet(SMultiBattleEndNet Obj_)
		{
			InvalidDisconnectInfo = Obj_.InvalidDisconnectInfo;
		}
		public SMultiBattleEndNet(SInvalidDisconnectInfo InvalidDisconnectInfo_)
		{
			InvalidDisconnectInfo = InvalidDisconnectInfo_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref InvalidDisconnectInfo);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("InvalidDisconnectInfo", ref InvalidDisconnectInfo);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(InvalidDisconnectInfo);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("InvalidDisconnectInfo", InvalidDisconnectInfo);
		}
		public void Set(SMultiBattleEndNet Obj_)
		{
			InvalidDisconnectInfo.Set(Obj_.InvalidDisconnectInfo);
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(InvalidDisconnectInfo);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(InvalidDisconnectInfo, "InvalidDisconnectInfo");
		}
	}
	public class SMultiBattleEndNetSc : SMultiBattleEndNet
	{
		public TResource[] ResourcesLeft = new TResource[6];
		public List<SBattleEndPlayer> BattleEndPlayers = new List<SBattleEndPlayer>();
		public List<STeamRanking> OrderedTeamRankings = new List<STeamRanking>();
		public TDoneQuests DoneQuests = new TDoneQuests();
		public SMultiBattleEndNetSc()
		{
			for (int iResourcesLeft = 0; iResourcesLeft < ResourcesLeft.Length; ++iResourcesLeft)
				ResourcesLeft[iResourcesLeft] = default(TResource);
		}
		public SMultiBattleEndNetSc(SMultiBattleEndNetSc Obj_) : base(Obj_)
		{
			ResourcesLeft = Obj_.ResourcesLeft;
			BattleEndPlayers = Obj_.BattleEndPlayers;
			OrderedTeamRankings = Obj_.OrderedTeamRankings;
			DoneQuests = Obj_.DoneQuests;
		}
		public SMultiBattleEndNetSc(SMultiBattleEndNet Super_, TResource[] ResourcesLeft_, List<SBattleEndPlayer> BattleEndPlayers_, List<STeamRanking> OrderedTeamRankings_, TDoneQuests DoneQuests_) : base(Super_)
		{
			ResourcesLeft = ResourcesLeft_;
			BattleEndPlayers = BattleEndPlayers_;
			OrderedTeamRankings = OrderedTeamRankings_;
			DoneQuests = DoneQuests_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref ResourcesLeft);
			Stream_.Pop(ref BattleEndPlayers);
			Stream_.Pop(ref OrderedTeamRankings);
			Stream_.Pop(ref DoneQuests);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("ResourcesLeft", ref ResourcesLeft);
			Value_.Pop("BattleEndPlayers", ref BattleEndPlayers);
			Value_.Pop("OrderedTeamRankings", ref OrderedTeamRankings);
			Value_.Pop("DoneQuests", ref DoneQuests);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(ResourcesLeft);
			Stream_.Push(BattleEndPlayers);
			Stream_.Push(OrderedTeamRankings);
			Stream_.Push(DoneQuests);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("ResourcesLeft", ResourcesLeft);
			Value_.Push("BattleEndPlayers", BattleEndPlayers);
			Value_.Push("OrderedTeamRankings", OrderedTeamRankings);
			Value_.Push("DoneQuests", DoneQuests);
		}
		public void Set(SMultiBattleEndNetSc Obj_)
		{
			base.Set(Obj_);
			ResourcesLeft = Obj_.ResourcesLeft;
			BattleEndPlayers = Obj_.BattleEndPlayers;
			OrderedTeamRankings = Obj_.OrderedTeamRankings;
			DoneQuests = Obj_.DoneQuests;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(ResourcesLeft) + "," + 
				SEnumChecker.GetStdName(BattleEndPlayers) + "," + 
				SEnumChecker.GetStdName(OrderedTeamRankings) + "," + 
				SEnumChecker.GetStdName(DoneQuests);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(ResourcesLeft, "ResourcesLeft") + "," + 
				SEnumChecker.GetMemberName(BattleEndPlayers, "BattleEndPlayers") + "," + 
				SEnumChecker.GetMemberName(OrderedTeamRankings, "OrderedTeamRankings") + "," + 
				SEnumChecker.GetMemberName(DoneQuests, "DoneQuests");
		}
	}
	public class SMultiBattleEndDrawNetSc : SMultiBattleEndNet
	{
		public TResource[] ResourcesLeft = new TResource[6];
		public TDoneQuests DoneQuests = new TDoneQuests();
		public SMultiBattleEndDrawNetSc()
		{
			for (int iResourcesLeft = 0; iResourcesLeft < ResourcesLeft.Length; ++iResourcesLeft)
				ResourcesLeft[iResourcesLeft] = default(TResource);
		}
		public SMultiBattleEndDrawNetSc(SMultiBattleEndDrawNetSc Obj_) : base(Obj_)
		{
			ResourcesLeft = Obj_.ResourcesLeft;
			DoneQuests = Obj_.DoneQuests;
		}
		public SMultiBattleEndDrawNetSc(SMultiBattleEndNet Super_, TResource[] ResourcesLeft_, TDoneQuests DoneQuests_) : base(Super_)
		{
			ResourcesLeft = ResourcesLeft_;
			DoneQuests = DoneQuests_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref ResourcesLeft);
			Stream_.Pop(ref DoneQuests);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("ResourcesLeft", ref ResourcesLeft);
			Value_.Pop("DoneQuests", ref DoneQuests);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(ResourcesLeft);
			Stream_.Push(DoneQuests);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("ResourcesLeft", ResourcesLeft);
			Value_.Push("DoneQuests", DoneQuests);
		}
		public void Set(SMultiBattleEndDrawNetSc Obj_)
		{
			base.Set(Obj_);
			ResourcesLeft = Obj_.ResourcesLeft;
			DoneQuests = Obj_.DoneQuests;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(ResourcesLeft) + "," + 
				SEnumChecker.GetStdName(DoneQuests);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(ResourcesLeft, "ResourcesLeft") + "," + 
				SEnumChecker.GetMemberName(DoneQuests, "DoneQuests");
		}
	}
	public class SMultiBattleEndInvalidNetSc : SMultiBattleEndNet
	{
		public SMultiBattleEndInvalidNetSc()
		{
		}
		public SMultiBattleEndInvalidNetSc(SMultiBattleEndInvalidNetSc Obj_) : base(Obj_)
		{
		}
		public SMultiBattleEndInvalidNetSc(SMultiBattleEndNet Super_) : base(Super_)
		{
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
		}
		public void Set(SMultiBattleEndInvalidNetSc Obj_)
		{
			base.Set(Obj_);
		}
		public override string StdName()
		{
			return 
				base.StdName();
		}
		public override string MemberName()
		{
			return 
				base.MemberName();
		}
	}
	public class SMultiBattleIconNetCs : SProto
	{
		public Int32 Code = default(Int32);
		public SMultiBattleIconNetCs()
		{
		}
		public SMultiBattleIconNetCs(SMultiBattleIconNetCs Obj_)
		{
			Code = Obj_.Code;
		}
		public SMultiBattleIconNetCs(Int32 Code_)
		{
			Code = Code_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Code);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Code", ref Code);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Code);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Code", Code);
		}
		public void Set(SMultiBattleIconNetCs Obj_)
		{
			Code = Obj_.Code;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Code);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Code, "Code");
		}
	}
	public class SMultiBattleIconNetSc : SProto
	{
		public Int32 PlayerIndex = default(Int32);
		public Int32 Code = default(Int32);
		public SMultiBattleIconNetSc()
		{
		}
		public SMultiBattleIconNetSc(SMultiBattleIconNetSc Obj_)
		{
			PlayerIndex = Obj_.PlayerIndex;
			Code = Obj_.Code;
		}
		public SMultiBattleIconNetSc(Int32 PlayerIndex_, Int32 Code_)
		{
			PlayerIndex = PlayerIndex_;
			Code = Code_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref PlayerIndex);
			Stream_.Pop(ref Code);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("PlayerIndex", ref PlayerIndex);
			Value_.Pop("Code", ref Code);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(PlayerIndex);
			Stream_.Push(Code);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("PlayerIndex", PlayerIndex);
			Value_.Push("Code", Code);
		}
		public void Set(SMultiBattleIconNetSc Obj_)
		{
			PlayerIndex = Obj_.PlayerIndex;
			Code = Obj_.Code;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(PlayerIndex) + "," + 
				SEnumChecker.GetStdName(Code);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(PlayerIndex, "PlayerIndex") + "," + 
				SEnumChecker.GetMemberName(Code, "Code");
		}
	}
	public class SMultiBattleLinkNetSc : SProto
	{
		public Int64 Tick = default(Int64);
		public Int32 PlayerIndex = default(Int32);
		public SMultiBattleLinkNetSc()
		{
		}
		public SMultiBattleLinkNetSc(SMultiBattleLinkNetSc Obj_)
		{
			Tick = Obj_.Tick;
			PlayerIndex = Obj_.PlayerIndex;
		}
		public SMultiBattleLinkNetSc(Int64 Tick_, Int32 PlayerIndex_)
		{
			Tick = Tick_;
			PlayerIndex = PlayerIndex_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Tick);
			Stream_.Pop(ref PlayerIndex);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Tick", ref Tick);
			Value_.Pop("PlayerIndex", ref PlayerIndex);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Tick);
			Stream_.Push(PlayerIndex);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Tick", Tick);
			Value_.Push("PlayerIndex", PlayerIndex);
		}
		public void Set(SMultiBattleLinkNetSc Obj_)
		{
			Tick = Obj_.Tick;
			PlayerIndex = Obj_.PlayerIndex;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Tick) + "," + 
				SEnumChecker.GetStdName(PlayerIndex);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Tick, "Tick") + "," + 
				SEnumChecker.GetMemberName(PlayerIndex, "PlayerIndex");
		}
	}
	public class SMultiBattleUnLinkNetSc : SProto
	{
		public Int64 Tick = default(Int64);
		public Int32 PlayerIndex = default(Int32);
		public TimePoint DisconnectEndTime = default(TimePoint);
		public SMultiBattleUnLinkNetSc()
		{
		}
		public SMultiBattleUnLinkNetSc(SMultiBattleUnLinkNetSc Obj_)
		{
			Tick = Obj_.Tick;
			PlayerIndex = Obj_.PlayerIndex;
			DisconnectEndTime = Obj_.DisconnectEndTime;
		}
		public SMultiBattleUnLinkNetSc(Int64 Tick_, Int32 PlayerIndex_, TimePoint DisconnectEndTime_)
		{
			Tick = Tick_;
			PlayerIndex = PlayerIndex_;
			DisconnectEndTime = DisconnectEndTime_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Tick);
			Stream_.Pop(ref PlayerIndex);
			Stream_.Pop(ref DisconnectEndTime);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Tick", ref Tick);
			Value_.Pop("PlayerIndex", ref PlayerIndex);
			Value_.Pop("DisconnectEndTime", ref DisconnectEndTime);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Tick);
			Stream_.Push(PlayerIndex);
			Stream_.Push(DisconnectEndTime);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Tick", Tick);
			Value_.Push("PlayerIndex", PlayerIndex);
			Value_.Push("DisconnectEndTime", DisconnectEndTime);
		}
		public void Set(SMultiBattleUnLinkNetSc Obj_)
		{
			Tick = Obj_.Tick;
			PlayerIndex = Obj_.PlayerIndex;
			DisconnectEndTime = Obj_.DisconnectEndTime;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Tick) + "," + 
				SEnumChecker.GetStdName(PlayerIndex) + "," + 
				SEnumChecker.GetStdName(DisconnectEndTime);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Tick, "Tick") + "," + 
				SEnumChecker.GetMemberName(PlayerIndex, "PlayerIndex") + "," + 
				SEnumChecker.GetMemberName(DisconnectEndTime, "DisconnectEndTime");
		}
	}
	public class SInvalidDisconnectInfoNetSc : SInvalidDisconnectInfo
	{
		public SInvalidDisconnectInfoNetSc()
		{
		}
		public SInvalidDisconnectInfoNetSc(SInvalidDisconnectInfoNetSc Obj_) : base(Obj_)
		{
		}
		public SInvalidDisconnectInfoNetSc(SInvalidDisconnectInfo Super_) : base(Super_)
		{
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
		}
		public void Set(SInvalidDisconnectInfoNetSc Obj_)
		{
			base.Set(Obj_);
		}
		public override string StdName()
		{
			return 
				base.StdName();
		}
		public override string MemberName()
		{
			return 
				base.MemberName();
		}
	}
	public class SArrowDodgeBattleJoinNetCs : SProto
	{
		public override void Push(CStream Stream_)
		{
		}
		public override void Push(JsonDataObject Value_)
		{
		}
		public override void Pop(CStream Stream_)
		{
		}
		public override void Pop(JsonDataObject Value_)
		{
		}
		public override string StdName()
		{
			return "";
		}
		public override string MemberName()
		{
			return "";
		}
	}
	public class SArrowDodgeBattleJoinNetSc : SProto
	{
		public TResource GoldCost = default(TResource);
		public Int32 PlayCount = default(Int32);
		public TimePoint RefreshTime = default(TimePoint);
		public TDoneQuests DoneQuests = new TDoneQuests();
		public SArrowDodgeBattleJoinNetSc()
		{
		}
		public SArrowDodgeBattleJoinNetSc(SArrowDodgeBattleJoinNetSc Obj_)
		{
			GoldCost = Obj_.GoldCost;
			PlayCount = Obj_.PlayCount;
			RefreshTime = Obj_.RefreshTime;
			DoneQuests = Obj_.DoneQuests;
		}
		public SArrowDodgeBattleJoinNetSc(TResource GoldCost_, Int32 PlayCount_, TimePoint RefreshTime_, TDoneQuests DoneQuests_)
		{
			GoldCost = GoldCost_;
			PlayCount = PlayCount_;
			RefreshTime = RefreshTime_;
			DoneQuests = DoneQuests_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref GoldCost);
			Stream_.Pop(ref PlayCount);
			Stream_.Pop(ref RefreshTime);
			Stream_.Pop(ref DoneQuests);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("GoldCost", ref GoldCost);
			Value_.Pop("PlayCount", ref PlayCount);
			Value_.Pop("RefreshTime", ref RefreshTime);
			Value_.Pop("DoneQuests", ref DoneQuests);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(GoldCost);
			Stream_.Push(PlayCount);
			Stream_.Push(RefreshTime);
			Stream_.Push(DoneQuests);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("GoldCost", GoldCost);
			Value_.Push("PlayCount", PlayCount);
			Value_.Push("RefreshTime", RefreshTime);
			Value_.Push("DoneQuests", DoneQuests);
		}
		public void Set(SArrowDodgeBattleJoinNetSc Obj_)
		{
			GoldCost = Obj_.GoldCost;
			PlayCount = Obj_.PlayCount;
			RefreshTime = Obj_.RefreshTime;
			DoneQuests = Obj_.DoneQuests;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(GoldCost) + "," + 
				SEnumChecker.GetStdName(PlayCount) + "," + 
				SEnumChecker.GetStdName(RefreshTime) + "," + 
				SEnumChecker.GetStdName(DoneQuests);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(GoldCost, "GoldCost") + "," + 
				SEnumChecker.GetMemberName(PlayCount, "PlayCount") + "," + 
				SEnumChecker.GetMemberName(RefreshTime, "RefreshTime") + "," + 
				SEnumChecker.GetMemberName(DoneQuests, "DoneQuests");
		}
	}
	public class SArrow : SProto
	{
		public SPoint LocalPosition = new SPoint();
		public SPoint Velocity = new SPoint();
		public SArrow()
		{
		}
		public SArrow(SArrow Obj_)
		{
			LocalPosition = Obj_.LocalPosition;
			Velocity = Obj_.Velocity;
		}
		public SArrow(SPoint LocalPosition_, SPoint Velocity_)
		{
			LocalPosition = LocalPosition_;
			Velocity = Velocity_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref LocalPosition);
			Stream_.Pop(ref Velocity);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("LocalPosition", ref LocalPosition);
			Value_.Pop("Velocity", ref Velocity);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(LocalPosition);
			Stream_.Push(Velocity);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("LocalPosition", LocalPosition);
			Value_.Push("Velocity", Velocity);
		}
		public void Set(SArrow Obj_)
		{
			LocalPosition.Set(Obj_.LocalPosition);
			Velocity.Set(Obj_.Velocity);
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(LocalPosition) + "," + 
				SEnumChecker.GetStdName(Velocity);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(LocalPosition, "LocalPosition") + "," + 
				SEnumChecker.GetMemberName(Velocity, "Velocity");
		}
	}
	public enum EArrowDodgeItemType
	{
		Coin,
		GoldBar,
		Shield,
		Stamina,
		Max,
		Null,
	}
	public class SArrowDodgeItem : SProto
	{
		public SPoint LocalPosition = new SPoint();
		public EArrowDodgeItemType ItemType = default(EArrowDodgeItemType);
		public SArrowDodgeItem()
		{
		}
		public SArrowDodgeItem(SArrowDodgeItem Obj_)
		{
			LocalPosition = Obj_.LocalPosition;
			ItemType = Obj_.ItemType;
		}
		public SArrowDodgeItem(SPoint LocalPosition_, EArrowDodgeItemType ItemType_)
		{
			LocalPosition = LocalPosition_;
			ItemType = ItemType_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref LocalPosition);
			Stream_.Pop(ref ItemType);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("LocalPosition", ref LocalPosition);
			Value_.Pop("ItemType", ref ItemType);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(LocalPosition);
			Stream_.Push(ItemType);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("LocalPosition", LocalPosition);
			Value_.Push("ItemType", ItemType);
		}
		public void Set(SArrowDodgeItem Obj_)
		{
			LocalPosition.Set(Obj_.LocalPosition);
			ItemType = Obj_.ItemType;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(LocalPosition) + "," + 
				"bb.EArrowDodgeItemType";
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(LocalPosition, "LocalPosition") + "," + 
				SEnumChecker.GetMemberName(ItemType, "ItemType");
		}
	}
	public class SArrowDodgeBattleInfo : SProto
	{
		public Int32 Point = default(Int32);
		public Int64 Tick = default(Int64);
		public TResource Gold = default(TResource);
		public SArrowDodgeBattleInfo()
		{
		}
		public SArrowDodgeBattleInfo(SArrowDodgeBattleInfo Obj_)
		{
			Point = Obj_.Point;
			Tick = Obj_.Tick;
			Gold = Obj_.Gold;
		}
		public SArrowDodgeBattleInfo(Int32 Point_, Int64 Tick_, TResource Gold_)
		{
			Point = Point_;
			Tick = Tick_;
			Gold = Gold_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Point);
			Stream_.Pop(ref Tick);
			Stream_.Pop(ref Gold);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Point", ref Point);
			Value_.Pop("Tick", ref Tick);
			Value_.Pop("Gold", ref Gold);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Point);
			Stream_.Push(Tick);
			Stream_.Push(Gold);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Point", Point);
			Value_.Push("Tick", Tick);
			Value_.Push("Gold", Gold);
		}
		public void Set(SArrowDodgeBattleInfo Obj_)
		{
			Point = Obj_.Point;
			Tick = Obj_.Tick;
			Gold = Obj_.Gold;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Point) + "," + 
				SEnumChecker.GetStdName(Tick) + "," + 
				SEnumChecker.GetStdName(Gold);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Point, "Point") + "," + 
				SEnumChecker.GetMemberName(Tick, "Tick") + "," + 
				SEnumChecker.GetMemberName(Gold, "Gold");
		}
	}
	public class SArrowDodgeBattleBuf : SProto
	{
		public Boolean Enabled = default(Boolean);
		public Int64 EndTick = default(Int64);
		public SArrowDodgeBattleBuf()
		{
		}
		public SArrowDodgeBattleBuf(SArrowDodgeBattleBuf Obj_)
		{
			Enabled = Obj_.Enabled;
			EndTick = Obj_.EndTick;
		}
		public SArrowDodgeBattleBuf(Boolean Enabled_, Int64 EndTick_)
		{
			Enabled = Enabled_;
			EndTick = EndTick_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Enabled);
			Stream_.Pop(ref EndTick);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Enabled", ref Enabled);
			Value_.Pop("EndTick", ref EndTick);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Enabled);
			Stream_.Push(EndTick);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Enabled", Enabled);
			Value_.Push("EndTick", EndTick);
		}
		public void Set(SArrowDodgeBattleBuf Obj_)
		{
			Enabled = Obj_.Enabled;
			EndTick = Obj_.EndTick;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Enabled) + "," + 
				SEnumChecker.GetStdName(EndTick);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Enabled, "Enabled") + "," + 
				SEnumChecker.GetMemberName(EndTick, "EndTick");
		}
	}
	public class SArrowDodgeBattleBufs : SProto
	{
		public SArrowDodgeBattleBuf Shield = new SArrowDodgeBattleBuf();
		public SArrowDodgeBattleBuf Stamina = new SArrowDodgeBattleBuf();
		public SArrowDodgeBattleBufs()
		{
		}
		public SArrowDodgeBattleBufs(SArrowDodgeBattleBufs Obj_)
		{
			Shield = Obj_.Shield;
			Stamina = Obj_.Stamina;
		}
		public SArrowDodgeBattleBufs(SArrowDodgeBattleBuf Shield_, SArrowDodgeBattleBuf Stamina_)
		{
			Shield = Shield_;
			Stamina = Stamina_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Shield);
			Stream_.Pop(ref Stamina);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Shield", ref Shield);
			Value_.Pop("Stamina", ref Stamina);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Shield);
			Stream_.Push(Stamina);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Shield", Shield);
			Value_.Push("Stamina", Stamina);
		}
		public void Set(SArrowDodgeBattleBufs Obj_)
		{
			Shield.Set(Obj_.Shield);
			Stamina.Set(Obj_.Stamina);
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Shield) + "," + 
				SEnumChecker.GetStdName(Stamina);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Shield, "Shield") + "," + 
				SEnumChecker.GetMemberName(Stamina, "Stamina");
		}
	}
	public class SArrowDodgeBattleBeginNetSc : SProto
	{
		public SBattlePlayer Player = new SBattlePlayer();
		public SArrowDodgeBattleInfo BattleInfo = new SArrowDodgeBattleInfo();
		public SArrowDodgeBattleBufs Bufs = new SArrowDodgeBattleBufs();
		public SCharacterNet Character = new SCharacterNet();
		public Int64 Tick = default(Int64);
		public UInt32 RandomSeed = default(UInt32);
		public Int64 NextDownArrowTick = default(Int64);
		public Int64 NextLeftArrowTick = default(Int64);
		public Int64 NextRightArrowTick = default(Int64);
		public Int64 NextItemTick = default(Int64);
		public List<SArrow> Arrows = new List<SArrow>();
		public List<SArrowDodgeItem> Items = new List<SArrowDodgeItem>();
		public Boolean Started = default(Boolean);
		public SArrowDodgeBattleBeginNetSc()
		{
		}
		public SArrowDodgeBattleBeginNetSc(SArrowDodgeBattleBeginNetSc Obj_)
		{
			Player = Obj_.Player;
			BattleInfo = Obj_.BattleInfo;
			Bufs = Obj_.Bufs;
			Character = Obj_.Character;
			Tick = Obj_.Tick;
			RandomSeed = Obj_.RandomSeed;
			NextDownArrowTick = Obj_.NextDownArrowTick;
			NextLeftArrowTick = Obj_.NextLeftArrowTick;
			NextRightArrowTick = Obj_.NextRightArrowTick;
			NextItemTick = Obj_.NextItemTick;
			Arrows = Obj_.Arrows;
			Items = Obj_.Items;
			Started = Obj_.Started;
		}
		public SArrowDodgeBattleBeginNetSc(SBattlePlayer Player_, SArrowDodgeBattleInfo BattleInfo_, SArrowDodgeBattleBufs Bufs_, SCharacterNet Character_, Int64 Tick_, UInt32 RandomSeed_, Int64 NextDownArrowTick_, Int64 NextLeftArrowTick_, Int64 NextRightArrowTick_, Int64 NextItemTick_, List<SArrow> Arrows_, List<SArrowDodgeItem> Items_, Boolean Started_)
		{
			Player = Player_;
			BattleInfo = BattleInfo_;
			Bufs = Bufs_;
			Character = Character_;
			Tick = Tick_;
			RandomSeed = RandomSeed_;
			NextDownArrowTick = NextDownArrowTick_;
			NextLeftArrowTick = NextLeftArrowTick_;
			NextRightArrowTick = NextRightArrowTick_;
			NextItemTick = NextItemTick_;
			Arrows = Arrows_;
			Items = Items_;
			Started = Started_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Player);
			Stream_.Pop(ref BattleInfo);
			Stream_.Pop(ref Bufs);
			Stream_.Pop(ref Character);
			Stream_.Pop(ref Tick);
			Stream_.Pop(ref RandomSeed);
			Stream_.Pop(ref NextDownArrowTick);
			Stream_.Pop(ref NextLeftArrowTick);
			Stream_.Pop(ref NextRightArrowTick);
			Stream_.Pop(ref NextItemTick);
			Stream_.Pop(ref Arrows);
			Stream_.Pop(ref Items);
			Stream_.Pop(ref Started);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Player", ref Player);
			Value_.Pop("BattleInfo", ref BattleInfo);
			Value_.Pop("Bufs", ref Bufs);
			Value_.Pop("Character", ref Character);
			Value_.Pop("Tick", ref Tick);
			Value_.Pop("RandomSeed", ref RandomSeed);
			Value_.Pop("NextDownArrowTick", ref NextDownArrowTick);
			Value_.Pop("NextLeftArrowTick", ref NextLeftArrowTick);
			Value_.Pop("NextRightArrowTick", ref NextRightArrowTick);
			Value_.Pop("NextItemTick", ref NextItemTick);
			Value_.Pop("Arrows", ref Arrows);
			Value_.Pop("Items", ref Items);
			Value_.Pop("Started", ref Started);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Player);
			Stream_.Push(BattleInfo);
			Stream_.Push(Bufs);
			Stream_.Push(Character);
			Stream_.Push(Tick);
			Stream_.Push(RandomSeed);
			Stream_.Push(NextDownArrowTick);
			Stream_.Push(NextLeftArrowTick);
			Stream_.Push(NextRightArrowTick);
			Stream_.Push(NextItemTick);
			Stream_.Push(Arrows);
			Stream_.Push(Items);
			Stream_.Push(Started);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Player", Player);
			Value_.Push("BattleInfo", BattleInfo);
			Value_.Push("Bufs", Bufs);
			Value_.Push("Character", Character);
			Value_.Push("Tick", Tick);
			Value_.Push("RandomSeed", RandomSeed);
			Value_.Push("NextDownArrowTick", NextDownArrowTick);
			Value_.Push("NextLeftArrowTick", NextLeftArrowTick);
			Value_.Push("NextRightArrowTick", NextRightArrowTick);
			Value_.Push("NextItemTick", NextItemTick);
			Value_.Push("Arrows", Arrows);
			Value_.Push("Items", Items);
			Value_.Push("Started", Started);
		}
		public void Set(SArrowDodgeBattleBeginNetSc Obj_)
		{
			Player.Set(Obj_.Player);
			BattleInfo.Set(Obj_.BattleInfo);
			Bufs.Set(Obj_.Bufs);
			Character.Set(Obj_.Character);
			Tick = Obj_.Tick;
			RandomSeed = Obj_.RandomSeed;
			NextDownArrowTick = Obj_.NextDownArrowTick;
			NextLeftArrowTick = Obj_.NextLeftArrowTick;
			NextRightArrowTick = Obj_.NextRightArrowTick;
			NextItemTick = Obj_.NextItemTick;
			Arrows = Obj_.Arrows;
			Items = Obj_.Items;
			Started = Obj_.Started;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Player) + "," + 
				SEnumChecker.GetStdName(BattleInfo) + "," + 
				SEnumChecker.GetStdName(Bufs) + "," + 
				SEnumChecker.GetStdName(Character) + "," + 
				SEnumChecker.GetStdName(Tick) + "," + 
				SEnumChecker.GetStdName(RandomSeed) + "," + 
				SEnumChecker.GetStdName(NextDownArrowTick) + "," + 
				SEnumChecker.GetStdName(NextLeftArrowTick) + "," + 
				SEnumChecker.GetStdName(NextRightArrowTick) + "," + 
				SEnumChecker.GetStdName(NextItemTick) + "," + 
				SEnumChecker.GetStdName(Arrows) + "," + 
				SEnumChecker.GetStdName(Items) + "," + 
				SEnumChecker.GetStdName(Started);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Player, "Player") + "," + 
				SEnumChecker.GetMemberName(BattleInfo, "BattleInfo") + "," + 
				SEnumChecker.GetMemberName(Bufs, "Bufs") + "," + 
				SEnumChecker.GetMemberName(Character, "Character") + "," + 
				SEnumChecker.GetMemberName(Tick, "Tick") + "," + 
				SEnumChecker.GetMemberName(RandomSeed, "RandomSeed") + "," + 
				SEnumChecker.GetMemberName(NextDownArrowTick, "NextDownArrowTick") + "," + 
				SEnumChecker.GetMemberName(NextLeftArrowTick, "NextLeftArrowTick") + "," + 
				SEnumChecker.GetMemberName(NextRightArrowTick, "NextRightArrowTick") + "," + 
				SEnumChecker.GetMemberName(NextItemTick, "NextItemTick") + "," + 
				SEnumChecker.GetMemberName(Arrows, "Arrows") + "," + 
				SEnumChecker.GetMemberName(Items, "Items") + "," + 
				SEnumChecker.GetMemberName(Started, "Started");
		}
	}
	public class SArrowDodgeBattleStartNetSc : SProto
	{
		public override void Push(CStream Stream_)
		{
		}
		public override void Push(JsonDataObject Value_)
		{
		}
		public override void Pop(CStream Stream_)
		{
		}
		public override void Pop(JsonDataObject Value_)
		{
		}
		public override string StdName()
		{
			return "";
		}
		public override string MemberName()
		{
			return "";
		}
	}
	public class SArrowDodgeBattleEndNetCs : SProto
	{
		public override void Push(CStream Stream_)
		{
		}
		public override void Push(JsonDataObject Value_)
		{
		}
		public override void Pop(CStream Stream_)
		{
		}
		public override void Pop(JsonDataObject Value_)
		{
		}
		public override string StdName()
		{
			return "";
		}
		public override string MemberName()
		{
			return "";
		}
	}
	public class SArrowDodgeBattleEndNetSc : SProto
	{
		public Int64 Tick = default(Int64);
		public TResource[] ResourcesLeft = new TResource[6];
		public TDoneQuests DoneQuests = new TDoneQuests();
		public SArrowDodgeBattleEndNetSc()
		{
			for (int iResourcesLeft = 0; iResourcesLeft < ResourcesLeft.Length; ++iResourcesLeft)
				ResourcesLeft[iResourcesLeft] = default(TResource);
		}
		public SArrowDodgeBattleEndNetSc(SArrowDodgeBattleEndNetSc Obj_)
		{
			Tick = Obj_.Tick;
			ResourcesLeft = Obj_.ResourcesLeft;
			DoneQuests = Obj_.DoneQuests;
		}
		public SArrowDodgeBattleEndNetSc(Int64 Tick_, TResource[] ResourcesLeft_, TDoneQuests DoneQuests_)
		{
			Tick = Tick_;
			ResourcesLeft = ResourcesLeft_;
			DoneQuests = DoneQuests_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Tick);
			Stream_.Pop(ref ResourcesLeft);
			Stream_.Pop(ref DoneQuests);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Tick", ref Tick);
			Value_.Pop("ResourcesLeft", ref ResourcesLeft);
			Value_.Pop("DoneQuests", ref DoneQuests);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Tick);
			Stream_.Push(ResourcesLeft);
			Stream_.Push(DoneQuests);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Tick", Tick);
			Value_.Push("ResourcesLeft", ResourcesLeft);
			Value_.Push("DoneQuests", DoneQuests);
		}
		public void Set(SArrowDodgeBattleEndNetSc Obj_)
		{
			Tick = Obj_.Tick;
			ResourcesLeft = Obj_.ResourcesLeft;
			DoneQuests = Obj_.DoneQuests;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Tick) + "," + 
				SEnumChecker.GetStdName(ResourcesLeft) + "," + 
				SEnumChecker.GetStdName(DoneQuests);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Tick, "Tick") + "," + 
				SEnumChecker.GetMemberName(ResourcesLeft, "ResourcesLeft") + "," + 
				SEnumChecker.GetMemberName(DoneQuests, "DoneQuests");
		}
	}
	public class SFlyAwayBattleJoinNetCs : SProto
	{
		public override void Push(CStream Stream_)
		{
		}
		public override void Push(JsonDataObject Value_)
		{
		}
		public override void Pop(CStream Stream_)
		{
		}
		public override void Pop(JsonDataObject Value_)
		{
		}
		public override string StdName()
		{
			return "";
		}
		public override string MemberName()
		{
			return "";
		}
	}
	public class SFlyAwayBattleJoinNetSc : SProto
	{
		public TResource GoldCost = default(TResource);
		public Int32 PlayCount = default(Int32);
		public TimePoint RefreshTime = default(TimePoint);
		public TDoneQuests DoneQuests = new TDoneQuests();
		public SFlyAwayBattleJoinNetSc()
		{
		}
		public SFlyAwayBattleJoinNetSc(SFlyAwayBattleJoinNetSc Obj_)
		{
			GoldCost = Obj_.GoldCost;
			PlayCount = Obj_.PlayCount;
			RefreshTime = Obj_.RefreshTime;
			DoneQuests = Obj_.DoneQuests;
		}
		public SFlyAwayBattleJoinNetSc(TResource GoldCost_, Int32 PlayCount_, TimePoint RefreshTime_, TDoneQuests DoneQuests_)
		{
			GoldCost = GoldCost_;
			PlayCount = PlayCount_;
			RefreshTime = RefreshTime_;
			DoneQuests = DoneQuests_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref GoldCost);
			Stream_.Pop(ref PlayCount);
			Stream_.Pop(ref RefreshTime);
			Stream_.Pop(ref DoneQuests);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("GoldCost", ref GoldCost);
			Value_.Pop("PlayCount", ref PlayCount);
			Value_.Pop("RefreshTime", ref RefreshTime);
			Value_.Pop("DoneQuests", ref DoneQuests);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(GoldCost);
			Stream_.Push(PlayCount);
			Stream_.Push(RefreshTime);
			Stream_.Push(DoneQuests);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("GoldCost", GoldCost);
			Value_.Push("PlayCount", PlayCount);
			Value_.Push("RefreshTime", RefreshTime);
			Value_.Push("DoneQuests", DoneQuests);
		}
		public void Set(SFlyAwayBattleJoinNetSc Obj_)
		{
			GoldCost = Obj_.GoldCost;
			PlayCount = Obj_.PlayCount;
			RefreshTime = Obj_.RefreshTime;
			DoneQuests = Obj_.DoneQuests;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(GoldCost) + "," + 
				SEnumChecker.GetStdName(PlayCount) + "," + 
				SEnumChecker.GetStdName(RefreshTime) + "," + 
				SEnumChecker.GetStdName(DoneQuests);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(GoldCost, "GoldCost") + "," + 
				SEnumChecker.GetMemberName(PlayCount, "PlayCount") + "," + 
				SEnumChecker.GetMemberName(RefreshTime, "RefreshTime") + "," + 
				SEnumChecker.GetMemberName(DoneQuests, "DoneQuests");
		}
	}
	public enum EFlyAwayLandState
	{
		Normal,
		Shaking,
		Falling,
	}
	public class SFlyAwayLand : SProto
	{
		public SPoint LocalPosition = new SPoint();
		public Int32 Number = default(Int32);
		public Int32 Index = default(Int32);
		public EFlyAwayLandState State = default(EFlyAwayLandState);
		public Int64 NextActionTick = default(Int64);
		public SFlyAwayLand()
		{
		}
		public SFlyAwayLand(SFlyAwayLand Obj_)
		{
			LocalPosition = Obj_.LocalPosition;
			Number = Obj_.Number;
			Index = Obj_.Index;
			State = Obj_.State;
			NextActionTick = Obj_.NextActionTick;
		}
		public SFlyAwayLand(SPoint LocalPosition_, Int32 Number_, Int32 Index_, EFlyAwayLandState State_, Int64 NextActionTick_)
		{
			LocalPosition = LocalPosition_;
			Number = Number_;
			Index = Index_;
			State = State_;
			NextActionTick = NextActionTick_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref LocalPosition);
			Stream_.Pop(ref Number);
			Stream_.Pop(ref Index);
			Stream_.Pop(ref State);
			Stream_.Pop(ref NextActionTick);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("LocalPosition", ref LocalPosition);
			Value_.Pop("Number", ref Number);
			Value_.Pop("Index", ref Index);
			Value_.Pop("State", ref State);
			Value_.Pop("NextActionTick", ref NextActionTick);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(LocalPosition);
			Stream_.Push(Number);
			Stream_.Push(Index);
			Stream_.Push(State);
			Stream_.Push(NextActionTick);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("LocalPosition", LocalPosition);
			Value_.Push("Number", Number);
			Value_.Push("Index", Index);
			Value_.Push("State", State);
			Value_.Push("NextActionTick", NextActionTick);
		}
		public void Set(SFlyAwayLand Obj_)
		{
			LocalPosition.Set(Obj_.LocalPosition);
			Number = Obj_.Number;
			Index = Obj_.Index;
			State = Obj_.State;
			NextActionTick = Obj_.NextActionTick;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(LocalPosition) + "," + 
				SEnumChecker.GetStdName(Number) + "," + 
				SEnumChecker.GetStdName(Index) + "," + 
				"bb.EFlyAwayLandState" + "," + 
				SEnumChecker.GetStdName(NextActionTick);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(LocalPosition, "LocalPosition") + "," + 
				SEnumChecker.GetMemberName(Number, "Number") + "," + 
				SEnumChecker.GetMemberName(Index, "Index") + "," + 
				SEnumChecker.GetMemberName(State, "State") + "," + 
				SEnumChecker.GetMemberName(NextActionTick, "NextActionTick");
		}
	}
	public enum EFlyAwayItemType
	{
		Coin,
		GoldBar,
		Apple,
		Meat,
		Chicken,
		Max,
		Null,
	}
	public class SFlyAwayItem : SProto
	{
		public SPoint LocalPosition = new SPoint();
		public EFlyAwayItemType ItemType = default(EFlyAwayItemType);
		public SFlyAwayItem()
		{
		}
		public SFlyAwayItem(SFlyAwayItem Obj_)
		{
			LocalPosition = Obj_.LocalPosition;
			ItemType = Obj_.ItemType;
		}
		public SFlyAwayItem(SPoint LocalPosition_, EFlyAwayItemType ItemType_)
		{
			LocalPosition = LocalPosition_;
			ItemType = ItemType_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref LocalPosition);
			Stream_.Pop(ref ItemType);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("LocalPosition", ref LocalPosition);
			Value_.Pop("ItemType", ref ItemType);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(LocalPosition);
			Stream_.Push(ItemType);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("LocalPosition", LocalPosition);
			Value_.Push("ItemType", ItemType);
		}
		public void Set(SFlyAwayItem Obj_)
		{
			LocalPosition.Set(Obj_.LocalPosition);
			ItemType = Obj_.ItemType;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(LocalPosition) + "," + 
				"bb.EFlyAwayItemType";
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(LocalPosition, "LocalPosition") + "," + 
				SEnumChecker.GetMemberName(ItemType, "ItemType");
		}
	}
	public class SFlyAwayBattleInfo : SProto
	{
		public Int32 Point = default(Int32);
		public Int32 PassedCount = default(Int32);
		public Int32 PerfectCombo = default(Int32);
		public TResource Gold = default(TResource);
		public SFlyAwayBattleInfo()
		{
		}
		public SFlyAwayBattleInfo(SFlyAwayBattleInfo Obj_)
		{
			Point = Obj_.Point;
			PassedCount = Obj_.PassedCount;
			PerfectCombo = Obj_.PerfectCombo;
			Gold = Obj_.Gold;
		}
		public SFlyAwayBattleInfo(Int32 Point_, Int32 PassedCount_, Int32 PerfectCombo_, TResource Gold_)
		{
			Point = Point_;
			PassedCount = PassedCount_;
			PerfectCombo = PerfectCombo_;
			Gold = Gold_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Point);
			Stream_.Pop(ref PassedCount);
			Stream_.Pop(ref PerfectCombo);
			Stream_.Pop(ref Gold);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Point", ref Point);
			Value_.Pop("PassedCount", ref PassedCount);
			Value_.Pop("PerfectCombo", ref PerfectCombo);
			Value_.Pop("Gold", ref Gold);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Point);
			Stream_.Push(PassedCount);
			Stream_.Push(PerfectCombo);
			Stream_.Push(Gold);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Point", Point);
			Value_.Push("PassedCount", PassedCount);
			Value_.Push("PerfectCombo", PerfectCombo);
			Value_.Push("Gold", Gold);
		}
		public void Set(SFlyAwayBattleInfo Obj_)
		{
			Point = Obj_.Point;
			PassedCount = Obj_.PassedCount;
			PerfectCombo = Obj_.PerfectCombo;
			Gold = Obj_.Gold;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Point) + "," + 
				SEnumChecker.GetStdName(PassedCount) + "," + 
				SEnumChecker.GetStdName(PerfectCombo) + "," + 
				SEnumChecker.GetStdName(Gold);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Point, "Point") + "," + 
				SEnumChecker.GetMemberName(PassedCount, "PassedCount") + "," + 
				SEnumChecker.GetMemberName(PerfectCombo, "PerfectCombo") + "," + 
				SEnumChecker.GetMemberName(Gold, "Gold");
		}
	}
	public class SFlyAwayBattleBeginNetSc : SProto
	{
		public SBattlePlayer Player = new SBattlePlayer();
		public SFlyAwayBattleInfo BattleInfo = new SFlyAwayBattleInfo();
		public SCharacterNet Character = new SCharacterNet();
		public Int64 Tick = default(Int64);
		public UInt32 RandomSeed = default(UInt32);
		public Int32 LandCounter = default(Int32);
		public SPoint LastLandPosition = new SPoint();
		public List<SFlyAwayLand> Lands = new List<SFlyAwayLand>();
		public List<SFlyAwayItem> Items = new List<SFlyAwayItem>();
		public Boolean Started = default(Boolean);
		public SFlyAwayBattleBeginNetSc()
		{
		}
		public SFlyAwayBattleBeginNetSc(SFlyAwayBattleBeginNetSc Obj_)
		{
			Player = Obj_.Player;
			BattleInfo = Obj_.BattleInfo;
			Character = Obj_.Character;
			Tick = Obj_.Tick;
			RandomSeed = Obj_.RandomSeed;
			LandCounter = Obj_.LandCounter;
			LastLandPosition = Obj_.LastLandPosition;
			Lands = Obj_.Lands;
			Items = Obj_.Items;
			Started = Obj_.Started;
		}
		public SFlyAwayBattleBeginNetSc(SBattlePlayer Player_, SFlyAwayBattleInfo BattleInfo_, SCharacterNet Character_, Int64 Tick_, UInt32 RandomSeed_, Int32 LandCounter_, SPoint LastLandPosition_, List<SFlyAwayLand> Lands_, List<SFlyAwayItem> Items_, Boolean Started_)
		{
			Player = Player_;
			BattleInfo = BattleInfo_;
			Character = Character_;
			Tick = Tick_;
			RandomSeed = RandomSeed_;
			LandCounter = LandCounter_;
			LastLandPosition = LastLandPosition_;
			Lands = Lands_;
			Items = Items_;
			Started = Started_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Player);
			Stream_.Pop(ref BattleInfo);
			Stream_.Pop(ref Character);
			Stream_.Pop(ref Tick);
			Stream_.Pop(ref RandomSeed);
			Stream_.Pop(ref LandCounter);
			Stream_.Pop(ref LastLandPosition);
			Stream_.Pop(ref Lands);
			Stream_.Pop(ref Items);
			Stream_.Pop(ref Started);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Player", ref Player);
			Value_.Pop("BattleInfo", ref BattleInfo);
			Value_.Pop("Character", ref Character);
			Value_.Pop("Tick", ref Tick);
			Value_.Pop("RandomSeed", ref RandomSeed);
			Value_.Pop("LandCounter", ref LandCounter);
			Value_.Pop("LastLandPosition", ref LastLandPosition);
			Value_.Pop("Lands", ref Lands);
			Value_.Pop("Items", ref Items);
			Value_.Pop("Started", ref Started);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Player);
			Stream_.Push(BattleInfo);
			Stream_.Push(Character);
			Stream_.Push(Tick);
			Stream_.Push(RandomSeed);
			Stream_.Push(LandCounter);
			Stream_.Push(LastLandPosition);
			Stream_.Push(Lands);
			Stream_.Push(Items);
			Stream_.Push(Started);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Player", Player);
			Value_.Push("BattleInfo", BattleInfo);
			Value_.Push("Character", Character);
			Value_.Push("Tick", Tick);
			Value_.Push("RandomSeed", RandomSeed);
			Value_.Push("LandCounter", LandCounter);
			Value_.Push("LastLandPosition", LastLandPosition);
			Value_.Push("Lands", Lands);
			Value_.Push("Items", Items);
			Value_.Push("Started", Started);
		}
		public void Set(SFlyAwayBattleBeginNetSc Obj_)
		{
			Player.Set(Obj_.Player);
			BattleInfo.Set(Obj_.BattleInfo);
			Character.Set(Obj_.Character);
			Tick = Obj_.Tick;
			RandomSeed = Obj_.RandomSeed;
			LandCounter = Obj_.LandCounter;
			LastLandPosition.Set(Obj_.LastLandPosition);
			Lands = Obj_.Lands;
			Items = Obj_.Items;
			Started = Obj_.Started;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Player) + "," + 
				SEnumChecker.GetStdName(BattleInfo) + "," + 
				SEnumChecker.GetStdName(Character) + "," + 
				SEnumChecker.GetStdName(Tick) + "," + 
				SEnumChecker.GetStdName(RandomSeed) + "," + 
				SEnumChecker.GetStdName(LandCounter) + "," + 
				SEnumChecker.GetStdName(LastLandPosition) + "," + 
				SEnumChecker.GetStdName(Lands) + "," + 
				SEnumChecker.GetStdName(Items) + "," + 
				SEnumChecker.GetStdName(Started);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Player, "Player") + "," + 
				SEnumChecker.GetMemberName(BattleInfo, "BattleInfo") + "," + 
				SEnumChecker.GetMemberName(Character, "Character") + "," + 
				SEnumChecker.GetMemberName(Tick, "Tick") + "," + 
				SEnumChecker.GetMemberName(RandomSeed, "RandomSeed") + "," + 
				SEnumChecker.GetMemberName(LandCounter, "LandCounter") + "," + 
				SEnumChecker.GetMemberName(LastLandPosition, "LastLandPosition") + "," + 
				SEnumChecker.GetMemberName(Lands, "Lands") + "," + 
				SEnumChecker.GetMemberName(Items, "Items") + "," + 
				SEnumChecker.GetMemberName(Started, "Started");
		}
	}
	public class SFlyAwayBattleStartNetSc : SProto
	{
		public override void Push(CStream Stream_)
		{
		}
		public override void Push(JsonDataObject Value_)
		{
		}
		public override void Pop(CStream Stream_)
		{
		}
		public override void Pop(JsonDataObject Value_)
		{
		}
		public override string StdName()
		{
			return "";
		}
		public override string MemberName()
		{
			return "";
		}
	}
	public class SFlyAwayBattleEndNetCs : SProto
	{
		public override void Push(CStream Stream_)
		{
		}
		public override void Push(JsonDataObject Value_)
		{
		}
		public override void Pop(CStream Stream_)
		{
		}
		public override void Pop(JsonDataObject Value_)
		{
		}
		public override string StdName()
		{
			return "";
		}
		public override string MemberName()
		{
			return "";
		}
	}
	public class SFlyAwayBattleEndNetSc : SProto
	{
		public Int64 Tick = default(Int64);
		public TResource[] ResourcesLeft = new TResource[6];
		public TDoneQuests DoneQuests = new TDoneQuests();
		public SFlyAwayBattleEndNetSc()
		{
			for (int iResourcesLeft = 0; iResourcesLeft < ResourcesLeft.Length; ++iResourcesLeft)
				ResourcesLeft[iResourcesLeft] = default(TResource);
		}
		public SFlyAwayBattleEndNetSc(SFlyAwayBattleEndNetSc Obj_)
		{
			Tick = Obj_.Tick;
			ResourcesLeft = Obj_.ResourcesLeft;
			DoneQuests = Obj_.DoneQuests;
		}
		public SFlyAwayBattleEndNetSc(Int64 Tick_, TResource[] ResourcesLeft_, TDoneQuests DoneQuests_)
		{
			Tick = Tick_;
			ResourcesLeft = ResourcesLeft_;
			DoneQuests = DoneQuests_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Tick);
			Stream_.Pop(ref ResourcesLeft);
			Stream_.Pop(ref DoneQuests);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Tick", ref Tick);
			Value_.Pop("ResourcesLeft", ref ResourcesLeft);
			Value_.Pop("DoneQuests", ref DoneQuests);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Tick);
			Stream_.Push(ResourcesLeft);
			Stream_.Push(DoneQuests);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Tick", Tick);
			Value_.Push("ResourcesLeft", ResourcesLeft);
			Value_.Push("DoneQuests", DoneQuests);
		}
		public void Set(SFlyAwayBattleEndNetSc Obj_)
		{
			Tick = Obj_.Tick;
			ResourcesLeft = Obj_.ResourcesLeft;
			DoneQuests = Obj_.DoneQuests;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Tick) + "," + 
				SEnumChecker.GetStdName(ResourcesLeft) + "," + 
				SEnumChecker.GetStdName(DoneQuests);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Tick, "Tick") + "," + 
				SEnumChecker.GetMemberName(ResourcesLeft, "ResourcesLeft") + "," + 
				SEnumChecker.GetMemberName(DoneQuests, "DoneQuests");
		}
	}
	public class SRanking : SProto
	{
		public SRankingUsers[] RankingUsersArray = new SRankingUsers[3];
		public SRanking()
		{
			for (int iRankingUsersArray = 0; iRankingUsersArray < RankingUsersArray.Length; ++iRankingUsersArray)
				RankingUsersArray[iRankingUsersArray] = new SRankingUsers();
		}
		public SRanking(SRanking Obj_)
		{
			RankingUsersArray = Obj_.RankingUsersArray;
		}
		public SRanking(SRankingUsers[] RankingUsersArray_)
		{
			RankingUsersArray = RankingUsersArray_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref RankingUsersArray);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("RankingUsersArray", ref RankingUsersArray);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(RankingUsersArray);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("RankingUsersArray", RankingUsersArray);
		}
		public void Set(SRanking Obj_)
		{
			RankingUsersArray = Obj_.RankingUsersArray;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(RankingUsersArray);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(RankingUsersArray, "RankingUsersArray");
		}
	}
	public enum EProtoRankingNetCs
	{
		RequestRanking,
		Max,
	}
	public enum EProtoRankingNetSc
	{
		RequestRanking,
		Max,
	}
	public class SGachaNetCs : SProto
	{
		public Int32 GachaIndex = default(Int32);
		public SGachaNetCs()
		{
		}
		public SGachaNetCs(SGachaNetCs Obj_)
		{
			GachaIndex = Obj_.GachaIndex;
		}
		public SGachaNetCs(Int32 GachaIndex_)
		{
			GachaIndex = GachaIndex_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref GachaIndex);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("GachaIndex", ref GachaIndex);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(GachaIndex);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("GachaIndex", GachaIndex);
		}
		public void Set(SGachaNetCs Obj_)
		{
			GachaIndex = Obj_.GachaIndex;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(GachaIndex);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(GachaIndex, "GachaIndex");
		}
	}
	public class SGachaX10NetCs : SProto
	{
		public Int32 GachaIndex = default(Int32);
		public SGachaX10NetCs()
		{
		}
		public SGachaX10NetCs(SGachaX10NetCs Obj_)
		{
			GachaIndex = Obj_.GachaIndex;
		}
		public SGachaX10NetCs(Int32 GachaIndex_)
		{
			GachaIndex = GachaIndex_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref GachaIndex);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("GachaIndex", ref GachaIndex);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(GachaIndex);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("GachaIndex", GachaIndex);
		}
		public void Set(SGachaX10NetCs Obj_)
		{
			GachaIndex = Obj_.GachaIndex;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(GachaIndex);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(GachaIndex, "GachaIndex");
		}
	}
	public class SGachaNetSc : SProto
	{
		public TResource[] Cost = new TResource[6];
		public Int32 Index = default(Int32);
		public Int32 CharCode = default(Int32);
		public SGachaNetSc()
		{
			for (int iCost = 0; iCost < Cost.Length; ++iCost)
				Cost[iCost] = default(TResource);
		}
		public SGachaNetSc(SGachaNetSc Obj_)
		{
			Cost = Obj_.Cost;
			Index = Obj_.Index;
			CharCode = Obj_.CharCode;
		}
		public SGachaNetSc(TResource[] Cost_, Int32 Index_, Int32 CharCode_)
		{
			Cost = Cost_;
			Index = Index_;
			CharCode = CharCode_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Cost);
			Stream_.Pop(ref Index);
			Stream_.Pop(ref CharCode);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Cost", ref Cost);
			Value_.Pop("Index", ref Index);
			Value_.Pop("CharCode", ref CharCode);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Cost);
			Stream_.Push(Index);
			Stream_.Push(CharCode);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Cost", Cost);
			Value_.Push("Index", Index);
			Value_.Push("CharCode", CharCode);
		}
		public void Set(SGachaNetSc Obj_)
		{
			Cost = Obj_.Cost;
			Index = Obj_.Index;
			CharCode = Obj_.CharCode;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Cost) + "," + 
				SEnumChecker.GetStdName(Index) + "," + 
				SEnumChecker.GetStdName(CharCode);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Cost, "Cost") + "," + 
				SEnumChecker.GetMemberName(Index, "Index") + "," + 
				SEnumChecker.GetMemberName(CharCode, "CharCode");
		}
	}
	public class SGachaX10NetSc : SProto
	{
		public TResource[] Cost = new TResource[6];
		public Int32 Index = default(Int32);
		public List<Int32> CharCodeList = new List<Int32>();
		public TResource[] Refund = new TResource[6];
		public SGachaX10NetSc()
		{
			for (int iCost = 0; iCost < Cost.Length; ++iCost)
				Cost[iCost] = default(TResource);
			for (int iRefund = 0; iRefund < Refund.Length; ++iRefund)
				Refund[iRefund] = default(TResource);
		}
		public SGachaX10NetSc(SGachaX10NetSc Obj_)
		{
			Cost = Obj_.Cost;
			Index = Obj_.Index;
			CharCodeList = Obj_.CharCodeList;
			Refund = Obj_.Refund;
		}
		public SGachaX10NetSc(TResource[] Cost_, Int32 Index_, List<Int32> CharCodeList_, TResource[] Refund_)
		{
			Cost = Cost_;
			Index = Index_;
			CharCodeList = CharCodeList_;
			Refund = Refund_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Cost);
			Stream_.Pop(ref Index);
			Stream_.Pop(ref CharCodeList);
			Stream_.Pop(ref Refund);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Cost", ref Cost);
			Value_.Pop("Index", ref Index);
			Value_.Pop("CharCodeList", ref CharCodeList);
			Value_.Pop("Refund", ref Refund);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Cost);
			Stream_.Push(Index);
			Stream_.Push(CharCodeList);
			Stream_.Push(Refund);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Cost", Cost);
			Value_.Push("Index", Index);
			Value_.Push("CharCodeList", CharCodeList);
			Value_.Push("Refund", Refund);
		}
		public void Set(SGachaX10NetSc Obj_)
		{
			Cost = Obj_.Cost;
			Index = Obj_.Index;
			CharCodeList = Obj_.CharCodeList;
			Refund = Obj_.Refund;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Cost) + "," + 
				SEnumChecker.GetStdName(Index) + "," + 
				SEnumChecker.GetStdName(CharCodeList) + "," + 
				SEnumChecker.GetStdName(Refund);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Cost, "Cost") + "," + 
				SEnumChecker.GetMemberName(Index, "Index") + "," + 
				SEnumChecker.GetMemberName(CharCodeList, "CharCodeList") + "," + 
				SEnumChecker.GetMemberName(Refund, "Refund");
		}
	}
	public class SGachaFailedNetSc : SGachaNetSc
	{
		public TResource[] Refund = new TResource[6];
		public SGachaFailedNetSc()
		{
			for (int iRefund = 0; iRefund < Refund.Length; ++iRefund)
				Refund[iRefund] = default(TResource);
		}
		public SGachaFailedNetSc(SGachaFailedNetSc Obj_) : base(Obj_)
		{
			Refund = Obj_.Refund;
		}
		public SGachaFailedNetSc(SGachaNetSc Super_, TResource[] Refund_) : base(Super_)
		{
			Refund = Refund_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref Refund);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("Refund", ref Refund);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(Refund);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("Refund", Refund);
		}
		public void Set(SGachaFailedNetSc Obj_)
		{
			base.Set(Obj_);
			Refund = Obj_.Refund;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(Refund);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(Refund, "Refund");
		}
	}
	public class SRankRewardNetCs : SProto
	{
		public override void Push(CStream Stream_)
		{
		}
		public override void Push(JsonDataObject Value_)
		{
		}
		public override void Pop(CStream Stream_)
		{
		}
		public override void Pop(JsonDataObject Value_)
		{
		}
		public override string StdName()
		{
			return "";
		}
		public override string MemberName()
		{
			return "";
		}
	}
	public class SRankRewardNetSc : SRewardDB
	{
		public Int32 LastGotRewardRankIndex = default(Int32);
		public SRankRewardNetSc()
		{
		}
		public SRankRewardNetSc(SRankRewardNetSc Obj_) : base(Obj_)
		{
			LastGotRewardRankIndex = Obj_.LastGotRewardRankIndex;
		}
		public SRankRewardNetSc(SRewardDB Super_, Int32 LastGotRewardRankIndex_) : base(Super_)
		{
			LastGotRewardRankIndex = LastGotRewardRankIndex_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref LastGotRewardRankIndex);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("LastGotRewardRankIndex", ref LastGotRewardRankIndex);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(LastGotRewardRankIndex);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("LastGotRewardRankIndex", LastGotRewardRankIndex);
		}
		public void Set(SRankRewardNetSc Obj_)
		{
			base.Set(Obj_);
			LastGotRewardRankIndex = Obj_.LastGotRewardRankIndex;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(LastGotRewardRankIndex);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(LastGotRewardRankIndex, "LastGotRewardRankIndex");
		}
	}
	public class SQuestSlotIndexCode : SProto
	{
		public TQuestSlotIndex SlotIndex = default(TQuestSlotIndex);
		public Int32 Code = default(Int32);
		public SQuestSlotIndexCode()
		{
		}
		public SQuestSlotIndexCode(SQuestSlotIndexCode Obj_)
		{
			SlotIndex = Obj_.SlotIndex;
			Code = Obj_.Code;
		}
		public SQuestSlotIndexCode(TQuestSlotIndex SlotIndex_, Int32 Code_)
		{
			SlotIndex = SlotIndex_;
			Code = Code_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref SlotIndex);
			Stream_.Pop(ref Code);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("SlotIndex", ref SlotIndex);
			Value_.Pop("Code", ref Code);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(SlotIndex);
			Stream_.Push(Code);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("SlotIndex", SlotIndex);
			Value_.Push("Code", Code);
		}
		public void Set(SQuestSlotIndexCode Obj_)
		{
			SlotIndex = Obj_.SlotIndex;
			Code = Obj_.Code;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(SlotIndex) + "," + 
				SEnumChecker.GetStdName(Code);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(SlotIndex, "SlotIndex") + "," + 
				SEnumChecker.GetMemberName(Code, "Code");
		}
	}
	public class SQuestGotNetSc : SProto
	{
		public TQuestSlotIndexCodes Quests = new TQuestSlotIndexCodes();
		public SQuestGotNetSc()
		{
		}
		public SQuestGotNetSc(SQuestGotNetSc Obj_)
		{
			Quests = Obj_.Quests;
		}
		public SQuestGotNetSc(TQuestSlotIndexCodes Quests_)
		{
			Quests = Quests_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Quests);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Quests", ref Quests);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Quests);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Quests", Quests);
		}
		public void Set(SQuestGotNetSc Obj_)
		{
			Quests = Obj_.Quests;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Quests);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Quests, "Quests");
		}
	}
	public class SQuestDoneNetSc : SProto
	{
		public TQuestSlotIndex SlotIndex = default(TQuestSlotIndex);
		public Int32 Count = default(Int32);
		public SQuestDoneNetSc()
		{
		}
		public SQuestDoneNetSc(SQuestDoneNetSc Obj_)
		{
			SlotIndex = Obj_.SlotIndex;
			Count = Obj_.Count;
		}
		public SQuestDoneNetSc(TQuestSlotIndex SlotIndex_, Int32 Count_)
		{
			SlotIndex = SlotIndex_;
			Count = Count_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref SlotIndex);
			Stream_.Pop(ref Count);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("SlotIndex", ref SlotIndex);
			Value_.Pop("Count", ref Count);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(SlotIndex);
			Stream_.Push(Count);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("SlotIndex", SlotIndex);
			Value_.Push("Count", Count);
		}
		public void Set(SQuestDoneNetSc Obj_)
		{
			SlotIndex = Obj_.SlotIndex;
			Count = Obj_.Count;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(SlotIndex) + "," + 
				SEnumChecker.GetStdName(Count);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(SlotIndex, "SlotIndex") + "," + 
				SEnumChecker.GetMemberName(Count, "Count");
		}
	}
	public class SQuestRewardNetCs : SProto
	{
		public TQuestSlotIndex SlotIndex = default(TQuestSlotIndex);
		public SQuestRewardNetCs()
		{
		}
		public SQuestRewardNetCs(SQuestRewardNetCs Obj_)
		{
			SlotIndex = Obj_.SlotIndex;
		}
		public SQuestRewardNetCs(TQuestSlotIndex SlotIndex_)
		{
			SlotIndex = SlotIndex_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref SlotIndex);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("SlotIndex", ref SlotIndex);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(SlotIndex);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("SlotIndex", SlotIndex);
		}
		public void Set(SQuestRewardNetCs Obj_)
		{
			SlotIndex = Obj_.SlotIndex;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(SlotIndex);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(SlotIndex, "SlotIndex");
		}
	}
	public class SQuestRewardNetSc : SRewardDB
	{
		public TQuestSlotIndex SlotIndex = default(TQuestSlotIndex);
		public TimePoint CoolEndTime = default(TimePoint);
		public Int32 DailyCompleteCount = default(Int32);
		public TimePoint DailyCompleteRefreshTime = default(TimePoint);
		public SQuestRewardNetSc()
		{
		}
		public SQuestRewardNetSc(SQuestRewardNetSc Obj_) : base(Obj_)
		{
			SlotIndex = Obj_.SlotIndex;
			CoolEndTime = Obj_.CoolEndTime;
			DailyCompleteCount = Obj_.DailyCompleteCount;
			DailyCompleteRefreshTime = Obj_.DailyCompleteRefreshTime;
		}
		public SQuestRewardNetSc(SRewardDB Super_, TQuestSlotIndex SlotIndex_, TimePoint CoolEndTime_, Int32 DailyCompleteCount_, TimePoint DailyCompleteRefreshTime_) : base(Super_)
		{
			SlotIndex = SlotIndex_;
			CoolEndTime = CoolEndTime_;
			DailyCompleteCount = DailyCompleteCount_;
			DailyCompleteRefreshTime = DailyCompleteRefreshTime_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref SlotIndex);
			Stream_.Pop(ref CoolEndTime);
			Stream_.Pop(ref DailyCompleteCount);
			Stream_.Pop(ref DailyCompleteRefreshTime);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("SlotIndex", ref SlotIndex);
			Value_.Pop("CoolEndTime", ref CoolEndTime);
			Value_.Pop("DailyCompleteCount", ref DailyCompleteCount);
			Value_.Pop("DailyCompleteRefreshTime", ref DailyCompleteRefreshTime);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(SlotIndex);
			Stream_.Push(CoolEndTime);
			Stream_.Push(DailyCompleteCount);
			Stream_.Push(DailyCompleteRefreshTime);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("SlotIndex", SlotIndex);
			Value_.Push("CoolEndTime", CoolEndTime);
			Value_.Push("DailyCompleteCount", DailyCompleteCount);
			Value_.Push("DailyCompleteRefreshTime", DailyCompleteRefreshTime);
		}
		public void Set(SQuestRewardNetSc Obj_)
		{
			base.Set(Obj_);
			SlotIndex = Obj_.SlotIndex;
			CoolEndTime = Obj_.CoolEndTime;
			DailyCompleteCount = Obj_.DailyCompleteCount;
			DailyCompleteRefreshTime = Obj_.DailyCompleteRefreshTime;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(SlotIndex) + "," + 
				SEnumChecker.GetStdName(CoolEndTime) + "," + 
				SEnumChecker.GetStdName(DailyCompleteCount) + "," + 
				SEnumChecker.GetStdName(DailyCompleteRefreshTime);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(SlotIndex, "SlotIndex") + "," + 
				SEnumChecker.GetMemberName(CoolEndTime, "CoolEndTime") + "," + 
				SEnumChecker.GetMemberName(DailyCompleteCount, "DailyCompleteCount") + "," + 
				SEnumChecker.GetMemberName(DailyCompleteRefreshTime, "DailyCompleteRefreshTime");
		}
	}
	public class SQuestNextNetCs : SProto
	{
		public TQuestSlotIndex SlotIndex = default(TQuestSlotIndex);
		public SQuestNextNetCs()
		{
		}
		public SQuestNextNetCs(SQuestNextNetCs Obj_)
		{
			SlotIndex = Obj_.SlotIndex;
		}
		public SQuestNextNetCs(TQuestSlotIndex SlotIndex_)
		{
			SlotIndex = SlotIndex_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref SlotIndex);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("SlotIndex", ref SlotIndex);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(SlotIndex);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("SlotIndex", SlotIndex);
		}
		public void Set(SQuestNextNetCs Obj_)
		{
			SlotIndex = Obj_.SlotIndex;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(SlotIndex);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(SlotIndex, "SlotIndex");
		}
	}
	public class SQuestNextNetSc : SProto
	{
		public TQuestSlotIndex SlotIndex = default(TQuestSlotIndex);
		public Int32 NewCode = default(Int32);
		public SQuestNextNetSc()
		{
		}
		public SQuestNextNetSc(SQuestNextNetSc Obj_)
		{
			SlotIndex = Obj_.SlotIndex;
			NewCode = Obj_.NewCode;
		}
		public SQuestNextNetSc(TQuestSlotIndex SlotIndex_, Int32 NewCode_)
		{
			SlotIndex = SlotIndex_;
			NewCode = NewCode_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref SlotIndex);
			Stream_.Pop(ref NewCode);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("SlotIndex", ref SlotIndex);
			Value_.Pop("NewCode", ref NewCode);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(SlotIndex);
			Stream_.Push(NewCode);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("SlotIndex", SlotIndex);
			Value_.Push("NewCode", NewCode);
		}
		public void Set(SQuestNextNetSc Obj_)
		{
			SlotIndex = Obj_.SlotIndex;
			NewCode = Obj_.NewCode;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(SlotIndex) + "," + 
				SEnumChecker.GetStdName(NewCode);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(SlotIndex, "SlotIndex") + "," + 
				SEnumChecker.GetMemberName(NewCode, "NewCode");
		}
	}
	public class SQuestDailyCompleteRewardNetCs : SProto
	{
		public override void Push(CStream Stream_)
		{
		}
		public override void Push(JsonDataObject Value_)
		{
		}
		public override void Pop(CStream Stream_)
		{
		}
		public override void Pop(JsonDataObject Value_)
		{
		}
		public override string StdName()
		{
			return "";
		}
		public override string MemberName()
		{
			return "";
		}
	}
	public class SQuestDailyCompleteRewardNetSc : SRewardDB
	{
		public TimePoint RefreshTime = default(TimePoint);
		public SQuestDailyCompleteRewardNetSc()
		{
		}
		public SQuestDailyCompleteRewardNetSc(SQuestDailyCompleteRewardNetSc Obj_) : base(Obj_)
		{
			RefreshTime = Obj_.RefreshTime;
		}
		public SQuestDailyCompleteRewardNetSc(SRewardDB Super_, TimePoint RefreshTime_) : base(Super_)
		{
			RefreshTime = RefreshTime_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref RefreshTime);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("RefreshTime", ref RefreshTime);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(RefreshTime);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("RefreshTime", RefreshTime);
		}
		public void Set(SQuestDailyCompleteRewardNetSc Obj_)
		{
			base.Set(Obj_);
			RefreshTime = Obj_.RefreshTime;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(RefreshTime);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(RefreshTime, "RefreshTime");
		}
	}
	public class SChangeNickNetCs : SProto
	{
		public String Nick = string.Empty;
		public SChangeNickNetCs()
		{
		}
		public SChangeNickNetCs(SChangeNickNetCs Obj_)
		{
			Nick = Obj_.Nick;
		}
		public SChangeNickNetCs(String Nick_)
		{
			Nick = Nick_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Nick);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Nick", ref Nick);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Nick);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Nick", Nick);
		}
		public void Set(SChangeNickNetCs Obj_)
		{
			Nick = Obj_.Nick;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Nick);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Nick, "Nick");
		}
	}
	public class SChangeNickNetSc : SProto
	{
		public String Nick = string.Empty;
		public SChangeNickNetSc()
		{
		}
		public SChangeNickNetSc(SChangeNickNetSc Obj_)
		{
			Nick = Obj_.Nick;
		}
		public SChangeNickNetSc(String Nick_)
		{
			Nick = Nick_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Nick);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Nick", ref Nick);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Nick);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Nick", Nick);
		}
		public void Set(SChangeNickNetSc Obj_)
		{
			Nick = Obj_.Nick;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Nick);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Nick, "Nick");
		}
	}
	public class SChangeNickFailNetSc : SProto
	{
		public EGameRet GameRet = default(EGameRet);
		public String ForbiddenWord = string.Empty;
		public SChangeNickFailNetSc()
		{
		}
		public SChangeNickFailNetSc(SChangeNickFailNetSc Obj_)
		{
			GameRet = Obj_.GameRet;
			ForbiddenWord = Obj_.ForbiddenWord;
		}
		public SChangeNickFailNetSc(EGameRet GameRet_, String ForbiddenWord_)
		{
			GameRet = GameRet_;
			ForbiddenWord = ForbiddenWord_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref GameRet);
			Stream_.Pop(ref ForbiddenWord);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("GameRet", ref GameRet);
			Value_.Pop("ForbiddenWord", ref ForbiddenWord);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(GameRet);
			Stream_.Push(ForbiddenWord);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("GameRet", GameRet);
			Value_.Push("ForbiddenWord", ForbiddenWord);
		}
		public void Set(SChangeNickFailNetSc Obj_)
		{
			GameRet = Obj_.GameRet;
			ForbiddenWord = Obj_.ForbiddenWord;
		}
		public override string StdName()
		{
			return 
				"rso.game.EGameRet" + "," + 
				SEnumChecker.GetStdName(ForbiddenWord);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(GameRet, "GameRet") + "," + 
				SEnumChecker.GetMemberName(ForbiddenWord, "ForbiddenWord");
		}
	}
	public class SNickPoint : SProto
	{
		public Int32 Point = default(Int32);
		public SNickPoint()
		{
		}
		public SNickPoint(SNickPoint Obj_)
		{
			Point = Obj_.Point;
		}
		public SNickPoint(Int32 Point_)
		{
			Point = Point_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Point);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Point", ref Point);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Point);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Point", Point);
		}
		public void Set(SNickPoint Obj_)
		{
			Point = Obj_.Point;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Point);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Point, "Point");
		}
	}
	public class SCheckIDNetSc : SProto
	{
		public List<SNickPoint> Datas = new List<SNickPoint>();
		public SCheckIDNetSc()
		{
		}
		public SCheckIDNetSc(SCheckIDNetSc Obj_)
		{
			Datas = Obj_.Datas;
		}
		public SCheckIDNetSc(List<SNickPoint> Datas_)
		{
			Datas = Datas_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Datas);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Datas", ref Datas);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Datas);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Datas", Datas);
		}
		public void Set(SCheckIDNetSc Obj_)
		{
			Datas = Obj_.Datas;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Datas);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Datas, "Datas");
		}
	}
	public class SCouponUseNetCs : SProto
	{
		public String Key = string.Empty;
		public SCouponUseNetCs()
		{
		}
		public SCouponUseNetCs(SCouponUseNetCs Obj_)
		{
			Key = Obj_.Key;
		}
		public SCouponUseNetCs(String Key_)
		{
			Key = Key_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Key);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Key", ref Key);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Key);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Key", Key);
		}
		public void Set(SCouponUseNetCs Obj_)
		{
			Key = Obj_.Key;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Key);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Key, "Key");
		}
	}
	public class SCouponUseNetSc : SRewardDB
	{
		public TResource[] ResourcesAdded = new TResource[6];
		public SCouponUseNetSc()
		{
			for (int iResourcesAdded = 0; iResourcesAdded < ResourcesAdded.Length; ++iResourcesAdded)
				ResourcesAdded[iResourcesAdded] = default(TResource);
		}
		public SCouponUseNetSc(SCouponUseNetSc Obj_) : base(Obj_)
		{
			ResourcesAdded = Obj_.ResourcesAdded;
		}
		public SCouponUseNetSc(SRewardDB Super_, TResource[] ResourcesAdded_) : base(Super_)
		{
			ResourcesAdded = ResourcesAdded_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref ResourcesAdded);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("ResourcesAdded", ref ResourcesAdded);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(ResourcesAdded);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("ResourcesAdded", ResourcesAdded);
		}
		public void Set(SCouponUseNetSc Obj_)
		{
			base.Set(Obj_);
			ResourcesAdded = Obj_.ResourcesAdded;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(ResourcesAdded);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(ResourcesAdded, "ResourcesAdded");
		}
	}
	public class SCouponUseFailNetSc : SProto
	{
		public ERet Ret = default(ERet);
		public SCouponUseFailNetSc()
		{
		}
		public SCouponUseFailNetSc(SCouponUseFailNetSc Obj_)
		{
			Ret = Obj_.Ret;
		}
		public SCouponUseFailNetSc(ERet Ret_)
		{
			Ret = Ret_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Ret);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Ret", ref Ret);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Ret);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Ret", Ret);
		}
		public void Set(SCouponUseFailNetSc Obj_)
		{
			Ret = Obj_.Ret;
		}
		public override string StdName()
		{
			return 
				"bb.ERet";
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Ret, "Ret");
		}
	}
	public class STutorialRewardNetCs : SProto
	{
		public override void Push(CStream Stream_)
		{
		}
		public override void Push(JsonDataObject Value_)
		{
		}
		public override void Pop(CStream Stream_)
		{
		}
		public override void Pop(JsonDataObject Value_)
		{
		}
		public override string StdName()
		{
			return "";
		}
		public override string MemberName()
		{
			return "";
		}
	}
	public class SRankingRewardInfoNetCs : SProto
	{
		public override void Push(CStream Stream_)
		{
		}
		public override void Push(JsonDataObject Value_)
		{
		}
		public override void Pop(CStream Stream_)
		{
		}
		public override void Pop(JsonDataObject Value_)
		{
		}
		public override string StdName()
		{
			return "";
		}
		public override string MemberName()
		{
			return "";
		}
	}
	public class SRankingRewardInfoNetSc : SProto
	{
		public Int64 Counter = default(Int64);
		public Int32[] RankingArray = new Int32[3];
		public SRankingRewardInfoNetSc()
		{
			for (int iRankingArray = 0; iRankingArray < RankingArray.Length; ++iRankingArray)
				RankingArray[iRankingArray] = default(Int32);
		}
		public SRankingRewardInfoNetSc(SRankingRewardInfoNetSc Obj_)
		{
			Counter = Obj_.Counter;
			RankingArray = Obj_.RankingArray;
		}
		public SRankingRewardInfoNetSc(Int64 Counter_, Int32[] RankingArray_)
		{
			Counter = Counter_;
			RankingArray = RankingArray_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Counter);
			Stream_.Pop(ref RankingArray);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Counter", ref Counter);
			Value_.Pop("RankingArray", ref RankingArray);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Counter);
			Stream_.Push(RankingArray);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Counter", Counter);
			Value_.Push("RankingArray", RankingArray);
		}
		public void Set(SRankingRewardInfoNetSc Obj_)
		{
			Counter = Obj_.Counter;
			RankingArray = Obj_.RankingArray;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Counter) + "," + 
				SEnumChecker.GetStdName(RankingArray);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Counter, "Counter") + "," + 
				SEnumChecker.GetMemberName(RankingArray, "RankingArray");
		}
	}
	public class SRankingRewardNetCs : SProto
	{
		public override void Push(CStream Stream_)
		{
		}
		public override void Push(JsonDataObject Value_)
		{
		}
		public override void Pop(CStream Stream_)
		{
		}
		public override void Pop(JsonDataObject Value_)
		{
		}
		public override string StdName()
		{
			return "";
		}
		public override string MemberName()
		{
			return "";
		}
	}
	public class SRankingRewardNetSc : SRewardDB
	{
		public Int64 Counter = default(Int64);
		public Int32[] RankingRewardArray = new Int32[3];
		public SRankingRewardNetSc()
		{
			for (int iRankingRewardArray = 0; iRankingRewardArray < RankingRewardArray.Length; ++iRankingRewardArray)
				RankingRewardArray[iRankingRewardArray] = default(Int32);
		}
		public SRankingRewardNetSc(SRankingRewardNetSc Obj_) : base(Obj_)
		{
			Counter = Obj_.Counter;
			RankingRewardArray = Obj_.RankingRewardArray;
		}
		public SRankingRewardNetSc(SRewardDB Super_, Int64 Counter_, Int32[] RankingRewardArray_) : base(Super_)
		{
			Counter = Counter_;
			RankingRewardArray = RankingRewardArray_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref Counter);
			Stream_.Pop(ref RankingRewardArray);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("Counter", ref Counter);
			Value_.Pop("RankingRewardArray", ref RankingRewardArray);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(Counter);
			Stream_.Push(RankingRewardArray);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("Counter", Counter);
			Value_.Push("RankingRewardArray", RankingRewardArray);
		}
		public void Set(SRankingRewardNetSc Obj_)
		{
			base.Set(Obj_);
			Counter = Obj_.Counter;
			RankingRewardArray = Obj_.RankingRewardArray;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(Counter) + "," + 
				SEnumChecker.GetStdName(RankingRewardArray);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(Counter, "Counter") + "," + 
				SEnumChecker.GetMemberName(RankingRewardArray, "RankingRewardArray");
		}
	}
	public class SRankingRewardFailNetSc : SProto
	{
		public ERet Ret = default(ERet);
		public SRankingRewardFailNetSc()
		{
		}
		public SRankingRewardFailNetSc(SRankingRewardFailNetSc Obj_)
		{
			Ret = Obj_.Ret;
		}
		public SRankingRewardFailNetSc(ERet Ret_)
		{
			Ret = Ret_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Ret);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Ret", ref Ret);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Ret);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Ret", Ret);
		}
		public void Set(SRankingRewardFailNetSc Obj_)
		{
			Ret = Obj_.Ret;
		}
		public override string StdName()
		{
			return 
				"bb.ERet";
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Ret, "Ret");
		}
	}
	public partial class global
	{
		public const Single c_AirResistance = 1.0f;
		public const SByte c_BalloonCountForPump = 1;
		public const SByte c_BalloonCountForRegen = 2;
		public const Single c_BalloonHeight = 0.27f;
		public const Single c_BalloonLocalScale = 0.5f;
		public const Single c_BalloonOffsetY = 0.5f;
		public const Single c_BalloonWidth = 0.2f;
		public const Int64 c_BattleStartDelayMilliSec = 2000;
		public const Int64 c_ChainKillDelayTickCount = 50000000;
		public const Single c_ContactOffset = 0.0001f;
		public const Single c_DieUpVel = 0.7f;
		public const Int32 c_FPS = 60;
		public const Single c_GameHeight = 3.5f;
		public const Single c_GhostSpeed = 3.0f;
		public const Single c_Gravity = -0.6465f;
		public const Single c_GravityDeadRatio = 2.0f;
		public const Single c_GravityParachuteRatio = 0.5f;
		public const Single c_GroundResistance = 0.1f;
		public const Single c_LandXDragPerFrame = 1.0f/c_FPS;
		public const Int32 c_MaxPlayer = 6;
		public const Single c_MaxVelDeadY = 1.13784f;
		public const Single c_MaxVelParachuteX = 0.682704f;
		public const Single c_MaxVelParachuteY = 0.28446f;
		public const Int64 c_NetworkTickBuffer = c_NetworkTickSync+500000;
		public const Int64 c_NetworkTickSync = 500000;
		public const Single c_OnePumpDuration = 0.4f;
		public const Single c_ParachuteAccX = 0.6465f;
		public const Single c_ParachuteHeight = 0.25f;
		public const Single c_ParachuteLocalScale = 0.5f;
		public const Single c_ParachuteOffsetY = 0.37f;
		public const Single c_ParachuteWidth = 0.45f;
		public const Single c_PlayerHeight = 0.150337f;
		public const Single c_PlayerOffsetY = c_PlayerHeight*0.5f;
		public const Single c_PlayerWidth = 0.1258713f;
		public const Single c_PlayerWidth_2 = c_PlayerWidth*0.5f;
		public const SByte c_PumpCountForBalloon = 6;
		public const Int32 c_QuestCnt_Max = 5;
		public const Int64 c_RegenDelayTickCount = 20000000;
		public const Single c_ScreenHeight = 1.8f;
		public const Single c_ScreenHeight_2 = c_ScreenHeight*0.5f;
		public const Single c_ScreenWidth = 3.448f;
		public const Single c_ScreenWidth_2 = c_ScreenWidth*0.5f;
		public const TVer c_Ver_Main = 41;
	}
}

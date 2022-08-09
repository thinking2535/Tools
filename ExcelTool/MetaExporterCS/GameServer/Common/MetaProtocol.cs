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
	using rso.physics;
	public enum ECashItemType
	{
		ResourcesPack,
		Max,
		Null,
	}
	public enum EGoodsItemType
	{
		AvatarColor,
		Max,
		Null,
	}
	public enum ERank : Byte
	{
		Unranked,
		Bronze,
		Silver,
		Gold,
		Diamond,
		Champion,
		Max,
	}
	public class SServerConfigMeta : SProto
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
	public class SStructureMove : SProto
	{
		public List<SRectCollider2D> Colliders = new List<SRectCollider2D>();
		public SPoint BeginPos = new SPoint();
		public SPoint EndPos = new SPoint();
		public Single Velocity = default(Single);
		public Single Delay = default(Single);
		public SStructureMove()
		{
		}
		public SStructureMove(SStructureMove Obj_)
		{
			Colliders = Obj_.Colliders;
			BeginPos = Obj_.BeginPos;
			EndPos = Obj_.EndPos;
			Velocity = Obj_.Velocity;
			Delay = Obj_.Delay;
		}
		public SStructureMove(List<SRectCollider2D> Colliders_, SPoint BeginPos_, SPoint EndPos_, Single Velocity_, Single Delay_)
		{
			Colliders = Colliders_;
			BeginPos = BeginPos_;
			EndPos = EndPos_;
			Velocity = Velocity_;
			Delay = Delay_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Colliders);
			Stream_.Pop(ref BeginPos);
			Stream_.Pop(ref EndPos);
			Stream_.Pop(ref Velocity);
			Stream_.Pop(ref Delay);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Colliders", ref Colliders);
			Value_.Pop("BeginPos", ref BeginPos);
			Value_.Pop("EndPos", ref EndPos);
			Value_.Pop("Velocity", ref Velocity);
			Value_.Pop("Delay", ref Delay);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Colliders);
			Stream_.Push(BeginPos);
			Stream_.Push(EndPos);
			Stream_.Push(Velocity);
			Stream_.Push(Delay);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Colliders", Colliders);
			Value_.Push("BeginPos", BeginPos);
			Value_.Push("EndPos", EndPos);
			Value_.Push("Velocity", Velocity);
			Value_.Push("Delay", Delay);
		}
		public void Set(SStructureMove Obj_)
		{
			Colliders = Obj_.Colliders;
			BeginPos.Set(Obj_.BeginPos);
			EndPos.Set(Obj_.EndPos);
			Velocity = Obj_.Velocity;
			Delay = Obj_.Delay;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Colliders) + "," + 
				SEnumChecker.GetStdName(BeginPos) + "," + 
				SEnumChecker.GetStdName(EndPos) + "," + 
				SEnumChecker.GetStdName(Velocity) + "," + 
				SEnumChecker.GetStdName(Delay);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Colliders, "Colliders") + "," + 
				SEnumChecker.GetMemberName(BeginPos, "BeginPos") + "," + 
				SEnumChecker.GetMemberName(EndPos, "EndPos") + "," + 
				SEnumChecker.GetMemberName(Velocity, "Velocity") + "," + 
				SEnumChecker.GetMemberName(Delay, "Delay");
		}
	}
	public class SConfigMeta : SProto
	{
		public Int32 BattleDurationSec = default(Int32);
		public Int32 BattleOneOnOneDurationSec = default(Int32);
		public Int32 GhostDelaySec = default(Int32);
		public Int32 InvulnerableDurationSec = default(Int32);
		public Int32 BalloonHitPoint = default(Int32);
		public Int32 ParachuteHitPoint = default(Int32);
		public Int32 FirstBalloonHitPoint = default(Int32);
		public Int32 QuestCoolMinutes = default(Int32);
		public TResource QuestNextCostGold = default(TResource);
		public Int32 ChangeNickFreeCount = default(Int32);
		public EResource ChangeNickCostType = default(EResource);
		public TResource ChangeNickCostValue = default(TResource);
		public EResource TutorialRewardType = default(EResource);
		public TResource TutorialRewardValue = default(TResource);
		public TResource MaxTicket = default(TResource);
		public EResource BattleCostType = default(EResource);
		public TResource BattleCostValue = default(TResource);
		public SConfigMeta()
		{
		}
		public SConfigMeta(SConfigMeta Obj_)
		{
			BattleDurationSec = Obj_.BattleDurationSec;
			BattleOneOnOneDurationSec = Obj_.BattleOneOnOneDurationSec;
			GhostDelaySec = Obj_.GhostDelaySec;
			InvulnerableDurationSec = Obj_.InvulnerableDurationSec;
			BalloonHitPoint = Obj_.BalloonHitPoint;
			ParachuteHitPoint = Obj_.ParachuteHitPoint;
			FirstBalloonHitPoint = Obj_.FirstBalloonHitPoint;
			QuestCoolMinutes = Obj_.QuestCoolMinutes;
			QuestNextCostGold = Obj_.QuestNextCostGold;
			ChangeNickFreeCount = Obj_.ChangeNickFreeCount;
			ChangeNickCostType = Obj_.ChangeNickCostType;
			ChangeNickCostValue = Obj_.ChangeNickCostValue;
			TutorialRewardType = Obj_.TutorialRewardType;
			TutorialRewardValue = Obj_.TutorialRewardValue;
			MaxTicket = Obj_.MaxTicket;
			BattleCostType = Obj_.BattleCostType;
			BattleCostValue = Obj_.BattleCostValue;
		}
		public SConfigMeta(Int32 BattleDurationSec_, Int32 BattleOneOnOneDurationSec_, Int32 GhostDelaySec_, Int32 InvulnerableDurationSec_, Int32 BalloonHitPoint_, Int32 ParachuteHitPoint_, Int32 FirstBalloonHitPoint_, Int32 QuestCoolMinutes_, TResource QuestNextCostGold_, Int32 ChangeNickFreeCount_, EResource ChangeNickCostType_, TResource ChangeNickCostValue_, EResource TutorialRewardType_, TResource TutorialRewardValue_, TResource MaxTicket_, EResource BattleCostType_, TResource BattleCostValue_)
		{
			BattleDurationSec = BattleDurationSec_;
			BattleOneOnOneDurationSec = BattleOneOnOneDurationSec_;
			GhostDelaySec = GhostDelaySec_;
			InvulnerableDurationSec = InvulnerableDurationSec_;
			BalloonHitPoint = BalloonHitPoint_;
			ParachuteHitPoint = ParachuteHitPoint_;
			FirstBalloonHitPoint = FirstBalloonHitPoint_;
			QuestCoolMinutes = QuestCoolMinutes_;
			QuestNextCostGold = QuestNextCostGold_;
			ChangeNickFreeCount = ChangeNickFreeCount_;
			ChangeNickCostType = ChangeNickCostType_;
			ChangeNickCostValue = ChangeNickCostValue_;
			TutorialRewardType = TutorialRewardType_;
			TutorialRewardValue = TutorialRewardValue_;
			MaxTicket = MaxTicket_;
			BattleCostType = BattleCostType_;
			BattleCostValue = BattleCostValue_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref BattleDurationSec);
			Stream_.Pop(ref BattleOneOnOneDurationSec);
			Stream_.Pop(ref GhostDelaySec);
			Stream_.Pop(ref InvulnerableDurationSec);
			Stream_.Pop(ref BalloonHitPoint);
			Stream_.Pop(ref ParachuteHitPoint);
			Stream_.Pop(ref FirstBalloonHitPoint);
			Stream_.Pop(ref QuestCoolMinutes);
			Stream_.Pop(ref QuestNextCostGold);
			Stream_.Pop(ref ChangeNickFreeCount);
			Stream_.Pop(ref ChangeNickCostType);
			Stream_.Pop(ref ChangeNickCostValue);
			Stream_.Pop(ref TutorialRewardType);
			Stream_.Pop(ref TutorialRewardValue);
			Stream_.Pop(ref MaxTicket);
			Stream_.Pop(ref BattleCostType);
			Stream_.Pop(ref BattleCostValue);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("BattleDurationSec", ref BattleDurationSec);
			Value_.Pop("BattleOneOnOneDurationSec", ref BattleOneOnOneDurationSec);
			Value_.Pop("GhostDelaySec", ref GhostDelaySec);
			Value_.Pop("InvulnerableDurationSec", ref InvulnerableDurationSec);
			Value_.Pop("BalloonHitPoint", ref BalloonHitPoint);
			Value_.Pop("ParachuteHitPoint", ref ParachuteHitPoint);
			Value_.Pop("FirstBalloonHitPoint", ref FirstBalloonHitPoint);
			Value_.Pop("QuestCoolMinutes", ref QuestCoolMinutes);
			Value_.Pop("QuestNextCostGold", ref QuestNextCostGold);
			Value_.Pop("ChangeNickFreeCount", ref ChangeNickFreeCount);
			Value_.Pop("ChangeNickCostType", ref ChangeNickCostType);
			Value_.Pop("ChangeNickCostValue", ref ChangeNickCostValue);
			Value_.Pop("TutorialRewardType", ref TutorialRewardType);
			Value_.Pop("TutorialRewardValue", ref TutorialRewardValue);
			Value_.Pop("MaxTicket", ref MaxTicket);
			Value_.Pop("BattleCostType", ref BattleCostType);
			Value_.Pop("BattleCostValue", ref BattleCostValue);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(BattleDurationSec);
			Stream_.Push(BattleOneOnOneDurationSec);
			Stream_.Push(GhostDelaySec);
			Stream_.Push(InvulnerableDurationSec);
			Stream_.Push(BalloonHitPoint);
			Stream_.Push(ParachuteHitPoint);
			Stream_.Push(FirstBalloonHitPoint);
			Stream_.Push(QuestCoolMinutes);
			Stream_.Push(QuestNextCostGold);
			Stream_.Push(ChangeNickFreeCount);
			Stream_.Push(ChangeNickCostType);
			Stream_.Push(ChangeNickCostValue);
			Stream_.Push(TutorialRewardType);
			Stream_.Push(TutorialRewardValue);
			Stream_.Push(MaxTicket);
			Stream_.Push(BattleCostType);
			Stream_.Push(BattleCostValue);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("BattleDurationSec", BattleDurationSec);
			Value_.Push("BattleOneOnOneDurationSec", BattleOneOnOneDurationSec);
			Value_.Push("GhostDelaySec", GhostDelaySec);
			Value_.Push("InvulnerableDurationSec", InvulnerableDurationSec);
			Value_.Push("BalloonHitPoint", BalloonHitPoint);
			Value_.Push("ParachuteHitPoint", ParachuteHitPoint);
			Value_.Push("FirstBalloonHitPoint", FirstBalloonHitPoint);
			Value_.Push("QuestCoolMinutes", QuestCoolMinutes);
			Value_.Push("QuestNextCostGold", QuestNextCostGold);
			Value_.Push("ChangeNickFreeCount", ChangeNickFreeCount);
			Value_.Push("ChangeNickCostType", ChangeNickCostType);
			Value_.Push("ChangeNickCostValue", ChangeNickCostValue);
			Value_.Push("TutorialRewardType", TutorialRewardType);
			Value_.Push("TutorialRewardValue", TutorialRewardValue);
			Value_.Push("MaxTicket", MaxTicket);
			Value_.Push("BattleCostType", BattleCostType);
			Value_.Push("BattleCostValue", BattleCostValue);
		}
		public void Set(SConfigMeta Obj_)
		{
			BattleDurationSec = Obj_.BattleDurationSec;
			BattleOneOnOneDurationSec = Obj_.BattleOneOnOneDurationSec;
			GhostDelaySec = Obj_.GhostDelaySec;
			InvulnerableDurationSec = Obj_.InvulnerableDurationSec;
			BalloonHitPoint = Obj_.BalloonHitPoint;
			ParachuteHitPoint = Obj_.ParachuteHitPoint;
			FirstBalloonHitPoint = Obj_.FirstBalloonHitPoint;
			QuestCoolMinutes = Obj_.QuestCoolMinutes;
			QuestNextCostGold = Obj_.QuestNextCostGold;
			ChangeNickFreeCount = Obj_.ChangeNickFreeCount;
			ChangeNickCostType = Obj_.ChangeNickCostType;
			ChangeNickCostValue = Obj_.ChangeNickCostValue;
			TutorialRewardType = Obj_.TutorialRewardType;
			TutorialRewardValue = Obj_.TutorialRewardValue;
			MaxTicket = Obj_.MaxTicket;
			BattleCostType = Obj_.BattleCostType;
			BattleCostValue = Obj_.BattleCostValue;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(BattleDurationSec) + "," + 
				SEnumChecker.GetStdName(BattleOneOnOneDurationSec) + "," + 
				SEnumChecker.GetStdName(GhostDelaySec) + "," + 
				SEnumChecker.GetStdName(InvulnerableDurationSec) + "," + 
				SEnumChecker.GetStdName(BalloonHitPoint) + "," + 
				SEnumChecker.GetStdName(ParachuteHitPoint) + "," + 
				SEnumChecker.GetStdName(FirstBalloonHitPoint) + "," + 
				SEnumChecker.GetStdName(QuestCoolMinutes) + "," + 
				SEnumChecker.GetStdName(QuestNextCostGold) + "," + 
				SEnumChecker.GetStdName(ChangeNickFreeCount) + "," + 
				"bb.EResource" + "," + 
				SEnumChecker.GetStdName(ChangeNickCostValue) + "," + 
				"bb.EResource" + "," + 
				SEnumChecker.GetStdName(TutorialRewardValue) + "," + 
				SEnumChecker.GetStdName(MaxTicket) + "," + 
				"bb.EResource" + "," + 
				SEnumChecker.GetStdName(BattleCostValue);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(BattleDurationSec, "BattleDurationSec") + "," + 
				SEnumChecker.GetMemberName(BattleOneOnOneDurationSec, "BattleOneOnOneDurationSec") + "," + 
				SEnumChecker.GetMemberName(GhostDelaySec, "GhostDelaySec") + "," + 
				SEnumChecker.GetMemberName(InvulnerableDurationSec, "InvulnerableDurationSec") + "," + 
				SEnumChecker.GetMemberName(BalloonHitPoint, "BalloonHitPoint") + "," + 
				SEnumChecker.GetMemberName(ParachuteHitPoint, "ParachuteHitPoint") + "," + 
				SEnumChecker.GetMemberName(FirstBalloonHitPoint, "FirstBalloonHitPoint") + "," + 
				SEnumChecker.GetMemberName(QuestCoolMinutes, "QuestCoolMinutes") + "," + 
				SEnumChecker.GetMemberName(QuestNextCostGold, "QuestNextCostGold") + "," + 
				SEnumChecker.GetMemberName(ChangeNickFreeCount, "ChangeNickFreeCount") + "," + 
				SEnumChecker.GetMemberName(ChangeNickCostType, "ChangeNickCostType") + "," + 
				SEnumChecker.GetMemberName(ChangeNickCostValue, "ChangeNickCostValue") + "," + 
				SEnumChecker.GetMemberName(TutorialRewardType, "TutorialRewardType") + "," + 
				SEnumChecker.GetMemberName(TutorialRewardValue, "TutorialRewardValue") + "," + 
				SEnumChecker.GetMemberName(MaxTicket, "MaxTicket") + "," + 
				SEnumChecker.GetMemberName(BattleCostType, "BattleCostType") + "," + 
				SEnumChecker.GetMemberName(BattleCostValue, "BattleCostValue");
		}
	}
	public class SForbiddenWordMeta : SProto
	{
		public String Word = string.Empty;
		public SForbiddenWordMeta()
		{
		}
		public SForbiddenWordMeta(SForbiddenWordMeta Obj_)
		{
			Word = Obj_.Word;
		}
		public SForbiddenWordMeta(String Word_)
		{
			Word = Word_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Word);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Word", ref Word);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Word);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Word", Word);
		}
		public void Set(SForbiddenWordMeta Obj_)
		{
			Word = Obj_.Word;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Word);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Word, "Word");
		}
	}
	public class SShopConfigServerMeta : SProto
	{
		public Int32 DailyRewardDurationMinute = default(Int32);
		public Int32 DailyRewardFreeCount = default(Int32);
		public Int32 DailyRewardAdCount = default(Int32);
		public SShopConfigServerMeta()
		{
		}
		public SShopConfigServerMeta(SShopConfigServerMeta Obj_)
		{
			DailyRewardDurationMinute = Obj_.DailyRewardDurationMinute;
			DailyRewardFreeCount = Obj_.DailyRewardFreeCount;
			DailyRewardAdCount = Obj_.DailyRewardAdCount;
		}
		public SShopConfigServerMeta(Int32 DailyRewardDurationMinute_, Int32 DailyRewardFreeCount_, Int32 DailyRewardAdCount_)
		{
			DailyRewardDurationMinute = DailyRewardDurationMinute_;
			DailyRewardFreeCount = DailyRewardFreeCount_;
			DailyRewardAdCount = DailyRewardAdCount_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref DailyRewardDurationMinute);
			Stream_.Pop(ref DailyRewardFreeCount);
			Stream_.Pop(ref DailyRewardAdCount);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("DailyRewardDurationMinute", ref DailyRewardDurationMinute);
			Value_.Pop("DailyRewardFreeCount", ref DailyRewardFreeCount);
			Value_.Pop("DailyRewardAdCount", ref DailyRewardAdCount);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(DailyRewardDurationMinute);
			Stream_.Push(DailyRewardFreeCount);
			Stream_.Push(DailyRewardAdCount);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("DailyRewardDurationMinute", DailyRewardDurationMinute);
			Value_.Push("DailyRewardFreeCount", DailyRewardFreeCount);
			Value_.Push("DailyRewardAdCount", DailyRewardAdCount);
		}
		public void Set(SShopConfigServerMeta Obj_)
		{
			DailyRewardDurationMinute = Obj_.DailyRewardDurationMinute;
			DailyRewardFreeCount = Obj_.DailyRewardFreeCount;
			DailyRewardAdCount = Obj_.DailyRewardAdCount;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(DailyRewardDurationMinute) + "," + 
				SEnumChecker.GetStdName(DailyRewardFreeCount) + "," + 
				SEnumChecker.GetStdName(DailyRewardAdCount);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(DailyRewardDurationMinute, "DailyRewardDurationMinute") + "," + 
				SEnumChecker.GetMemberName(DailyRewardFreeCount, "DailyRewardFreeCount") + "," + 
				SEnumChecker.GetMemberName(DailyRewardAdCount, "DailyRewardAdCount");
		}
	}
	public class SShopMeta : SProto
	{
		public Int32 Code = default(Int32);
		public EResource CostType = default(EResource);
		public TResource CostValue = default(TResource);
		public Int32 RewardCode = default(Int32);
		public SShopMeta()
		{
		}
		public SShopMeta(SShopMeta Obj_)
		{
			Code = Obj_.Code;
			CostType = Obj_.CostType;
			CostValue = Obj_.CostValue;
			RewardCode = Obj_.RewardCode;
		}
		public SShopMeta(Int32 Code_, EResource CostType_, TResource CostValue_, Int32 RewardCode_)
		{
			Code = Code_;
			CostType = CostType_;
			CostValue = CostValue_;
			RewardCode = RewardCode_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Code);
			Stream_.Pop(ref CostType);
			Stream_.Pop(ref CostValue);
			Stream_.Pop(ref RewardCode);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Code", ref Code);
			Value_.Pop("CostType", ref CostType);
			Value_.Pop("CostValue", ref CostValue);
			Value_.Pop("RewardCode", ref RewardCode);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Code);
			Stream_.Push(CostType);
			Stream_.Push(CostValue);
			Stream_.Push(RewardCode);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Code", Code);
			Value_.Push("CostType", CostType);
			Value_.Push("CostValue", CostValue);
			Value_.Push("RewardCode", RewardCode);
		}
		public void Set(SShopMeta Obj_)
		{
			Code = Obj_.Code;
			CostType = Obj_.CostType;
			CostValue = Obj_.CostValue;
			RewardCode = Obj_.RewardCode;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Code) + "," + 
				"bb.EResource" + "," + 
				SEnumChecker.GetStdName(CostValue) + "," + 
				SEnumChecker.GetStdName(RewardCode);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Code, "Code") + "," + 
				SEnumChecker.GetMemberName(CostType, "CostType") + "," + 
				SEnumChecker.GetMemberName(CostValue, "CostValue") + "," + 
				SEnumChecker.GetMemberName(RewardCode, "RewardCode");
		}
	}
	public class SShopPackageServerMeta : SProto
	{
		public Int32 Code = default(Int32);
		public EResource CostType = default(EResource);
		public TResource CostValue = default(TResource);
		public Int32 RewardCode = default(Int32);
		public SShopPackageServerMeta()
		{
		}
		public SShopPackageServerMeta(SShopPackageServerMeta Obj_)
		{
			Code = Obj_.Code;
			CostType = Obj_.CostType;
			CostValue = Obj_.CostValue;
			RewardCode = Obj_.RewardCode;
		}
		public SShopPackageServerMeta(Int32 Code_, EResource CostType_, TResource CostValue_, Int32 RewardCode_)
		{
			Code = Code_;
			CostType = CostType_;
			CostValue = CostValue_;
			RewardCode = RewardCode_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Code);
			Stream_.Pop(ref CostType);
			Stream_.Pop(ref CostValue);
			Stream_.Pop(ref RewardCode);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Code", ref Code);
			Value_.Pop("CostType", ref CostType);
			Value_.Pop("CostValue", ref CostValue);
			Value_.Pop("RewardCode", ref RewardCode);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Code);
			Stream_.Push(CostType);
			Stream_.Push(CostValue);
			Stream_.Push(RewardCode);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Code", Code);
			Value_.Push("CostType", CostType);
			Value_.Push("CostValue", CostValue);
			Value_.Push("RewardCode", RewardCode);
		}
		public void Set(SShopPackageServerMeta Obj_)
		{
			Code = Obj_.Code;
			CostType = Obj_.CostType;
			CostValue = Obj_.CostValue;
			RewardCode = Obj_.RewardCode;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Code) + "," + 
				"bb.EResource" + "," + 
				SEnumChecker.GetStdName(CostValue) + "," + 
				SEnumChecker.GetStdName(RewardCode);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Code, "Code") + "," + 
				SEnumChecker.GetMemberName(CostType, "CostType") + "," + 
				SEnumChecker.GetMemberName(CostValue, "CostValue") + "," + 
				SEnumChecker.GetMemberName(RewardCode, "RewardCode");
		}
	}
	public class SShopDailyRewardServerMeta : SProto
	{
		public Double Probability = default(Double);
		public EResource RewardType = default(EResource);
		public TResource RewardValue = default(TResource);
		public SShopDailyRewardServerMeta()
		{
		}
		public SShopDailyRewardServerMeta(SShopDailyRewardServerMeta Obj_)
		{
			Probability = Obj_.Probability;
			RewardType = Obj_.RewardType;
			RewardValue = Obj_.RewardValue;
		}
		public SShopDailyRewardServerMeta(Double Probability_, EResource RewardType_, TResource RewardValue_)
		{
			Probability = Probability_;
			RewardType = RewardType_;
			RewardValue = RewardValue_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Probability);
			Stream_.Pop(ref RewardType);
			Stream_.Pop(ref RewardValue);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Probability", ref Probability);
			Value_.Pop("RewardType", ref RewardType);
			Value_.Pop("RewardValue", ref RewardValue);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Probability);
			Stream_.Push(RewardType);
			Stream_.Push(RewardValue);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Probability", Probability);
			Value_.Push("RewardType", RewardType);
			Value_.Push("RewardValue", RewardValue);
		}
		public void Set(SShopDailyRewardServerMeta Obj_)
		{
			Probability = Obj_.Probability;
			RewardType = Obj_.RewardType;
			RewardValue = Obj_.RewardValue;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Probability) + "," + 
				"bb.EResource" + "," + 
				SEnumChecker.GetStdName(RewardValue);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Probability, "Probability") + "," + 
				SEnumChecker.GetMemberName(RewardType, "RewardType") + "," + 
				SEnumChecker.GetMemberName(RewardValue, "RewardValue");
		}
	}
	public class SCharacterMeta : SProto
	{
		public Int32 Code = default(Int32);
		public EGrade Grade = default(EGrade);
		public EResource CostType = default(EResource);
		public TResource CostValue = default(TResource);
		public EResource RefundType = default(EResource);
		public TResource RefundValue = default(TResource);
		public Single MaxVelUp = default(Single);
		public Single MaxVelDown = default(Single);
		public Single MaxVelXGround = default(Single);
		public Single MaxVelXAir = default(Single);
		public Single FlapDeltaVelX = default(Single);
		public Single FlapDeltaVelUp = default(Single);
		public Single RunAcc = default(Single);
		public Single StaminaMax = default(Single);
		public Single StaminaPerTick = default(Single);
		public Int32 StaminaRegenDelay = default(Int32);
		public Single PumpSpeed = default(Single);
		public SCharacterMeta()
		{
		}
		public SCharacterMeta(SCharacterMeta Obj_)
		{
			Code = Obj_.Code;
			Grade = Obj_.Grade;
			CostType = Obj_.CostType;
			CostValue = Obj_.CostValue;
			RefundType = Obj_.RefundType;
			RefundValue = Obj_.RefundValue;
			MaxVelUp = Obj_.MaxVelUp;
			MaxVelDown = Obj_.MaxVelDown;
			MaxVelXGround = Obj_.MaxVelXGround;
			MaxVelXAir = Obj_.MaxVelXAir;
			FlapDeltaVelX = Obj_.FlapDeltaVelX;
			FlapDeltaVelUp = Obj_.FlapDeltaVelUp;
			RunAcc = Obj_.RunAcc;
			StaminaMax = Obj_.StaminaMax;
			StaminaPerTick = Obj_.StaminaPerTick;
			StaminaRegenDelay = Obj_.StaminaRegenDelay;
			PumpSpeed = Obj_.PumpSpeed;
		}
		public SCharacterMeta(Int32 Code_, EGrade Grade_, EResource CostType_, TResource CostValue_, EResource RefundType_, TResource RefundValue_, Single MaxVelUp_, Single MaxVelDown_, Single MaxVelXGround_, Single MaxVelXAir_, Single FlapDeltaVelX_, Single FlapDeltaVelUp_, Single RunAcc_, Single StaminaMax_, Single StaminaPerTick_, Int32 StaminaRegenDelay_, Single PumpSpeed_)
		{
			Code = Code_;
			Grade = Grade_;
			CostType = CostType_;
			CostValue = CostValue_;
			RefundType = RefundType_;
			RefundValue = RefundValue_;
			MaxVelUp = MaxVelUp_;
			MaxVelDown = MaxVelDown_;
			MaxVelXGround = MaxVelXGround_;
			MaxVelXAir = MaxVelXAir_;
			FlapDeltaVelX = FlapDeltaVelX_;
			FlapDeltaVelUp = FlapDeltaVelUp_;
			RunAcc = RunAcc_;
			StaminaMax = StaminaMax_;
			StaminaPerTick = StaminaPerTick_;
			StaminaRegenDelay = StaminaRegenDelay_;
			PumpSpeed = PumpSpeed_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Code);
			Stream_.Pop(ref Grade);
			Stream_.Pop(ref CostType);
			Stream_.Pop(ref CostValue);
			Stream_.Pop(ref RefundType);
			Stream_.Pop(ref RefundValue);
			Stream_.Pop(ref MaxVelUp);
			Stream_.Pop(ref MaxVelDown);
			Stream_.Pop(ref MaxVelXGround);
			Stream_.Pop(ref MaxVelXAir);
			Stream_.Pop(ref FlapDeltaVelX);
			Stream_.Pop(ref FlapDeltaVelUp);
			Stream_.Pop(ref RunAcc);
			Stream_.Pop(ref StaminaMax);
			Stream_.Pop(ref StaminaPerTick);
			Stream_.Pop(ref StaminaRegenDelay);
			Stream_.Pop(ref PumpSpeed);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Code", ref Code);
			Value_.Pop("Grade", ref Grade);
			Value_.Pop("CostType", ref CostType);
			Value_.Pop("CostValue", ref CostValue);
			Value_.Pop("RefundType", ref RefundType);
			Value_.Pop("RefundValue", ref RefundValue);
			Value_.Pop("MaxVelUp", ref MaxVelUp);
			Value_.Pop("MaxVelDown", ref MaxVelDown);
			Value_.Pop("MaxVelXGround", ref MaxVelXGround);
			Value_.Pop("MaxVelXAir", ref MaxVelXAir);
			Value_.Pop("FlapDeltaVelX", ref FlapDeltaVelX);
			Value_.Pop("FlapDeltaVelUp", ref FlapDeltaVelUp);
			Value_.Pop("RunAcc", ref RunAcc);
			Value_.Pop("StaminaMax", ref StaminaMax);
			Value_.Pop("StaminaPerTick", ref StaminaPerTick);
			Value_.Pop("StaminaRegenDelay", ref StaminaRegenDelay);
			Value_.Pop("PumpSpeed", ref PumpSpeed);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Code);
			Stream_.Push(Grade);
			Stream_.Push(CostType);
			Stream_.Push(CostValue);
			Stream_.Push(RefundType);
			Stream_.Push(RefundValue);
			Stream_.Push(MaxVelUp);
			Stream_.Push(MaxVelDown);
			Stream_.Push(MaxVelXGround);
			Stream_.Push(MaxVelXAir);
			Stream_.Push(FlapDeltaVelX);
			Stream_.Push(FlapDeltaVelUp);
			Stream_.Push(RunAcc);
			Stream_.Push(StaminaMax);
			Stream_.Push(StaminaPerTick);
			Stream_.Push(StaminaRegenDelay);
			Stream_.Push(PumpSpeed);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Code", Code);
			Value_.Push("Grade", Grade);
			Value_.Push("CostType", CostType);
			Value_.Push("CostValue", CostValue);
			Value_.Push("RefundType", RefundType);
			Value_.Push("RefundValue", RefundValue);
			Value_.Push("MaxVelUp", MaxVelUp);
			Value_.Push("MaxVelDown", MaxVelDown);
			Value_.Push("MaxVelXGround", MaxVelXGround);
			Value_.Push("MaxVelXAir", MaxVelXAir);
			Value_.Push("FlapDeltaVelX", FlapDeltaVelX);
			Value_.Push("FlapDeltaVelUp", FlapDeltaVelUp);
			Value_.Push("RunAcc", RunAcc);
			Value_.Push("StaminaMax", StaminaMax);
			Value_.Push("StaminaPerTick", StaminaPerTick);
			Value_.Push("StaminaRegenDelay", StaminaRegenDelay);
			Value_.Push("PumpSpeed", PumpSpeed);
		}
		public void Set(SCharacterMeta Obj_)
		{
			Code = Obj_.Code;
			Grade = Obj_.Grade;
			CostType = Obj_.CostType;
			CostValue = Obj_.CostValue;
			RefundType = Obj_.RefundType;
			RefundValue = Obj_.RefundValue;
			MaxVelUp = Obj_.MaxVelUp;
			MaxVelDown = Obj_.MaxVelDown;
			MaxVelXGround = Obj_.MaxVelXGround;
			MaxVelXAir = Obj_.MaxVelXAir;
			FlapDeltaVelX = Obj_.FlapDeltaVelX;
			FlapDeltaVelUp = Obj_.FlapDeltaVelUp;
			RunAcc = Obj_.RunAcc;
			StaminaMax = Obj_.StaminaMax;
			StaminaPerTick = Obj_.StaminaPerTick;
			StaminaRegenDelay = Obj_.StaminaRegenDelay;
			PumpSpeed = Obj_.PumpSpeed;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Code) + "," + 
				"bb.EGrade" + "," + 
				"bb.EResource" + "," + 
				SEnumChecker.GetStdName(CostValue) + "," + 
				"bb.EResource" + "," + 
				SEnumChecker.GetStdName(RefundValue) + "," + 
				SEnumChecker.GetStdName(MaxVelUp) + "," + 
				SEnumChecker.GetStdName(MaxVelDown) + "," + 
				SEnumChecker.GetStdName(MaxVelXGround) + "," + 
				SEnumChecker.GetStdName(MaxVelXAir) + "," + 
				SEnumChecker.GetStdName(FlapDeltaVelX) + "," + 
				SEnumChecker.GetStdName(FlapDeltaVelUp) + "," + 
				SEnumChecker.GetStdName(RunAcc) + "," + 
				SEnumChecker.GetStdName(StaminaMax) + "," + 
				SEnumChecker.GetStdName(StaminaPerTick) + "," + 
				SEnumChecker.GetStdName(StaminaRegenDelay) + "," + 
				SEnumChecker.GetStdName(PumpSpeed);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Code, "Code") + "," + 
				SEnumChecker.GetMemberName(Grade, "Grade") + "," + 
				SEnumChecker.GetMemberName(CostType, "CostType") + "," + 
				SEnumChecker.GetMemberName(CostValue, "CostValue") + "," + 
				SEnumChecker.GetMemberName(RefundType, "RefundType") + "," + 
				SEnumChecker.GetMemberName(RefundValue, "RefundValue") + "," + 
				SEnumChecker.GetMemberName(MaxVelUp, "MaxVelUp") + "," + 
				SEnumChecker.GetMemberName(MaxVelDown, "MaxVelDown") + "," + 
				SEnumChecker.GetMemberName(MaxVelXGround, "MaxVelXGround") + "," + 
				SEnumChecker.GetMemberName(MaxVelXAir, "MaxVelXAir") + "," + 
				SEnumChecker.GetMemberName(FlapDeltaVelX, "FlapDeltaVelX") + "," + 
				SEnumChecker.GetMemberName(FlapDeltaVelUp, "FlapDeltaVelUp") + "," + 
				SEnumChecker.GetMemberName(RunAcc, "RunAcc") + "," + 
				SEnumChecker.GetMemberName(StaminaMax, "StaminaMax") + "," + 
				SEnumChecker.GetMemberName(StaminaPerTick, "StaminaPerTick") + "," + 
				SEnumChecker.GetMemberName(StaminaRegenDelay, "StaminaRegenDelay") + "," + 
				SEnumChecker.GetMemberName(PumpSpeed, "PumpSpeed");
		}
	}
	public class SCharacterServerMeta : SCharacterMeta
	{
		public Boolean Default = default(Boolean);
		public SCharacterServerMeta()
		{
		}
		public SCharacterServerMeta(SCharacterServerMeta Obj_) : base(Obj_)
		{
			Default = Obj_.Default;
		}
		public SCharacterServerMeta(SCharacterMeta Super_, Boolean Default_) : base(Super_)
		{
			Default = Default_;
		}
		public override void Push(CStream Stream_)
		{
			base.Push(Stream_);
			Stream_.Pop(ref Default);
		}
		public override void Push(JsonDataObject Value_)
		{
			base.Push(Value_);
			Value_.Pop("Default", ref Default);
		}
		public override void Pop(CStream Stream_)
		{
			base.Pop(Stream_);
			Stream_.Push(Default);
		}
		public override void Pop(JsonDataObject Value_)
		{
			base.Pop(Value_);
			Value_.Push("Default", Default);
		}
		public void Set(SCharacterServerMeta Obj_)
		{
			base.Set(Obj_);
			Default = Obj_.Default;
		}
		public override string StdName()
		{
			return 
				base.StdName() + "," + 
				SEnumChecker.GetStdName(Default);
		}
		public override string MemberName()
		{
			return 
				base.MemberName() + "," + 
				SEnumChecker.GetMemberName(Default, "Default");
		}
	}
	public class SCharacterGradeMeta : SProto
	{
		public EGrade Grade = default(EGrade);
		public SCharacterGradeMeta()
		{
		}
		public SCharacterGradeMeta(SCharacterGradeMeta Obj_)
		{
			Grade = Obj_.Grade;
		}
		public SCharacterGradeMeta(EGrade Grade_)
		{
			Grade = Grade_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Grade);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Grade", ref Grade);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Grade);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Grade", Grade);
		}
		public void Set(SCharacterGradeMeta Obj_)
		{
			Grade = Obj_.Grade;
		}
		public override string StdName()
		{
			return 
				"bb.EGrade";
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Grade, "Grade");
		}
	}
	public class SMultiMap : SProto
	{
		public String PrefabName = string.Empty;
		public TPoses Poses = new TPoses();
		public SPoint PropPosition = new SPoint();
		public List<SBoxCollider2D> Structures = new List<SBoxCollider2D>();
		public List<SStructureMove> StructureMoves = new List<SStructureMove>();
		public SMultiMap()
		{
		}
		public SMultiMap(SMultiMap Obj_)
		{
			PrefabName = Obj_.PrefabName;
			Poses = Obj_.Poses;
			PropPosition = Obj_.PropPosition;
			Structures = Obj_.Structures;
			StructureMoves = Obj_.StructureMoves;
		}
		public SMultiMap(String PrefabName_, TPoses Poses_, SPoint PropPosition_, List<SBoxCollider2D> Structures_, List<SStructureMove> StructureMoves_)
		{
			PrefabName = PrefabName_;
			Poses = Poses_;
			PropPosition = PropPosition_;
			Structures = Structures_;
			StructureMoves = StructureMoves_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref PrefabName);
			Stream_.Pop(ref Poses);
			Stream_.Pop(ref PropPosition);
			Stream_.Pop(ref Structures);
			Stream_.Pop(ref StructureMoves);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("PrefabName", ref PrefabName);
			Value_.Pop("Poses", ref Poses);
			Value_.Pop("PropPosition", ref PropPosition);
			Value_.Pop("Structures", ref Structures);
			Value_.Pop("StructureMoves", ref StructureMoves);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(PrefabName);
			Stream_.Push(Poses);
			Stream_.Push(PropPosition);
			Stream_.Push(Structures);
			Stream_.Push(StructureMoves);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("PrefabName", PrefabName);
			Value_.Push("Poses", Poses);
			Value_.Push("PropPosition", PropPosition);
			Value_.Push("Structures", Structures);
			Value_.Push("StructureMoves", StructureMoves);
		}
		public void Set(SMultiMap Obj_)
		{
			PrefabName = Obj_.PrefabName;
			Poses = Obj_.Poses;
			PropPosition.Set(Obj_.PropPosition);
			Structures = Obj_.Structures;
			StructureMoves = Obj_.StructureMoves;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(PrefabName) + "," + 
				SEnumChecker.GetStdName(Poses) + "," + 
				SEnumChecker.GetStdName(PropPosition) + "," + 
				SEnumChecker.GetStdName(Structures) + "," + 
				SEnumChecker.GetStdName(StructureMoves);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(PrefabName, "PrefabName") + "," + 
				SEnumChecker.GetMemberName(Poses, "Poses") + "," + 
				SEnumChecker.GetMemberName(PropPosition, "PropPosition") + "," + 
				SEnumChecker.GetMemberName(Structures, "Structures") + "," + 
				SEnumChecker.GetMemberName(StructureMoves, "StructureMoves");
		}
	}
	public class SPrefabNameCollider : SProto
	{
		public String PrefabName = string.Empty;
		public SRectCollider2D Collider = new SRectCollider2D();
		public SPrefabNameCollider()
		{
		}
		public SPrefabNameCollider(SPrefabNameCollider Obj_)
		{
			PrefabName = Obj_.PrefabName;
			Collider = Obj_.Collider;
		}
		public SPrefabNameCollider(String PrefabName_, SRectCollider2D Collider_)
		{
			PrefabName = PrefabName_;
			Collider = Collider_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref PrefabName);
			Stream_.Pop(ref Collider);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("PrefabName", ref PrefabName);
			Value_.Pop("Collider", ref Collider);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(PrefabName);
			Stream_.Push(Collider);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("PrefabName", PrefabName);
			Value_.Push("Collider", Collider);
		}
		public void Set(SPrefabNameCollider Obj_)
		{
			PrefabName = Obj_.PrefabName;
			Collider.Set(Obj_.Collider);
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(PrefabName) + "," + 
				SEnumChecker.GetStdName(Collider);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(PrefabName, "PrefabName") + "," + 
				SEnumChecker.GetMemberName(Collider, "Collider");
		}
	}
	public class SArrowDodgeMap : SProto
	{
		public String PrefabName = string.Empty;
		public SPoint PropPosition = new SPoint();
		public List<SBoxCollider2D> Structures = new List<SBoxCollider2D>();
		public SArrowDodgeMap()
		{
		}
		public SArrowDodgeMap(SArrowDodgeMap Obj_)
		{
			PrefabName = Obj_.PrefabName;
			PropPosition = Obj_.PropPosition;
			Structures = Obj_.Structures;
		}
		public SArrowDodgeMap(String PrefabName_, SPoint PropPosition_, List<SBoxCollider2D> Structures_)
		{
			PrefabName = PrefabName_;
			PropPosition = PropPosition_;
			Structures = Structures_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref PrefabName);
			Stream_.Pop(ref PropPosition);
			Stream_.Pop(ref Structures);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("PrefabName", ref PrefabName);
			Value_.Pop("PropPosition", ref PropPosition);
			Value_.Pop("Structures", ref Structures);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(PrefabName);
			Stream_.Push(PropPosition);
			Stream_.Push(Structures);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("PrefabName", PrefabName);
			Value_.Push("PropPosition", PropPosition);
			Value_.Push("Structures", Structures);
		}
		public void Set(SArrowDodgeMap Obj_)
		{
			PrefabName = Obj_.PrefabName;
			PropPosition.Set(Obj_.PropPosition);
			Structures = Obj_.Structures;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(PrefabName) + "," + 
				SEnumChecker.GetStdName(PropPosition) + "," + 
				SEnumChecker.GetStdName(Structures);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(PrefabName, "PrefabName") + "," + 
				SEnumChecker.GetMemberName(PropPosition, "PropPosition") + "," + 
				SEnumChecker.GetMemberName(Structures, "Structures");
		}
	}
	public class SArrowDodgeMapInfo : SProto
	{
		public List<SArrowDodgeMap> Maps = new List<SArrowDodgeMap>();
		public SPrefabNameCollider Arrow = new SPrefabNameCollider();
		public SPrefabNameCollider Coin = new SPrefabNameCollider();
		public SPrefabNameCollider GoldBar = new SPrefabNameCollider();
		public SPrefabNameCollider Shield = new SPrefabNameCollider();
		public SPrefabNameCollider Stamina = new SPrefabNameCollider();
		public SArrowDodgeMapInfo()
		{
		}
		public SArrowDodgeMapInfo(SArrowDodgeMapInfo Obj_)
		{
			Maps = Obj_.Maps;
			Arrow = Obj_.Arrow;
			Coin = Obj_.Coin;
			GoldBar = Obj_.GoldBar;
			Shield = Obj_.Shield;
			Stamina = Obj_.Stamina;
		}
		public SArrowDodgeMapInfo(List<SArrowDodgeMap> Maps_, SPrefabNameCollider Arrow_, SPrefabNameCollider Coin_, SPrefabNameCollider GoldBar_, SPrefabNameCollider Shield_, SPrefabNameCollider Stamina_)
		{
			Maps = Maps_;
			Arrow = Arrow_;
			Coin = Coin_;
			GoldBar = GoldBar_;
			Shield = Shield_;
			Stamina = Stamina_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Maps);
			Stream_.Pop(ref Arrow);
			Stream_.Pop(ref Coin);
			Stream_.Pop(ref GoldBar);
			Stream_.Pop(ref Shield);
			Stream_.Pop(ref Stamina);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Maps", ref Maps);
			Value_.Pop("Arrow", ref Arrow);
			Value_.Pop("Coin", ref Coin);
			Value_.Pop("GoldBar", ref GoldBar);
			Value_.Pop("Shield", ref Shield);
			Value_.Pop("Stamina", ref Stamina);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Maps);
			Stream_.Push(Arrow);
			Stream_.Push(Coin);
			Stream_.Push(GoldBar);
			Stream_.Push(Shield);
			Stream_.Push(Stamina);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Maps", Maps);
			Value_.Push("Arrow", Arrow);
			Value_.Push("Coin", Coin);
			Value_.Push("GoldBar", GoldBar);
			Value_.Push("Shield", Shield);
			Value_.Push("Stamina", Stamina);
		}
		public void Set(SArrowDodgeMapInfo Obj_)
		{
			Maps = Obj_.Maps;
			Arrow.Set(Obj_.Arrow);
			Coin.Set(Obj_.Coin);
			GoldBar.Set(Obj_.GoldBar);
			Shield.Set(Obj_.Shield);
			Stamina.Set(Obj_.Stamina);
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Maps) + "," + 
				SEnumChecker.GetStdName(Arrow) + "," + 
				SEnumChecker.GetStdName(Coin) + "," + 
				SEnumChecker.GetStdName(GoldBar) + "," + 
				SEnumChecker.GetStdName(Shield) + "," + 
				SEnumChecker.GetStdName(Stamina);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Maps, "Maps") + "," + 
				SEnumChecker.GetMemberName(Arrow, "Arrow") + "," + 
				SEnumChecker.GetMemberName(Coin, "Coin") + "," + 
				SEnumChecker.GetMemberName(GoldBar, "GoldBar") + "," + 
				SEnumChecker.GetMemberName(Shield, "Shield") + "," + 
				SEnumChecker.GetMemberName(Stamina, "Stamina");
		}
	}
	public class SFlyAwayMap : SProto
	{
		public String PrefabName = string.Empty;
		public SPoint PropPosition = new SPoint();
		public List<SBoxCollider2D> Structures = new List<SBoxCollider2D>();
		public SFlyAwayMap()
		{
		}
		public SFlyAwayMap(SFlyAwayMap Obj_)
		{
			PrefabName = Obj_.PrefabName;
			PropPosition = Obj_.PropPosition;
			Structures = Obj_.Structures;
		}
		public SFlyAwayMap(String PrefabName_, SPoint PropPosition_, List<SBoxCollider2D> Structures_)
		{
			PrefabName = PrefabName_;
			PropPosition = PropPosition_;
			Structures = Structures_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref PrefabName);
			Stream_.Pop(ref PropPosition);
			Stream_.Pop(ref Structures);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("PrefabName", ref PrefabName);
			Value_.Pop("PropPosition", ref PropPosition);
			Value_.Pop("Structures", ref Structures);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(PrefabName);
			Stream_.Push(PropPosition);
			Stream_.Push(Structures);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("PrefabName", PrefabName);
			Value_.Push("PropPosition", PropPosition);
			Value_.Push("Structures", Structures);
		}
		public void Set(SFlyAwayMap Obj_)
		{
			PrefabName = Obj_.PrefabName;
			PropPosition.Set(Obj_.PropPosition);
			Structures = Obj_.Structures;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(PrefabName) + "," + 
				SEnumChecker.GetStdName(PropPosition) + "," + 
				SEnumChecker.GetStdName(Structures);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(PrefabName, "PrefabName") + "," + 
				SEnumChecker.GetMemberName(PropPosition, "PropPosition") + "," + 
				SEnumChecker.GetMemberName(Structures, "Structures");
		}
	}
	public class SFlyAwayMapInfo : SProto
	{
		public List<SFlyAwayMap> Maps = new List<SFlyAwayMap>();
		public List<SPrefabNameCollider> Lands = new List<SPrefabNameCollider>();
		public SPrefabNameCollider Coin = new SPrefabNameCollider();
		public SPrefabNameCollider GoldBar = new SPrefabNameCollider();
		public SPrefabNameCollider Apple = new SPrefabNameCollider();
		public SPrefabNameCollider Meat = new SPrefabNameCollider();
		public SPrefabNameCollider Chicken = new SPrefabNameCollider();
		public SFlyAwayMapInfo()
		{
		}
		public SFlyAwayMapInfo(SFlyAwayMapInfo Obj_)
		{
			Maps = Obj_.Maps;
			Lands = Obj_.Lands;
			Coin = Obj_.Coin;
			GoldBar = Obj_.GoldBar;
			Apple = Obj_.Apple;
			Meat = Obj_.Meat;
			Chicken = Obj_.Chicken;
		}
		public SFlyAwayMapInfo(List<SFlyAwayMap> Maps_, List<SPrefabNameCollider> Lands_, SPrefabNameCollider Coin_, SPrefabNameCollider GoldBar_, SPrefabNameCollider Apple_, SPrefabNameCollider Meat_, SPrefabNameCollider Chicken_)
		{
			Maps = Maps_;
			Lands = Lands_;
			Coin = Coin_;
			GoldBar = GoldBar_;
			Apple = Apple_;
			Meat = Meat_;
			Chicken = Chicken_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Maps);
			Stream_.Pop(ref Lands);
			Stream_.Pop(ref Coin);
			Stream_.Pop(ref GoldBar);
			Stream_.Pop(ref Apple);
			Stream_.Pop(ref Meat);
			Stream_.Pop(ref Chicken);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Maps", ref Maps);
			Value_.Pop("Lands", ref Lands);
			Value_.Pop("Coin", ref Coin);
			Value_.Pop("GoldBar", ref GoldBar);
			Value_.Pop("Apple", ref Apple);
			Value_.Pop("Meat", ref Meat);
			Value_.Pop("Chicken", ref Chicken);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Maps);
			Stream_.Push(Lands);
			Stream_.Push(Coin);
			Stream_.Push(GoldBar);
			Stream_.Push(Apple);
			Stream_.Push(Meat);
			Stream_.Push(Chicken);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Maps", Maps);
			Value_.Push("Lands", Lands);
			Value_.Push("Coin", Coin);
			Value_.Push("GoldBar", GoldBar);
			Value_.Push("Apple", Apple);
			Value_.Push("Meat", Meat);
			Value_.Push("Chicken", Chicken);
		}
		public void Set(SFlyAwayMapInfo Obj_)
		{
			Maps = Obj_.Maps;
			Lands = Obj_.Lands;
			Coin.Set(Obj_.Coin);
			GoldBar.Set(Obj_.GoldBar);
			Apple.Set(Obj_.Apple);
			Meat.Set(Obj_.Meat);
			Chicken.Set(Obj_.Chicken);
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Maps) + "," + 
				SEnumChecker.GetStdName(Lands) + "," + 
				SEnumChecker.GetStdName(Coin) + "," + 
				SEnumChecker.GetStdName(GoldBar) + "," + 
				SEnumChecker.GetStdName(Apple) + "," + 
				SEnumChecker.GetStdName(Meat) + "," + 
				SEnumChecker.GetStdName(Chicken);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Maps, "Maps") + "," + 
				SEnumChecker.GetMemberName(Lands, "Lands") + "," + 
				SEnumChecker.GetMemberName(Coin, "Coin") + "," + 
				SEnumChecker.GetMemberName(GoldBar, "GoldBar") + "," + 
				SEnumChecker.GetMemberName(Apple, "Apple") + "," + 
				SEnumChecker.GetMemberName(Meat, "Meat") + "," + 
				SEnumChecker.GetMemberName(Chicken, "Chicken");
		}
	}
	public class SMapMeta : SProto
	{
		public List<SMultiMap> OneOnOneMaps = new List<SMultiMap>();
		public SArrowDodgeMapInfo ArrowDodgeMapInfo = new SArrowDodgeMapInfo();
		public SFlyAwayMapInfo FlyAwayMapInfo = new SFlyAwayMapInfo();
		public SMapMeta()
		{
		}
		public SMapMeta(SMapMeta Obj_)
		{
			OneOnOneMaps = Obj_.OneOnOneMaps;
			ArrowDodgeMapInfo = Obj_.ArrowDodgeMapInfo;
			FlyAwayMapInfo = Obj_.FlyAwayMapInfo;
		}
		public SMapMeta(List<SMultiMap> OneOnOneMaps_, SArrowDodgeMapInfo ArrowDodgeMapInfo_, SFlyAwayMapInfo FlyAwayMapInfo_)
		{
			OneOnOneMaps = OneOnOneMaps_;
			ArrowDodgeMapInfo = ArrowDodgeMapInfo_;
			FlyAwayMapInfo = FlyAwayMapInfo_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref OneOnOneMaps);
			Stream_.Pop(ref ArrowDodgeMapInfo);
			Stream_.Pop(ref FlyAwayMapInfo);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("OneOnOneMaps", ref OneOnOneMaps);
			Value_.Pop("ArrowDodgeMapInfo", ref ArrowDodgeMapInfo);
			Value_.Pop("FlyAwayMapInfo", ref FlyAwayMapInfo);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(OneOnOneMaps);
			Stream_.Push(ArrowDodgeMapInfo);
			Stream_.Push(FlyAwayMapInfo);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("OneOnOneMaps", OneOnOneMaps);
			Value_.Push("ArrowDodgeMapInfo", ArrowDodgeMapInfo);
			Value_.Push("FlyAwayMapInfo", FlyAwayMapInfo);
		}
		public void Set(SMapMeta Obj_)
		{
			OneOnOneMaps = Obj_.OneOnOneMaps;
			ArrowDodgeMapInfo.Set(Obj_.ArrowDodgeMapInfo);
			FlyAwayMapInfo.Set(Obj_.FlyAwayMapInfo);
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(OneOnOneMaps) + "," + 
				SEnumChecker.GetStdName(ArrowDodgeMapInfo) + "," + 
				SEnumChecker.GetStdName(FlyAwayMapInfo);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(OneOnOneMaps, "OneOnOneMaps") + "," + 
				SEnumChecker.GetMemberName(ArrowDodgeMapInfo, "ArrowDodgeMapInfo") + "," + 
				SEnumChecker.GetMemberName(FlyAwayMapInfo, "FlyAwayMapInfo");
		}
	}
	public class SGachaMeta : SProto
	{
		public EResource CostResource = default(EResource);
		public Int32 CostValue = default(Int32);
		public EResource TenCostResource = default(EResource);
		public Int32 TenCostValue = default(Int32);
		public Int32 RewardCode = default(Int32);
		public SGachaMeta()
		{
		}
		public SGachaMeta(SGachaMeta Obj_)
		{
			CostResource = Obj_.CostResource;
			CostValue = Obj_.CostValue;
			TenCostResource = Obj_.TenCostResource;
			TenCostValue = Obj_.TenCostValue;
			RewardCode = Obj_.RewardCode;
		}
		public SGachaMeta(EResource CostResource_, Int32 CostValue_, EResource TenCostResource_, Int32 TenCostValue_, Int32 RewardCode_)
		{
			CostResource = CostResource_;
			CostValue = CostValue_;
			TenCostResource = TenCostResource_;
			TenCostValue = TenCostValue_;
			RewardCode = RewardCode_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref CostResource);
			Stream_.Pop(ref CostValue);
			Stream_.Pop(ref TenCostResource);
			Stream_.Pop(ref TenCostValue);
			Stream_.Pop(ref RewardCode);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("CostResource", ref CostResource);
			Value_.Pop("CostValue", ref CostValue);
			Value_.Pop("TenCostResource", ref TenCostResource);
			Value_.Pop("TenCostValue", ref TenCostValue);
			Value_.Pop("RewardCode", ref RewardCode);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(CostResource);
			Stream_.Push(CostValue);
			Stream_.Push(TenCostResource);
			Stream_.Push(TenCostValue);
			Stream_.Push(RewardCode);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("CostResource", CostResource);
			Value_.Push("CostValue", CostValue);
			Value_.Push("TenCostResource", TenCostResource);
			Value_.Push("TenCostValue", TenCostValue);
			Value_.Push("RewardCode", RewardCode);
		}
		public void Set(SGachaMeta Obj_)
		{
			CostResource = Obj_.CostResource;
			CostValue = Obj_.CostValue;
			TenCostResource = Obj_.TenCostResource;
			TenCostValue = Obj_.TenCostValue;
			RewardCode = Obj_.RewardCode;
		}
		public override string StdName()
		{
			return 
				"bb.EResource" + "," + 
				SEnumChecker.GetStdName(CostValue) + "," + 
				"bb.EResource" + "," + 
				SEnumChecker.GetStdName(TenCostValue) + "," + 
				SEnumChecker.GetStdName(RewardCode);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(CostResource, "CostResource") + "," + 
				SEnumChecker.GetMemberName(CostValue, "CostValue") + "," + 
				SEnumChecker.GetMemberName(TenCostResource, "TenCostResource") + "," + 
				SEnumChecker.GetMemberName(TenCostValue, "TenCostValue") + "," + 
				SEnumChecker.GetMemberName(RewardCode, "RewardCode");
		}
	}
	public class SGachaGradeMeta : SProto
	{
		public EGrade Grade = default(EGrade);
		public Double Probability = default(Double);
		public SGachaGradeMeta()
		{
		}
		public SGachaGradeMeta(SGachaGradeMeta Obj_)
		{
			Grade = Obj_.Grade;
			Probability = Obj_.Probability;
		}
		public SGachaGradeMeta(EGrade Grade_, Double Probability_)
		{
			Grade = Grade_;
			Probability = Probability_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Grade);
			Stream_.Pop(ref Probability);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Grade", ref Grade);
			Value_.Pop("Probability", ref Probability);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Grade);
			Stream_.Push(Probability);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Grade", Grade);
			Value_.Push("Probability", Probability);
		}
		public void Set(SGachaGradeMeta Obj_)
		{
			Grade = Obj_.Grade;
			Probability = Obj_.Probability;
		}
		public override string StdName()
		{
			return 
				"bb.EGrade" + "," + 
				SEnumChecker.GetStdName(Probability);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Grade, "Grade") + "," + 
				SEnumChecker.GetMemberName(Probability, "Probability");
		}
	}
	public class SGachaRewardMeta : SProto
	{
		public Int32 Code = default(Int32);
		public Double Probability = default(Double);
		public Int32 CharCode = default(Int32);
		public SGachaRewardMeta()
		{
		}
		public SGachaRewardMeta(SGachaRewardMeta Obj_)
		{
			Code = Obj_.Code;
			Probability = Obj_.Probability;
			CharCode = Obj_.CharCode;
		}
		public SGachaRewardMeta(Int32 Code_, Double Probability_, Int32 CharCode_)
		{
			Code = Code_;
			Probability = Probability_;
			CharCode = CharCode_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Code);
			Stream_.Pop(ref Probability);
			Stream_.Pop(ref CharCode);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Code", ref Code);
			Value_.Pop("Probability", ref Probability);
			Value_.Pop("CharCode", ref CharCode);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Code);
			Stream_.Push(Probability);
			Stream_.Push(CharCode);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Code", Code);
			Value_.Push("Probability", Probability);
			Value_.Push("CharCode", CharCode);
		}
		public void Set(SGachaRewardMeta Obj_)
		{
			Code = Obj_.Code;
			Probability = Obj_.Probability;
			CharCode = Obj_.CharCode;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Code) + "," + 
				SEnumChecker.GetStdName(Probability) + "," + 
				SEnumChecker.GetStdName(CharCode);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Code, "Code") + "," + 
				SEnumChecker.GetMemberName(Probability, "Probability") + "," + 
				SEnumChecker.GetMemberName(CharCode, "CharCode");
		}
	}
	public class SRewardItemMeta : SProto
	{
		public String Type = string.Empty;
		public Int32 Data = default(Int32);
		public SRewardItemMeta()
		{
		}
		public SRewardItemMeta(SRewardItemMeta Obj_)
		{
			Type = Obj_.Type;
			Data = Obj_.Data;
		}
		public SRewardItemMeta(String Type_, Int32 Data_)
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
		public void Set(SRewardItemMeta Obj_)
		{
			Type = Obj_.Type;
			Data = Obj_.Data;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Type) + "," + 
				SEnumChecker.GetStdName(Data);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Type, "Type") + "," + 
				SEnumChecker.GetMemberName(Data, "Data");
		}
	}
	public class SCodeRewardItemMeta : SProto
	{
		public Int32 Code = default(Int32);
		public SRewardItemMeta RewardItem = new SRewardItemMeta();
		public SCodeRewardItemMeta()
		{
		}
		public SCodeRewardItemMeta(SCodeRewardItemMeta Obj_)
		{
			Code = Obj_.Code;
			RewardItem = Obj_.RewardItem;
		}
		public SCodeRewardItemMeta(Int32 Code_, SRewardItemMeta RewardItem_)
		{
			Code = Code_;
			RewardItem = RewardItem_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Code);
			Stream_.Pop(ref RewardItem);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Code", ref Code);
			Value_.Pop("RewardItem", ref RewardItem);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Code);
			Stream_.Push(RewardItem);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Code", Code);
			Value_.Push("RewardItem", RewardItem);
		}
		public void Set(SCodeRewardItemMeta Obj_)
		{
			Code = Obj_.Code;
			RewardItem.Set(Obj_.RewardItem);
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Code) + "," + 
				SEnumChecker.GetStdName(RewardItem);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Code, "Code") + "," + 
				SEnumChecker.GetMemberName(RewardItem, "RewardItem");
		}
	}
	public class SRankMeta : SProto
	{
		public ERank Rank = default(ERank);
		public SRankMeta()
		{
		}
		public SRankMeta(SRankMeta Obj_)
		{
			Rank = Obj_.Rank;
		}
		public SRankMeta(ERank Rank_)
		{
			Rank = Rank_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Rank);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Rank", ref Rank);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Rank);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Rank", Rank);
		}
		public void Set(SRankMeta Obj_)
		{
			Rank = Obj_.Rank;
		}
		public override string StdName()
		{
			return 
				"bb.ERank";
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Rank, "Rank");
		}
	}
	public class SRankTierMeta : SProto
	{
		public ERank Rank = default(ERank);
		public Int32 Tier = default(Int32);
		public Int32 MaxPoint = default(Int32);
		public SRankTierMeta()
		{
		}
		public SRankTierMeta(SRankTierMeta Obj_)
		{
			Rank = Obj_.Rank;
			Tier = Obj_.Tier;
			MaxPoint = Obj_.MaxPoint;
		}
		public SRankTierMeta(ERank Rank_, Int32 Tier_, Int32 MaxPoint_)
		{
			Rank = Rank_;
			Tier = Tier_;
			MaxPoint = MaxPoint_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Rank);
			Stream_.Pop(ref Tier);
			Stream_.Pop(ref MaxPoint);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Rank", ref Rank);
			Value_.Pop("Tier", ref Tier);
			Value_.Pop("MaxPoint", ref MaxPoint);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Rank);
			Stream_.Push(Tier);
			Stream_.Push(MaxPoint);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Rank", Rank);
			Value_.Push("Tier", Tier);
			Value_.Push("MaxPoint", MaxPoint);
		}
		public void Set(SRankTierMeta Obj_)
		{
			Rank = Obj_.Rank;
			Tier = Obj_.Tier;
			MaxPoint = Obj_.MaxPoint;
		}
		public override string StdName()
		{
			return 
				"bb.ERank" + "," + 
				SEnumChecker.GetStdName(Tier) + "," + 
				SEnumChecker.GetStdName(MaxPoint);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Rank, "Rank") + "," + 
				SEnumChecker.GetMemberName(Tier, "Tier") + "," + 
				SEnumChecker.GetMemberName(MaxPoint, "MaxPoint");
		}
	}
	public class SRankRewardMeta : SProto
	{
		public Int32 Point = default(Int32);
		public Int32 RewardCode = default(Int32);
		public SRankRewardMeta()
		{
		}
		public SRankRewardMeta(SRankRewardMeta Obj_)
		{
			Point = Obj_.Point;
			RewardCode = Obj_.RewardCode;
		}
		public SRankRewardMeta(Int32 Point_, Int32 RewardCode_)
		{
			Point = Point_;
			RewardCode = RewardCode_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Point);
			Stream_.Pop(ref RewardCode);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Point", ref Point);
			Value_.Pop("RewardCode", ref RewardCode);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Point);
			Stream_.Push(RewardCode);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Point", Point);
			Value_.Push("RewardCode", RewardCode);
		}
		public void Set(SRankRewardMeta Obj_)
		{
			Point = Obj_.Point;
			RewardCode = Obj_.RewardCode;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Point) + "," + 
				SEnumChecker.GetStdName(RewardCode);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Point, "Point") + "," + 
				SEnumChecker.GetMemberName(RewardCode, "RewardCode");
		}
	}
	public class SQuestMeta : SProto
	{
		public EQuestType QuestType = default(EQuestType);
		public Int32 Code = default(Int32);
		public Int32 RequirmentCount = default(Int32);
		public String Param = string.Empty;
		public String Operator = string.Empty;
		public Int32 RewardCode = default(Int32);
		public SQuestMeta()
		{
		}
		public SQuestMeta(SQuestMeta Obj_)
		{
			QuestType = Obj_.QuestType;
			Code = Obj_.Code;
			RequirmentCount = Obj_.RequirmentCount;
			Param = Obj_.Param;
			Operator = Obj_.Operator;
			RewardCode = Obj_.RewardCode;
		}
		public SQuestMeta(EQuestType QuestType_, Int32 Code_, Int32 RequirmentCount_, String Param_, String Operator_, Int32 RewardCode_)
		{
			QuestType = QuestType_;
			Code = Code_;
			RequirmentCount = RequirmentCount_;
			Param = Param_;
			Operator = Operator_;
			RewardCode = RewardCode_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref QuestType);
			Stream_.Pop(ref Code);
			Stream_.Pop(ref RequirmentCount);
			Stream_.Pop(ref Param);
			Stream_.Pop(ref Operator);
			Stream_.Pop(ref RewardCode);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("QuestType", ref QuestType);
			Value_.Pop("Code", ref Code);
			Value_.Pop("RequirmentCount", ref RequirmentCount);
			Value_.Pop("Param", ref Param);
			Value_.Pop("Operator", ref Operator);
			Value_.Pop("RewardCode", ref RewardCode);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(QuestType);
			Stream_.Push(Code);
			Stream_.Push(RequirmentCount);
			Stream_.Push(Param);
			Stream_.Push(Operator);
			Stream_.Push(RewardCode);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("QuestType", QuestType);
			Value_.Push("Code", Code);
			Value_.Push("RequirmentCount", RequirmentCount);
			Value_.Push("Param", Param);
			Value_.Push("Operator", Operator);
			Value_.Push("RewardCode", RewardCode);
		}
		public void Set(SQuestMeta Obj_)
		{
			QuestType = Obj_.QuestType;
			Code = Obj_.Code;
			RequirmentCount = Obj_.RequirmentCount;
			Param = Obj_.Param;
			Operator = Obj_.Operator;
			RewardCode = Obj_.RewardCode;
		}
		public override string StdName()
		{
			return 
				"bb.EQuestType" + "," + 
				SEnumChecker.GetStdName(Code) + "," + 
				SEnumChecker.GetStdName(RequirmentCount) + "," + 
				SEnumChecker.GetStdName(Param) + "," + 
				SEnumChecker.GetStdName(Operator) + "," + 
				SEnumChecker.GetStdName(RewardCode);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(QuestType, "QuestType") + "," + 
				SEnumChecker.GetMemberName(Code, "Code") + "," + 
				SEnumChecker.GetMemberName(RequirmentCount, "RequirmentCount") + "," + 
				SEnumChecker.GetMemberName(Param, "Param") + "," + 
				SEnumChecker.GetMemberName(Operator, "Operator") + "," + 
				SEnumChecker.GetMemberName(RewardCode, "RewardCode");
		}
	}
	public class SQuestDailyCompleteMeta : SProto
	{
		public Int32 RequirmentCount = default(Int32);
		public Int32 RewardCode = default(Int32);
		public Int32 RefreshMinutes = default(Int32);
		public SQuestDailyCompleteMeta()
		{
		}
		public SQuestDailyCompleteMeta(SQuestDailyCompleteMeta Obj_)
		{
			RequirmentCount = Obj_.RequirmentCount;
			RewardCode = Obj_.RewardCode;
			RefreshMinutes = Obj_.RefreshMinutes;
		}
		public SQuestDailyCompleteMeta(Int32 RequirmentCount_, Int32 RewardCode_, Int32 RefreshMinutes_)
		{
			RequirmentCount = RequirmentCount_;
			RewardCode = RewardCode_;
			RefreshMinutes = RefreshMinutes_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref RequirmentCount);
			Stream_.Pop(ref RewardCode);
			Stream_.Pop(ref RefreshMinutes);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("RequirmentCount", ref RequirmentCount);
			Value_.Pop("RewardCode", ref RewardCode);
			Value_.Pop("RefreshMinutes", ref RefreshMinutes);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(RequirmentCount);
			Stream_.Push(RewardCode);
			Stream_.Push(RefreshMinutes);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("RequirmentCount", RequirmentCount);
			Value_.Push("RewardCode", RewardCode);
			Value_.Push("RefreshMinutes", RefreshMinutes);
		}
		public void Set(SQuestDailyCompleteMeta Obj_)
		{
			RequirmentCount = Obj_.RequirmentCount;
			RewardCode = Obj_.RewardCode;
			RefreshMinutes = Obj_.RefreshMinutes;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(RequirmentCount) + "," + 
				SEnumChecker.GetStdName(RewardCode) + "," + 
				SEnumChecker.GetStdName(RefreshMinutes);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(RequirmentCount, "RequirmentCount") + "," + 
				SEnumChecker.GetMemberName(RewardCode, "RewardCode") + "," + 
				SEnumChecker.GetMemberName(RefreshMinutes, "RefreshMinutes");
		}
	}
	public class SBattleRewardMeta : SProto
	{
		public SBattleType BattleType = new SBattleType();
		public Int32 AddGold = default(Int32);
		public Int32 Unranked = default(Int32);
		public Int32 Bronze = default(Int32);
		public Int32 Silver = default(Int32);
		public Int32 Gold = default(Int32);
		public Int32 Diamond = default(Int32);
		public Int32 Champion = default(Int32);
		public SBattleRewardMeta()
		{
		}
		public SBattleRewardMeta(SBattleRewardMeta Obj_)
		{
			BattleType = Obj_.BattleType;
			AddGold = Obj_.AddGold;
			Unranked = Obj_.Unranked;
			Bronze = Obj_.Bronze;
			Silver = Obj_.Silver;
			Gold = Obj_.Gold;
			Diamond = Obj_.Diamond;
			Champion = Obj_.Champion;
		}
		public SBattleRewardMeta(SBattleType BattleType_, Int32 AddGold_, Int32 Unranked_, Int32 Bronze_, Int32 Silver_, Int32 Gold_, Int32 Diamond_, Int32 Champion_)
		{
			BattleType = BattleType_;
			AddGold = AddGold_;
			Unranked = Unranked_;
			Bronze = Bronze_;
			Silver = Silver_;
			Gold = Gold_;
			Diamond = Diamond_;
			Champion = Champion_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref BattleType);
			Stream_.Pop(ref AddGold);
			Stream_.Pop(ref Unranked);
			Stream_.Pop(ref Bronze);
			Stream_.Pop(ref Silver);
			Stream_.Pop(ref Gold);
			Stream_.Pop(ref Diamond);
			Stream_.Pop(ref Champion);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("BattleType", ref BattleType);
			Value_.Pop("AddGold", ref AddGold);
			Value_.Pop("Unranked", ref Unranked);
			Value_.Pop("Bronze", ref Bronze);
			Value_.Pop("Silver", ref Silver);
			Value_.Pop("Gold", ref Gold);
			Value_.Pop("Diamond", ref Diamond);
			Value_.Pop("Champion", ref Champion);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(BattleType);
			Stream_.Push(AddGold);
			Stream_.Push(Unranked);
			Stream_.Push(Bronze);
			Stream_.Push(Silver);
			Stream_.Push(Gold);
			Stream_.Push(Diamond);
			Stream_.Push(Champion);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("BattleType", BattleType);
			Value_.Push("AddGold", AddGold);
			Value_.Push("Unranked", Unranked);
			Value_.Push("Bronze", Bronze);
			Value_.Push("Silver", Silver);
			Value_.Push("Gold", Gold);
			Value_.Push("Diamond", Diamond);
			Value_.Push("Champion", Champion);
		}
		public void Set(SBattleRewardMeta Obj_)
		{
			BattleType.Set(Obj_.BattleType);
			AddGold = Obj_.AddGold;
			Unranked = Obj_.Unranked;
			Bronze = Obj_.Bronze;
			Silver = Obj_.Silver;
			Gold = Obj_.Gold;
			Diamond = Obj_.Diamond;
			Champion = Obj_.Champion;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(BattleType) + "," + 
				SEnumChecker.GetStdName(AddGold) + "," + 
				SEnumChecker.GetStdName(Unranked) + "," + 
				SEnumChecker.GetStdName(Bronze) + "," + 
				SEnumChecker.GetStdName(Silver) + "," + 
				SEnumChecker.GetStdName(Gold) + "," + 
				SEnumChecker.GetStdName(Diamond) + "," + 
				SEnumChecker.GetStdName(Champion);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(BattleType, "BattleType") + "," + 
				SEnumChecker.GetMemberName(AddGold, "AddGold") + "," + 
				SEnumChecker.GetMemberName(Unranked, "Unranked") + "," + 
				SEnumChecker.GetMemberName(Bronze, "Bronze") + "," + 
				SEnumChecker.GetMemberName(Silver, "Silver") + "," + 
				SEnumChecker.GetMemberName(Gold, "Gold") + "," + 
				SEnumChecker.GetMemberName(Diamond, "Diamond") + "," + 
				SEnumChecker.GetMemberName(Champion, "Champion");
		}
	}
	public class SMultiMeta : SProto
	{
		public Int32 DisconnectableSeconds = default(Int32);
		public Int32 PunishMinutesForDisconnect = default(Int32);
		public SMultiMeta()
		{
		}
		public SMultiMeta(SMultiMeta Obj_)
		{
			DisconnectableSeconds = Obj_.DisconnectableSeconds;
			PunishMinutesForDisconnect = Obj_.PunishMinutesForDisconnect;
		}
		public SMultiMeta(Int32 DisconnectableSeconds_, Int32 PunishMinutesForDisconnect_)
		{
			DisconnectableSeconds = DisconnectableSeconds_;
			PunishMinutesForDisconnect = PunishMinutesForDisconnect_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref DisconnectableSeconds);
			Stream_.Pop(ref PunishMinutesForDisconnect);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("DisconnectableSeconds", ref DisconnectableSeconds);
			Value_.Pop("PunishMinutesForDisconnect", ref PunishMinutesForDisconnect);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(DisconnectableSeconds);
			Stream_.Push(PunishMinutesForDisconnect);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("DisconnectableSeconds", DisconnectableSeconds);
			Value_.Push("PunishMinutesForDisconnect", PunishMinutesForDisconnect);
		}
		public void Set(SMultiMeta Obj_)
		{
			DisconnectableSeconds = Obj_.DisconnectableSeconds;
			PunishMinutesForDisconnect = Obj_.PunishMinutesForDisconnect;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(DisconnectableSeconds) + "," + 
				SEnumChecker.GetStdName(PunishMinutesForDisconnect);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(DisconnectableSeconds, "DisconnectableSeconds") + "," + 
				SEnumChecker.GetMemberName(PunishMinutesForDisconnect, "PunishMinutesForDisconnect");
		}
	}
	public class SMultiMatchDeniedDurationMeta : SProto
	{
		public Int32 DisconnectedCount = default(Int32);
		public Int32 DeniedSeconds = default(Int32);
		public SMultiMatchDeniedDurationMeta()
		{
		}
		public SMultiMatchDeniedDurationMeta(SMultiMatchDeniedDurationMeta Obj_)
		{
			DisconnectedCount = Obj_.DisconnectedCount;
			DeniedSeconds = Obj_.DeniedSeconds;
		}
		public SMultiMatchDeniedDurationMeta(Int32 DisconnectedCount_, Int32 DeniedSeconds_)
		{
			DisconnectedCount = DisconnectedCount_;
			DeniedSeconds = DeniedSeconds_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref DisconnectedCount);
			Stream_.Pop(ref DeniedSeconds);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("DisconnectedCount", ref DisconnectedCount);
			Value_.Pop("DeniedSeconds", ref DeniedSeconds);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(DisconnectedCount);
			Stream_.Push(DeniedSeconds);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("DisconnectedCount", DisconnectedCount);
			Value_.Push("DeniedSeconds", DeniedSeconds);
		}
		public void Set(SMultiMatchDeniedDurationMeta Obj_)
		{
			DisconnectedCount = Obj_.DisconnectedCount;
			DeniedSeconds = Obj_.DeniedSeconds;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(DisconnectedCount) + "," + 
				SEnumChecker.GetStdName(DeniedSeconds);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(DisconnectedCount, "DisconnectedCount") + "," + 
				SEnumChecker.GetMemberName(DeniedSeconds, "DeniedSeconds");
		}
	}
	public class SArrowDodgeMeta : SProto
	{
		public Int32 ArrowDodgePoint = default(Int32);
		public Int32 ArrowGetPoint = default(Int32);
		public Int64 ItemDurationTick = default(Int64);
		public Int64 ItemRegenPeriodTick = default(Int64);
		public Int32 PlayCountMax = default(Int32);
		public TResource ChargeCostGold = default(TResource);
		public Int32 RefreshDurationMinute = default(Int32);
		public SArrowDodgeMeta()
		{
		}
		public SArrowDodgeMeta(SArrowDodgeMeta Obj_)
		{
			ArrowDodgePoint = Obj_.ArrowDodgePoint;
			ArrowGetPoint = Obj_.ArrowGetPoint;
			ItemDurationTick = Obj_.ItemDurationTick;
			ItemRegenPeriodTick = Obj_.ItemRegenPeriodTick;
			PlayCountMax = Obj_.PlayCountMax;
			ChargeCostGold = Obj_.ChargeCostGold;
			RefreshDurationMinute = Obj_.RefreshDurationMinute;
		}
		public SArrowDodgeMeta(Int32 ArrowDodgePoint_, Int32 ArrowGetPoint_, Int64 ItemDurationTick_, Int64 ItemRegenPeriodTick_, Int32 PlayCountMax_, TResource ChargeCostGold_, Int32 RefreshDurationMinute_)
		{
			ArrowDodgePoint = ArrowDodgePoint_;
			ArrowGetPoint = ArrowGetPoint_;
			ItemDurationTick = ItemDurationTick_;
			ItemRegenPeriodTick = ItemRegenPeriodTick_;
			PlayCountMax = PlayCountMax_;
			ChargeCostGold = ChargeCostGold_;
			RefreshDurationMinute = RefreshDurationMinute_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref ArrowDodgePoint);
			Stream_.Pop(ref ArrowGetPoint);
			Stream_.Pop(ref ItemDurationTick);
			Stream_.Pop(ref ItemRegenPeriodTick);
			Stream_.Pop(ref PlayCountMax);
			Stream_.Pop(ref ChargeCostGold);
			Stream_.Pop(ref RefreshDurationMinute);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("ArrowDodgePoint", ref ArrowDodgePoint);
			Value_.Pop("ArrowGetPoint", ref ArrowGetPoint);
			Value_.Pop("ItemDurationTick", ref ItemDurationTick);
			Value_.Pop("ItemRegenPeriodTick", ref ItemRegenPeriodTick);
			Value_.Pop("PlayCountMax", ref PlayCountMax);
			Value_.Pop("ChargeCostGold", ref ChargeCostGold);
			Value_.Pop("RefreshDurationMinute", ref RefreshDurationMinute);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(ArrowDodgePoint);
			Stream_.Push(ArrowGetPoint);
			Stream_.Push(ItemDurationTick);
			Stream_.Push(ItemRegenPeriodTick);
			Stream_.Push(PlayCountMax);
			Stream_.Push(ChargeCostGold);
			Stream_.Push(RefreshDurationMinute);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("ArrowDodgePoint", ArrowDodgePoint);
			Value_.Push("ArrowGetPoint", ArrowGetPoint);
			Value_.Push("ItemDurationTick", ItemDurationTick);
			Value_.Push("ItemRegenPeriodTick", ItemRegenPeriodTick);
			Value_.Push("PlayCountMax", PlayCountMax);
			Value_.Push("ChargeCostGold", ChargeCostGold);
			Value_.Push("RefreshDurationMinute", RefreshDurationMinute);
		}
		public void Set(SArrowDodgeMeta Obj_)
		{
			ArrowDodgePoint = Obj_.ArrowDodgePoint;
			ArrowGetPoint = Obj_.ArrowGetPoint;
			ItemDurationTick = Obj_.ItemDurationTick;
			ItemRegenPeriodTick = Obj_.ItemRegenPeriodTick;
			PlayCountMax = Obj_.PlayCountMax;
			ChargeCostGold = Obj_.ChargeCostGold;
			RefreshDurationMinute = Obj_.RefreshDurationMinute;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(ArrowDodgePoint) + "," + 
				SEnumChecker.GetStdName(ArrowGetPoint) + "," + 
				SEnumChecker.GetStdName(ItemDurationTick) + "," + 
				SEnumChecker.GetStdName(ItemRegenPeriodTick) + "," + 
				SEnumChecker.GetStdName(PlayCountMax) + "," + 
				SEnumChecker.GetStdName(ChargeCostGold) + "," + 
				SEnumChecker.GetStdName(RefreshDurationMinute);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(ArrowDodgePoint, "ArrowDodgePoint") + "," + 
				SEnumChecker.GetMemberName(ArrowGetPoint, "ArrowGetPoint") + "," + 
				SEnumChecker.GetMemberName(ItemDurationTick, "ItemDurationTick") + "," + 
				SEnumChecker.GetMemberName(ItemRegenPeriodTick, "ItemRegenPeriodTick") + "," + 
				SEnumChecker.GetMemberName(PlayCountMax, "PlayCountMax") + "," + 
				SEnumChecker.GetMemberName(ChargeCostGold, "ChargeCostGold") + "," + 
				SEnumChecker.GetMemberName(RefreshDurationMinute, "RefreshDurationMinute");
		}
	}
	public class SArrowDodgeItemMeta : SProto
	{
		public EArrowDodgeItemType ItemType = default(EArrowDodgeItemType);
		public UInt32 CreateWeight = default(UInt32);
		public Int32 AddedPoint = default(Int32);
		public TResource AddedGold = default(TResource);
		public SArrowDodgeItemMeta()
		{
		}
		public SArrowDodgeItemMeta(SArrowDodgeItemMeta Obj_)
		{
			ItemType = Obj_.ItemType;
			CreateWeight = Obj_.CreateWeight;
			AddedPoint = Obj_.AddedPoint;
			AddedGold = Obj_.AddedGold;
		}
		public SArrowDodgeItemMeta(EArrowDodgeItemType ItemType_, UInt32 CreateWeight_, Int32 AddedPoint_, TResource AddedGold_)
		{
			ItemType = ItemType_;
			CreateWeight = CreateWeight_;
			AddedPoint = AddedPoint_;
			AddedGold = AddedGold_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref ItemType);
			Stream_.Pop(ref CreateWeight);
			Stream_.Pop(ref AddedPoint);
			Stream_.Pop(ref AddedGold);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("ItemType", ref ItemType);
			Value_.Pop("CreateWeight", ref CreateWeight);
			Value_.Pop("AddedPoint", ref AddedPoint);
			Value_.Pop("AddedGold", ref AddedGold);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(ItemType);
			Stream_.Push(CreateWeight);
			Stream_.Push(AddedPoint);
			Stream_.Push(AddedGold);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("ItemType", ItemType);
			Value_.Push("CreateWeight", CreateWeight);
			Value_.Push("AddedPoint", AddedPoint);
			Value_.Push("AddedGold", AddedGold);
		}
		public void Set(SArrowDodgeItemMeta Obj_)
		{
			ItemType = Obj_.ItemType;
			CreateWeight = Obj_.CreateWeight;
			AddedPoint = Obj_.AddedPoint;
			AddedGold = Obj_.AddedGold;
		}
		public override string StdName()
		{
			return 
				"bb.EArrowDodgeItemType" + "," + 
				SEnumChecker.GetStdName(CreateWeight) + "," + 
				SEnumChecker.GetStdName(AddedPoint) + "," + 
				SEnumChecker.GetStdName(AddedGold);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(ItemType, "ItemType") + "," + 
				SEnumChecker.GetMemberName(CreateWeight, "CreateWeight") + "," + 
				SEnumChecker.GetMemberName(AddedPoint, "AddedPoint") + "," + 
				SEnumChecker.GetMemberName(AddedGold, "AddedGold");
		}
	}
	public class SFlyAwayMeta : SProto
	{
		public Int32 PlayCountMax = default(Int32);
		public TResource ChargeCostGold = default(TResource);
		public Int32 RefreshDurationMinute = default(Int32);
		public SFlyAwayMeta()
		{
		}
		public SFlyAwayMeta(SFlyAwayMeta Obj_)
		{
			PlayCountMax = Obj_.PlayCountMax;
			ChargeCostGold = Obj_.ChargeCostGold;
			RefreshDurationMinute = Obj_.RefreshDurationMinute;
		}
		public SFlyAwayMeta(Int32 PlayCountMax_, TResource ChargeCostGold_, Int32 RefreshDurationMinute_)
		{
			PlayCountMax = PlayCountMax_;
			ChargeCostGold = ChargeCostGold_;
			RefreshDurationMinute = RefreshDurationMinute_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref PlayCountMax);
			Stream_.Pop(ref ChargeCostGold);
			Stream_.Pop(ref RefreshDurationMinute);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("PlayCountMax", ref PlayCountMax);
			Value_.Pop("ChargeCostGold", ref ChargeCostGold);
			Value_.Pop("RefreshDurationMinute", ref RefreshDurationMinute);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(PlayCountMax);
			Stream_.Push(ChargeCostGold);
			Stream_.Push(RefreshDurationMinute);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("PlayCountMax", PlayCountMax);
			Value_.Push("ChargeCostGold", ChargeCostGold);
			Value_.Push("RefreshDurationMinute", RefreshDurationMinute);
		}
		public void Set(SFlyAwayMeta Obj_)
		{
			PlayCountMax = Obj_.PlayCountMax;
			ChargeCostGold = Obj_.ChargeCostGold;
			RefreshDurationMinute = Obj_.RefreshDurationMinute;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(PlayCountMax) + "," + 
				SEnumChecker.GetStdName(ChargeCostGold) + "," + 
				SEnumChecker.GetStdName(RefreshDurationMinute);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(PlayCountMax, "PlayCountMax") + "," + 
				SEnumChecker.GetMemberName(ChargeCostGold, "ChargeCostGold") + "," + 
				SEnumChecker.GetMemberName(RefreshDurationMinute, "RefreshDurationMinute");
		}
	}
	public class SFlyAwayItemMeta : SProto
	{
		public EFlyAwayItemType ItemType = default(EFlyAwayItemType);
		public UInt32 StaminaCreateWeight = default(UInt32);
		public Int32 AddedPoint = default(Int32);
		public TResource AddedGold = default(TResource);
		public Single AddedStamina = default(Single);
		public SFlyAwayItemMeta()
		{
		}
		public SFlyAwayItemMeta(SFlyAwayItemMeta Obj_)
		{
			ItemType = Obj_.ItemType;
			StaminaCreateWeight = Obj_.StaminaCreateWeight;
			AddedPoint = Obj_.AddedPoint;
			AddedGold = Obj_.AddedGold;
			AddedStamina = Obj_.AddedStamina;
		}
		public SFlyAwayItemMeta(EFlyAwayItemType ItemType_, UInt32 StaminaCreateWeight_, Int32 AddedPoint_, TResource AddedGold_, Single AddedStamina_)
		{
			ItemType = ItemType_;
			StaminaCreateWeight = StaminaCreateWeight_;
			AddedPoint = AddedPoint_;
			AddedGold = AddedGold_;
			AddedStamina = AddedStamina_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref ItemType);
			Stream_.Pop(ref StaminaCreateWeight);
			Stream_.Pop(ref AddedPoint);
			Stream_.Pop(ref AddedGold);
			Stream_.Pop(ref AddedStamina);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("ItemType", ref ItemType);
			Value_.Pop("StaminaCreateWeight", ref StaminaCreateWeight);
			Value_.Pop("AddedPoint", ref AddedPoint);
			Value_.Pop("AddedGold", ref AddedGold);
			Value_.Pop("AddedStamina", ref AddedStamina);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(ItemType);
			Stream_.Push(StaminaCreateWeight);
			Stream_.Push(AddedPoint);
			Stream_.Push(AddedGold);
			Stream_.Push(AddedStamina);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("ItemType", ItemType);
			Value_.Push("StaminaCreateWeight", StaminaCreateWeight);
			Value_.Push("AddedPoint", AddedPoint);
			Value_.Push("AddedGold", AddedGold);
			Value_.Push("AddedStamina", AddedStamina);
		}
		public void Set(SFlyAwayItemMeta Obj_)
		{
			ItemType = Obj_.ItemType;
			StaminaCreateWeight = Obj_.StaminaCreateWeight;
			AddedPoint = Obj_.AddedPoint;
			AddedGold = Obj_.AddedGold;
			AddedStamina = Obj_.AddedStamina;
		}
		public override string StdName()
		{
			return 
				"bb.EFlyAwayItemType" + "," + 
				SEnumChecker.GetStdName(StaminaCreateWeight) + "," + 
				SEnumChecker.GetStdName(AddedPoint) + "," + 
				SEnumChecker.GetStdName(AddedGold) + "," + 
				SEnumChecker.GetStdName(AddedStamina);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(ItemType, "ItemType") + "," + 
				SEnumChecker.GetMemberName(StaminaCreateWeight, "StaminaCreateWeight") + "," + 
				SEnumChecker.GetMemberName(AddedPoint, "AddedPoint") + "," + 
				SEnumChecker.GetMemberName(AddedGold, "AddedGold") + "," + 
				SEnumChecker.GetMemberName(AddedStamina, "AddedStamina");
		}
	}
	public class SCouponMeta : SProto
	{
		public Int32 Code = default(Int32);
		public Int32 StartYear = default(Int32);
		public Int32 StartMonth = default(Int32);
		public Int32 StartDay = default(Int32);
		public Int32 StartHour = default(Int32);
		public Int32 EndYear = default(Int32);
		public Int32 EndMonth = default(Int32);
		public Int32 EndDay = default(Int32);
		public Int32 EndHour = default(Int32);
		public Int32 RewardCode = default(Int32);
		public SCouponMeta()
		{
		}
		public SCouponMeta(SCouponMeta Obj_)
		{
			Code = Obj_.Code;
			StartYear = Obj_.StartYear;
			StartMonth = Obj_.StartMonth;
			StartDay = Obj_.StartDay;
			StartHour = Obj_.StartHour;
			EndYear = Obj_.EndYear;
			EndMonth = Obj_.EndMonth;
			EndDay = Obj_.EndDay;
			EndHour = Obj_.EndHour;
			RewardCode = Obj_.RewardCode;
		}
		public SCouponMeta(Int32 Code_, Int32 StartYear_, Int32 StartMonth_, Int32 StartDay_, Int32 StartHour_, Int32 EndYear_, Int32 EndMonth_, Int32 EndDay_, Int32 EndHour_, Int32 RewardCode_)
		{
			Code = Code_;
			StartYear = StartYear_;
			StartMonth = StartMonth_;
			StartDay = StartDay_;
			StartHour = StartHour_;
			EndYear = EndYear_;
			EndMonth = EndMonth_;
			EndDay = EndDay_;
			EndHour = EndHour_;
			RewardCode = RewardCode_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Code);
			Stream_.Pop(ref StartYear);
			Stream_.Pop(ref StartMonth);
			Stream_.Pop(ref StartDay);
			Stream_.Pop(ref StartHour);
			Stream_.Pop(ref EndYear);
			Stream_.Pop(ref EndMonth);
			Stream_.Pop(ref EndDay);
			Stream_.Pop(ref EndHour);
			Stream_.Pop(ref RewardCode);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Code", ref Code);
			Value_.Pop("StartYear", ref StartYear);
			Value_.Pop("StartMonth", ref StartMonth);
			Value_.Pop("StartDay", ref StartDay);
			Value_.Pop("StartHour", ref StartHour);
			Value_.Pop("EndYear", ref EndYear);
			Value_.Pop("EndMonth", ref EndMonth);
			Value_.Pop("EndDay", ref EndDay);
			Value_.Pop("EndHour", ref EndHour);
			Value_.Pop("RewardCode", ref RewardCode);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Code);
			Stream_.Push(StartYear);
			Stream_.Push(StartMonth);
			Stream_.Push(StartDay);
			Stream_.Push(StartHour);
			Stream_.Push(EndYear);
			Stream_.Push(EndMonth);
			Stream_.Push(EndDay);
			Stream_.Push(EndHour);
			Stream_.Push(RewardCode);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Code", Code);
			Value_.Push("StartYear", StartYear);
			Value_.Push("StartMonth", StartMonth);
			Value_.Push("StartDay", StartDay);
			Value_.Push("StartHour", StartHour);
			Value_.Push("EndYear", EndYear);
			Value_.Push("EndMonth", EndMonth);
			Value_.Push("EndDay", EndDay);
			Value_.Push("EndHour", EndHour);
			Value_.Push("RewardCode", RewardCode);
		}
		public void Set(SCouponMeta Obj_)
		{
			Code = Obj_.Code;
			StartYear = Obj_.StartYear;
			StartMonth = Obj_.StartMonth;
			StartDay = Obj_.StartDay;
			StartHour = Obj_.StartHour;
			EndYear = Obj_.EndYear;
			EndMonth = Obj_.EndMonth;
			EndDay = Obj_.EndDay;
			EndHour = Obj_.EndHour;
			RewardCode = Obj_.RewardCode;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Code) + "," + 
				SEnumChecker.GetStdName(StartYear) + "," + 
				SEnumChecker.GetStdName(StartMonth) + "," + 
				SEnumChecker.GetStdName(StartDay) + "," + 
				SEnumChecker.GetStdName(StartHour) + "," + 
				SEnumChecker.GetStdName(EndYear) + "," + 
				SEnumChecker.GetStdName(EndMonth) + "," + 
				SEnumChecker.GetStdName(EndDay) + "," + 
				SEnumChecker.GetStdName(EndHour) + "," + 
				SEnumChecker.GetStdName(RewardCode);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Code, "Code") + "," + 
				SEnumChecker.GetMemberName(StartYear, "StartYear") + "," + 
				SEnumChecker.GetMemberName(StartMonth, "StartMonth") + "," + 
				SEnumChecker.GetMemberName(StartDay, "StartDay") + "," + 
				SEnumChecker.GetMemberName(StartHour, "StartHour") + "," + 
				SEnumChecker.GetMemberName(EndYear, "EndYear") + "," + 
				SEnumChecker.GetMemberName(EndMonth, "EndMonth") + "," + 
				SEnumChecker.GetMemberName(EndDay, "EndDay") + "," + 
				SEnumChecker.GetMemberName(EndHour, "EndHour") + "," + 
				SEnumChecker.GetMemberName(RewardCode, "RewardCode");
		}
	}
	public class SCouponKeyMeta : SProto
	{
		public String Key = string.Empty;
		public Int32 Code = default(Int32);
		public SCouponKeyMeta()
		{
		}
		public SCouponKeyMeta(SCouponKeyMeta Obj_)
		{
			Key = Obj_.Key;
			Code = Obj_.Code;
		}
		public SCouponKeyMeta(String Key_, Int32 Code_)
		{
			Key = Key_;
			Code = Code_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Key);
			Stream_.Pop(ref Code);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Key", ref Key);
			Value_.Pop("Code", ref Code);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Key);
			Stream_.Push(Code);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Key", Key);
			Value_.Push("Code", Code);
		}
		public void Set(SCouponKeyMeta Obj_)
		{
			Key = Obj_.Key;
			Code = Obj_.Code;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Key) + "," + 
				SEnumChecker.GetStdName(Code);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Key, "Key") + "," + 
				SEnumChecker.GetMemberName(Code, "Code");
		}
	}
	public class SRankingConfigMeta : SProto
	{
		public Int32 PeriodMinutes = default(Int32);
		public String BaseTime = string.Empty;
		public SRankingConfigMeta()
		{
		}
		public SRankingConfigMeta(SRankingConfigMeta Obj_)
		{
			PeriodMinutes = Obj_.PeriodMinutes;
			BaseTime = Obj_.BaseTime;
		}
		public SRankingConfigMeta(Int32 PeriodMinutes_, String BaseTime_)
		{
			PeriodMinutes = PeriodMinutes_;
			BaseTime = BaseTime_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref PeriodMinutes);
			Stream_.Pop(ref BaseTime);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("PeriodMinutes", ref PeriodMinutes);
			Value_.Pop("BaseTime", ref BaseTime);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(PeriodMinutes);
			Stream_.Push(BaseTime);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("PeriodMinutes", PeriodMinutes);
			Value_.Push("BaseTime", BaseTime);
		}
		public void Set(SRankingConfigMeta Obj_)
		{
			PeriodMinutes = Obj_.PeriodMinutes;
			BaseTime = Obj_.BaseTime;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(PeriodMinutes) + "," + 
				SEnumChecker.GetStdName(BaseTime);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(PeriodMinutes, "PeriodMinutes") + "," + 
				SEnumChecker.GetMemberName(BaseTime, "BaseTime");
		}
	}
	public class SRankingRewardMeta : SProto
	{
		public String Mode = string.Empty;
		public Int32 End = default(Int32);
		public Int32 RewardCode = default(Int32);
		public SRankingRewardMeta()
		{
		}
		public SRankingRewardMeta(SRankingRewardMeta Obj_)
		{
			Mode = Obj_.Mode;
			End = Obj_.End;
			RewardCode = Obj_.RewardCode;
		}
		public SRankingRewardMeta(String Mode_, Int32 End_, Int32 RewardCode_)
		{
			Mode = Mode_;
			End = End_;
			RewardCode = RewardCode_;
		}
		public override void Push(CStream Stream_)
		{
			Stream_.Pop(ref Mode);
			Stream_.Pop(ref End);
			Stream_.Pop(ref RewardCode);
		}
		public override void Push(JsonDataObject Value_)
		{
			Value_.Pop("Mode", ref Mode);
			Value_.Pop("End", ref End);
			Value_.Pop("RewardCode", ref RewardCode);
		}
		public override void Pop(CStream Stream_)
		{
			Stream_.Push(Mode);
			Stream_.Push(End);
			Stream_.Push(RewardCode);
		}
		public override void Pop(JsonDataObject Value_)
		{
			Value_.Push("Mode", Mode);
			Value_.Push("End", End);
			Value_.Push("RewardCode", RewardCode);
		}
		public void Set(SRankingRewardMeta Obj_)
		{
			Mode = Obj_.Mode;
			End = Obj_.End;
			RewardCode = Obj_.RewardCode;
		}
		public override string StdName()
		{
			return 
				SEnumChecker.GetStdName(Mode) + "," + 
				SEnumChecker.GetStdName(End) + "," + 
				SEnumChecker.GetStdName(RewardCode);
		}
		public override string MemberName()
		{
			return 
				SEnumChecker.GetMemberName(Mode, "Mode") + "," + 
				SEnumChecker.GetMemberName(End, "End") + "," + 
				SEnumChecker.GetMemberName(RewardCode, "RewardCode");
		}
	}
}

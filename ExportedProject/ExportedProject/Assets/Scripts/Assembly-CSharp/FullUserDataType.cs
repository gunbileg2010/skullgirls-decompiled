using System;

[Flags]
public enum FullUserDataType
{
	All = int.MaxValue,
	UserOnly = 0,
	Accounts = 1,
	Characters = 2,
	Moves = 4,
	NodeModifiers = 8,
	Gachas = 0x10,
	BaseCharacterCurrencies = 0x20,
	BattleTier = 0x40,
	Consumables = 0x80,
	SyncPvpRecord = 0x100,
	EventLockedCharacters = 0x200,
	Deployments = 0x400,
	Catalog = 0x800,
	DailyChallenges = 0x1000
}

// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0xA0)]
public unsafe partial struct Item {
    [FieldOffset(0x00)] public int Singular_Offset;
    [FieldOffset(0x04)] public int Plural_Offset;
    [FieldOffset(0x08)] public int Description_Offset;
    [FieldOffset(0x0C)] public int Name_Offset;
    [FieldOffset(0x10)] public sbyte Adjective;
    [FieldOffset(0x11)] public sbyte PossessivePronoun;
    [FieldOffset(0x12)] public sbyte StartsWithVowel;
    [FieldOffset(0x13)] public sbyte Unknown0;
    [FieldOffset(0x14)] public sbyte Pronoun;
    [FieldOffset(0x15)] public sbyte Article;
    [FieldOffset(0x18)] public ulong ModelMain;
    [FieldOffset(0x20)] public ulong ModelSub;
    [FieldOffset(0x28)] public ushort DamagePhys;
    [FieldOffset(0x2A)] public ushort DamageMag;
    [FieldOffset(0x2C)] public ushort Delayms;
    [FieldOffset(0x2E)] public ushort BlockRate;
    [FieldOffset(0x30)] public ushort Block;
    [FieldOffset(0x32)] public ushort DefensePhys;
    [FieldOffset(0x34)] public ushort DefenseMag;
    [FieldOffset(0x36), FixedSizeArray] internal FixedSizeArray6<short> _baseParamValue;
    [FieldOffset(0x42), FixedSizeArray] internal FixedSizeArray6<short> _baseParamValueSpecial;
    [FieldOffset(0x4E)] public byte LevelEquip;
    [FieldOffset(0x4F)] public byte RequiredPvpRank;
    [FieldOffset(0x50)] public byte EquipRestriction;
    /// <remarks>ClassJobCategory</remarks>
    [FieldOffset(0x51)] public byte ClassJobCategory;
    /// <remarks>GrandCompany</remarks>
    [FieldOffset(0x52)] public byte GrandCompany;
    /// <remarks>ItemSeries</remarks>
    [FieldOffset(0x53)] public byte ItemSeries;
    [FieldOffset(0x54)] public byte BaseParamModifier;
    /// <remarks>ClassJob</remarks>
    [FieldOffset(0x55)] public byte ClassJobUse;
    [FieldOffset(0x56)] public byte Unknown2;
    [FieldOffset(0x57)] public byte Unknown3;
    [FieldOffset(0x58), FixedSizeArray] internal FixedSizeArray6<byte> _baseParam;
    /// <remarks>ItemSpecialBonus</remarks>
    [FieldOffset(0x5E)] public byte ItemSpecialBonus;
    [FieldOffset(0x5F)] public byte ItemSpecialBonusParam;
    [FieldOffset(0x60), FixedSizeArray] internal FixedSizeArray6<byte> _baseParamSpecial;
    [FieldOffset(0x66)] public byte MaterializeType;
    [FieldOffset(0x67)] public byte MateriaSlotCount;
    [FieldOffset(0x68)] public byte SubStatCategory;
    [FieldOffset(0x69)] public BitField69Flags BitField69;
    public bool IsAdvancedMeldingPermitted => BitField69.HasFlag(BitField69Flags.IsAdvancedMeldingPermitted);
    public bool IsPvP => BitField69.HasFlag(BitField69Flags.IsPvP);
    public bool IsGlamorous => BitField69.HasFlag(BitField69Flags.IsGlamorous);
    [FieldOffset(0x70)] public uint AdditionalData;
    [FieldOffset(0x74)] public uint StackSize;
    [FieldOffset(0x78)] public uint PriceMid;
    [FieldOffset(0x7C)] public uint PriceLow;
    /// <remarks>ItemRepairResource</remarks>
    [FieldOffset(0x80)] public int ItemRepair;
    /// <remarks>Item</remarks>
    [FieldOffset(0x84)] public int ItemGlamour;
    [FieldOffset(0x88)] public ushort Icon;
    /// <remarks>ItemLevel</remarks>
    [FieldOffset(0x8A)] public ushort LevelItem;
    [FieldOffset(0x8C)] public ushort Unknown4;
    /// <remarks>ItemAction</remarks>
    [FieldOffset(0x8E)] public ushort ItemAction;
    [FieldOffset(0x90)] public ushort Cooldowns;
    [FieldOffset(0x92)] public ushort Desynth;
    [FieldOffset(0x94)] public ushort AetherialReduce;
    [FieldOffset(0x96)] public byte Rarity;
    [FieldOffset(0x97)] public byte FilterGroup;
    /// <remarks>ItemUICategory</remarks>
    [FieldOffset(0x98)] public byte ItemUICategory;
    /// <remarks>ItemSearchCategory</remarks>
    [FieldOffset(0x99)] public byte ItemSearchCategory;
    /// <remarks>EquipSlotCategory</remarks>
    [FieldOffset(0x9A)] public byte EquipSlotCategory;
    /// <remarks>ItemSortCategory</remarks>
    [FieldOffset(0x9B)] public byte ItemSortCategory;
    [FieldOffset(0x9C)] public byte DyeCount;
    [FieldOffset(0x9D)] public byte CastTimeSeconds;
    /// <remarks>ClassJob</remarks>
    [FieldOffset(0x9E)] public byte ClassJobRepair;
    [FieldOffset(0x9F)] public BitField9FFlags BitField9F;
    public bool IsUnique => BitField9F.HasFlag(BitField9FFlags.IsUnique);
    public bool IsUntradable => BitField9F.HasFlag(BitField9FFlags.IsUntradable);
    public bool IsIndisposable => BitField9F.HasFlag(BitField9FFlags.IsIndisposable);
    public bool Lot => BitField9F.HasFlag(BitField9FFlags.Lot);
    public bool CanBeHq => BitField9F.HasFlag(BitField9FFlags.CanBeHq);
    public bool IsCrestWorthy => BitField9F.HasFlag(BitField9FFlags.IsCrestWorthy);
    public bool IsCollectable => BitField9F.HasFlag(BitField9FFlags.IsCollectable);
    public bool AlwaysCollectable => BitField9F.HasFlag(BitField9FFlags.AlwaysCollectable);

    [Flags]
    public enum BitField69Flags : byte {
    	IsAdvancedMeldingPermitted = 1 << 0,
    	IsPvP = 1 << 1,
    	IsGlamorous = 1 << 2,
    }
    [Flags]
    public enum BitField9FFlags : byte {
    	IsUnique = 1 << 0,
    	IsUntradable = 1 << 1,
    	IsIndisposable = 1 << 2,
    	Lot = 1 << 3,
    	CanBeHq = 1 << 4,
    	IsCrestWorthy = 1 << 5,
    	IsCollectable = 1 << 6,
    	AlwaysCollectable = 1 << 7,
    }
}

// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0xEC)]
public unsafe partial struct SatisfactionNpc {
    [FieldOffset(0x00), FixedSizeArray] internal FixedSizeArray6<SatisfactionNpcParamsStruct> _satisfactionNpcParams;
    [FieldOffset(0x90)] public int Unknown0;
    [FieldOffset(0x94)] public int Unknown1;
    [FieldOffset(0x98)] public int Unknown2;
    [FieldOffset(0x9C)] public int Unknown3;
    [FieldOffset(0xA0)] public int Unknown4;
    [FieldOffset(0xA4)] public int Unknown5;
    [FieldOffset(0xA8)] public int Unknown6;
    [FieldOffset(0xAC)] public int Unknown7;
    [FieldOffset(0xB0)] public int Unknown8;
    [FieldOffset(0xB4)] public int Unknown9;
    [FieldOffset(0xB8)] public int Unknown10;
    [FieldOffset(0xBC)] public int Unknown11;
    [FieldOffset(0xC0)] public int Unknown12;
    [FieldOffset(0xC4)] public int Unknown13;
    [FieldOffset(0xC8)] public int Unknown14;
    [FieldOffset(0xCC)] public int Unknown15;
    [FieldOffset(0xD0)] public int Unknown16;
    [FieldOffset(0xD4)] public int Unknown17;
    /// <remarks>ENpcResident</remarks>
    [FieldOffset(0xD8)] public int Npc;
    /// <remarks>Quest</remarks>
    [FieldOffset(0xDC)] public int QuestRequired;
    [FieldOffset(0xE0)] public int Icon;
    [FieldOffset(0xE4)] public byte LevelUnlock;
    [FieldOffset(0xE5)] public byte DeliveriesPerWeek;
    [FieldOffset(0xE6)] public byte Unknown18;
    [FieldOffset(0xE7)] public byte Unknown19;
    [FieldOffset(0xE8)] public byte Unknown20;

    [GenerateInterop]
    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public partial struct SatisfactionNpcParamsStruct {
        [FieldOffset(0x00)] public int SupplyIndex;
        [FieldOffset(0x04), FixedSizeArray] internal FixedSizeArray3<int> _item;
        [FieldOffset(0x10)] public ushort SatisfactionRequired;
        [FieldOffset(0x12), FixedSizeArray] internal FixedSizeArray3<byte> _itemCount;
        [FieldOffset(0x15), FixedSizeArray] internal FixedSizeArray3<bool> _isHQ;
    }
}

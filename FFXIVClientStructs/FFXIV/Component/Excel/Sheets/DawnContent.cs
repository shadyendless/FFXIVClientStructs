// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x3C)]
public unsafe partial struct DawnContent {
    /// <remarks>ContentFinderCondition</remarks>
    [FieldOffset(0x00)] public uint Content;
    [FieldOffset(0x04)] public uint ExpBelowExMaxLvl;
    [FieldOffset(0x08)] public uint ExpAboveExMaxLvl;
    [FieldOffset(0x0C)] public uint Unknown0;
    [FieldOffset(0x10)] public uint Unknown1;
    [FieldOffset(0x14)] public uint Unknown2;
    [FieldOffset(0x18)] public uint Unknown3;
    [FieldOffset(0x1C)] public uint Unknown4;
    [FieldOffset(0x20)] public uint Unknown5;
    [FieldOffset(0x24)] public uint Unknown6;
    [FieldOffset(0x28)] public uint Unknown7;
    [FieldOffset(0x2C)] public uint Unknown8;
    [FieldOffset(0x30)] public uint Unknown9;
    [FieldOffset(0x34)] public uint Unknown10;
    [FieldOffset(0x38)] public byte Unknown11;
    [FieldOffset(0x39)] public BitField39Flags BitField39;
    public bool Unknown12 => BitField39.HasFlag(BitField39Flags.Unknown12);
    public bool Unknown13 => BitField39.HasFlag(BitField39Flags.Unknown13);
    public bool Unknown14 => BitField39.HasFlag(BitField39Flags.Unknown14);

    [Flags]
    public enum BitField39Flags : byte {
    	Unknown12 = 1 << 0,
    	Unknown13 = 1 << 1,
    	Unknown14 = 1 << 2,
    }
}

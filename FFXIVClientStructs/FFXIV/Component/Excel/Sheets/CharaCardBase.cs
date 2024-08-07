// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x18)]
public unsafe partial struct CharaCardBase {
    [FieldOffset(0x00)] public int Name_Offset;
    [FieldOffset(0x04)] public int Image;
    /// <remarks>BannerCondition</remarks>
    [FieldOffset(0x08)] public ushort UnlockCondition;
    [FieldOffset(0x0A)] public ushort Unknown_70_1;
    [FieldOffset(0x0C)] public ushort Unknown_70_2;
    [FieldOffset(0x0E)] public ushort SortKey;
    [FieldOffset(0x10)] public byte FontColor;
    [FieldOffset(0x11)] public byte Unknown3;
    [FieldOffset(0x12)] public byte Unknown0;
    [FieldOffset(0x13)] public bool Unknown1;
    [FieldOffset(0x14)] public bool Unknown2;
}

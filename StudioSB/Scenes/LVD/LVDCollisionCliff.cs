﻿using StudioSB.Tools;

namespace StudioSB.Scenes.LVD
{
    public class LVDCollisionCliff : LVDEntry
    {
        public LVDVector2 Position { get; set; } = new LVDVector2(0, 0);

        public float Angle { get; set; } = 0;

        public int LineIndex { get; set; } = 0;

        public override void Read(BinaryReaderExt r)
        {
            base.Read(r);
            
            r.Skip(1);
            Position.X = r.ReadSingle();
            Position.Y = r.ReadSingle();
            Angle = r.ReadSingle();
            LineIndex = r.ReadInt32();
        }

        public override void Write(BinaryWriterExt writer)
        {
            base.Write(writer);

            writer.Write((byte)1);
            writer.Write(Position.X);
            writer.Write(Position.Y);
            writer.Write(Angle);
            writer.Write(LineIndex);
        }
    }
}

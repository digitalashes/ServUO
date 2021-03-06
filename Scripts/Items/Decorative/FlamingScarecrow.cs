using System;

namespace Server.Items
{
    public class FlamingScarecrow : BaseLight
    {
        public override int LabelNumber { get { return 1027732; } } // scarecrow

        [Constructable]
        public FlamingScarecrow()
            : base(0x9F33)
        {
            Duration = TimeSpan.Zero;
            Burning = false;
        }

        public override int LitItemID { get { return 0x9F34; } }
        public override int UnlitItemID { get { return 0x9F33; } }

        public FlamingScarecrow(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}

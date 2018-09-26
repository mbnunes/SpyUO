using System.Collections.ObjectModel;
using System.IO;

namespace Ultima.Spy.Packets
{
	[UltimaPacket("Mobile Query", UltimaPacketDirection.FromClient, 0x34 )]
	public class MobileQuery : UltimaPacket, IUltimaEntity
    {

        private byte _type;

        [UltimaPacketProperty]
        public byte Type
        {
            get { return _type; }
        }

        private uint _Serial;

        [UltimaPacketProperty("Serial", "0x{0:X}")]
        public uint Serial
        {
            get { return _Serial; }
        }


        protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID
			reader.ReadUInt32();
            _type = reader.ReadByte();
            _Serial = reader.ReadUInt32();
        }
	}
}

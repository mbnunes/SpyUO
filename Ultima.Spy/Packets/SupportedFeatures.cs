using System.Collections.ObjectModel;
using System.IO;

namespace Ultima.Spy.Packets
{
	[UltimaPacket("Supported Features", UltimaPacketDirection.FromServer, 0xB9 )]
	public class SupportedFeatures : UltimaPacket
	{
		private uint _flags;

		[UltimaPacketProperty]
		public uint Flags
        {
			get { return _flags; }
		}

        protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID
			_flags = reader.ReadUInt32();
        }
	}
}

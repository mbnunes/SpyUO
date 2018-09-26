using System.Collections.ObjectModel;
using System.IO;

namespace Ultima.Spy.Packets
{
	[UltimaPacket("OPL Info", UltimaPacketDirection.FromServer, 0xDC )]
	public class OPLInfo : UltimaPacket, IUltimaEntity
	{
		private uint _Serial;

		[UltimaPacketProperty( "Serial", "0x{0:X}" )]
		public uint Serial
		{
			get { return _Serial; }
		}

		private uint _Hash;

		[UltimaPacketProperty]
		public uint Hash
		{
			get { return _Hash; }
		}

		protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID
			_Serial = reader.ReadUInt32();
			_Hash = reader.ReadUInt32();
		}
	}
}

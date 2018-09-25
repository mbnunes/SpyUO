using System.Collections.ObjectModel;
using System.IO;

namespace Ultima.Spy.Packets
{
	[UltimaPacket("Play Server", UltimaPacketDirection.FromClient, 0xA0 )]
	public class PlayServer : UltimaPacket
	{
		private int _serverIndex;

		[UltimaPacketProperty]
		public int serverIndex
        {
			get { return _serverIndex; }
		}

		protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID
			_serverIndex = reader.ReadInt16();
		}
	}
}

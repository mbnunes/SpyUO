using System.Collections.ObjectModel;
using System.IO;

namespace Ultima.Spy.Packets
{
	[UltimaPacket("Play Server Accept", UltimaPacketDirection.FromServer, 0x8C )]
	public class PlayServerAccept : UltimaPacket
	{
		private uint _serverIP;

		[UltimaPacketProperty]
		public uint serverIP
        {
			get { return _serverIP; }
		}

        private uint _serverPort;

        [UltimaPacketProperty]
        public uint serverPort
        {
            get { return _serverPort; }
        }

        private uint _authID;

        [UltimaPacketProperty]
        public uint authID
        {
            get { return _authID; }
        }

        protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID
            _serverIP   = reader.ReadUInt32();
            _serverPort = reader.ReadUInt16();
            _authID = reader.ReadUInt32();
        }

	}
}

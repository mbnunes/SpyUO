using System.Collections.ObjectModel;
using System.IO;

namespace Ultima.Spy.Packets
{
	[UltimaPacket("UO3D Client Type", UltimaPacketDirection.FromClient, 0xE1 )]
	public class UO3DClientType : UltimaPacket
	{
		private int _size;

		[UltimaPacketProperty]
		public int Size
        {
			get { return _size; }
		}

        private uint _clientType;

        [UltimaPacketProperty]
        public uint ClientType
        {
            get { return _clientType; }
        }


        protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID
			_size = reader.ReadInt16();
            reader.ReadInt16();
            _clientType = reader.ReadUInt32();
        }
	}
}

using System.Collections.ObjectModel;
using System.IO;

namespace Ultima.Spy.Packets
{
	[UltimaPacket("UO3D Mobile New Health Bar Status", UltimaPacketDirection.FromServer, 0x16 )]
	public class UO3DMobileNewHealthBarStatus : UltimaPacket, IUltimaEntity
	{
		private uint _Serial;

		[UltimaPacketProperty( "Serial", "0x{0:X}" )]
		public uint Serial
		{
			get { return _Serial; }
		}

		private int _size;

		[UltimaPacketProperty]
		public int Size
		{
			get { return _size; }
		}

        private int _Extended;

        [UltimaPacketProperty]
        public int Extended
        {
            get { return _Extended; }
        }

        private int _StatusColor;

        [UltimaPacketProperty]
        public int StatusColor
        {
            get { return _StatusColor; }
        }

        private byte _Flag;

        [UltimaPacketProperty]
        public int Flag
        {
            get { return _Flag; }
        }

        protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID
            _size = reader.ReadInt16();
			_Serial = reader.ReadUInt32();
            _Extended = reader.ReadInt16();
            _StatusColor = reader.ReadInt16();
            _Flag = reader.ReadByte();
        }
	}
}

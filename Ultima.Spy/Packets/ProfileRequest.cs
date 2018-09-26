using System.Collections.ObjectModel;
using System.IO;

namespace Ultima.Spy.Packets
{
	[UltimaPacket("Profile Request", UltimaPacketDirection.FromClient, 0xB8 )]
	public class ProfileRequest : UltimaPacket, IUltimaEntity
    {
        private uint _Serial;

        [UltimaPacketProperty("Serial", "0x{0:X}")]
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

        private int _LengthText;

        [UltimaPacketProperty]
        public int LengthText
        {
            get { return _LengthText; }
        }

        private byte _Mode;

        [UltimaPacketProperty]
        public byte Mode
        {
            get { return _Mode; }
        }

        private string _Text;

        [UltimaPacketProperty("Text")]
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }


        protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID
			_size = reader.ReadInt16();
            _Mode = reader.ReadByte();
            _Serial = reader.ReadUInt32();
            _LengthText = reader.ReadInt16();
            _Text = reader.ReadUnicodeString();
        }
	}
}

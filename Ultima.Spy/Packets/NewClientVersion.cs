using System.IO;
using System.Text;

namespace Ultima.Spy.Packets
{
	[UltimaPacket( "New Client Version", UltimaPacketDirection.FromClient, 0xEF )]
	public class NewClientVersionPacket : UltimaPacket, IUltimaEntity
	{
		private uint _Serial;

		[UltimaPacketProperty( "Serial", "0x{0:X}" )]
		public uint Serial
		{
			get { return _Serial; }
		}	

        private int _Ip;

        [UltimaPacketProperty("IP")]
        public int Ip
        {
            get { return _Ip; }
        }

        private int _Major;

        [UltimaPacketProperty("Major")]
        public int Major
        {
            get { return _Major; }
        }

        private int _Minor;

        [UltimaPacketProperty("Minor")]
        public int Minor
        {
            get { return _Minor; }
        }

        private int _Revision;

        [UltimaPacketProperty("Revision")]
        public int Revision
        {
            get { return _Revision; }
        }

        private int _Build;

        [UltimaPacketProperty("Build")]
        public int Build
        {
            get { return _Build; }
        }

        protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID
            _Serial = reader.ReadUInt32();
            _Ip = reader.ReadInt32(); // IP
            _Major = reader.ReadInt32(); // Version Major
            _Minor = reader.ReadInt32(); // Version Minor
            _Revision = reader.ReadInt32(); // Version Revision
            _Build = reader.ReadInt32(); // Version Build
        }
	}
}

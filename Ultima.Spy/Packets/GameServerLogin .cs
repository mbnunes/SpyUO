using System.Collections.ObjectModel;
using System.IO;

namespace Ultima.Spy.Packets
{
	[UltimaPacket("Game Server Login", UltimaPacketDirection.FromClient, 0x91 )]
	public class GameServerLogin : UltimaPacket
	{
		private uint _authId;

		[UltimaPacketProperty]
		public uint authId
        {
			get { return _authId; }
		}

        private string _accountName;

        [UltimaPacketProperty("Account Name")]
        public string AccountName
        {
            get { return _accountName; }
            set { _accountName = value; }
        }

        private string _password;

        [UltimaPacketProperty("Password")]
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID
			_authId = reader.ReadUInt32();
            _accountName = reader.ReadAsciiString(30);
            _password = reader.ReadAsciiString(30);
        }
	}
}

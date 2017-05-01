using System.IO;
using System.Text;

namespace Ultima.Spy.Packets
{
	[UltimaPacket( "New Create Char", UltimaPacketDirection.FromClient, 0xF8 )]
	public class NewCreateCharacterPacket : UltimaPacket
	{
		private uint _Unk1;

		[UltimaPacketProperty( "Unknow1")]
		public uint Unk1
		{
			get { return _Unk1; }
		}	

        private uint _Unk2;

        [UltimaPacketProperty("Unknow2")]
        public uint Unk2
        {
            get { return _Unk2; }
        }

        private int _Unk3;

        [UltimaPacketProperty("Unknow3")]
        public int Unk3
        {
            get { return _Unk3; }
        }

        private string _CharName;

        [UltimaPacketProperty("Name")]
        public string CharName
        {
            get { return _CharName; }
            set { _CharName = value; }
        }

        private int _Unk4;

        [UltimaPacketProperty("Unknow4")]
        public int Unk4
        {
            get { return _Unk4; }
        }

        private uint _Flags;

        [UltimaPacketProperty("Flags")]
        public uint Flags
        {
            get { return _Flags; }
        }

        private uint _Unk5;

        [UltimaPacketProperty("Unknow5")]
        public uint Unk5
        {
            get { return _Unk5; }
        }

        private uint _LoginCount;

        [UltimaPacketProperty("LoginCount")]
        public uint LoginCount
        {
            get { return _LoginCount; }
        }

        private int _Profession;

        [UltimaPacketProperty("Profession")]
        public int Profession
        {
            get { return _Profession; }
        }

        private int _GenderAndRace;

        [UltimaPacketProperty("GenderAndRace")]
        public int GenderAndRace
        {
            get { return _GenderAndRace; }
        }

        private int _Strength;

        [UltimaPacketProperty("Strength")]
        public int Strength
        {
            get { return _Strength; }
        }

        private int _Dexterity;

        [UltimaPacketProperty("Dexterity")]
        public int Dexterity
        {
            get { return _Dexterity; }
        }

        private int _Intelligence;

        [UltimaPacketProperty("Intelligence")]
        public int Intelligence
        {
            get { return _Intelligence; }
        }

        private int _Skill1;

        [UltimaPacketProperty("Skill1")]
        public int Skill1
        {
            get { return _Skill1; }
        }

        private int _Skill1Amount;

        [UltimaPacketProperty("Skill1 Amount")]
        public int Skill1Amount
        {
            get { return _Skill1Amount; }
        }

        private int _Skill2;

        [UltimaPacketProperty("Skill2")]
        public int Skill2
        {
            get { return _Skill2; }
        }

        private int _Skill2Amount;

        [UltimaPacketProperty("Skill2 Amount")]
        public int Skill2Amount
        {
            get { return _Skill2Amount; }
        }

        private int _Skill3;

        [UltimaPacketProperty("Skill3")]
        public int Skill3
        {
            get { return _Skill3; }
        }

        private int _Skill3Amount;

        [UltimaPacketProperty("Skill3 Amount")]
        public int Skill3Amount
        {
            get { return _Skill3Amount; }
        }

        private int _Skill4;

        [UltimaPacketProperty("Skill4")]
        public int Skill4
        {
            get { return _Skill4; }
        }

        private int _Skill4Amount;

        [UltimaPacketProperty("Skill4 Amount")]
        public int Skill4Amount
        {
            get { return _Skill4Amount; }
        }

        private int _SkinHue;

        [UltimaPacketProperty("SkinHue")]
        public int SkinHue
        {
            get { return _SkinHue; }
        }

        private int _HairStyle;

        [UltimaPacketProperty("HairStyle")]
        public int HairStyle
        {
            get { return _HairStyle; }
        }

        private int _HairHue;

        [UltimaPacketProperty("HairHue")]
        public int HairHue
        {
            get { return _HairHue; }
        }

        private int _BeardStyle;

        [UltimaPacketProperty("BeardStyle")]
        public int BeardStyle
        {
            get { return _BeardStyle; }
        }

        private int _BeardHue;

        [UltimaPacketProperty("BeardHue")]
        public int BeardHue
        {
            get { return _BeardHue; }
        }

        private int _ShardIndex;

        [UltimaPacketProperty("ShardIndex")]
        public int ShardIndex
        {
            get { return _ShardIndex; }
        }

        private int _StartingCity;

        [UltimaPacketProperty("StartingCity")]
        public int StartingCity
        {
            get { return _StartingCity; }
        }

        private uint _CharSlot;

        [UltimaPacketProperty("CharSlot")]
        public uint CharSlot
        {
            get { return _CharSlot; }
        }

        private uint _ClientIP;

        [UltimaPacketProperty("ClientIP")]
        public uint ClientIP
        {
            get { return _ClientIP; }
        }

        private int _ShirtHue;

        [UltimaPacketProperty("ShirtHue")]
        public int ShirtHue
        {
            get { return _ShirtHue; }
        }

        private int _PantsHue;

        [UltimaPacketProperty("PantsHue")]
        public int PantsHue
        {
            get { return _PantsHue; }
        }


        protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID
            _Unk1 = reader.ReadUInt32();
            _Unk2 = reader.ReadUInt32();
            _Unk3 = reader.ReadByte();
            _CharName = reader.ReadAsciiString(30);
            _Unk4 = reader.ReadInt16();
            _Flags = reader.ReadUInt32();
            _Unk5 = reader.ReadUInt32();
            _LoginCount = reader.ReadUInt32();
            _Profession = reader.ReadByte();
            reader.ReadBytes( 15 );
            _GenderAndRace = reader.ReadByte();
            _Strength = reader.ReadByte();
            _Dexterity = reader.ReadByte();
            _Intelligence = reader.ReadByte();
            _Skill1 = reader.ReadByte();
            _Skill1Amount = reader.ReadByte();
            _Skill2 = reader.ReadByte();
            _Skill2Amount = reader.ReadByte();
            _Skill3 = reader.ReadByte();
            _Skill3Amount = reader.ReadByte();
            _Skill4 = reader.ReadByte();
            _Skill4Amount = reader.ReadByte();
            _SkinHue = reader.ReadInt16();
            _HairStyle = reader.ReadInt16();
            _HairHue = reader.ReadInt16();
            _BeardStyle = reader.ReadInt16();
            _BeardHue = reader.ReadInt16();
            _ShardIndex = reader.ReadByte();
            _StartingCity = reader.ReadByte();
            _CharSlot = reader.ReadUInt32();
            _ClientIP = reader.ReadUInt32();
            _ShirtHue = reader.ReadInt16();
            _PantsHue = reader.ReadInt16();
        }
	}
}

using System.IO;
using System.Text;

namespace Ultima.Spy.Packets
{
	[UltimaPacket( "Create Char 3D", UltimaPacketDirection.FromClient, 0x8D )]
	public class CreateCharacter3D : UltimaPacket
	{
		private int _Size;

		[UltimaPacketProperty( "Size")]
		public int Size
		{
			get { return _Size; }
		}	

        private uint _Unk1;

        [UltimaPacketProperty("Unknow1")]
        public uint Unk1
        {
            get { return _Unk1; }
        }

        private uint _CharSlot;

        [UltimaPacketProperty("CharSlot")]
        public uint CharSlot
        {
            get { return _CharSlot; }
        }

        private string _CharName;

        [UltimaPacketProperty("Name")]
        public string CharName
        {
            get { return _CharName; }
            set { _CharName = value; }
        }

        private string _Unk2;

        [UltimaPacketProperty("Unknow2")]
        public string Unk2
        {
            get { return _Unk2; }
            set { _Unk2 = value; }
        }

        private int _Profession;

        [UltimaPacketProperty("Profession")]
        public int Profession
        {
            get { return _Profession; }
        }

        private int _Flags;

        [UltimaPacketProperty("Flags")]
        public int Flags
        {
            get { return _Flags; }
        }

        private int _Gender;

        [UltimaPacketProperty("Gender")]
        public int Gender
        {
            get { return _Gender; }
        }

        private int _Race;

        [UltimaPacketProperty("Race")]
        public int Race
        {
            get { return _Race; }
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

        private int _SkinColor;

        [UltimaPacketProperty("SkinColor")]
        public int SkinColor
        {
            get { return _SkinColor; }
        }

        private uint _Unk3;

        [UltimaPacketProperty("Unknown3")]
        public uint Unk3
        {
            get { return _Unk3; }
        }

        private uint _Unk4;

        [UltimaPacketProperty("Unknown4")]
        public uint Unk4
        {
            get { return _Unk4; }
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

        private int _HairHue;

        [UltimaPacketProperty("HairHue")]
        public int HairHue
        {
            get { return _HairHue; }
        }

        private int _HairStyle;

        [UltimaPacketProperty("HairStyle")]
        public int HairStyle
        {
            get { return _HairStyle; }
        }

        private int _ShirtColor;

        [UltimaPacketProperty("ShirtColor")]
        public int ShirtColor
        {
            get { return _ShirtColor; }
        }

        private int _ShirtID;

        [UltimaPacketProperty("ShirtID")]
        public int ShirtID
        {
            get { return _ShirtID; }
        }

        private int _FaceColor;

        [UltimaPacketProperty("FaceColor")]
        public int FaceColor
        {
            get { return _FaceColor; }
        }

        private int _FaceID;

        [UltimaPacketProperty("FaceID")]
        public int FaceID
        {
            get { return _FaceID; }
        }

        private int _BeardHue;

        [UltimaPacketProperty("BeardHue")]
        public int BeardHue
        {
            get { return _BeardHue; }
        }

        private int _BeardStyle;

        [UltimaPacketProperty("BeardStyle")]
        public int BeardStyle
        {
            get { return _BeardStyle; }
        }    

        protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID
            _Size = reader.ReadUInt16();
            _Unk1 = reader.ReadUInt32();
            _CharSlot = reader.ReadUInt32();
            _CharName = reader.ReadAsciiString(30);
            _Unk2 = reader.ReadAsciiString(30);
            _Profession = reader.ReadByte();
            _Flags = reader.ReadByte();
            _Gender = reader.ReadByte();
            _Race = reader.ReadByte();
            _Strength = reader.ReadByte();
            _Dexterity = reader.ReadByte();
            _Intelligence = reader.ReadByte();
            _SkinColor = reader.ReadUInt16();
            reader.ReadUInt32();
            reader.ReadUInt32();
            _Skill1 = reader.ReadByte();
            _Skill1Amount = reader.ReadByte();
            _Skill2 = reader.ReadByte();
            _Skill2Amount = reader.ReadByte();
            _Skill3 = reader.ReadByte();
            _Skill3Amount = reader.ReadByte();
            _Skill4 = reader.ReadByte();
            _Skill4Amount = reader.ReadByte();
            reader.ReadBytes(25);
            reader.ReadByte();
            _HairHue = reader.ReadInt16();
            _HairStyle = reader.ReadUInt16();
            reader.ReadByte();
            reader.ReadUInt32();
            reader.ReadByte();
            _ShirtColor = reader.ReadUInt16();
            _ShirtID = reader.ReadUInt16();
            reader.ReadByte();
            _FaceColor = reader.ReadUInt16();
            _FaceID = reader.ReadUInt16();
            reader.ReadByte();
            _BeardHue = reader.ReadInt16();
            _BeardStyle = reader.ReadInt16();
        }
	}
}

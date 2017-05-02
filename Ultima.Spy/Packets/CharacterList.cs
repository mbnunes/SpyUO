using System.Collections.ObjectModel;
using System.IO;
using System.Collections.Generic;

namespace Ultima.Spy.Packets
{
	[UltimaPacket( "CharacterList", UltimaPacketDirection.FromServer, 0xA9 )]
	public class CharacterListPacket : UltimaPacket
	{
		private int _Size;

		[UltimaPacketProperty( "Size")]
		public int Size
		{
			get { return _Size; }
		}

        private List<string> _CharName;

        [UltimaPacketProperty]
        public List<string> CharName
        {
            get { return _CharName; }
        }

        private List<CitiesInfo> _CitiesInfo;

        [UltimaPacketProperty("Cities Info")]
        public List<CitiesInfo> CitiesInfo
        {
            get { return _CitiesInfo; }
        }

        private uint _Flags;

        [UltimaPacketProperty("Flags")]
        public uint Flags
        {
            get { return _Flags; }
        }

        private int _LastCharSlot;

		[UltimaPacketProperty("Last Character Slot")]
		public int LastCharSlot
        {
			get { return _LastCharSlot; }
		}       

		protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID
			_Size = reader.ReadInt16();
            byte count = reader.ReadByte();
            _CharName = new List<string>();

            if (count != 0)
            {
                for (int i = 0; i < count; ++i)
                {
                    _CharName.Add(reader.ReadAsciiString(30));
                    reader.Fill(30);
                }
            }else
            {
                count = 7;
                for (int i = 0; i < count; ++i)
                {
                    reader.Fill(60);                    
                }
            }

            byte citiesCount = reader.ReadByte();
            _CitiesInfo = new List<CitiesInfo>();

            for (int j = 0; j < citiesCount; ++j)
            {
                _CitiesInfo.Add(new CitiesInfo(this, reader));
            }

			_Flags = reader.ReadUInt32();
			_LastCharSlot = reader.ReadInt16();

		}
	}

    public class CitiesInfo
    {
        private UltimaPacket _Parent;

        public UltimaPacket Parent
        {
            get { return _Parent; }
        }

        private byte _CitieIndex;

        [UltimaPacketProperty("Index")]
        public byte CitieIndex
        {
            get { return _CitieIndex; }
        }

        private string _CitieName;

        [UltimaPacketProperty("City Name")]
        public string CitieName
        {
            get { return _CitieName; }
            set { _CitieName = value; }
        }

        private string _BuildingName;

        [UltimaPacketProperty("Build Name")]
        public string BuildingName
        {
            get { return _BuildingName; }
            set { _BuildingName = value; }
        }

        private uint _X;

        [UltimaPacketProperty("X")]
        public uint X
        {
            get { return _X; }
        }
        private uint _Y;

        [UltimaPacketProperty("Y")]
        public uint Y
        {
            get { return _Y; }
        }
        private uint _Z;

        [UltimaPacketProperty("Z")]
        public uint Z
        {
            get { return _Z; }
        }
        private uint _Map;

        [UltimaPacketProperty("Map")]
        public uint Map
        {
            get { return _Map; }
        }

        private uint _Cliloc;

        [UltimaPacketProperty("Cliloc")]
        public uint Cliloc
        {
            get { return _Cliloc; }
        }

        public CitiesInfo(UltimaPacket parent, BigEndianReader reader)
        {
            _Parent = parent;
            _CitieIndex = reader.ReadByte();
            _CitieName = reader.ReadAsciiString(32);
            _BuildingName = reader.ReadAsciiString(32);
            _X = reader.ReadUInt32();
            _Y = reader.ReadUInt32();
            _Z = reader.ReadUInt32();
            _Map = reader.ReadUInt32();
            _Cliloc = reader.ReadUInt32();
            uint unk = reader.ReadUInt32();
            
        }

    }
}

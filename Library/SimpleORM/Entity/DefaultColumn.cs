using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace faturamento.Library.SimpleORM.Entity
{
	class DefaultColumn
	{
		private String _name;
		private bool   _key;
		private String _type;
		private String _mappedName;
		private String _value;
		private String _formattedValue;
		private bool _increment;

		public String Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}

		public bool Key
		{
			get
			{
				return _key;
			}
			set
			{
				_key = value;
			}
		}

		public string Type
		{
			get
			{
				return _type;
			}
			set
			{
				_type = value;
			}
		}
		public string MappedName 
		{
			get
			{
				return _mappedName;
			}
			set
			{
				_mappedName = value;
			}
		}
		public string Value
		{
			get
			{
				return _value;
			}
			set
			{
				_value = value;
				_formattedValue = "'" & _value & "'";
			}
		}

		public string FormattedValue
		{
			get
			{
				return _formattedValue;
			}
			set
			{
				_formattedValue = value;
			}
		}

		public bool Increment
		{
			get
			{
				return _increment;
			}
			set
			{
				_increment = value;
			}
		}

		public DefaultColumn(String Name, String MappedName, String Type, bool Key, bool Increment)
		{
			Init(Name, MappedName, Type, Key, false, Increment);
		}

		public DefaultColumn (String Name, String MappedName, String Type, bool Key ) 
		{
			Init(Name, MappedName, Type, Key , false);
		}

		public DefaultColumn(String Name, String MappedName, String Type)
		{
			Init(Name, MappedName, Type, false, false);
		}

		public DefaultColumn(String Name)
		{
			Init(Name, Name, "String", false, false); 
		}

		private void Init (String Name, String MappedName, String Type, bool Key, bool Increment) {
			this._name = Name;
			this._key = Key;
			this._type = Type;
			this._mappedName = MappedName;
			this.FormattedValue = "''";
			this.Increment = false;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace faturamento.Library.SimpleORM.Entity
{
	abstract class DefaultEntity
	{
		private string _SQL;
		private string _WHERE;
		protected string Table;
		protected List<DefaultColumn> Columns;

		private string refreshKeyValues () 
		{
			bool existKey = false;
			_WHERE = "";

			foreach (DefaultColumn Column in Columns) {
				if (Column.Key == true) {
					existKey = true;
					break;
				}
			}

			foreach (DefaultColumn Column in Columns) {
				if (existKey == false || Column.Key == true ) {
					if (len(trim(_WHERE)) > 0) {
						_WHERE = _WHERE & " AND"; 
					}
					_WHERE = " " & Column.MappedName & "=" & Column.FormattedValue;
				}
			}
			if (len(trim(_WHERE)) > 0) {
				_WHERE = " WHERE " & _WHERE;
			}
		}

		public virtual bool Delete()
		{
			refreshKeyValues 
			_SQL = "DELETE FROM " & Table & _WHERE ;
			return true;
		}

		public virtual bool Save()
		{
			refreshKeyValues 
			_SQL = "SELECT * FROM " & _WHERE;
 			return true;
		}
	}
}

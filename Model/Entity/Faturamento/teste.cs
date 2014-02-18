using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using faturamento.Library.SimpleORM.Entity;

namespace faturamento.Entity.Faturamento
{
	class teste : DefaultEntity 
	{
		int CODIGO = 0;
		int NOME   = 1; 

		public teste()
		{
			this.Table = "CLIENTE";
			this.Columns.Add(new DefaultColumn("CODIGO","COD_CLIENTE","STRING",true,true));
			this.Columns.Add(new DefaultColumn("NOME"));  
		}

		public String Codigo
		{
			get
			{
				return this.Columns[CODIGO].Value;
			}
			set
			{
				this.Columns[CODIGO].Value = value;
			}
		}

		public String Nome
		{
			get
			{	
				return this.Columns[NOME].Value;
			}
			set
			{
				this.Columns[NOME].Value = value;
			}
		}

	}
}
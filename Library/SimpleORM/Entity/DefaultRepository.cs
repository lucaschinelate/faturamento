using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace faturamento.Library.SimpleORM.Entity
{
	abstract class DefaultRepository
	{
		public virtual DefaultEntity findOneBy()
		{
		}
		public virtual DefaultEntity[] findBy()
		{
		}

	}
}

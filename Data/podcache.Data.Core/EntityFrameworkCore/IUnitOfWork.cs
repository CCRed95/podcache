using System;
using Microsoft.EntityFrameworkCore.Storage;
using podcache.Data.Core.EntityFrameworkCore.Infrastucture;

namespace podcache.Data.Core.EntityFrameworkCore
{
	public interface IUnitOfWork
    : IDisposable
	{
		IRepository<TSet> GetRepositoryBase<TSet>() 
			where TSet 
        : EntityBase;

	  IDbContextTransaction BeginTransaction();

		int Save();
	}
}

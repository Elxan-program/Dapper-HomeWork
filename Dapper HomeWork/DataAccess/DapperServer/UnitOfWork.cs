using Dapper_HomeWork.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_HomeWork.DataAccess.DapperServer
{
    public class UnitOfWork : IUnitOfWork
    {
        public IBookRepository BookRepository => new BookRepository();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_HomeWork.Domain.Abstractions
{
    public interface IUnitOfWork
    {
        IBookRepository BookRepository { get; }
    }
}

using System.Data;
using System.Data.Common;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Infrastructure;

public struct DapperCommand
{
    public DapperCommand(DbTransaction transaction, string sql, object? vars = null)
    {
        var commandType = CommandType.Text;

        Definition = new CommandDefinition(
            sql,
            vars,
            transaction,
            null,
            commandType
        );
    }
    public CommandDefinition Definition { get; }
}

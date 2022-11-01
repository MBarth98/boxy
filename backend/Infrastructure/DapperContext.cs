using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Infrastructure;

public static class DapperContext
{
    public static async Task<IEnumerable<T>> QueryAsync<T>(this DbContext _EFCore_Context, string sql, object? parameters = null)
    {
        // get the connection from the EFCore context
        var connection = _EFCore_Context.Database.GetDbConnection();
        
        // Get the EF Core transaction from the EF Core context
        var transaction = _EFCore_Context.Database.CurrentTransaction?.GetDbTransaction() ?? throw new InvalidOperationException("No transaction found");

        // build the dapper command
        var command = new DapperCommand( transaction, sql, parameters);

        // execute the command using dapper
        return await connection.QueryAsync<T>(command.Definition);
    }

    public static async Task<int> ExecuteAsync(this DbContext _EFCore_Context, string sql, object? parameters = null)
    {
        var connection  = _EFCore_Context.Database.GetDbConnection();
        var transaction = _EFCore_Context.Database.CurrentTransaction?.GetDbTransaction() ?? throw new InvalidOperationException("No transaction found");
    
        var command = new DapperCommand( transaction, sql, parameters);

        return await connection.ExecuteAsync(command.Definition);
    }
}

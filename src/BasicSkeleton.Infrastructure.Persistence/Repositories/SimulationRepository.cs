using System.Data;
using BasicSkeleton.Domain.Entities;
using BasicSkeleton.Domain.Repositories;
using BasicSkeleton.Infra.Queries;
using Dapper;

namespace BasicSkeleton.Infra.Database.Repositories;

public class SimulationRepository(
    IDbConnection dbConnection
) : ISimulationRepository
{
    public async Task<Simulation> Save(Simulation simulation)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Simulation>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Simulation>> GetAllByDocumentAndCreationDate(string document, DateTime creationDate)
    {
        var query = SimulationQueries.GetSimulationsByDocumentAndCreationDate;
        
        var simulations = await dbConnection.QueryAsync<IEnumerable<Simulation>>(query, new
        {
            document,
            creationDate
        });

        return simulations;
    }

    public async Task<Simulation?> GetById(string simulationId)
    {
        throw new NotImplementedException();
    }
}
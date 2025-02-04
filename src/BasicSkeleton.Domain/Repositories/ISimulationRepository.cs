using BasicSkeleton.Domain.Entities;

namespace BasicSkeleton.Domain.Repositories;

public interface ISimulationRepository
{
    public Task<Simulation> Save(Simulation simulation);

    public Task<IEnumerable<Simulation>> GetAll();
    
    public Task<IEnumerable<Simulation>> GetAllByDocumentAndCreationDate(string document, DateTime creationDate);

    public Task<Simulation?> GetById(string simulationId);
}
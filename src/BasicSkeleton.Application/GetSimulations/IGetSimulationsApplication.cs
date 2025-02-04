using BasicSkeleton.Domain.Entities;

namespace BasicSkeleton.Application.GetSimulations;

public interface IGetSimulationsApplication
{
    public Task<IEnumerable<Simulation>> GetAll();
}
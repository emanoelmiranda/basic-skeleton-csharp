using BasicSkeleton.Domain.Entities;
using BasicSkeleton.Domain.Repositories;
using Microsoft.Extensions.Logging;

namespace BasicSkeleton.Application.GetSimulations;

public class GetSimulationsApplication(
    ILogger<GetSimulationsApplication> logger,
    ISimulationRepository simulationRepository
) : IGetSimulationsApplication
{
    public async Task<IEnumerable<Simulation>> GetAll()
    {
        logger.LogInformation("Getting simulations...");
        return await simulationRepository.GetAll();
    }
}
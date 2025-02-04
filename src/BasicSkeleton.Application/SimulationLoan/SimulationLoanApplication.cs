using BasicSkeleton.Domain.Entities;
using BasicSkeleton.Domain.Repositories;
using BasicSkeleton.Domain.Validations;
using FluentResults;
using Microsoft.Extensions.Logging;

namespace BasicSkeleton.Application.SimulationLoan;

public class SimulationLoanApplication(
    ILogger<SimulationLoanApplication> logger,
    ISimulationRepository simulationRepository,
    SimulationValidator simulationValidator
) : ISimulationLoanApplication
{
    public async Task<Result<Simulation>> Simulate()
    {
        logger.LogInformation("Simulating loan...");

        try
        {
            var simulation = new Simulation();
            
            await simulationValidator.ValidateAsync(simulation);
        
            var result = await simulationRepository.Save(simulation);

            return Result.Ok(result);
        }
        catch (Exception e)
        {
            logger.LogError($"Occurred an error while trying perform simulation! error: {e.Message}");
            return Result.Fail(e.Message);
        }
    }
}
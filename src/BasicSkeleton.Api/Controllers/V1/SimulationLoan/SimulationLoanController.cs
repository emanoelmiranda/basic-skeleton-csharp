using BasicSkeleton.Application.GetSimulations;
using BasicSkeleton.Application.SimulationLoan;
using BasicSkeleton.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BasicSkeletonApi.Controllers.V1.SimulationLoan;

[ApiController]
[Route("api/[controller]")]
public class SimulationLoanController(
    ISimulationLoanApplication simulationLoanApplication,
    IGetSimulationsApplication getSimulationsApplication
) : ControllerBase
{
    [HttpGet]
    public async ActionResult<IEnumerable<Simulation>> GetSimulations()
    {
        var simulations = await getSimulationsApplication.GetAll();
        return simulations;
    }

    [HttpGet("{id}")]
    public async ActionResult<string> GetSimulation(string id)
    {
        return $"Simulation {id}";
    }

    [HttpPost]
    public async ActionResult<Simulation> Simulate()
    {
        var simulation = await simulationLoanApplication.Simulate();

        return simulation;
    }
}
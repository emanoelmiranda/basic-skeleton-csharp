using BasicSkeleton.Application.SimulationLoan;
using Microsoft.AspNetCore.Mvc;

namespace BasicSkeletonApi.Controllers.V1.SimulationLoan;

[ApiController]
[Route("api/[controller]")]
public class SimulationLoanController(
    // ISimulationLoanApplication simulationLoanApplication
) : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<string>> GetSimulations()
    {
        return new[] { "Simulation1", "Simulation2" };
    }

    [HttpGet("{id}")]
    public ActionResult<string> GetSimulation(string id)
    {
        return $"Simulation {id}";
    }
}
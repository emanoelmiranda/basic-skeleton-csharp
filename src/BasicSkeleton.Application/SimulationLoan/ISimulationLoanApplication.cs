using BasicSkeleton.Domain.Entities;
using FluentResults;

namespace BasicSkeleton.Application.SimulationLoan;

public interface ISimulationLoanApplication
{
    public Task<Result<Simulation>> Simulate();
}
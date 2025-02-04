namespace BasicSkeleton.Infra.Queries;

public static class SimulationQueries
{
    public const string GetSimulationsByDocumentAndCreationDate = 
        """
        SELECT * FROM schema.simulations s WHERE 
            s.document=@Document AND 
            s.creation_date = @creationDate
        ORDER BY creation_date DESC
        """;
}
namespace Project.Domain.Enums
{
    public enum ProjectStatus
    {
        Draft,        // Created but not published
        Open,         // Accepting requests
        InProgress,   // Someone working on it
        Completed,    // Finished
        Cancelled     // Abandoned or removed
    }
}

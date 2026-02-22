using SIMP.Domain.Enums;

namespace SIMP.Domain.Entities;

public class Incident
{
    public Guid Id { get; private set; }
    public string Title { get; private set; } = IncidentConstants.DEFAULT_TITLE;
    public string Description { get; private set; } = IncidentConstants.DEFAUTL_DESCRIPTION;

    public IncidentSeverity Severity { get; private set; }
    public IncidentStatus Status { get; private set; }
    public DateTime CreatedAt { get; private set; }
    private Incident()
    {
    }
    public Incident(string title, string description, IncidentSeverity severity)
    {
        Id = Guid.NewGuid();
        Title = title;
        Description = description;
        Severity = severity;
        Status = IncidentStatus.Open;
        CreatedAt = DateTime.UtcNow;
    }

    public void Close()
    {
        Status = IncidentStatus.Closed;
    }
}
namespace _29_01_2026_DigitalisNyomozas;

public class CaseStatus
{
    private string status;

    public CaseStatus(string status)
    {
        this.status = status;
    }

    public string Status
    {
        get => status;
        set => status = value ?? throw new ArgumentNullException(nameof(value));
    }
}
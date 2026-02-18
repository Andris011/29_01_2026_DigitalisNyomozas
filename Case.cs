using System.Text;
using System.Linq;


namespace _29_01_2026_DigitalisNyomozas;

internal class Case
{

    private string ugyAzonosito;
    private string cim;
    private string leiras;
    private string allapot;
    private List<Person> szemelyek = new List<Person>();
    private List<Suspect> gyanusitottak = new List<Suspect>();
    private List<Witness> tanuk = new List<Witness>();
    private List<Evidence> bizonyitekok = new List<Evidence>();
    private List<TimelineEvent> idovonal = new List<TimelineEvent>();
    

    public Case(string ugyAzonosito, string cim, string leiras, string allapot)
    {
        this.ugyAzonosito = ugyAzonosito;
        this.cim = cim;
        this.leiras = leiras;
        this.allapot = allapot;
    }
    
    public string UgyAzonosito
    {
        get => ugyAzonosito;
        set => ugyAzonosito = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Cim
    {
        get => cim;
        set => cim = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Leiras
    {
        get => leiras;
        set => leiras = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Allapot
    {
        get => allapot;
        set => allapot = value ?? throw new ArgumentNullException(nameof(value));
    }

    public void AddEvidence(Evidence evidence)
    {
        bizonyitekok.Add(evidence);
    }

    public void AddWitness(Witness witness)
    {
        tanuk.Add(witness);
    }

    public void AddSuspect(Suspect suspect)
    {
        gyanusitottak.Add(suspect);
    }


    // public override string ToString()
    // {
    //     if (tanuk.Count > 0 && gyanusitottak.Count > 0 && bizonyitekok.Count > 0)
    //     {
    //         return $"azonosító: {ugyAzonosito}, cím: {cim}, leírás: {leiras}, állapot: {allapot} " +
    //                $"\n gyanúsítottak: {string.Join("\n\t", gyanusitottak)}" +
    //                $"\n tanúk: {string.Join("\n\t", tanuk)}" +
    //                $"\n bizonyítékok: {string.Join("\n\t",  bizonyitekok)}";
    //     }
    //     else if (tanuk.Count > 0 && bizonyitekok.Count == 0)
    //     {
    //         return $"azonosító: {ugyAzonosito}, cím: {cim}, leírás: {leiras}, állapot: {allapot} " +
    //                $"\n tanúk: {string.Join("\n\t", tanuk)}";
    //     }
    //     else if (gyanusitottak.Count > 0 && bizonyitekok.Count == 0)
    //     {
    //         return $"azonosító: {ugyAzonosito}, cím: {cim}, leírás: {leiras}, állapot: {allapot} " +
    //                $"\n gyanúsítottak: {string.Join("\n\t", gyanusitottak)}";
    //     }
    //     else if (gyanusitottak.Count > 0 && tanuk.Count > 0 && bizonyitekok.Count == 0)
    //     {
    //         return $"azonosító: {ugyAzonosito}, cím: {cim}, leírás: {leiras}, állapot: {allapot} " +
    //                $"\n gyanúsítottak: {string.Join("\n\t", gyanusitottak)}" +
    //                $"\n tanúk: {string.Join("\n\t", tanuk)}";
    //     }
    //     else if (gyanusitottak.Count == 0 && tanuk.Count && bizonyitekok.Count > 0)
    //     {
    //         return $"azonosító: {ugyAzonosito}, cím: {cim}, leírás: {leiras}, állapot: {allapot} " +
    //                $"\n bizonyitekok: {string.Join("\n\t", bizonyitekok)}";
    //     }
    //     else
    //     {
    //         return $"azonosító: {ugyAzonosito}, cím: {cim}, leírás: {leiras}, állapot: {allapot} ";
    //     }
    //     
    // }
    
    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine("--------------------------");
        sb.AppendLine($"Azonosító: {ugyAzonosito}");
        sb.AppendLine($"Cím: {cim}");
        sb.AppendLine($"Leírás: {leiras}");
        sb.AppendLine($"Állapot: {allapot}");
        sb.AppendLine();

        if (gyanusitottak.Any())
        {
            sb.AppendLine("Gyanúsítottak: \n\t");
            sb.AppendLine(string.Join("\n", gyanusitottak));
            sb.AppendLine();
        }

        if (tanuk.Any())
        {
            sb.AppendLine("Tanúk: \n\t");
            sb.AppendLine(string.Join("\n", tanuk));
            sb.AppendLine();
        }

        if (bizonyitekok.Any())
        {
            sb.AppendLine("Bizonyítékok:");
            sb.AppendLine(string.Join("\n", bizonyitekok));
            sb.AppendLine();
        }

        return sb.ToString();
    }


}
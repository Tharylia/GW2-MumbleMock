namespace Estreya.MumbleMock.Models;
internal class Identity
{
    public string? Name { get; set; }
    public string? Profession { get; set; }
    public string? Specialization { get; set; }

    public string? Race { get; set; }

    public string? WorldId { get; set; }
    public int TeamColorId { get; set; }

    public bool IsCommander { get; set; }
    public float FOV { get; set; }
    public string? UISize { get; set; }
}

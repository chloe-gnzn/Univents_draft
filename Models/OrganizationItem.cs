namespace Univents.Models;

public class OrganizationItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Members { get; set; }
    public int Events { get; set; }
    public string Tag { get; set; } = string.Empty;
    public string Color { get; set; } = "#c5e61c";
    public string Initial { get; set; } = string.Empty;
}

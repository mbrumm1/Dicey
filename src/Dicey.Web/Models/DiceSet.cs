namespace Dicey.Web.Models;

public class DiceSet
{
    public string Name { get; set; } = string.Empty;
    public List<Die> Dice { get; set; } = new List<Die>();
}

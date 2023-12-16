namespace Dicey.Web.Models;

public class Die
{
    public int Sides { get; set; }
    public int Value { get; set; }

    public void Reset()
    {
        Value = Sides;
    }
}

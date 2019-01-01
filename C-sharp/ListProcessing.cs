using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

public class Entry
{
    private readonly int _hour;
    private readonly double _temperature;
    public double Temperature  => _temperature;
    public int Hour  => _hour;

    public Entry(int hour, double temperature)
    {
        _hour = hour;
        _temperature = temperature;
    }
    override public string ToString() => "[" + Hour + ":00 temp = " + Temperature + " degs]";
}
public class EntryTest {
    double c2f(double celsius) => 1.8*celsius+32;
    public ImmutableList<Entry> ImmutableLogProcessor(IEnumerable<Entry> entries) => entries
        .Where((entry) => entry.Hour < 17)
        .Select((entry) => new Entry(entry.Hour, c2f(entry.Temperature)))
        .ToImmutableList();
}
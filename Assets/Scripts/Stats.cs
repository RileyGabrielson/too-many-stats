using System.Collections.Generic;

public interface StatStorage {
    public Stat GetStat(string name);
}


public class Stats: StatStorage
{
    private List<Stat> statsList;

    public Stats() {
        this.statsList = new List<Stat>();
    }

    public void AddStat(Stat stat) {
        this.statsList.Add(stat);
    }

    public Stat GetStat(string name) {
        var stat = this.statsList.Find(stat => stat.GetName() == name);
        return stat;
    }
}

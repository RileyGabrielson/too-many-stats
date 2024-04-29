using System.Collections.Generic;
using Unity.VisualScripting;

public interface StatStorage {
    public Stat GetStat(string name);
    public List<Stat> GetAllStats();
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

    public List<Stat> GetAllStats() {
        return this.statsList;
    }
}

using System.Collections.Generic;

public class RunStats: StatStorage {
    public static string MovementSpeed = "speed";
    public static string JumpHeight = "jump height";
    public static string NumJumps = "num jumps";
    public static string AttackSpeed = "attack speed";

    private Stats baseStats;

    public RunStats() {
        this.baseStats = new Stats();

        Stat movementSpeed = new Stat(RunStats.MovementSpeed, 0, new MultiplicativeProgression(1));
        this.baseStats.AddStat(movementSpeed);

        Stat jumpHeight = new Stat(RunStats.JumpHeight, 0, new MultiplicativeProgression(1));
        this.baseStats.AddStat(jumpHeight);

        Stat numJumps = new Stat(RunStats.NumJumps, 0, new MultiplicativeProgression(1));
        this.baseStats.AddStat(numJumps);

        Stat attackSpeed = new Stat(RunStats.AttackSpeed, 0, new MultiplicativeProgression(1));
        this.baseStats.AddStat(attackSpeed);
    }

    public Stat GetStat(string name) {
        return this.baseStats.GetStat(name);
    }

    public List<Stat> GetAllStats() {
        return this.baseStats.GetAllStats();
    }
}
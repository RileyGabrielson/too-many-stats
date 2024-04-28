public class RunStats: StatStorage {
    public static string MovementSpeed = "speed";
    public static string JumpHeight = "jump height";
    public static string AttackSpeed = "attack speed";

    private Stats baseStats;

    public RunStats() {
        this.baseStats = new Stats();

        Stat movementSpeed = new Stat(RunStats.MovementSpeed, 0, new MultiplicativeProgression(1));
        this.baseStats.AddStat(movementSpeed);

        Stat jumpHeight = new Stat(RunStats.JumpHeight, 0, new MultiplicativeProgression(1));
        this.baseStats.AddStat(jumpHeight);

        Stat attackSpeed = new Stat(RunStats.AttackSpeed, 0, new MultiplicativeProgression(1));
        this.baseStats.AddStat(attackSpeed);
    }

    public Stat GetStat(string name) {
        return this.baseStats.GetStat(name);
    }
}
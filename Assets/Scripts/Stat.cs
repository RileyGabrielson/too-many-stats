using UnityEditor;

public class Stat
{
    private string name;
    private int points;
    private Progression progression;

    public Stat(string name, int initialPoints, Progression progression) {
        this.name = name;
        this.points = initialPoints;
        this.progression = progression;
    }

    public void Increase(int amount) {
        this.points += amount;
    }

    public void SetPoints(int points) {
        this.points = points;
    }

    public int GetPoints() {
        return this.points;
    }

    public string GetName() {
        return this.name;
    }

    public int GetLevel() {
        var (level, _remainder) = this.GetLevelAndRemainder();
        return level;
    }

    public (int, int) GetLevelAndRemainder() {
        int remainder = points;
        int curLevel = 1;
        int pointsPerLevel = this.progression.PointsPerLevel(curLevel);

        while (remainder > pointsPerLevel) {
            curLevel++;
            remainder -= pointsPerLevel;
            pointsPerLevel = this.progression.PointsPerLevel(curLevel);
        }

        return (curLevel, remainder);
    }
}

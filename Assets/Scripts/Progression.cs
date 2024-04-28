using System;

public interface Progression {
    int PointsPerLevel(int curLevel);
}

public class MultiplicativeProgression: Progression
{
    private int increase;

    public MultiplicativeProgression(int increase) {
        this.increase = increase;
    }

    public int PointsPerLevel(int curLevel) {
        return this.increase * curLevel;
    }
}

public class ExponentialProgression: Progression
{
    private int increase;

    public ExponentialProgression(int increase) {
        this.increase = increase;
    }

    public int PointsPerLevel(int curLevel) {
        return (int)Math.Pow(curLevel, this.increase);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public class GameManager : MonoBehaviour
{
    public Movement player;
    public UpgradeStatsView runStatsView;

    private RunStats runStats;

    void Awake() {
        this.runStats = new RunStats();
        this.player.Initialize(this.runStats);
        this.runStatsView.Initialize(this.runStats);
    }
}

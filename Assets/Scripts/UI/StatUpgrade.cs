using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatUpgrade : MonoBehaviour
{
    public TextMeshProUGUI dataText;

    private Stat stat;

    public void Initialize(Stat stat) {
        this.stat = stat;
        this.Refresh();
    }

    public void Refresh() {
        var (level, remainder) = stat.GetLevelAndRemainder();
        this.dataText.text = stat.GetName() + "  |  LVL: " + level.ToString() + "  | REM: " + remainder.ToString();
    }

    public void Upgrade(int amount) {
        this.stat.Increase(amount);
        this.Refresh();
    }
}

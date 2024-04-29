using System.Collections.Generic;
using UnityEngine;

public class UpgradeStatsView : MonoBehaviour
{
    public Transform viewRoot;
    public Transform statsParent;
    public GameObject statUpgradePrefab;

    private List<GameObject> statViews = new List<GameObject>();
    private StatStorage stats;

    public void Initialize(StatStorage stats) {
        this.stats = stats;
    }

    public void Show() {
        this.BuildStats();
        this.viewRoot.gameObject.SetActive(true);
    }

    public void Hide() {
        this.viewRoot.gameObject.SetActive(false);
        this.ClearStats();
    }

    private void BuildStats() {
        var statsList = this.stats.GetAllStats();
        statsList.ForEach(stat => {
            var newStatView = Instantiate(this.statUpgradePrefab, this.statsParent);
            newStatView.GetComponent<StatUpgrade>().Initialize(stat);
            this.statViews.Add(newStatView);
        });
    }

    private void ClearStats() {
        this.statViews.ForEach(statView => Destroy(statView));
        this.statViews.Clear();
    }
}

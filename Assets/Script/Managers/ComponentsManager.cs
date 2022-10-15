using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentsManager : Singleton<ComponentsManager>
{
    [SerializeField] List<Tip> tips;
    [SerializeField] List<Body> bodies;
    [SerializeField] List<Thruster> thrusters;

    [SerializeField] GameObject tipsPanel;
    [SerializeField] GameObject bodyPanel;
    [SerializeField] GameObject thrustersPanel;
    [SerializeField] GameObject ComponentUiPref;

    public void Start() {
        for (int i = 0; i < tips.Count; i++) {
            tips[i].ID = i;
            ComponentUI btn = Instantiate(ComponentUiPref, tipsPanel.transform).GetComponent<ComponentUI>();
            btn.SetComponentUI(tips[i]);
        }

        for (int i = 0; i < bodies.Count; i++) {
            bodies[i].ID = i;
            ComponentUI btn = Instantiate(ComponentUiPref, tipsPanel.transform).GetComponent<ComponentUI>();
            btn.SetComponentUI(bodies[i]);
        }

        for (int i = 0; i < thrusters.Count; i++) {
            thrusters[i].ID = i;
            ComponentUI btn = Instantiate(ComponentUiPref, tipsPanel.transform).GetComponent<ComponentUI>();
            btn.SetComponentUI(thrusters[i]);
        }
    }
        public Tip GetTip(int _id) {
        return tips[_id];
    }
    public Body GetBody(int _id) {
        return bodies[_id];
    }
    public Thruster GetThruster(int _id) {
        return thrusters[_id];
    }
}

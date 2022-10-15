using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentsManager : Singleton<ComponentsManager>
{
    [SerializeField] List<Tip> tips;
    [SerializeField] List<Body> bodies;
    [SerializeField] List<Thruster> thrusters;

    public void InitLists() {
        for (int i = 0; i < tips.Count; i++)
            tips[i].ID = i;
        for (int i = 0; i < bodies.Count; i++)
            bodies[i].ID = i;
        for (int i = 0; i < thrusters.Count; i++)
            thrusters[i].ID = i;
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

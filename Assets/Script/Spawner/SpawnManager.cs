using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : Singleton<SpawnManager>
{
    [SerializeField] private List<Phase> phases;
    private int nextPhaseDistance;
    private int currentPhaseIndex = -1;

    protected override void Awake() {
        base.Awake();
        foreach(Phase phase in phases)phase.gameObject.SetActive(false);
        nextPhaseDistance = phases[0].BeginningDistance;
        StartCoroutine(handlePhases());
    }

    private IEnumerator handlePhases() {
        while (true) {
            if(Rocket.Instance.Distance > nextPhaseDistance) {

                if (currentPhaseIndex != -1) phases[currentPhaseIndex].gameObject.SetActive(false);
                currentPhaseIndex++;
                phases[currentPhaseIndex].gameObject.SetActive(true);

                if (currentPhaseIndex + 1 == phases.Count)
                    break;
                else
                    nextPhaseDistance = phases[currentPhaseIndex + 1].BeginningDistance;

            }
            yield return new WaitForSeconds(0.5f);
        }
    }

}

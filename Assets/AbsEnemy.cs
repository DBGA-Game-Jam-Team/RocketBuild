using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbsEnemy : MonoBehaviour
{
    [SerializeField] float minShotTime;
    [SerializeField] float maxShotTime;

    private void Start() {
        StartCoroutine(HandleShooting());
    }
    private IEnumerator HandleShooting() {
        while (true) {
            yield return new WaitForSeconds(Random.Range(minShotTime, maxShotTime));
                Shot();
        }
    }

    protected abstract void Shot();
}

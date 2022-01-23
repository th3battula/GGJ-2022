using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefabFactory : MonoBehaviour {
    void OnEnable() {
        this.transform.DetachChildren();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpanseAsset : ExpanseBehaviour {
    // This class inherits the ExpanseBehaviour class so its get automatically instantiated.
    void Start () {
        transform.Find("ExpanseAsset/Sphere").gameObject.AddComponent<Trigger>();
    }
}

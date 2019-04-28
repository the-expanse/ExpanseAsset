using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpanseAsset : ExpanseBehaviour {

	void Start () {
        transform.Find("ExpanseAsset/Sphere").gameObject.AddComponent<Trigger>();
    }
}

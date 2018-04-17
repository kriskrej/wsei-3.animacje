using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitcherLogic : MonoBehaviour {
	public float GetKnobPositionInNextFrame(float currentPosition01, float mousePosition01) {
        return (currentPosition01+mousePosition01)/2;
    }
}

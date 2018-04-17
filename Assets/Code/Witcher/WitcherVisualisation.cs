using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitcherVisualisation : MonoBehaviour {
    public RectTransform knob;
    public WitcherLogic logic;
		
	void FixedUpdate () {
        var newPosition = logic.GetKnobPositionInNextFrame(GetKnobPosition(), GetMousePosition());
        SetKnobPosition(newPosition);
	}

    private float GetKnobPosition() {
        return knob.anchoredPosition.x;
    }

    private float GetMousePosition() {
        return Input.mousePosition.x / Screen.width;
    }

    private void SetKnobPosition(float newPosition) {
        knob.anchoredPosition = new Vector2(newPosition*Screen.width - Screen.width/2, knob.anchoredPosition.y);
    }
}

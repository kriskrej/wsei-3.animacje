using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitcherVisualisation : MonoBehaviour {
    public RectTransform bar;
    public RectTransform point;
    public WitcherLogic logic;
		
	void FixedUpdate () {
        var newPosition = logic.GetKnobPositionInNextFrame(GetKnobPosition(), GetMousePosition());
        SetKnobPosition(newPosition);
	}

    private float GetKnobPosition() {
        point.anchoredPosition = new Vector2(GetMousePosition() * Screen.width - Screen.width / 2, point.anchoredPosition.y);
        return bar.anchoredPosition.x / Screen.width + 0.5f;
    }

    private float GetMousePosition() {
        return Input.mousePosition.x / Screen.width;
    }

    private void SetKnobPosition(float newPosition) {
        bar.anchoredPosition = new Vector2(newPosition*Screen.width - Screen.width/2, bar.anchoredPosition.y);
    }
}

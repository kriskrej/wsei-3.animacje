using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitcherLogic : MonoBehaviour {
    public WitcherVisualisation ui;

    void Update() {
        ui.PointX = ui.MouseX;
        ui.BarX = ui.MouseX;
        ui.BarWidth = ui.MouseX;
        Debug.Log(ui.BarWidth + "=" + (ui.MouseX) +"\n");
        //ui.BarWidth = 1 - ui.MouseX + 0.1f;

        
    }

    bool IsMouseOverBar() {
        throw new System.NotImplementedException();
    }


    float life = 0.5f;
	public float GetKnobPositionInNextFrame(float currentPosition01, float mousePosition01) {
        return (currentPosition01+mousePosition01)/2;
    }
}

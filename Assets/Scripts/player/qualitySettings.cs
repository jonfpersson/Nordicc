using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class qualitySettings : MonoBehaviour {

    public PostProcessingProfile inGameProfile;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if(QualitySettings.GetQualityLevel() == 1)
        //{
        //    inGameProfile.antialiasing.enabled = false;
        //    inGameProfile.antialiasing = AntialiasingModel.FxaaQualitySettings;
        //} else if(QualitySettings.GetQualityLevel() == 2)
        //{
        //    inGameProfile.antialiasing.enabled = false;

        //}
        //else if (QualitySettings.GetQualityLevel() == 3)
        //{
        //    inGameProfile.antialiasing.enabled = false;

        //}
        //else if (QualitySettings.GetQualityLevel() == 4)
        //{
        //    inGameProfile.antialiasing.enabled = false;

        //}
        //else if (QualitySettings.GetQualityLevel() == 5)
        //{
        //    inGameProfile.antialiasing.enabled = true;

        //}
        //else if (QualitySettings.GetQualityLevel() == 6)
        //{
        //    inGameProfile.antialiasing.enabled = true;

        //}

    }
}

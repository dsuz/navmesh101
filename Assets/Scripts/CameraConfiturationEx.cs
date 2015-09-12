using UnityEngine;
using System.Collections;

public class CameraConfiturationEx : MonoBehaviour {
    public bool m_turnOffShadow = false;
    private float _storedShadowDistance;

    void OnPreRender()
    {
        if (m_turnOffShadow)
        {
            _storedShadowDistance = QualitySettings.shadowDistance;
            QualitySettings.shadowDistance = 0;
        }
    }

    void OnPostRender()
    {
        QualitySettings.shadowDistance = _storedShadowDistance;
    }
}

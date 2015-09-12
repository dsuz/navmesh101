using UnityEngine;
using System.Collections;

/// <summary>
/// マウスクリック/タップで移動先(moveTarget)を指定するクラス
/// </summary>
public class TargetPickerController : MonoBehaviour
{
    public float surfaceOffset = 1.5f;
    /// <summary>moveTargetとして置くGameObject</summary>
    [SerializeField]private GameObject m_moveTarget;
    /// <summary>Raycastのレイヤーマスク</summary>
    private LayerMask _layerMask;

    private void Start()
    {
        _layerMask = 1 << 8;
    }

    private void Update()
    {
        // マウス左クリック/タップが入力されていない時は何もしない
        if (!Input.GetMouseButtonDown(0)) return;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Raycastが床(floor layer)にヒットしなかったら何もしない
        if (!Physics.Raycast(ray, out hit, Camera.main.farClipPlane, _layerMask))
        {
            //if (!Physics.Raycast(ray, out hit))
            return;
        }

        m_moveTarget.transform.position = hit.point + hit.normal * surfaceOffset;
    }
}
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // 追従するプレイヤーのTransform
    public Vector3 offset = new Vector3(0, 5, -10); // プレイヤーからのオフセット

    void LateUpdate()
    {
        if (target != null)
        {
            // プレイヤーの位置にオフセットを加えてカメラを移動
            transform.position = target.position + offset;
        }
    }
}

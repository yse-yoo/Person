using UnityEngine;

public class CubeAction : MonoBehaviour
{

    // private void OnTriggerEnter(Collider other)
    // {
    //     Debug.Log("OnTriggerEnter");
    //     if (other.CompareTag("Player"))
    //     {
    //         ChangeColor();
    //     }
    // }

    // Cubeがプレイヤーと衝突したときに呼ばれる
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision!!!!");
        Debug.Log(collision.gameObject.tag);
        Debug.Log(collision.gameObject.name); 
        // 衝突した相手が "Player" タグを持っているか確認
        if (collision.gameObject.CompareTag("Player"))
        {
            // アクション例：Cubeの色をランダムに変更する
            ChangeColor();

            // アクション例：ログを表示
            Debug.Log("Player hit the Cube!");
        }
    }

    // 色をランダムに変更する関数
    private void ChangeColor()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = new Color(
                Random.value, // Red
                Random.value, // Green
                Random.value  // Blue
            );
        }
    }
}

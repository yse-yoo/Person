using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // 移動速度
    public float jumpForce = 5f; // ジャンプ力

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Rigidbodyを取得
    }

    void Update()
    {
        MovePlayer(); // プレイヤーの移動を処理
        Jump();        // ジャンプを処理
    }

    // プレイヤーの移動処理
    private void MovePlayer()
    {
        float moveX = Input.GetAxis("Horizontal"); // 左右の入力
        float moveZ = Input.GetAxis("Vertical");   // 前後の入力

        Vector3 move = new Vector3(moveX, 0f, moveZ) * moveSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + move); // Rigidbodyを使った移動
    }

    // プレイヤーのジャンプ処理
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    // 地面との接触を検知
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}

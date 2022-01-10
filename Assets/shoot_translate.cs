using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_translate : MonoBehaviour
{
    float speed = 5.0f;
    float power = 500.0f;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance_per_frame = speed * Time.deltaTime;
        float vertical_input = Input.GetAxis("Vertical"); // 앞,뒤 이동
        float horizontal_input = Input.GetAxis("Horizontal"); // 좌,우 이동
        Vector3 launch_direction = new Vector3(0, 1, 1); // 발사방향

        transform.Translate(Vector3.forward * vertical_input * distance_per_frame);
        transform.Translate(Vector3.right * horizontal_input * distance_per_frame);

        if(Input.GetButtonDown("Fire1")) // 마우스 왼쪽 버튼 눌렀을 때 or 키보드의 왼쪽 Ctrl or 조이스틱 버튼 0번
        {
            ball.GetComponent<Rigidbody>().AddForce(launch_direction * power);
        }
    }
}

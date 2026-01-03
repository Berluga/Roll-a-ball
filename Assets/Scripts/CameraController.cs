using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Late Update（延迟更新）和 Update（更新）一样，每帧都会运行，但会在所有其他更新完成后运行。 相机位置要到玩家在该帧移动后才会设置。
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}

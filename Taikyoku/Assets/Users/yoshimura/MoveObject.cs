using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //-x���W�Ɉړ���������
        transform.position += new Vector3(-1, 0, 0) * Time.deltaTime*3;
    }

    //�R���C�_�[2d�����I�u�W�F�N�g�ƏՓ˂����烍�O���o��
    void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("Hit"); // ���O��\������

    }
}

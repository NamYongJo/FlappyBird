using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    float timer = 0;
    public float timeDiff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; //�� �����Ӹ��� Ÿ�̸ӿ� ���ؼ� Ÿ�̸Ӱ� 1�� �Ǹ� 1�ʰ� �帥 ���� ��
        if (timer > timeDiff) //Ÿ�̸Ӱ� 1���� Ŭ�� Time.deltaTime�� fps�� ���� �ٸ� �������� timer�� 1�� �Ǿ����� fps�� ������� 1�ʰ� �帥 �����̶�� ��
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(3, Random.Range(-2.0f, 4.0f), 0);
            timer = 0;
            Destroy(newpipe, 10.0f);
        }
    }
}

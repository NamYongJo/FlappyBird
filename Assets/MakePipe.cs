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
        timer += Time.deltaTime; //매 프레임마다 타이머에 더해서 타이머가 1이 되면 1초가 흐른 것이 됨
        if (timer > timeDiff) //타이머가 1보다 클때 Time.deltaTime이 fps에 따라 다른 값이지만 timer가 1이 되었을때 fps에 상관없이 1초가 흐른 시점이라는 뜻
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(3, Random.Range(-2.0f, 4.0f), 0);
            timer = 0;
            Destroy(newpipe, 10.0f);
        }
    }
}

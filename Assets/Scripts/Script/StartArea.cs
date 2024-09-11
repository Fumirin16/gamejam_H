using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartArea : MonoBehaviour
{
    //���̃G���A�ɓ��������玞�ԃX�^�[�g
    TimeManager timeManager;
    [SerializeField] GameObject Text_time;

    // Start is called before the first frame update
    void Start()
    {
        timeManager = Text_time.GetComponent<TimeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        timeManager.TimeStart();
    }
}

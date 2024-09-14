using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TimeText;
    [SerializeField] int minute;
    [SerializeField] int second;
    [SerializeField] GameObject GameOverPanel;

    // ���ݎ���
    float elapsedTime;

    // �J�E���g�J�n�̃t���b�O
    [System.NonSerialized] public bool counter_flag = false;

    // Start is called before the first frame update
    void Start()
    {
        // ����b�ɕϊ�
        minute = minute * 60;

        elapsedTime = minute + second;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter_flag)
        {
            elapsedTime -= Time.deltaTime;
        }

        // 0�b�ȉ��i�^�C���A�b�v�j�ɂȂ�����
        if(elapsedTime < 0)
        {
            ChangeGameOver();
        }
        else
        {
            // �c�莞�Ԃ�Text�ŕ\��
            TimeText.text = ((int)elapsedTime / 60).ToString() + ":" + ((int)elapsedTime % 60).ToString();
        }
    }

    public void TimeStart()
    {
        counter_flag = true;
    }

    public void ChangeGameOver()
    {
        GameOverPanel.SetActive(true);
        counter_flag = false;
        TimeText.text = "";
    }
}

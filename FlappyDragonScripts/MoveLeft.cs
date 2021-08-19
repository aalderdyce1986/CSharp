using System;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float Speed = 1;
    private Enemy enemy;

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * Speed, Space.World);

        if (transform.position.x < -15)
        {
            transform.position += new Vector3(30, 0, 0); //Vector3.right * 30;
            ShowRandomSprite();
            enemy?.Respawn();
        }
            
    }

    void ShowRandomSprite()
    {
        int index = UnityEngine.Random.Range(0, 3);
        int childCount = transform.childCount;

        for(int i = 0; i < childCount; i++)
        {
            Transform child = transform.GetChild(i);
            bool shouldShow = (index == i);

            child.gameObject.SetActive(shouldShow);
        }
    }

    private void OnEnable()
    {
        ShowRandomSprite();
    }
}

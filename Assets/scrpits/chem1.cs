using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class chem1 : MonoBehaviour
{
    
    public GameObject[] FishPrefab;
    public GameObject[] FishPrefab1;
    public GameObject[] FishPrefab2;
    public GameObject[] FishPrefab3;


    public GameObject[] DectPrefab;
    
    //��ʱ��
    float timer = 0;

    float positonx;
    float positony;

    


    


    int random1;
    int random2;
    int n = 0;

   
    

    /*public float lifetime;//����һ����ʧ��ʱ��
    public GameObject _enemyship;//������Ҫ���ص�����

    public int enemyCount;//�������ɵĸ���

    public float WaitTime; //����һ��ʱ�䣬�ù�������Ϸ��ʼһ��ʱ���ſ�ʼ����

    public float NextTime;//������һ�������ʱ����

    public Rigidbody2D projectile;
    */

    
    // Start is called before the first frame update
    void Start()
    {
       
        /*StartCoroutine(spawnWaves());

          print (positonx);

         Destroy(gameObject, lifetime);//�ﵽʱ���Զ�������*/
    }



    void Update()

    {
        /*timeBetween += Time.deltaTime;
        if(timeBetween>spawnTime)
        {
            random1 = Random.Range(0, 3);
            random2 = Random.Range(3, 6);
            positony = chems[random1];
            positonx = chems[random2];
            Instantiate(FishPrefab[Random.Range(0, FishPrefab.Length)], new Vector2(2.15f, positony), Quaternion.identity);
                timeBetween = 0;
        }



        random1 = Random.Range(0, 3);
            random2 = Random.Range(3, 6);
            positony = chems[random1];
            positonx = chems[random2];

        */
        random1 = Random.Range(0, 3);
        random2 = Random.Range(3, 6);
        

        timer += Time.deltaTime;
        //��������һ��

        if (timer >= 8)

        {

            timer = 0;
            n += 1;
            //���
            Instantiate(FishPrefab[Random.Range(0, FishPrefab.Length)], DectPrefab[Random.Range(0, 2)].transform.position, Quaternion.identity);

            print(timer);
            //�Ҳ�

            Instantiate(FishPrefab1[Random.Range(0, FishPrefab1.Length)], DectPrefab[Random.Range(3, 5)].transform.position, Quaternion.identity);
            //�Ϸ�
           Instantiate(FishPrefab2[Random.Range(0, FishPrefab2.Length)], DectPrefab[Random.Range(6, 8)].transform.position, Quaternion.identity);
            //�·�
            Instantiate(FishPrefab3[Random.Range(0, FishPrefab3.Length)], DectPrefab[Random.Range(9, 11)].transform.position, Quaternion.identity);
            
            /*for(int i =0;i<10;i++)
            {
                Instantiate(FishPrefab[Random.Range(0, FishPrefab.Length)], new Vector2(2.15f, positony), Quaternion.identity)

            }*/
            //����Ԥ������

            //Instantiate(����)����һ������д���Random.Range(0, ����ĳ���Ҳ����Ԥ������ĸ���)]���ڶ�������д���ɵ�λ�ã�����������д��ת(Ҳ���Բ���תQuaternion.identity)
            //���
            /*GameObject leftFish = Instantiate(FishPrefab[Random.Range(0, FishPrefab.Length)], new Vector2(2.15f, positony), Quaternion.identity) as GameObject;
            leftFish.transform.position =*/
            /*Destroy(leftFish, 1f);*/
            /*leftFish.GetComponent<Fish>().SetTarget(left_targets[random1].transform);*/
            //�Ҳ�

            /*GameObject rightFish = Instantiate(FishPrefab[Random.Range(0, FishPrefab.Length)], new Vector2(15.6f, positony), Quaternion.identity);
            /*rightFish.GetComponent<Fish>().SetTarget(right_targets[random1].transform);*/
            /*rightFish.transform.position=

            //�Ϸ�
           /* Instantiate(FishPrefab[Random.Range(0, FishPrefab.Length)], new Vector2(positonx, 4.26f), Quaternion.identity);
            //�·�
            Instantiate(FishPrefab[Random.Range(0, FishPrefab.Length)], new Vector2(positonx, -8.73f), Quaternion.identity);



            //��ʱ������

            
            print(timer);}*/



            /*IEnumerator spawnWaves()

            {

                yield return new WaitForSeconds(WaitTime); //����Ϸ��ʼ�����waittimeʱ���ſ�ʼִ��

                while(true)

                {

                    for(int i = 0; i < enemyCount)

                    {

                        Vector3 shipPosition = new Vector3(Random.Range(-1000, 1000), Random.Range(-1000, 1000), Random.Range(-1000, 1000));//��������������������
                        Quaternion shipRotation = Quaternion.Euler(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180));//�����������������Ƕ�
                        Instantiate(_enemyShip, shipPosition, shipRotation);//��������
                        yield return new WaitForSeconds(spawnTime);//��������ʱ����

                    }

                }

            }*/










        }
    }
}

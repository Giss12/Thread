using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Thread : MonoBehaviour
{
    private void Start()
    {
        //faktorial(5);
        //chisla(10);
        schet(10);

        //Task tr = new Task(() =>
        //{
        //    faktorial(4);
        //});
        //tr.Start();

        Task tr2 = Task.Factory.StartNew(() =>
        {

        });
        tr2.Wait();
        Debug.Log("Task finished");

        //Task tr3 = Task.Run(() =>
        //{
        //    faktorial(9);
        //});


    }

    public void faktorial(int b)
    {
        int a = 1;
        for (int i = 1; i <= b; i++)
        {
            a = a * i;
        }
        Debug.Log(a);
    }
    public void chisla(int a)
    {
        for (int i = 0; i <= a; i++)
        {
            Debug.Log(i);
            Thread.Sleep(1000);
        }
    }
    public void schet(int N)
    {
        Task tr4 = Task.Run(() =>
        {
            chisla(N);
        });
        tr4.ContinueWith((task) =>
        {
            chisla(N * 2);
        });
    }

}

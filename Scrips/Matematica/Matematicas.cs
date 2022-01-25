using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // suelta un numoro aleatorio
     public static int numAl(int min, int max)
    {
        int value = 0;
        for (int i = 0; i <= 10; i++)
        {
            var guid = System.Guid.NewGuid();
            var justNumbers = new System.String(guid.ToString().Where(System.Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0,9));
            var random = new System.Random(seed);
            value = random.Next(min, max);
        }
        return value;
    }
    // limpia los arrays dejando solos numeros
    public static int limpiezaString( GameObject gm, int sub , int rem = 1)
    {
        string lim = gm.name.Substring(sub);
        if (rem > 0)
        {
            lim = lim.Remove(rem);
        }
        return int.Parse(lim);
    }
    public static int ubicacion(int pos , int can)
    {
        int[] n = new int[can];
        n[0] = can;
        for (int i = 1; i < n.Length; i++)
        {
            int y = i;
            y--;
            n[i] = n[y] - 1;
        }
        pos--;
        return n[pos];
    }
}

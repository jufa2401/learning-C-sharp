using System.Collections.Generic;

public class Yield
{
//  Without yield
public static IEnumerable<int> GreaterThan(int[] arr, int gt) {
    List<int> temp = new List<int>();
    foreach (int n in arr) {
        if (n > gt) temp.Add(n);
    }
    return temp;
}
// With yield
public static IEnumerable<int> GreaterThan2(int[] arr, int gt) {
    foreach (int n in arr) {
        if (n > gt) yield return n;
    }
}



}
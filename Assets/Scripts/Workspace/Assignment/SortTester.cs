using Assignment;
using UnityEngine;

public class SortTester : MonoBehaviour
{
    void Start()
    {
       
        var sut = new StudentSolution(); 
        int[] result = sut.AS01_SelectionSortDescending(new[] { 5, 2, 8, 1, 9 });
        Debug.Log(string.Join(", ", result)); 
       
      
        var sut2 = new StudentSolution();  
        int[] result2 = sut2.AS02_BubbleSortDescending(new[] { 64, 34, 25, 12, 22, 11, 90 });
        Debug.Log(string.Join(", ", result2)); 
      
        
        var sut3 = new StudentSolution();  
        int[] result3 = sut3.AS03_InsertionSortDescending(new[] { -5, 2, -3, 8, 0 });
        Debug.Log(string.Join(", ", result3));
                                           
        var sut4 = new StudentSolution();   
        int result4 = sut4.AS04_FindTheSecondLargestNumber(new[] { 1, 2, 3, 4, 5 });
        Debug.Log(result4); 


        var sutEX = new StudentSolution();
        int resultEX = sutEX.EX01_FindLongestConsecutiveSequence(new[] { 5, 4, 3, 2, 1 });
        Debug.Log($"The longest consecutive sequence is " + resultEX); 
    }
}
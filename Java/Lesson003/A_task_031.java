/*
 * 
 * Реализовать алгоритм сортировки слиянием.
 * 
 */

package Education_GeekBrains.Java.Lesson003;

import java.util.Arrays;
import java.util.Random;

public class A_task_031 {
    public static void main(String[] args) {
        Random randVal = new Random();
        int[] unsortArr = new int[30];
        for (int i = 0; i < unsortArr.length; i++) {
            unsortArr[i] = randVal.nextInt(100);
        }
        System.out.printf("Исходный массив: %s\n", Arrays.toString(unsortArr));

        int[] result = merge_sort(unsortArr);
        System.out.printf("Отсортированный массив: %s\n", Arrays.toString(result));
    }

    public static int[] mergeArray(int[] sortArr, int[] list0) {
        int n1 = sortArr.length, n2 = list0.length;
        int n = n1 + n2, i1 = 0, i2 = 0;
        int[] resArr = new int[n];

        for (int i = 0; i < n; i++) {
            if (i1 == n1) {
                resArr[i] = list0[i2++];
            } 
            else if (i2 == n2) {
                resArr[i] = sortArr[i1++];
            } 
            else {
                if (sortArr[i1] < list0[i2]) {
                    resArr[i] = sortArr[i1++];
                } 
                else {
                    resArr[i] = list0[i2++];
                }
            }
        }
        return resArr;
    }

    public static int[] merge_sort(int[] array) {
        if (array.length < 2) return array;

        int[] bufOneArray = new int[array.length / 2];
        System.arraycopy(array, 0, bufOneArray, 0, array.length / 2);

        int[] bufTwoArray = new int[array.length - bufOneArray.length];
        System.arraycopy(array, array.length / 2, bufTwoArray, 0, array.length - bufOneArray.length);

        bufOneArray = merge_sort(bufOneArray);
        bufTwoArray = merge_sort(bufTwoArray);

        return mergeArray(bufOneArray, bufTwoArray);
    }
}
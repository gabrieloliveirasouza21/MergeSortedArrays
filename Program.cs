using System.Xml.Serialization;

internal class Program {
    private static void Main(string[] args) {
        void MergeSortedArrays(int[] firstArr, int[] SndArr) {

            int TotalSize = firstArr.Length + SndArr.Length;
            int[] arrIntem = new int[TotalSize];
            int contador = 0;

            for (int i = 0; i < firstArr.Length; i++) {
                arrIntem[i] = firstArr[i];
                contador++;
            }

            for (int i = contador; i < TotalSize; i++) {
                arrIntem[i] = SndArr[i - contador];
            }

            //foreach (int i in arrIntem) {
            //    Console.WriteLine(i);
            //}

            // implementar o Bubble Sort para ordenação

            for (int i = 0; i < arrIntem.Length - 1; i++) {
                for (int j = 0; j < arrIntem.Length - i - 1; j++) {
                    if (arrIntem[j] > arrIntem[j+1]) {
                        int aux = arrIntem[j];
                        arrIntem[j] = arrIntem[j+1];
                        arrIntem[j+1] = aux;
                    }
                }
            }

            foreach(var i in arrIntem) {
                Console.Write(i + " ");
            }

        }
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = { 4, 5, 3 };
        MergeSortedArrays(arr1,arr2);    
    }
}
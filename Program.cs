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
                arrIntem[i] = SndArr[SndArr.Length - i];
            }

            foreach (int i in arrIntem) {
                Console.WriteLine(i);
            }

            

        }
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = { 4, 5, 3 };
        MergeSortedArrays(arr1,arr2);    
    }
}
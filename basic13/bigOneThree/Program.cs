using System;


namespace bigOneThree {
    class Program {
        static void Main(string[] args) {
        }
        public static void PrintNumbers() {
            Console.WriteLine("hi");
            for(int i = 0; i <= 255; i++){
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds(){
            for(int i = 1; i <= 255; i++){
                if(i % 2 == 1){
                    Console.WriteLine(i);
                }
            }
        }
        public static void PrintSum(){
            int sum = 0;
            for(int i = 0; i <= 255; i++){
                Console.WriteLine(i);
                sum += (int)i;
            }
        }
        public static void LoopArray(int[] numbers){
            numbers = new int[] {1,2,3,3,4,5,6};
            foreach(int num in numbers){
                Console.WriteLine(num);
            }
        }
        public static int FindMax(int[] numbers){
            numbers = new int[] {1,2,3,3,4,5,6};
            int max = 0;
             foreach(int num in numbers){
                 if(num > max){
                     max = num;
                     Console.WriteLine(max);
                 }
             } return max;
        }
        public static void GetAverage(int[] numbers){
            numbers = new int[] {1,2,3,3,4,5,6};
            int sum = 0;
            int avg = 0;
            foreach(int num in numbers){
                sum += (int)num;
                if(sum % numbers.Length == avg){
                    Console.WriteLine(avg);
                }
            }
        }
        public static int[] OddArray(){
            int count = 0;
            for(int i=1;i<256;i++) {
                if(i % 2 == 1) {
                    count++;
                }
              }
            int[] arr = new int[count];
            for(int i=1;i<256;i++) {
                if(i%2 == 1) {
                    arr[i] = i;
                }
            }
            return arr;
        }
        public static int GreaterThanY(int[] numbers, int y){
            int greaterThan = 0;
            foreach(int i in numbers) {
                if(i > y) {
                    greaterThan++;
                }
            }
            return greaterThan;
        }
        public static void SquareArrayValues(int[] numbers){
             int[] arr = new int[numbers.Length];
            for(int i=0;i<arr.Length;i++) {
                arr[i] = numbers[i] * numbers[i];
            }
            Console.WriteLine(arr);
        }
        public static void EliminateNegatives(int[] numbers){
            for(int i=0;i<numbers.Length;i++) {
                if(numbers[i] < 0) {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine(numbers);
        }
        public static void MinMaxAverage(int[] numbers){
            int max = 0;
            int min = 0;
            int sum = 0;
            int avg = 0;
            for(int i=0;i<numbers.Length;i++) {
                if(numbers[i] > max) {
                    max = numbers[i];
                }
                if(numbers[i] < min) {
                    min = numbers[i];
                }
                sum += numbers[i];
            }
            avg = sum/numbers.Length;
        }
        public static void ShiftValues(int[] numbers){
             int[] arr = new int[numbers.Length];
            arr[arr.Length-1] = 0;
            for(int i=0;i<numbers.Length-2;i++) {
                arr[i] = numbers[i + 1];
            }
        }
        public static object[] NumToString(int[] numbers){
             object[] arr = new object[numbers.Length];
            for(int i=0;i<numbers.Length;i++) {
                if(numbers[i] < 0) {
                    arr[i] = "Dojo";
                } else {
                    arr[i] = numbers[i];
                }
            }
            return arr;
        }
    }
}
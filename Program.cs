using System;

public class Program {

    public static void Main(string[] args) {
        Console.Clear();
/*
        write1ThroughN_While(-1);
        write1ThroughN_While(5);
        write1ThroughN_While(0);

        write1ThroughN_For(-1);
        write1ThroughN_For(5);
        write1ThroughN_For(0);

        writeNThrough1_While(-1);
        writeNThrough1_While(5);
        writeNThrough1_While(0);

        writeNThrough1_For(-1);
        writeNThrough1_For(5);
        writeNThrough1_For(0);

        writeEvensThrough100();

        findSum(5);
        findSum(1);
        findSum(-3);
        findSum(100);

        findSumOfEvenNumbers(10);
        findSumOfEvenNumbers(-5);
        findSumOfEvenNumbers(2);
        findSumOfEvenNumbers(0);
        findSumOfEvenNumbers(1);
        findSumOfEvenNumbers(25);
        findSumOfEvenNumbers(-25);

        findSumOfOddNumbers(10);
        findSumOfOddNumbers(-5);
        findSumOfOddNumbers(1);
        findSumOfOddNumbers(2);
        findSumOfOddNumbers(25);
        findSumOfOddNumbers(-25);
*/
        outputRightTriangle(4);
        outputRightTriangle(6);
        outputRightTriangle(-4);
        outputRightTriangle(-6);
        outputRightTriangle(0);

        // outOfRangeMessage();

    }

    public static void write1ThroughN_While(int n) {
        if(n < 1){
            outOfRangeMessage(n);
        } else {
            int i = 1;
            while(i <= n){
                Console.Write(i + " ");
                i++;
            } Console.WriteLine("");
        }

    }

    public static void write1ThroughN_For(int n) {
        if(n < 1){
            outOfRangeMessage(n);
        } else {
            for(int i = 1; i <= n; i++) {
                Console.Write(i + " ");
            } Console.WriteLine("");
        }

    }

    public static void writeNThrough1_While(int n) {
        if(n < 1){
            outOfRangeMessage(n);
        } else {
            int i = n;
            while(i >= 1){
                Console.Write(i + " ");
                i--;
            } Console.WriteLine("");
        }

    }

    public static void writeNThrough1_For(int n) {
        if(n < 1){
            outOfRangeMessage(n);
        } else {
            for(int i = n; i >= 1; i--) {
                Console.Write(i + " ");
            } Console.WriteLine("");
        }
    }

    public static void writeEvensThrough100(){
        for(int i = 0; i < 101; i+=2) {
            Console.Write(i + " ");
        } Console.WriteLine("");
    }

    public static void findSum(int n){
        int sum = 0;
        if(n >= 1){
            for(int i = 0; i <= n; i++) {
                sum += i;
            }
        } else if(n < 1){
            for(int i = n; i <= 1; i++){
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }

    public static void findSumOfEvenNumbers(int n){
        int sum = 0;
        if(n >= 1){
            for(int i = 0; i <= n; i+=2) {
                sum += i;
            }
        } else if(n < 1){
            for(int i = 0; i > n; i-=2){
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }

    public static void findSumOfOddNumbers(int n){
        int sum = 0;
        if(n >= 1){
            for(int i = 1; i <= n; i+=2) {
                sum += i;
            }
        } else if(n < 1){
            for(int i = 1; i >= n; i-=2){
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }

    public static void outputRightTriangle(int _base){
        if(_base > 0){

        } else if(_base < 0){

        }
    }

    public static void outOfRangeMessage(int n) {Console.WriteLine(n + " is out of range.");}

}
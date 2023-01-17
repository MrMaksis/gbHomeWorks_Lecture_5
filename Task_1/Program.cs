#region Задание 1
    int[] SetRandomArray(int num){

        Random rndNum = new Random();
        int[] arrayNum = new int[num];

        for (int i = 0; i < num; i++){
            int randomNum = rndNum.Next(100, 999);
            arrayNum[i] = randomNum;
        }
        return arrayNum;
    }
    void GetArrayEven(int[] arr){
        int countNumEven = 0;
        for (int i = 0; i < arr.Length; i++){
            if(arr[i] % 2 == 0) countNumEven++;
            if(i == arr.Length - 1) Console.WriteLine($"В массиве найдено {countNumEven}, четных чисел");
        }      
    }
    Console.Write("Введите количество элементов массива: ");
    int inpNum = Convert.ToInt32(Console.ReadLine());

    GetArrayEven(SetRandomArray(inpNum)); 
#endregion
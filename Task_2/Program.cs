#region Задание 2
    int[] SetRandomArray(int num){

            Random rndNum = new Random();
            int[] arrayNum = new int[num];

            for (int i = 0; i < num; i++){
                int randomNum = rndNum.Next(1, 999);
                arrayNum[i] = randomNum;
            }
            return arrayNum;
    }

    void GetArrayValue(int[] arr){
        int countNumEven = 0;
        for (int i = 0; i < arr.Length; i++){
            if(i % 2 == 0) countNumEven += arr[i];
            if(i == arr.Length - 1) Console.WriteLine($"Сумма нечетных позиций равна: {countNumEven}");
        }      
    }

    Console.Write("Введите количество элементов массива: ");
    int inpNum = Convert.ToInt32(Console.ReadLine());

    GetArrayValue(SetRandomArray(inpNum)); 
#endregion


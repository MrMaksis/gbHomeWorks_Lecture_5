#region Задание 3
    double[] SetRandomArray(int num){

            Random rndNum = new Random();
            double[] arrayNum = new double[num];

            for (int i = 0; i < num; i++){
                double randomNum = rndNum.NextDouble() * 100;
                arrayNum[i] = randomNum;
            }
            return arrayNum;
    }

    double SummArrayMaxMin(double[] arr){
        return Math.Round(arr.Max() - arr.Min(), 3);
    }

    Console.Write("Введите количество элементов массива: ");
    int inpNum = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Разница макс. и мин. элемента массива равна: {SummArrayMaxMin(SetRandomArray(inpNum))}");
#endregion


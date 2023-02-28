// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.

Console.WriteLine("Введите количество элементов массива: ");
int size  = int.Parse(Console.ReadLine()??"");

string[] arr1 = new string[size];

for (int i = 0; i < size; i++){
	Console.Write("Введите элемент массива: ");
    string result = Console.ReadLine()??"";
	arr1[i] = result;  
}
Console.WriteLine();
Console.Write("Введенный массив: [");
Console.Write(string.Join(",", arr1));
Console.Write("]");

int count = 0;
int numberSymbols = 3;

for (int i = 0; i < arr1.Length; i++){
	if(arr1[i].Length <= numberSymbols){
		count++;
	}   
}
Console.WriteLine();
Console.Write("Полученный массив: [");
string[] arr2 = new string[count];
int j = 0;
for (int i = 0; i < arr1.Length; i++){
    if(arr1[i].Length <= numberSymbols){
        arr2[j] = arr1[i];
        Console.Write(arr2[j] + ",");
        j++;
    }
}
Console.Write("]");

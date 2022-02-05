namespace skyplex;

    public class Ex004
    {
        // public void Multiplicarr(){
        //     int n = 1;
        //     for (n = 1; n <11; n++){
        //     for (int i = 0; i<11; i++){
        //         Console.WriteLine(n+" x "+i+" = "+(n*i));
        //     }
        //     }
        // }

        // public void CompararMaiorMenor(){
        //     int[] array = new int[10];
        //     int maior = 0;
        //     for (int i = 0; i < 10; i++){
        //         Console.WriteLine("Digite o "+(i+1)+"º número: ");
        //         array[i] = Convert.ToInt32(Console.ReadLine());
        //     }
        //     // Console.WriteLine("Valor maior: "+array.Max());
        //     // Console.WriteLine("Valor menor: "+array.Min());

        //    for(int ind = 0; ind < array.Length; ind++ ){
        //        if (array[ind] > maior){
        //            maior = array[ind];
        //        }
        //    }

        //    int menor = array[0];
        //     for(int indice = 0; indice < array.Length; indice++){
        //         if (array[indice] < menor){
        //             menor = array[indice];
        //         }
        //     }

        //    Console.WriteLine(maior);
        //    Console.WriteLine(menor);
        // }

        // public void ProcurarNome(){

        //     string[] arrayNomes = new string[10];

        //     for(int i = 0; i < arrayNomes.Length; i++ ){
        //         Console.WriteLine("Digite o "+(i+1)+"º nome:");
        //         arrayNomes[i] = Console.ReadLine();
        //     }

        //     Console.WriteLine("Digite um nome para buscar:");
        //     var buscar = Console.ReadLine();

        //     if (arrayNomes.Contains(buscar)){
        //         Console.WriteLine("Nome encontrado");
        //     }else{
        //         Console.WriteLine("Nome não encontrado");
        //     }
        // }

        // public void ImprimirArrayReverso(){
        //     int[] arrayString = new int[15];

        //     for(int i = 0; i < 15; i++){
        //         Console.WriteLine("Digite o "+(i+1)+"º número:");
        //         arrayString[i] = Convert.ToInt32(Console.ReadLine());
        //     }
        //     for(int ind = 14; ind >= 0; ind--){
        //         Console.WriteLine((ind+1)+"º número: "+arrayString[ind]);
        //     }
        // }


        public void Multiplicar(){
             for (int i = 0; i < 11; i++){
                for (int ix = 0; ix < 11; ix++){
                    Console.WriteLine(i+" x "+ix+" = "+(i*ix));
                }
            }
        }

        public void BuscarNome(){
            string[] nomes = new string[10];
            string buscar = "";
            string res = "";

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Digite o "+(i+1)+"º nome:");
                nomes[i] = Console.ReadLine();
            }
            Console.WriteLine("Digite um nome para buscar:");
            buscar = Console.ReadLine();

            for (int i = 0; i < nomes.Length; i++){
                if (buscar == nomes[i]){
                    res = nomes[i];
                    Console.WriteLine("Achei: "+res);
                    return;
                }
            }
            if (res != ""){
                 Console.WriteLine("ACHEI"+res);
            }else{
                 Console.WriteLine("Não achei!");
            }
        }

        public void InverterArray(){
            int[] numeros = new int[15];
            Console.WriteLine("Digite 15x um número aleatório:");
            for (int i=0; i<numeros.Length; i++){
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i= 14; i>= 0; i--){
            Console.WriteLine(numeros[i]);
            }
        }
    }

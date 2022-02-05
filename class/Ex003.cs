namespace skyplex;

    public class Ex003
    {
        public void CalcularDesconto()
        {
            double precoUnd = 3.50;
            string dima = "Diamante";
            string dimas = "Diamantes";

            Console.WriteLine("Cada "+dima+" no League of Legends Wild Rift custa R$ "+precoUnd);
            Console.WriteLine("Digite a quantidade (numérica) de "+dimas+" que você deseja: ");

            int quantidadeDiamantes = Convert.ToInt32(Console.ReadLine());

            double precoTotal = quantidadeDiamantes * precoUnd;
            double porcento = precoTotal / 100;

            Console.WriteLine("Total comprado: "+ quantidadeDiamantes+ " de "+dimas);
            Console.WriteLine("Valor total: "+ precoTotal);

            if (quantidadeDiamantes <= 5 ){
                Console.WriteLine("Preço com desconto: "+ (precoTotal - (2 * porcento)) );
            }else if (quantidadeDiamantes >5 && quantidadeDiamantes <= 10){
                Console.WriteLine("Preço com desconto: "+ (precoTotal - (3 * porcento)) );
            }else{
                Console.WriteLine("Preço com desconto: "+ (precoTotal - (5 * porcento)) );
            }
        }
    }

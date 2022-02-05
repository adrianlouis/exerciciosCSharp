namespace skyplex;

    public class Ex002
    {
        
        public void CalcularValor()
        {

            double valorAlcool = 4.90;
            double valorGasolina = 5.30;
            double valorFinal = 0;

            Console.WriteLine("Tipo do Combustível vendido: (1 para álcool / 2 para gasolina)");
            int tipoCombustível = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Litros de combustível vendido: ");
            double litrosVendido = Convert.ToInt32( Console.ReadLine());

            if (litrosVendido <= 20 && tipoCombustível == 1){
                double porcento = (valorAlcool / 100) * 3;
                valorFinal = (valorAlcool - porcento) * litrosVendido;
            }else if (litrosVendido >= 20 && tipoCombustível == 1){
                double porcento = (valorAlcool / 100) * 5;
                valorFinal = (valorAlcool - porcento) * litrosVendido;
            }else if (litrosVendido <= 20 && tipoCombustível ==2){
                double porcento = (valorGasolina / 100) * 4;
                valorFinal = (valorGasolina - porcento) * litrosVendido;
            }else if (litrosVendido >= 20 && tipoCombustível == 2){
                double porcento = (valorGasolina / 100) * 6;
                valorFinal = (valorGasolina - porcento) * litrosVendido;
            }

            Console.WriteLine ("Valor a pagar: "+ valorFinal);

        }
    }

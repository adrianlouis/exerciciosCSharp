namespace skyplex;

public class FirstClass
{
    public void PodeVotar()
    {
        Console.WriteLine("Hi Bugs! Mês do seu nascimento: ");


        int anoNascimentoUser = Convert.ToInt32(Console.ReadLine());

        int anoAtual = DateTime.Now.Year;

        int resultado = anoAtual - anoNascimentoUser;

        if (resultado < 16){
            Console.WriteLine("Devido a sua idade, você não pode votar!");

        }else{
            Console.WriteLine("Você já pode exercer seu direito de votar!");
        }
    }
}

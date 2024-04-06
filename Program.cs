using System.ComponentModel.Design;

namespace testando_fisica
{
    class Program
    {
        static void Main(string[] args)
        {

           string[] flores = { "lavanda", "azaleia","ranúnuculo","girassol"};
           string florzinha = Console.ReadLine();


            if (flores.Contains(florzinha))
            {
                Console.WriteLine("ÓTIMO GOSTO PARA PLANTA");
            }
            else
            {
                Console.WriteLine("PÉSSIMO GOSTO PARA PLANTA");
            }
            
            if (florzinha == "lavanda")
            {
                Console.WriteLine("que flor cheirosa");
            }
            if (florzinha == "ranúnculo")
            {
                Console.WriteLine(" a flor favorita do Gabriel");
            }
            if (florzinha == "azaleia")
            {
                Console.WriteLine("que flor de velho");
            }
            if (florzinha == "girassol")
            {
                Console.WriteLine("a flor favorita da Bia");
            }







        }
    }
}

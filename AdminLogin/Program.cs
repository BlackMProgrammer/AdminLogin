using System;
using System.Windows.Markup;

namespace AdminLogin
{
    class Program
    {
 
        static void Main(string[] args)
        {
            string user = "Admin".ToLower();
            string pass = "1234";
            string valuser;
            string valpassword;
            int try1 = 0;

            do
            {
                Console.WriteLine("Digite el usuario");
                valuser = Console.ReadLine().ToLower();

                Console.WriteLine("Digite la contraseña");

                valpassword = Console.ReadLine();

                if (valuser != user)
                {
                        Console.WriteLine("Digite un usuario Correcto");
                    if (valpassword != pass)
                    {
                        Console.WriteLine("Digite una constraseña correcta");
                    }
                }
                else if (valpassword != pass)
                {
                    Console.WriteLine("Digite una constraseña correcta");
                    
                }

                if (valuser == user && valpassword == pass)
                {
                    Console.WriteLine("Bienvenido {0}", user);
                }

                try1++;
            } while ((valuser != user || valpassword != pass) && try1 < 3);
           
        }
    }
}

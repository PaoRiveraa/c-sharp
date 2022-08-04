using System;

namespace _ejercicio_clase_animales_
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilidades.EnviarCorreo();

            Perro p = new Perro();
            p.Nombre = "simba";
            p.Patas = 4 ;
            p.EsDomestico = true;
            p.Comer();
            p.Caminar();
            p.Ladrar();
            p.Tamano();

            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Patas);

            Gato g = new Gato();
            g.Nombre = "Pelusa";
            g.Patas = 4;
            g.Pelaje = "Peludo";
            g.Comer();
            g.Caminar();
            g.Maullar();

            Console.WhiteLine(g.Nombre);
            Console.WhiteLine(g.Patas);

            Mono M = new Mono();
            M.Nombre = "George";
            M.Patas = 2;
            M.Comer();
            M.Caminar();
            M.Maullar();

            Console.WhiteLine(M.Nombre);
            Console.WhiteLine(M.Patas);

            Ave A = new Ave();
            A.Nombre = "Gallina";
            A.Alas = 2;
            A.Pelaje = "blanca";
            A.Comer();
            A.Caminar();
            A.cantar();

            Console.WhiteLine(A.Nombre);
            Console.WhiteLine(A.Alas);

            Aguila Ag = new Aguila();
            Ag.Nombre = "Alcom";
            Ag.Patas = 2;
            Ag.Comer();
            Ag.Caminar = "Vuelan alto";
            Ag.cantar();

            Console.WhiteLine(Ag.Nombre);
            Console.WhiteLine(Ag.Patas);

            Loro L = new Loro();
            L.Nombre = "Zazu";
            L.Patas = 2;
            L.Comer();
            L.Caminar();
            L.Hablar();

            Console.WhiteLine(L.Nombre);
            Console.WhiteLine(L.Patas);

            Peces P = new Peces();
            P.Nombre = "Nemo";
            P.Aletas =  "2";
            P.Comer();
            P.Nadar();
            

            Console.WhiteLine(P.Nombre);
            Console.WhiteLine(P.Aletas);

            Pez PZ = new Pez();
            PZ.Nombre = "Pez Globo";
            PZ.Aletas = 2;
            PZ.Comer();
            PZ.Nadar();
            PZ.inflar();

            Console.WhiteLine(PZ.Nombre);
            Console.WhiteLine(PZ.Aletas);


            Caballo C = new Caballo();
            C.Nombre = "Corsel";
            C.Patas = 4;
            C.Comer();
            C.Caminar();
            

            Console.WhiteLine(C.Nombre);
            Console.WhiteLine(C.Patas);

            Tigre TG = new Tigre();
            TG.Nombre = "Zucarita";
            TG.Patas = 4;
            TG.Comer();
            TG.Caminar();
            

            Console.WhiteLine(TG.Nombre);
            Console.WhiteLine(TG.Patas);







            




        }
    }
}
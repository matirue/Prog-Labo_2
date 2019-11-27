        static void Main(string[] args)
        {
            
            Concesionaria miConcesionaria = 6;

            Fabricante f1 = new Fabricante("RENAULT", EPais.Francia);
            Fabricante f2 = new Fabricante("CITROEN", EPais.Francia);

            Auto a1 = new Auto("R9", 65000, f1, ETipo.Sedan);

            Moto m1 = new Moto("DUCATI",EPais.Italia, "MONSTER", 450000, ECilindrada.cc500);
            Moto m2 = new Moto("BMW", EPais.Alemania, "G 310 GS", 437500, ECilindrada.cc125);
            Moto m3 = new Moto("DUCATI", EPais.Italia, "MONSTER", 150000, ECilindrada.cc125);

            Auto a2 = new Auto("C4", 285900, f2, ETipo.Deportivo);
            Auto a3 = new Auto("C4", 390500, f2, ETipo.Familiar);
            Auto a4 = new Auto("C4", 96300, f1, ETipo.Deportivo);
            
            miConcesionaria += a1;
            //YA INGRESADO
            miConcesionaria += a1;

            miConcesionaria += m1;
            miConcesionaria += m2;
            miConcesionaria += m3;

            miConcesionaria += a2;
            miConcesionaria += a3;
            //SIN LUGAR
            miConcesionaria += a4;
            
            Console.WriteLine(Concesionaria.Mostrar(miConcesionaria));

            Console.ReadLine();
        }

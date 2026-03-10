using System;

namespace ExamenesPrototype
{
    class Program
    {
        static void Main(string[] args)
        {

            ExamenPrototype protoPatrones = new PatronesDiseno();
            protoPatrones.Materia = "Patrones de Diseño";
            protoPatrones.Clave = "PD101";
            protoPatrones.Docente = "Juan Perez";
            protoPatrones.Salon = "A1";
            Console.WriteLine();

            ExamenPrototype patronesB = protoPatrones.Clone();
            patronesB.Grupo = "B";

            Console.WriteLine(patronesB.VerExamen());


            ExamenPrototype protoProg = new Programacion();
            protoProg.Materia = "Programación";
            protoProg.Clave = "PR102";
            protoProg.Docente = "Maria Lopez";
            protoProg.Salon = "B1";
            Console.WriteLine();

            ExamenPrototype progA = protoProg.Clone();
            progA.Grupo = "A";

            Console.WriteLine(progA.VerExamen());

           
            ExamenPrototype protoBD = new BaseDatos();
            protoBD.Materia = "Base de Datos";
            protoBD.Clave = "BD103";
            protoBD.Docente = "Carlos Ruiz";
            protoBD.Salon = "C1";
            Console.WriteLine();    

            ExamenPrototype bdA = protoBD.Clone();
            bdA.Grupo = "A";

            Console.WriteLine(bdA.VerExamen());

           
            ExamenPrototype protoRedes = new Redes();
            protoRedes.Materia = "Redes";
            protoRedes.Clave = "RD104";
            protoRedes.Docente = "Luis Torres";
            protoRedes.Salon = "D1";
            Console.WriteLine();

            ExamenPrototype redesA = protoRedes.Clone();
            redesA.Grupo = "A";

            Console.WriteLine(redesA.VerExamen());

          
            ExamenPrototype protoSO = new SistemasOperativos();
            protoSO.Materia = "Sistemas Operativos";
            protoSO.Clave = "SO105";
            protoSO.Docente = "Ana Martinez";
            protoSO.Salon = "E1";
            Console.WriteLine();

            ExamenPrototype soA = protoSO.Clone();
            soA.Grupo = "A";

            Console.WriteLine(soA.VerExamen());

            
            ExamenPrototype protoIS = new IngenieriaSoftware();
            protoIS.Materia = "Ingeniería de Software";
            protoIS.Clave = "IS106";
            protoIS.Docente = "Pedro Sanchez";
            protoIS.Salon = "F1";
            Console.WriteLine();

            ExamenPrototype isA = protoIS.Clone();
            isA.Grupo = "A";

            Console.WriteLine(isA.VerExamen());

            
            ExamenPrototype protoED = new EstructuraDatos();
            protoED.Materia = "Estructura de Datos";
            protoED.Clave = "ED107";
            protoED.Docente = "Laura Gómez";
            protoED.Salon = "G1";
            Console.WriteLine();

            ExamenPrototype edA = protoED.Clone();
            edA.Grupo = "A";

            Console.WriteLine(edA.VerExamen());

            
            ExamenPrototype protoMat = new Matematicas();
            protoMat.Materia = "Matemáticas";
            protoMat.Clave = "MT108";
            protoMat.Docente = "Ricardo Díaz";
            protoMat.Salon = "H1";
            Console.WriteLine();

            ExamenPrototype matA = protoMat.Clone();
            matA.Grupo = "A";

            Console.WriteLine(matA.VerExamen());

            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLYASegundoparcial
{
    class Program
    {
        // Readme: Clase abstracta Universidad. Jefe de catedra hereda de Universidad. Luego profesor titular y ayudante heredan de Jefe de Catedra. 
        static void Main(string[] args)
        {
            // Instancio el listado de alumnos, array de sesiones y los actores del sistema. Luego el menu principal con todos ellos de parametro
            List<Alumno> ListadoAlumnos = new List<Alumno>();
            int[] sesionesAbiertas = new int[3];

            ProfesorTitular Profesor = new ProfesorTitular();
            JefeCatedra Jefe = new JefeCatedra();
            Ayudante Ayudante = new Ayudante();

            MenuPrincipal(Jefe, Profesor, Ayudante, ListadoAlumnos, sesionesAbiertas);
        }

        public static void MenuPrincipal(JefeCatedra Jefe, ProfesorTitular Profesor, Ayudante Ayudante, List<Alumno> ListadoAlumnos, int[] sesionesAbiertas)
        {
            bool flagMenu = true;
            do
            {
                bool flagJefe = true;
                bool flagTitular = true;
                bool flagAyudante = true;
                Console.Clear();
                Console.WriteLine("BIENVENIDO AL SISTEMA");
                Console.WriteLine("1- Jefe de Catedra");
                Console.WriteLine("2- Profesor Titular");
                Console.WriteLine("3- Ayudante");
                Console.WriteLine("4- Mostrar Sesiones Abiertas");
                Console.WriteLine("5- Salir del Sistema");

                int opcion = Validacion.PedirInt(1, 5, "Por favor seleccione una opcion");

                switch (opcion)
                {
                    case 1:
                        Console.Clear();

                        // Valida si el legajo esta vacio o no. Si esta vacio lo pide y guarda en array, sino pasa al menu
                        if (Jefe.Legajo == 0)
                        {
                            Jefe.PedirLegajo();
                            sesionesAbiertas[0] = Jefe.Legajo;
                        }

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("SUBMENU JEFE DE CATEDRA");
                            Console.WriteLine("1- Listar datos de los Alumnos");
                            Console.WriteLine("2- Cantidad de Alumnos discriminados por Situacion Final");
                            Console.WriteLine("3- Editar Alumno");
                            Console.WriteLine("4- Buscar Registro");
                            Console.WriteLine("5- Volver al Menu Principal");


                            int opcionJefe = Validacion.PedirInt(1, 5, "Por favor seleccione una opcion");

                            switch (opcionJefe)
                            {
                                case 1:
                                    Console.Clear();
                                    Jefe.ListarDatosAlumnos(ListadoAlumnos);
                                    break;
                                case 2:
                                    Console.Clear();
                                    Jefe.CantDiscrSitFinal(ListadoAlumnos);
                                    break;
                                case 3:
                                    Console.Clear();
                                    Jefe.EditarAlumno(ListadoAlumnos);
                                    break;
                                case 4:
                                    Console.Clear();
                                    Jefe.BuscarRegistro(ListadoAlumnos);
                                    break;
                                case 5:
                                    Console.Clear();
                                    flagJefe = false;
                                    break;
                            }
                        } while (flagJefe);

                        break;
                    case 2:
                        Console.Clear();

                        // Valida si el legajo esta vacio o no. Si esta vacio lo pide y guarda en array, sino pasa al menu
                        if (Profesor.Legajo == 0)
                        {
                            Profesor.PedirLegajo();
                            sesionesAbiertas[1] = Profesor.Legajo;
                        }

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("SUBMENU PROFESOR TITULAR");
                            Console.WriteLine("1- Carga de datos de los Alumnos");
                            Console.WriteLine("2- Listar datos de los Alumnos");
                            Console.WriteLine("3- Situacion Final de cada Alumno");
                            Console.WriteLine("4- Cantidad de Alumnos discriminados por Situacion Final");
                            Console.WriteLine("5- Editar alumno");
                            Console.WriteLine("6- Buscar Registro");
                            Console.WriteLine("7- Volver al Menu Principal");


                            int opcionTitular = Validacion.PedirInt(1, 7, "Por favor seleccione una opcion");

                            switch (opcionTitular)
                            {
                                case 1:
                                    Console.Clear();
                                    Profesor.CargarDatosAlumnos(ListadoAlumnos);
                                    break;
                                case 2:
                                    Console.Clear();
                                    Profesor.ListarDatosAlumnos(ListadoAlumnos);
                                    break;
                                case 3:
                                    Console.Clear();
                                    Profesor.SitFinalAlumno(ListadoAlumnos);
                                    break;
                                case 4:
                                    Console.Clear();
                                    Profesor.CantDiscrSitFinal(ListadoAlumnos);
                                    break;
                                case 5:
                                    Console.Clear();
                                    Profesor.EditarAlumno(ListadoAlumnos);
                                    break;
                                case 6:
                                    Console.Clear();
                                    Profesor.BuscarRegistro(ListadoAlumnos);
                                    break;
                                case 7:
                                    Console.Clear();
                                    flagTitular = false;
                                    break;
                            }
                        } while (flagTitular);


                        break;
                    case 3:
                        Console.Clear();

                        // Valida si el legajo esta vacio o no. Si esta vacio lo pide y guarda en array, sino pasa al menu
                        if (Ayudante.Legajo == 0)
                        {
                            Ayudante.PedirLegajo();
                            sesionesAbiertas[2] = Ayudante.Legajo;
                        }
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("SUBMENU AYUDANTE");
                            Console.WriteLine("1- Listar datos de los Alumnos");
                            Console.WriteLine("2- Cantidad de Alumnos discriminados por Situacion Final");
                            Console.WriteLine("3- Editar Alumno");
                            Console.WriteLine("4- Buscar Registro ");
                            Console.WriteLine("5- Promedio de cada Alumno");
                            Console.WriteLine("6- Cantidad de Alumnos a Recuperar");
                            Console.WriteLine("7- Volver al Menu Principal");


                            int opcionAyudante = Validacion.PedirInt(1, 7, "Por favor seleccione una opcion");

                            switch (opcionAyudante)
                            {
                                case 1:
                                    Console.Clear();
                                    Ayudante.ListarDatosAlumnos(ListadoAlumnos);
                                    break;
                                case 2:
                                    Console.Clear();
                                    Ayudante.CantDiscrSitFinal(ListadoAlumnos);
                                    break;
                                case 3:
                                    Console.Clear();
                                    Ayudante.EditarAlumno(ListadoAlumnos);
                                    break;
                                case 4:
                                    Console.Clear();
                                    Ayudante.BuscarRegistro(ListadoAlumnos);
                                    break;
                                case 5:
                                    Console.Clear();
                                    Ayudante.PromedioAlumno(ListadoAlumnos);
                                    break;
                                case 6:
                                    Console.Clear();
                                    Ayudante.CantAlumnosRecuperar(ListadoAlumnos);
                                    break;
                                case 7:
                                    Console.Clear();
                                    flagAyudante = false;
                                    break;
                            }
                        } while (flagAyudante);
                        break;
                    case 4:
                        Console.Clear();

                        // Primero valido que no haya ninguna sesion abierta
                        if (sesionesAbiertas[0] == 0 && sesionesAbiertas[1] == 0 && sesionesAbiertas[2] == 0)
                        {
                            Console.WriteLine("Ningun miembro del equipo docente hay ingresado al sistema aun. Presione una tecla para volver ");
                            Console.ReadKey();
                        }
                        // Si hay alguna sesion abierta, busco cual es y lo muestra
                        else
                        {
                            if (sesionesAbiertas[0] != 0)
                            {
                                Console.WriteLine("ROL: " + Jefe.ToString());
                                Console.WriteLine("LEGAJO: " + Jefe.Legajo);
                            }
                            if (sesionesAbiertas[1] != 0)
                            {
                                Console.WriteLine("ROL: " + Profesor.ToString());
                                Console.WriteLine("LEGAJO: " + Profesor.Legajo);
                            }
                            if (sesionesAbiertas[2] != 0)
                            {
                                Console.WriteLine("ROL: " + Ayudante.ToString());
                                Console.WriteLine("LEGAJO: " + Ayudante.Legajo);
                            }
                            Console.WriteLine("Presione una tecla para volver");
                            Console.ReadKey();
                        }
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Gracias por utilizar el sistema, presione cualquier tecla para finalizar.");
                        Console.ReadKey();
                        flagMenu = false;
                        break;
                }
            } while (flagMenu);
        }
    }

    class Validacion
    {
        public static int PedirInt(int min, int max, string msj)
        {
            int valor;
            bool valido = false;

            Console.WriteLine(msj);

            do
            {
                if (!int.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine($"Debe ingresar un valor numerico valido entre {min} y {max} \r\n ");
                }
                else
                {
                    if (valor < min || valor > max)
                    {
                        Console.WriteLine($"Debe ingresar un numero valido entre {min} y {max} \r\n ");
                    }
                    else
                    {
                        valido = true;
                    }
                }
            } while (!valido);
            return valor;
        }

        public static double PedirDouble(double min, double max, string msj)
        {
            double valor;
            bool valido = false;

            Console.WriteLine(msj);

            do
            {
                if (!double.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine($"Debe ingresar un valor numerico valido entre {min} y {max} \r\n ");
                }
                else
                {
                    if (valor < min || valor > max)
                    {
                        Console.WriteLine($"Debe ingresar un numero valido entre {min} y {max} \r\n ");
                    }
                    else
                    {
                        valido = true;
                    }
                }
            } while (!valido);
            return valor;
        }

        public static string PedirStringNoVacio(string msj)
        {
            string valor;

            do
            {
                Console.WriteLine(msj);
                valor = Console.ReadLine();
                if (valor == "")
                {
                    Console.WriteLine("No puede quedar vacio  \r\n ");
                }
            } while (valor == "");

            return valor;
        }

        //Verifica si la lista de alumnos esta vacia. True en caso de estar vacia, false si hay datos. 
        public static bool NoHaydatosCargados(List<Alumno> ListadoAlumnos)
        {
            bool valor = true;
            if (ListadoAlumnos.Count == 0)
            {
                return valor;
            }
            else
            {
                valor = false;
            }
            return valor;
        }

    }

    // Clase abstracta con metodo abstracto que obliga a su posterior sobreescritura
    abstract class Universidad
    {
        public abstract void BuscarRegistro(List<Alumno> ListadoAlumnos);
    }

    class JefeCatedra : Universidad
    {
        //Variables de clase
        private int _legajo;

        //Propiedades de Clase. Solo lectura (seteo de legajo es a traves de un metodo para poder validar antes)
        public int Legajo
        {
            get { return this._legajo; }
        }
        //Constructor de clase. Comienza el legajo en 0 para poder validar si hay sesiones abiertas o no.
        public JefeCatedra()
        {
            this._legajo = 0;
        }

        //Metodos de clase
        public void ListarDatosAlumnos(List<Alumno> ListadoAlumnos)
        {
            // Valido primero si no hay datos 
            if (Validacion.NoHaydatosCargados(ListadoAlumnos))
            {
                Console.WriteLine("Todavia no hay datos en el sistema para realizar dicha tarea. Presione cualquier tecla para volver.");
                Console.ReadKey();
            }
            else
            {   // Si hay datos, se itera sobre el listado, evaluando cada posibilidad segun el criterio del Jefe
                double promedio;
                foreach (Alumno alumno in ListadoAlumnos)
                {
                    Console.WriteLine("Alumno/a: " + alumno.Nombre + " " + alumno.Apellido + ", Numero de registro: " + alumno.Registro + ", Condicion de cursada: " + alumno.CondicionCursada());
                    promedio = (alumno.Nota1 + alumno.Nota2) / 2;
                    if (promedio == 0)
                    {
                        Console.WriteLine("La situacion final del alumno es Ausente");
                    }
                    else if (promedio < 4 || alumno.Nota1 < 4 || alumno.Nota2 < 4)
                    {
                        Console.WriteLine("La situacion final del alumno es Insuficiente");
                    }
                    else if (promedio < 7 && (alumno.Nota1 >= 4 && alumno.Nota2 >= 4))
                    {
                        Console.WriteLine("La situacion final del alumno es Regularizado");
                    }
                    else if (promedio >= 7)
                    {
                        Console.WriteLine("La situacion final del alumno es Promocionado");
                    }
                }
                Console.WriteLine("Presione cualquier tecla para volver");
                Console.ReadKey();
            }
        }

        public void CantDiscrSitFinal(List<Alumno> ListadoAlumnos)
        {
            // Valido primero si no hay datos 
            if (Validacion.NoHaydatosCargados(ListadoAlumnos))
            {
                Console.WriteLine("Todavia no hay datos en el sistema para realizar dicha tarea. Presione cualquier tecla para volver.");
                Console.ReadKey();
            }
            else
            //Si hay datos, se itera sobre el listado y suma a los diferentes contadores segun el criterio del Jefe. Luego se muestran los resultados
            {
                double promedio;
                int ausentes = 0;
                int insuficientes = 0;
                int regularizados = 0;
                int promocionados = 0;

                foreach (Alumno alumno in ListadoAlumnos)
                {
                    promedio = (alumno.Nota1 + alumno.Nota2) / 2;
                    if (promedio == 0)
                    {
                        ausentes++;
                    }
                    else if (promedio < 4 || alumno.Nota1 < 4 || alumno.Nota2 < 4)
                    {
                        insuficientes++;
                    }
                    else if (promedio < 7 && (alumno.Nota1 >= 4 && alumno.Nota2 >= 4))
                    {
                        regularizados++;
                    }
                    else if (promedio >= 7)
                    {
                        promocionados++;
                    }
                }
                Console.WriteLine($"Cantidad de alumnos ausentes: {ausentes}");
                Console.WriteLine($"Cantidad de alumnos insuficientes: {insuficientes}");
                Console.WriteLine($"Cantidad de alumnos regularizados: {regularizados}");
                Console.WriteLine($"Cantidad de alumnos promocionados: {promocionados}");
                Console.WriteLine("Presione cualquier tecla para volver");
                Console.ReadKey();
            }
        }
        // Virtual para permitir redefinicion, ya que el profesor tambien puede editar las notas
        public virtual void EditarAlumno(List<Alumno> ListadoAlumnos)
        {
            int registro;
            bool flagEncontrado = false;
            bool flagMenuEdicion = true;
            // Valido primero si no hay datos 
            if (Validacion.NoHaydatosCargados(ListadoAlumnos))
            {
                Console.WriteLine("Todavia no hay datos en el sistema para realizar dicha tarea. Presione cualquier tecla para volver.");
                Console.ReadKey();
            }
            else
            // Si hay datos, se pide el numero de registro y se recorre el listado buscando ese numero
            // Si se encuentra, abre menu para editar, caso contrario mensaje de error.
            {
                registro = Validacion.PedirInt(100000, 999999, "Por favor ingrese el numero de registro del alumno a editar");
                foreach (Alumno alumno in ListadoAlumnos)
                {
                    if (alumno.Registro == registro)
                    {

                        Console.WriteLine("El numero de registro ingresado (" + alumno.Registro + ") pertenece a: " + alumno.Nombre + " " + alumno.Apellido);
                        do
                        {
                            Console.WriteLine("1- Editar nombre");
                            Console.WriteLine("2- Editar apellido");
                            Console.WriteLine("3- Editar registro");
                            Console.WriteLine("4- Finalizar edicion");
                            int opcion = Validacion.PedirInt(1, 4, "Por favor seleccione una opcion");

                            switch (opcion)
                            {
                                case 1:
                                    alumno.Nombre = Validacion.PedirStringNoVacio("Ingrese el nuevo nombre del alumno");
                                    Console.WriteLine("Edicion completada, presione una tecla para volver al menu de edicion");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 2:
                                    alumno.Apellido = Validacion.PedirStringNoVacio("Ingrese el nuevo Apellido del alumno");
                                    Console.WriteLine("Edicion completada, presione una tecla para volver al menu de edicion");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3:
                                    alumno.Registro = Validacion.PedirInt(100000, 999999, "Ingrese el nuevo registro del alumno");
                                    Console.WriteLine("Edicion completada, presione una tecla para volver al menu de edicion");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 4:
                                    flagMenuEdicion = false;
                                    break;
                            }

                        } while (flagMenuEdicion);

                        flagEncontrado = true;
                    }
                }
                if (!flagEncontrado)
                {
                    Console.WriteLine("El numero de registro ingresado no pertenece a ningun alumno cargado en el sistema. Presione cualquier tecla para volver");
                    Console.ReadKey();
                }

            }
        }

        public override void BuscarRegistro(List<Alumno> ListadoAlumnos)
        {
            int registro;
            bool flagEncontrado = false;
            // Valido primero si no hay datos 
            if (Validacion.NoHaydatosCargados(ListadoAlumnos))
            {
                Console.WriteLine("Todavia no hay datos en el sistema para realizar dicha tarea. Presione cualquier tecla para volver.");
                Console.ReadKey();
            }
            else
            // Si hay datos, se pide el registro y se lo busca en el listado. Si se encuentra se muestran datos, sino mensaje de error
            {
                registro = Validacion.PedirInt(100000, 999999, "Por favor ingrese el numero de registro del alumno a buscar");
                foreach (Alumno alumno in ListadoAlumnos)
                {
                    if (alumno.Registro == registro)
                    {
                        Console.WriteLine($"El alumno con el registro {registro} obtuvo en los parciales las notas " + alumno.Nota1 + " y " + alumno.Nota2);
                        Console.WriteLine("Su promedio es de: " + ((alumno.Nota1 + alumno.Nota2) / 2));
                        Console.WriteLine("Presione cualquier tecla para volver");
                        flagEncontrado = true;
                    }
                }
                if (!flagEncontrado)
                {
                    Console.WriteLine("El numero de registro ingresado no pertenece a ningun alumno cargado en el sistema. Presione cualquier tecla para volver");
                }
                Console.ReadKey();
            }
        }
        // Pide el numero de legajo a traves de una validacion y lo guarda en el atributo.
        public void PedirLegajo()
        {
            this._legajo = Validacion.PedirInt(100000, 999999, "Por favor ingrese su legajo");
        }
        // Polimorfismo para identificar el rol de cada actor
        public override string ToString()
        {
            return "Jefe de Catedra";
        }
    }

    class ProfesorTitular : JefeCatedra
    {
        public void CargarDatosAlumnos(List<Alumno> ListadoAlumnos)
        {
            // Valido primero si hay datos. Si los hay, no permite cargarlos de nuevo
            if (!Validacion.NoHaydatosCargados(ListadoAlumnos))
            {
                Console.WriteLine("Los datos de los alumnos ya han sido cargados en el sistema, presione cualquier tecla para volver al submenu");
                Console.ReadKey();
            }
            else
            // Si no hay datos, se cargan todos los datos de los 8 alumnos, uno por uno hasta temrinar. Muestra mensaje una vez terminado
            {
                int i = 0;
                while (i < 8)
                {
                    Console.Clear();
                    Console.WriteLine($"DATOS DEL ALUMNO NUMERO {i + 1}");
                    string nombre = Validacion.PedirStringNoVacio($"Por favor ingrese el nombre del alumno numero{i + 1} ");
                    string apellido = Validacion.PedirStringNoVacio($"Por favor ingrese el apellido del alumno numero {i + 1} ");
                    int registro = Validacion.PedirInt(100000, 999999, $"Por favor ingrese el registro del alumno numero {i + 1}");
                    double nota1 = Validacion.PedirDouble(0, 10, $"Por favor ingrese la primer nota del alumno numero {i + 1}");
                    double nota2 = Validacion.PedirDouble(0, 10, $"Por favor ingrese la segunda nota del alumno numero {i + 1}");

                    Alumno alumno = new Alumno(nombre, apellido, registro, nota1, nota2);
                    ListadoAlumnos.Add(alumno);
                    i++;
                }
                Console.WriteLine("Todos los alumnos se han cargado correctamente, presione cualquier tecla para volver al submenu");
                Console.ReadKey();
            }
        }

        public void SitFinalAlumno(List<Alumno> ListadoAlumnos)
        {
            // Valido primero si no hay datos 
            if (Validacion.NoHaydatosCargados(ListadoAlumnos))
            {
                Console.WriteLine("Todavia no hay datos en el sistema para realizar dicha tarea. Presione cualquier tecla para volver.");
                Console.ReadKey();
            }
            else
            {
                // Si los hay, se itera sobre el listado y se evalua segun el criterio del profesor
                double promedio;
                foreach (Alumno alumno in ListadoAlumnos)
                {
                    Console.WriteLine("Alumno/a: " + alumno.Nombre);
                    promedio = (alumno.Nota1 + alumno.Nota2) / 2;
                    if (promedio == 0)
                    {
                        Console.WriteLine("La situacion final del alumno es Ausente");
                    }
                    else if (promedio < 4 || alumno.Nota1 < 4 || alumno.Nota2 < 4)
                    {
                        Console.WriteLine("La situacion final del alumno es Insuficiente");
                    }
                    else if (promedio < 6.5 && (alumno.Nota1 >= 4 && alumno.Nota2 >= 4))
                    {
                        Console.WriteLine("La situacion final del alumno es Regularizado");
                    }
                    else if (promedio >= 6.5)
                    {
                        Console.WriteLine("La situacion final del alumno es Promocionado");
                    }

                }
                Console.WriteLine("Presione cualquier tecla para volver");
                Console.ReadKey();
            }
        }
        // Polimorfismo con NEW. La funcion incluye situacion final, la cual se evalua diferente segun jefe y profesor.
        // Se tienen en cuenta la consideracion numero 4 de que debe plantearse como una nueva funcion
        public new void ListarDatosAlumnos(List<Alumno> ListadoAlumnos)
        {
            // Valido primero si no hay datos 
            if (Validacion.NoHaydatosCargados(ListadoAlumnos))
            {
                Console.WriteLine("Todavia no hay datos en el sistema para realizar dicha tarea. Presione cualquier tecla para volver.");
                Console.ReadKey();
            }
            else
            { // si los hay, se itera sobre el listado y se muestra nombre, apellido, registro, condicion de cursada y debajo se evalua la situacion final segun el criterio del profesor
                double promedio;
                foreach (Alumno alumno in ListadoAlumnos)
                {
                    Console.WriteLine("Alumno/a: " + alumno.Nombre + " " + alumno.Apellido + ", Numero de registro: " + alumno.Registro + ", Condicion de cursada: " + alumno.CondicionCursada());
                    promedio = (alumno.Nota1 + alumno.Nota2) / 2;
                    if (promedio == 0)
                    {
                        Console.WriteLine("La situacion final del alumno es Ausente");
                    }
                    else if (promedio < 4 || alumno.Nota1 < 4 || alumno.Nota2 < 4)
                    {
                        Console.WriteLine("La situacion final del alumno es Insuficiente");
                    }
                    else if (promedio < 6.5 && (alumno.Nota1 >= 4 && alumno.Nota2 >= 4))
                    {
                        Console.WriteLine("La situacion final del alumno es Regularizado");
                    }
                    else if (promedio >= 6.5)
                    {
                        Console.WriteLine("La situacion final del alumno es Promocionado");
                    }

                }
                Console.WriteLine("Presione cualquier tecla para volver");
                Console.ReadKey();
            }
        }
        // Polimorfismo con NEW, aca tambien difiere el criterio segun jefe o profesor
        // Se tienen en cuenta la consideracion numero 4 de que debe plantearse como una nueva funcion
        public new void CantDiscrSitFinal(List<Alumno> ListadoAlumnos)
        {
            // Valido primero si no hay datos 
            if (Validacion.NoHaydatosCargados(ListadoAlumnos))
            {
                Console.WriteLine("Todavia no hay datos en el sistema para realizar dicha tarea. Presione cualquier tecla para volver.");
                Console.ReadKey();
            }
            else
            {  //Si hay datos, se itera sobre el listado y suma a los diferentes contadores segun el criterio del profesor. Luego se muestran los resultados
                double promedio;
                int ausentes = 0;
                int insuficientes = 0;
                int regularizados = 0;
                int promocionados = 0;

                foreach (Alumno alumno in ListadoAlumnos)
                {
                    promedio = (alumno.Nota1 + alumno.Nota2) / 2;
                    if (promedio == 0)
                    {
                        ausentes++;
                    }
                    else if (promedio < 4 || alumno.Nota1 < 4 || alumno.Nota2 < 4)
                    {
                        insuficientes++;
                    }
                    else if (promedio < 6.5 && (alumno.Nota1 >= 4 && alumno.Nota2 >= 4))
                    {
                        regularizados++;
                    }
                    else if (promedio >= 6.5)
                    {
                        promocionados++;
                    }
                }
                Console.WriteLine($"Cantidad de alumnos ausentes: {ausentes}");
                Console.WriteLine($"Cantidad de alumnos insuficientes: {insuficientes}");
                Console.WriteLine($"Cantidad de alumnos regularizados: {regularizados}");
                Console.WriteLine($"Cantidad de alumnos promocionados: {promocionados}");
                Console.WriteLine("Presione cualquier tecla para volver");
                Console.ReadKey();
            }
        }
        // Sobreescritura del metodo heredado, se suma la edicion de notas
        public override void EditarAlumno(List<Alumno> ListadoAlumnos)
        {
            int registro;
            bool flagEncontrado = false;
            bool flagMenuEdicion = true;
            // Valido primero si no hay datos 
            if (Validacion.NoHaydatosCargados(ListadoAlumnos))
            {
                Console.WriteLine("Todavia no hay datos en el sistema para realizar dicha tarea. Presione cualquier tecla para volver.");
                Console.ReadKey();
            }
            else
            { //si los hay, se pide el registro y se lo busca en el listado. Si se encuentra se abre el menu para editar
                registro = Validacion.PedirInt(100000, 999999, "Por favor ingrese el numero de registro del alumno a editar");
                foreach (Alumno alumno in ListadoAlumnos)
                {
                    if (alumno.Registro == registro)
                    {
                        // Jefe puede editar solo Nombre, Apellido y registro.
                        Console.WriteLine("El numero de registro ingresado (" + alumno.Registro + ") pertenece a: " + alumno.Nombre + " " + alumno.Apellido);
                        do
                        {
                            Console.WriteLine("1- Editar nombre");
                            Console.WriteLine("2- Editar apellido");
                            Console.WriteLine("3- Editar registro");
                            Console.WriteLine("4- Editar notas");
                            Console.WriteLine("5- Finalizar edicion");
                            int opcion = Validacion.PedirInt(1, 5, "Por favor seleccione una opcion");

                            switch (opcion)
                            {
                                case 1:
                                    alumno.Nombre = Validacion.PedirStringNoVacio("Ingrese el nuevo nombre del alumno");
                                    Console.WriteLine("Edicion completada, presione una tecla para volver al menu de edicion");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 2:
                                    alumno.Apellido = Validacion.PedirStringNoVacio("Ingrese el nuevo Apellido del alumno");
                                    Console.WriteLine("Edicion completada, presione una tecla para volver al menu de edicion");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3:
                                    alumno.Registro = Validacion.PedirInt(100000, 999999, "Ingrese el nuevo registro del alumno");
                                    Console.WriteLine("Edicion completada, presione una tecla para volver al menu de edicion");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 4:
                                    alumno.Nota1 = Validacion.PedirDouble(0, 10, "Ingrese la nueva nota numero 1 del alumno");
                                    alumno.Nota2 = Validacion.PedirDouble(0, 10, "Ingrese la nueva nota numero 2 del alumno");
                                    Console.WriteLine("Edicion completada, presione una tecla para volver al menu de edicion");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 5:
                                    flagMenuEdicion = false;
                                    break;

                            }

                        } while (flagMenuEdicion);

                        flagEncontrado = true;
                    }
                }
                if (!flagEncontrado)
                {
                    Console.WriteLine("El numero de registro ingresado no pertenece a ningun alumno cargado en el sistema. Presione cualquier tecla para volver");
                    Console.ReadKey();
                }

            }
        }
        // Polimorfismo para identificar el rol de cada actor
        public override string ToString()
        {
            return "Profesor Titular";
        }
    }

    class Ayudante : JefeCatedra
    {
        public void PromedioAlumno(List<Alumno> ListadoAlumnos)
        {
            if (Validacion.NoHaydatosCargados(ListadoAlumnos))
            {
                Console.WriteLine("Todavia no hay datos en el sistema para realizar dicha tarea. Presione cualquier tecla para volver.");
                Console.ReadKey();
            }
            else
            {
                foreach (Alumno alumno in ListadoAlumnos)
                {
                    Console.WriteLine("Registro: " + alumno.Registro + ", Alumno: " + alumno.Apellido + " " + alumno.Nombre + ", Promedio: " + ((alumno.Nota1 + alumno.Nota2) / 2));
                }
                Console.ReadKey();
            }
        }

        public void CantAlumnosRecuperar(List<Alumno> ListadoAlumnos)
        {
            double recuperan = 0;

            if (Validacion.NoHaydatosCargados(ListadoAlumnos))
            {
                Console.WriteLine("Todavia no hay datos en el sistema para realizar dicha tarea. Presione cualquier tecla para volver.");
                Console.ReadKey();
            }
            else
            {
                foreach (Alumno alumno in ListadoAlumnos)
                {
                    if ((alumno.Nota1 < 4 && alumno.Nota2 > 4) || (alumno.Nota1 > 4 && alumno.Nota2 < 4))
                    {
                        recuperan++;
                    }
                }
                Console.WriteLine($"Recuperan {recuperan} ({(recuperan * 100) / 8}%) de 8 alumnos.");
                Console.WriteLine("Presione cualquier tecla para volver");
                Console.ReadKey();
            }
        }
        // Polimorfismo para identificar el rol de cada actor
        public override string ToString()
        {
            return "Ayudante";
        }
    }

    class Alumno
    {
        //Variables de clase
        private string _nombre;
        private string _apellido;
        private int _registro;
        private double _nota1;
        private double _nota2;

        //Propiedades de clase 
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }
        public int Registro
        {
            get { return this._registro; }
            set { this._registro = value; }
        }
        public double Nota1
        {
            get { return this._nota1; }
            set { this._nota1 = value; }
        }
        public double Nota2
        {
            get { return this._nota2; }
            set { this._nota2 = value; }
        }

        //Constructores de clase
        public Alumno(string nombreEntrada, string apellidoEntrada, int registroEntrada, double nota1Entrada, double nota2Entrada)
        {
            this._nombre = nombreEntrada;
            this._apellido = apellidoEntrada;
            this._registro = registroEntrada;
            this._nota1 = nota1Entrada;
            this._nota2 = nota2Entrada;
        }

        //Metodos de clase
        public string CondicionCursada()
        {
            if (_nota1 == 0 && _nota2 == 0)
            {
                return "ausente";
            }
            else
            {
                return "cursando";
            }
        }
    }
}
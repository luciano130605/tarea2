using System;


class vehiculo {
    public int anio;
    public string modelo;
    public string marca;
    public int anioDeSerie;

    public void arrancar(){
        Console.WriteLine("El vehiculo esta arrancando.");
    }
    public void frenar(){
        Console.WriteLine("El vehiculo esta frenando.");
    }
    public void acelerar(){
        Console.WriteLine("El vehiculo esta acelerando.");
    }
    public void detener(){
        Console.WriteLine("El vehiculo se esta deteniendo.");
    }
}

class autobus : vehiculo {
    public int capacidad;
    public int numeroPuertas;
    public int numerosAsientos;

    public void datos(){
        Console.WriteLine("");
        Console.WriteLine($"\nAutobus. \nAño: {anio} \nModelo: {modelo}\nMarca: {marca}\nAño de serie: {anioDeSerie} \nCapacidad: {capacidad} \nNumero de puertas: {numeroPuertas} \nNumero de asientos: {numerosAsientos}");
    }
    public void cargarPasajeros(){
        Console.WriteLine("El autobus esta cargando pasajeros.");
    }
    public void descargaPasajeros(){
        Console.WriteLine("El autobus esta descargando pasajeros.");
    }
}

class auto : vehiculo {
    public int puertas;
    public string transmicion;

    public void datos(){
       Console.WriteLine($"\nAuto. \nAño: {anio} \nModelo: {modelo}\nMarca: {marca}\nAño de serie: {anioDeSerie} \nPuertas: {puertas} \nTransmicion: {transmicion}");
    }
}

class moto : vehiculo {
    public int cilindraje;
    public string transmicion;

    public void datos(){
        Console.WriteLine($"\nMoto. \nAño: {anio} \nModelo: {modelo}\nMarca: {marca}\nAño de serie: {anioDeSerie} \nCilindraje: {cilindraje}\nTransmicion: {transmicion}");
    }
}

class animal {
    public int edad;
    public string especie;
    public string genero;
    public double peso;

    public void alimentar(){
        Console.WriteLine("");
        Console.WriteLine("El animal esta comiendo.");
    }
    public void reproducir(){
        Console.WriteLine("El animal se esta reproduciendo.");
    }
    public void sonido(){
        Console.WriteLine("El animal esta haciendo sonidos.");
    }        
}

class pajaro : animal {
    public int numeroDePatas;
    public bool plumas;

    public void datos(){
        Console.WriteLine($"\nPajaro.\nEspecie: {especie}\nGenero: {genero} \nEdad: {edad}\nPeso: {peso}\nNumero de patas: {numeroDePatas} \nPlumas: {plumas}");
    }
    public void volar(){
        Console.WriteLine("");
        Console.WriteLine("El pajaro esta volando.");
    }
    public void criar(){
        Console.WriteLine("El pajaro esta criando.");
    }

}

class reptil : animal {
    public string escamas;

    public void datos() {
        Console.WriteLine($"\nReptil. \nEspecie: {especie}\nGenero: {genero} \nEdad: {edad}\nPeso: {peso}\nEscamas: {escamas}");
    }
    public void mudarPiel (){
        Console.WriteLine("El reptil esta mudando la piel.");
    }
} 

class biblioteca {
    public string nombre;
    public string ubicacion;
    public string apertura;

    public void datos(){
        Console.WriteLine("");
        Console.WriteLine($"Nombre de la biblioteca: {nombre} \nUbicacion: {ubicacion} \nHorario de apertura: {apertura}");
    }
    public void agregarLibro() {
        Console.WriteLine("");
        Console.WriteLine("Se agrego el libro.");
    }
    public void prestarLibro() {
        Console.WriteLine("Se presto el libro.");
    }
    public void devolverLibro() {
        Console.WriteLine("Se devolvio el libro.");
    }
    public void buscarLibroAutor() {
        Console.WriteLine("");
        Console.WriteLine("Ingrese el autor: \nEl libro es: ");
    }
    public void buscarLibroTitulo() {
        Console.WriteLine("");
        Console.WriteLine("Ingrese el titulo: \nEl libro es: ");
    }
}

class libro : biblioteca {
    public string titulo;
    public string autor;
    public int anioPublicacion;
    public string genero;

    public void datos(){
        Console.WriteLine("");
        Console.WriteLine($"Libro. \nTitulo: {titulo} \nAutor: {autor} \nAño de publicacion: {anioPublicacion} \nGenero: {genero}");
    }
    public void abrir(){
        Console.WriteLine("");
        Console.WriteLine("Se esta abriendo el libro");
    }
    public void leer(){
        Console.WriteLine("Se esta leyendo el libro");
    }
    public void cerrar(){
        Console.WriteLine("Se esta cerrando el libro");
    }
}

class cajeroAutomatico {
    public string ubicacion;
    public int numeroDeSerie;
    public double saldoDisponible;

    public void datos(){
        Console.WriteLine("");
        Console.WriteLine($"Ubicacion: {ubicacion} \nNumero de Serie: {numeroDeSerie}\nSaldo disponible: {saldoDisponible}");
    }
    public void retirarDinero() {
        Console.WriteLine("");
        Console.WriteLine("Retirando dinero.");
    }
    public void depositarDinero() {
        Console.WriteLine("Depositando dinero.");
    }
    public void consultarSaldo() {
        Console.WriteLine("Consultando saldo...\nSu saldo es: ");
    }
}

class empleado {
    public string nombre;
    public string apellido;
    public int dni;
    public string departamento;
    public double salario;


    public void datos() {
        Console.WriteLine("");
        Console.WriteLine($"Empleado.\nNombre: {nombre}\nApellido: {apellido}\nDNI: {dni}\nDepartamento: {departamento}\nSalario: {salario}");
    }
    public void calcularSalario(){
        Console.WriteLine("Calculando su salario...\nSu salario es: ");
    }
}

class departamentos : empleado {
    public string nombre;
    public string ubicacion;

    public void datos(){
        Console.WriteLine("");
        Console.WriteLine($"Departamentos.\nNombre del departamento: {nombre}\nUbicacion: {ubicacion}\n Departamento: {departamento}");
    }
    public void agregarEmpleado(){
        Console.WriteLine("");
        Console.WriteLine("Ingrese el empleado a agregar:\nEmpleado agregado.");
    }

}

class roles : empleado {
    public string nombre;

    public void datos(){
    Console.WriteLine("");
    Console.WriteLine($"Roles.\nNombre: {nombre}\nDNI: {dni}");
    }
    public void asignarRol(){
        Console.WriteLine("");
        Console.WriteLine("Ingrese el DNI del empleado a asginar el rol: \nQue rol: \nRol asignado.");
    }
}

class program {
    
    static void Main(){
        vehiculo Vehiculo = new vehiculo();
        Vehiculo.arrancar();
        Vehiculo.frenar();
        Vehiculo.acelerar();
        Vehiculo.detener();

        autobus Autobus = new autobus();
        Autobus.anio = 2023;
        Autobus.modelo = "Autobus de dos pisos";
        Autobus.marca = "Volvo";
        Autobus.anioDeSerie = 2021;
        Autobus.capacidad = 50;
        Autobus.numeroPuertas = 2;
        Autobus.numerosAsientos = 50;

        Autobus.cargarPasajeros();
        Autobus.descargaPasajeros();
        Autobus.datos();

        auto Auto = new auto();
        Auto.anio = 2022;
        Auto.modelo = "Cronos";
        Auto.marca = "Fiat";
        Auto.anioDeSerie = 2022;
        Auto.puertas = 4;
        Auto.transmicion = "Automatico";

        Auto.datos();

        moto Moto = new moto();
        Moto.anio = 2015;
        Moto.modelo = "Blitz";
        Moto.marca = "Motomel";
        Moto.anioDeSerie = 2015;
        Moto.cilindraje = 110;
        Moto.transmicion = "Manual";

        Moto.datos();

        animal Animal = new animal();
        Animal.alimentar();
        Animal.reproducir();
        Animal.sonido();
        
        pajaro Pajaro = new pajaro();
        Pajaro.edad = 5;
        Pajaro.especie = "Aguila";
        Pajaro.genero = "Masculino";
        Pajaro.peso = 16.4;
        Pajaro.numeroDePatas = 2;
        Pajaro.plumas = true;

        Pajaro.datos();
        Pajaro.volar();
        Pajaro.criar();
        
        reptil Reptil = new reptil();
        Reptil.edad = 10;
        Reptil.especie ="Iguana";
        Reptil.genero = "Femenino";
        Reptil.peso = 20;
        Reptil.escamas = "Verde";
        
        Reptil.datos();
        Reptil.mudarPiel();

        biblioteca Biblioteca = new biblioteca();
        Biblioteca.nombre = "Biblioteca X";
        Biblioteca.ubicacion = "Capital Federal";
        Biblioteca.apertura = "10:00";

        Biblioteca.datos();
        Biblioteca.agregarLibro();
        Biblioteca.prestarLibro();
        Biblioteca.devolverLibro();
        Biblioteca.buscarLibroAutor();
        Biblioteca.buscarLibroTitulo();

        libro Libro = new libro();
        Libro.titulo = "El principito";
        Libro.autor = "Saint-Exupery";
        Libro.anioPublicacion = 1943;
        Libro.genero = "Novela infantil";
        
        Libro.datos();
        Libro.abrir();
        Libro.leer();
        Libro.cerrar();

        cajeroAutomatico cajero = new cajeroAutomatico();
        cajero.ubicacion = "Capital Federal";
        cajero.numeroDeSerie = 1234;
        cajero.saldoDisponible = 100.87;

        cajero.datos();
        cajero.retirarDinero();
        cajero.depositarDinero();
        cajero.consultarSaldo();

        empleado Empleado = new empleado();
        Empleado.nombre = "Juan";
        Empleado.apellido = "Perez";
        Empleado.dni = 12345678;
        Empleado.departamento = "Recursos humanos";
        Empleado.salario = 1342.79;

        Empleado.datos();
        Empleado.calcularSalario();

        departamentos Departamento = new departamentos();
        Departamento.nombre = "X";
        Departamento.ubicacion = "Tucuman 500";
        Departamento.departamento = "Sistemas";
        
        Departamento.datos();
        Departamento.agregarEmpleado();

        roles rol = new roles();
        rol.nombre = "jose";
        rol.dni = 126886443;

        rol.datos();
        rol.asignarRol();
    }
}
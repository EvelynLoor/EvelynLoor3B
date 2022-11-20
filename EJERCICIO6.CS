//Modificar el programa anterior para que en lugar de leer 8 números, 
//se puedan leer tantos números como se quiera hasta que llegue un cero. 
//El resultado es la suma de todos los números leídos.
class EJERCICIO5{

public int NumeroVeces=;
double valor= 0;
double acumulado =0;
console.Writeline("¿Cuantos numeros desea ingresar");
NumeroVeces = Convert.ToInt32(console.ReadLine());


do 
     {
        console.Writeline("Ingrese el valor" +i);
          valor= Convert.ToDouble(console.ReadLine());
          acumulado= acumulado + valor;
     }
 while (NumeroVeces !=0);


}

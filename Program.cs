
Console.WriteLine("Renta Semestral-Anual \nMenos de $10000 paga el 5% \nEntre $10000 y $20000 paga el 10%"
+"\nEntre $20000 y $35000 paga el 15%"
+"\nEntre $35000 y $45000 paga el 20%"
+"\nMayor a $45000 paga el 30%"
+"\nIngrese El valor de la renta del primer Semestre: ");

uint semestre1 = uint.Parse(Console.ReadLine());

Console.WriteLine("Ingrese El valor de la renta del segundo Semestre: ");

uint semestre2 = uint.Parse(Console.ReadLine());

uint Vrenta = semestre1 + semestre2;

if(Vrenta < 10000){
   Console.WriteLine("Su renta anual es: "+ Vrenta + 
   "\nImpuesto agregado del 5% "+ "\nValor del 5%: "+ Vrenta*0.05 
   +"\nTotal a pagar es: " + Vrenta*1.05 );
   }
if(Vrenta < 20000 & Vrenta >= 10000 ){
    Console.WriteLine("Su renta anual es: "+ Vrenta + 
   "\nImpuesto agregado del 10% "+ "\nValor del 10%: "+ Vrenta*0.10 
   +"\nTotal a pagar es: " + Vrenta*1.10 );
}
if(Vrenta < 35000 & Vrenta >= 20000 ){
    Console.WriteLine("Su renta anual es: "+ Vrenta + 
   "\nImpuesto agregado del 15% "+ "\nValor del 15%: "+ Vrenta*0.15 
   +"\nTotal a pagar es: " + Vrenta*1.15 );
}
if(Vrenta < 45000 & Vrenta >= 35000 ){
    Console.WriteLine("Su renta anual es: "+ Vrenta + 
   "\nImpuesto agregado del 20% "+ "\nValor del 20%: "+ Vrenta*0.20 
   +"\nTotal a pagar es: " + Vrenta*1.20 );
}
if(Vrenta >= 45000 ){
    Console.WriteLine("Su renta anual es: "+ Vrenta + 
   "\nImpuesto agregado del 30% "+ "\nValor del 30%: "+ Vrenta*0.30 
   +"\nTotal a pagar es: " + Vrenta*1.30 );
}




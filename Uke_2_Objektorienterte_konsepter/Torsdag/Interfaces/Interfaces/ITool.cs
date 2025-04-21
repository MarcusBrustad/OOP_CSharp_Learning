namespace Interfaces;
/*
1. Lag et interface ITool med en metode Use().
 */

// Det er best practice å kalle et interface noe som begynner med "I" for (I)nterfarce
public interface ITool
{
    // Definerer hva som må implementeres av klasser som har dette interfacet. 
    public void Use();
}
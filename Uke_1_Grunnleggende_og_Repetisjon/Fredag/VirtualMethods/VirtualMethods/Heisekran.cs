namespace VirtualMethods;
/*
Lag en klasse Heisekran som også arver fra Maskin, men ikke override metoden.
*/

// Deklarer klassen og igjen arver fra Maskin, men siden vi bruker 'virtual' må ikke metoden direkte arves eller endres.
public class Heisekran : Maskin
{
    // Kaller ikke inn på metoden, da den allerede eksisterer i baseklassen og vi ikke skal endre noe på den. 
    
}
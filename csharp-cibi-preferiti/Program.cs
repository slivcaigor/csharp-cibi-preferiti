// See https://aka.ms/new-console-template for more information

// Nel programma inizializzate un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi). L’array deve essere già inizializzato nel programma, e i vostri cibi preferiti non vanno chiesti all’utente tramite input.


//Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:
//-La lunghezza della classifica
//- La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
//-Il vostro cibo top (prima posizione della classifica)
//-Il vostro cibo preferito ma non troppo (ultima posizione della classifica)


//Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione **mediana.** Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari. In questo caso vanno stampati i 2 elementi in centro alla vostra classifica.


// Inizializzazione dell'array di cibi preferiti
string[] cibiPreferiti = { "Sushi", "Pizza", "Pokè", "Spaghetti", "Risotto", "Tacos" };

// Stampa la lunghezza dell'array di cibi preferiti
Console.WriteLine($"La classifica è composta da {cibiPreferiti.Length} piatti:");

// Stampa la classifica con la posizione dei cibi 
for (var i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine($"{i + 1}. {cibiPreferiti[i]}");
}

// Stampa il cibo top e il cibo preferito ma non troppo
Console.WriteLine($"Il cibo top è {cibiPreferiti[0]}");
Console.WriteLine($"Il cibo preferito ma non troppo è {cibiPreferiti[cibiPreferiti.Length - 1]}");


//Bonus
if (cibiPreferiti.Length % 2 == 0)
{
    int ciboMediano = cibiPreferiti.Length / 2;
    Console.WriteLine($"Il cibo di mezza classifica è {cibiPreferiti[ciboMediano - 1]} e {cibiPreferiti[ciboMediano]}");
}
else
{
    int ciboMediano = cibiPreferiti.Length / 2;
    Console.WriteLine($"Il cibo di mezza classifica è {cibiPreferiti[ciboMediano]}");
}
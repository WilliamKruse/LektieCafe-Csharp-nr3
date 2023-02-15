using opgave2;
//Hey og velkommen til OPGAVESÆT 3 i C#!
//Her øverst har jeg skrevet tests til alle opgaverne så du hurtigt kan se om du har løst dem rigtigt.

////////////////////////Tests/////////////////////////////
//opgave1 TEST
//Console.WriteLine(OlesBil(60, 20));//burde give 60(minutter)
//Console.WriteLine(OlesBil(120, 1));//burde give 1.5(minutter)

//opgave2 TEST
/*
int DødeDyr = 0;
int RaskeDyr = 0;
for (int i = 0; i < 100; i++)
{
    Animal dyr = new Animal();
    dyr.CureAnimal();
    if (dyr.Dead == true)
    {
        DødeDyr++;
    }
    else
    {
        RaskeDyr++;
    }
}
Console.WriteLine("Healthy Animals: " + RaskeDyr + " Dead Animals: " + DødeDyr + " (ud af 100)");
*/

//opgave 3 TEST
//Animal dyr2 = new Animal();
//Console.WriteLine(dyr2.GetAnimalInfo);

//opgave 4 TEST
//Console.WriteLine(DagligOmsætning(60));//burde give 8550


///////////////////////////////////////////opgaver///////////////////////////////////////

//opg1

/*
Ole har en racerbil der kører rundt på en rund racerbane. Bilen skal køre 3 kilometer for at have kørt én runde på banen.
Bilen har en tophastighed på 420 KM/T, men det kan den ikke køre hele tiden.
Ole vil gerne finde ud af hvor lang tid det tager hans bil at køre banen et bestemt antal gange.

Lav en funktion der tager Bilens Gennemsnits hastighed og antal runder bilen skal køre som input.
Den skal returnere antal minutter det kommer til at tage i alt.
*/

double OlesBil(int hastighed, int antalRunder)
{
    //TODO
    return 123;
}


//opg2

/*
På Dr.Pol's dyreklinik har han mange dyr inde hver dag. Han bruger alt den bedste medicin, men nogle gange kan han ikke redde dyret.
Som regl er det fordi dyret er gammelt eller ejerne har opdaget sygdommen for sent.

I mappen "Models" finder du klassen Animal.
Hvert animal har
-En alder
-En sygdomsstatus true/false (true = syg)
-En status på om de er døde (true = død)
-En IQ på ejeren af dyret

Når Dr. Pol behandler et dyr ender det enten med et raskt dyr eller et dødt dyr.
Han bruger nemlig funktionen "CureAnimal" som du skal gøre færdig.
Det hele afhænger af dyrets alder og ejerens IQ.

Her er kravene for funktionen "CureAnimal":

-hvis ejer iq er under 50 dør dyret lige meget hvad.
-hvis alder er over 16 dør dyret lige meget hvad.
-hvis alder er 1 - 16 har dyret en 8% chance for at dø.
-de 8% bliver tredoblet hvis ejerIQ er imellem 50 og 80.
-de 8% bliver fordoblet hvis ejerIQ er 80-100.
-funktionen skal ikke returnere noget, men ændre status på dyret. Dead = false eller Dead = true!

*/


//opg 3
/*
Lav en ny funktion til animal klassen.
Den skal returnere en string med alt information om dyret.
funktionen skal hedde: GetAnimalInfo
*/

//opgave 4
/*
dr. Pol bruger 20 minutter på hver kunde der kommer ind i butikken.
Den gennemsnitlige kunde giver 450kr for den 20 minutter lange konsultation.

Den første kunde kommer ind hver morgen klokken 8:00
Dr. Pol har frokost pause hver dag fra klokken 11:00 til 11:30

Lav en funktion der uddregner hvor mange penge der kommer i kassen hver dag, alt efter hvornår dr.pol tager fri.
Som input parameter tager funktionen antal minutter (int),
de minutter er hvor lang tid dr. pol bliver på klinikken efter klokken 14:00.

HVIS HAN IKKE KAN NÅ DE FULDE 20 MINUTTER PÅ DEN SIDSTE KONSULTATION, GIVER DET INGEN PENGE!

*/
int DagligOmsætning(int overtid)
{
    //TODO
    return 123;
}

//opgave 5 ekstra svær opgave!!
//Lav en helt ny funktion der udregner hvor stor chancen er for at dyret kommer til at overleve.
//brug denne nye funktion til at udvidde "GetAnimalInfo", så den også kan udskrive chancen for overlevelse.


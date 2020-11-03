//Fase 1

var nom = "Albert";
var cognom1 = "Pipió";
var cognom2 = "Adroher";

var dia = 5;
var mes = 3;
var any = 1987;

console.log(cognom1, cognom2 + ", " + nom);
console.log(dia + "/" + mes + "/" + any);

//Fi Fase 1

//Fase 2

var BISIESTO = 1948;
var anyBisiesto = BISIESTO + 4;
var anysTraspas = 0;

while (anyBisiesto < any)
{
    anyBisiesto += 4;
    anysTraspas++;
}
console.log("Entre el " + BISIESTO + " i el " + any + " hi ha " + anysTraspas + " anys de traspàs.");

//Fi Fase 2

//Fase 3

for (i = BISIESTO; i <= any; i+=4)
{
    console.log(i);
}

var nomComplet = ("El meu nom és " + nom + " " + cognom1 + " " + cognom2);
var dataNaixement = ("Vaig néixer el " + dia + "/" + mes + "/" + any);

console.log(nomComplet);
console.log(dataNaixement);

var anySi = ("El meu any de naixement és de traspàs");
var anyNo = ("El meu any de naixement no és de traspàs");

var preguntaAny = false;

    if(preguntaAny) console.log(anySi);

    else console.log(anyNo);

//Fi Fase 3

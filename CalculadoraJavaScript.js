var  val1  =  Number ( prompt ( "Digite um número \n 7 8 9 \n 4 5 6 \n 1 2 3 \n 0" ) )
var  sinal  =  prompt ( "Informe o tipo de calculo: \n + - \n x /" )
var  val2  =  Number ( prompt ( "Digite um número \n 7 8 9 \n 4 5 6 \n 1 2 3 \n 0" ) )
var  resultado  =  null

function  calcular ( )  {
    if  ( sinal  ==  "+" )  {
        resultado  =  val1  +  val2
    }
    if  ( sinal  ==  "-" )  {
        resultado  =  val1  -  val2
    }
    if  ( sinal  ==  "x" )  {
        resultado  =  val1  *  val2
    }
    if  ( sinal  ==  "/" )  {
        resultado  =  val1  /  val2
    }

    return  resultado
}
calcular ( )
alert ( val1  +  ""  +  sinal  +  ""  +  val2  +  "="  +  resultado )

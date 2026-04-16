Algoritmo ejercicio2
	Definir num1, num2, opc, resul Como Real
	Definir msj Como Caracter
	Escribir Sin Saltar "Digite dos valores numericos: "
	Leer num1
	Leer num2
	//menu de las operacones
	Escribir "******"
	Escribir "Menu principal"
	Escribir "1-suma"
	Escribir "2-resta"
	Escribir "3-Multiplicacion"
	Escribir "4-Division"
	Escribir "5-Salir"
	Escribir Sin Saltar "digite el signo segun la op"
	Leer opc
	
	//evaluar la Opcion 
	Segun opc Hacer
		1:
				msj="EL RESULTADO ES: "
				resul=num1+num2
		2:
				msj="EL RESULTADO ES: "
				resul=num1-num2
		3:
			msj="El resultado es: "
			resul=num1*num2
		4:
			msj="El resultado es: "
			resul=num1/num2
		5:
			msj="SALIENDO... "
		De Otro Modo:
			msj="Seleccione un numero correcto"
	Fin Segun
FinAlgoritmo
